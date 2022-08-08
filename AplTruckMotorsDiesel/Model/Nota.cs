using AplTruckMotorsDiesel.Model_BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.Model
{
    class Nota
    {
        public string Numero { get; set; }
        public string Cliente { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Data { get; set; }
        public string Observacao { get; set; }

        public static List<Nota> RetornaListaNotas(string fonte, int operacao)
        {
            List<Nota> lista = new List<Nota>();

            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";
            string query;

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                DataTable dados = new DataTable();
                switch (operacao)
                {
                    case 1:
                        query = "SELECT * FROM table_notas WHERE numero LIKE '%" + fonte + "%'";
                        break;
                    case 2:
                        query = "SELECT * FROM table_notas WHERE modelo LIKE '%" + fonte + "%'";
                        break;
                    case 3:
                        query = "SELECT * FROM table_notas WHERE placa LIKE '%" + fonte + "%'";
                        break;
                    case 4:
                        query = "SELECT * FROM table_notas WHERE data LIKE '%" + fonte + "%'";
                        break;
                    case 5:
                        query = "SELECT * FROM table_notas WHERE cliente LIKE '%" + fonte + "%'";
                        break;
                    default:
                        query = "SELECT * FROM table_notas";
                        break;
                }
                

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    Nota nota = new Nota();
                    nota.Numero = Convert.ToString(row["numero"]);
                    nota.Cliente = Convert.ToString(row["cliente"]);
                    nota.Modelo = Convert.ToString(row["modelo"]);
                    nota.Placa = Convert.ToString(row["placa"]);
                    nota.Data = Convert.ToString(row["data"]);
                    nota.Observacao = Convert.ToString(row["obs"]);
                    lista.Add(nota);
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

        public static void inserirNota(Nota nota)
        {
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConexao = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConexao);

            try
            {
                string query = "INSERT INTO table_notas (numero, cliente, modelo, placa, data, obs) " +
                    "VALUES ('" + nota.Numero + "', '" + nota.Cliente + "', '" + nota.Modelo + "', '" + nota.Placa + "', '" + nota.Data + "', '" + nota.Observacao + "')";
                conexao.Open();
                SQLiteCommand comando = new SQLiteCommand();

                comando.Connection = conexao;

                comando.CommandText = query;

                comando.ExecuteNonQuery();

                MessageBox.Show("Registro Inserido ");
                comando.Dispose();

            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Erro ao inserir Registro " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
