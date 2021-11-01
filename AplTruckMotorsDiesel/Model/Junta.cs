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
    class Junta
    {
        private string id; 
        private string codigoJunta;
        private string codigoOriginal;
        private string marca;
        private string observacao;

        public Junta()
        {
        }

        public Junta(string codigoJunta)
        {
            this.codigoJunta = codigoJunta;
        }

        public Junta(string id, string codigoJunta, string codigoOriginal, string marca, string observacao)
        {
            this.id = id;
            this.codigoJunta = codigoJunta;
            this.codigoOriginal = codigoOriginal;
            this.marca = marca;
            this.observacao = observacao;
        }

        public string CodigoJunta { get => codigoJunta; set => codigoJunta = value; }
        public string CodigoOriginal { get => codigoOriginal; set => codigoOriginal = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Id { get => id; set => id = value; }

        /// <summary>
        /// Método para retornar ficha tecnica do item, precisa passar o codigo como parametro
        /// </summary>
        /// <param name="codigo">Codigo do item usado para pesquisar o mesmo no banco de dados</param>
        /// <returns></returns>
        public static Junta retornaFichaTecnicaPorCodigo(string codigo)
        {
            Junta junta = new Junta();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_junta WHERE codigo LIKE '" + codigo + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    junta = new Junta(Convert.ToString(row["id"]),
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
            return junta;
        }

        public static Junta retornaFichaTecnicaPorId(string id)
        {
            Junta junta = new Junta();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_junta WHERE id LIKE '" + id + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    junta = new Junta(Convert.ToString(row["id"]),
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
            return junta;
        }

    }
}
