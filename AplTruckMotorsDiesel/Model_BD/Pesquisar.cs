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
        /// <summary>
        /// Este método retorna a lista de motores cadastrado no banco de dados, se for passado algum codigo de pesquisa
        /// ele irá retornar o motor com o codigo informado
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Esse método retorna a lista de itens de acordo com o motor clicado na listview, precisa passar trÊs parametros
        /// pra ele, que estão comentador abaixo:
        /// </summary>
        /// <param name="idDoItemRetorno"> Precisa passar como parametro o nome da coluna na tebela APLICAÇÃO</param>
        /// <param name="queryParametro"> Precisa passar a query que será executada pelo SQLite, cada MODEL tem sua própria query</param>
        /// <param name="objetoPeca"> Precisa passar um identificador para ser usado no SWITH, para criar o objeto especifico para ser retornador</param>
        /// <returns></returns>
        public static List<Object> retornaPeca(string idDoItemRetorno, string itemSelecionado, int objetoPeca)
        {
            List<Object> listaPistao = new List<Object>();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                DataTable dados = new DataTable();

                string query = "SELECT * FROM table_aplicacao " +
                    "INNER JOIN table_aneis ON table_aplicacao.idAneis = table_aneis.codigo " +
                    "INNER JOIN table_motor ON table_aplicacao.idMotor = table_motor.id " +
                    "WHERE table_motor.modeloMotor LIKE '%" + itemSelecionado + "%' ";

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);
                foreach (System.Data.DataRow row in dados.Rows)
                {
                    switch (objetoPeca)
                    {
                        case 1:
                            listaPistao.Add(new Pistao(Convert.ToString(row[idDoItemRetorno])));
                            break;
                        case 2:
                            listaPistao.Add(new BronzinaBiela(Convert.ToString(row[idDoItemRetorno])));
                            break;
                        case 3:
                            listaPistao.Add(new Junta(Convert.ToString(row[idDoItemRetorno])));
                            break;
                        case 4:
                            listaPistao.Add(new Aneis(Convert.ToString(row[idDoItemRetorno])));
                            break;
                        case 5:
                            listaPistao.Add(new BronzinaMancal(Convert.ToString(row[idDoItemRetorno])));
                            break;
                        case 6:
                            listaPistao.Add(new BombaAgua(Convert.ToString(row[idDoItemRetorno])));
                            break;
                        case 7:
                            listaPistao.Add(new BombaOleo(Convert.ToString(row[idDoItemRetorno])));
                            break;
                        case 8:
                            listaPistao.Add(new KitMotor(Convert.ToString(row[idDoItemRetorno])));
                            break;
                    }
                    
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
