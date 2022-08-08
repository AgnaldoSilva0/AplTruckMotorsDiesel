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
    class Outra
    {
        private int id;
        private string descricao;
        private string codigo;
        private string marca;
        private string observacao;

        public Outra()
        {
        }

        public Outra(string descricao)
        {
            this.descricao = descricao;
        }

        public Outra(int id, string descricao, string codigo, string modeloVeiculo, string observacao)
        {
            this.id = id;
            this.descricao = descricao;
            this.codigo = codigo;
            this.marca = modeloVeiculo;
            this.observacao = observacao;
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Observacao { get => observacao; set => observacao = value; }

        public static Outra retornaFichaTecnicaPorId(string id)
        {
            Outra outra = new Outra();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_outra WHERE id LIKE '" + id + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    outra = new Outra(Convert.ToInt32(row["id"]),
                        Convert.ToString(row["descricao"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["marca"]),
                        Convert.ToString(row["observacao"]));
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
            return outra;
        }

        public static Outra retornaFichaTecnicaPorCodigo(string descricao)
        {
            Outra outra = new Outra();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_outra WHERE descricao LIKE '" + descricao + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    outra = new Outra(Convert.ToInt32(row["id"]),
                        Convert.ToString(row["descricao"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["marca"]),
                        Convert.ToString(row["observacao"]));
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
            return outra;
        }

        public static List<Outra> retornaTodosOutra()
        {
            List<Outra> lista = new List<Outra>();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_outra";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    lista.Add(new Outra(Convert.ToInt32(row["id"]),
                        Convert.ToString(row["descricao"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["marca"]),
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
    }
}
