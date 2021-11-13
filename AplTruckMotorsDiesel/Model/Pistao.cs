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
    class Pistao
    {
        private string id;
        private string codigoPistao;
        private string codigoOriginal;
        private string marca;
        private string observacao;

        public string CodigoPistao { get => codigoPistao; set => codigoPistao = value; }
        public string CodigoOriginal { get => codigoOriginal; set => codigoOriginal = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Id { get => id; }

        public Pistao()
        {
        }

        public Pistao(string codigoPistao)
        {
            this.codigoPistao = codigoPistao;
        }

        public Pistao(string id, string codigoPistao, string codigoOriginal, string marca, string observacao)
        {
            this.id = id;
            this.codigoPistao = codigoPistao;
            this.codigoOriginal = codigoOriginal;
            this.marca = marca;
            this.observacao = observacao;
        }



        /// <summary>
        /// Método para retornar ficha tecnica do item, precisa passar o id como parametro
        /// </summary>
        /// <param name="codigo">id do item usado para pesquisar o mesmo no banco de dados</param>
        /// <returns></returns>
        public static Pistao retornaFichaTecnicaPorId(string id) {
            Pistao pistao = new Pistao();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_pistao WHERE id LIKE '" + id + "' ";
                //Implementar reaproveitamento de código com a lista por codigo

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    pistao = new Pistao(Convert.ToString(row["id"]),
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
            return pistao;
        }

        /// <summary>
        /// Retorna a ficha tecnica do item passado por codigo por parametro
        /// </summary>
        /// <param name="codigo"> Esse método precisa que o código seja passado por parametro</param>
        /// <returns></returns>
        public static Pistao retornaFichaTecnicaPorCodigo(string codigo)
        {
            Pistao pistao = new Pistao();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_pistao WHERE codigo LIKE '" + codigo + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    pistao = new Pistao(Convert.ToString(row["id"]),
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
            return pistao;
        }

        public static List<Pistao> retornaTodosPistao()
        {
            List<Pistao> lista = new List<Pistao>();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_pistao";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    lista.Add(new Pistao(Convert.ToString(row["id"]),
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
