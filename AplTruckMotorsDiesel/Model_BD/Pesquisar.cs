using AplTruckMotorsDiesel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.Model_BD
{
    class Pesquisar
    {

        public static List<Motor> RetornarMotor(string codigo)
        {
            List<Motor> lista = new List<Motor>();
            lista.Clear();
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db"; C:\BDs\dds
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_motor";
                if (codigo != "")
                {
                    //Coloca o % como se fosse um CONTAINS
                   query = "SELECT * FROM table_motor WHERE modeloVeiculo LIKE '%" + codigo + "%' ";
                }

                DataTable dados = new DataTable();
                
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    lista.Add(new Motor(Convert.ToInt32(row["id"]), 
                        Convert.ToString(row["modeloMotor"]),
                        Convert.ToString(row["modeloVeiculo"]), 
                        Convert.ToString(row["observacao"])));
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();

            }

            return lista;

        }

        public static List<Pistao> retornaPistao(string idDoItemRetorno, string queryParametro)
        {
            List<Pistao> listaPistao = new List<Pistao>();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(queryParametro, strConection);

                conexao.Open();

                adaptador.Fill(dados);
                foreach (System.Data.DataRow row in dados.Rows)
                {
                    listaPistao.Add(new Pistao(Convert.ToString(row[idDoItemRetorno])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return listaPistao;
        } 

    }
}
