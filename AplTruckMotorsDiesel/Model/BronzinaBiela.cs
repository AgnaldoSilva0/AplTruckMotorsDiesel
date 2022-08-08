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
    class BronzinaBiela
    {
        private string id;
        private string codigoBBiela;
        private string codigoOriginal;
        private string marca;
        private string observacao;

        public BronzinaBiela()
        {
        }

        public BronzinaBiela(string codigoBBiela)
        {
            this.codigoBBiela = codigoBBiela;
        }

        public BronzinaBiela(string id, string codigoBBiela, string codigoOriginal, string marca, string observacao)
        {
            this.id = id;
            this.codigoBBiela = codigoBBiela;
            this.codigoOriginal = codigoOriginal;
            this.marca = marca;
            this.observacao = observacao;
        }

        public string CodigoBBiela { get => codigoBBiela; set => codigoBBiela = value; }
        public string CodigoOriginal { get => codigoOriginal; set => codigoOriginal = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Id { get => id; set => id = value; }

        /// <summary>
        /// Método para retornar ficha tecnica do item, precisa passar o codigo como parametro
        /// </summary>
        /// <param name="codigo">Codigo do item usado para pesquisar o mesmo no banco de dados</param>
        /// <returns></returns>
        public static BronzinaBiela retornaFichaTecnicaPorCodigo(string codigo)
        {
            BronzinaBiela bronzinaBiela = new BronzinaBiela();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_bbiela WHERE codigo LIKE '" + codigo + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    bronzinaBiela = new BronzinaBiela(Convert.ToString(row["id"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["codigoOriginal"]),
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
            return bronzinaBiela;
        }

        public static BronzinaBiela retornaFichaTecnicaPorId(string id)
        {
            BronzinaBiela bronzinaBiela = new BronzinaBiela();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_bbiela WHERE id LIKE '" + id + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    bronzinaBiela = new BronzinaBiela(Convert.ToString(row["id"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["codigoOriginal"]),
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
            return bronzinaBiela;
        }

        public static List<BronzinaBiela> retornaTodosBronzinaBiela()
        {
            List<BronzinaBiela> lista = new List<BronzinaBiela>();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_bbiela";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    lista.Add(new BronzinaBiela(Convert.ToString(row["id"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["codigoOriginal"]),
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
