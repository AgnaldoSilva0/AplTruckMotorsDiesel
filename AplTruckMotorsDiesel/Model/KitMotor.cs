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
    class KitMotor
    {
        private string id;
        private string codigoKitMotor;
        private string itensKit;
        private string marca;
        private string observacao;

        public KitMotor()
        {
        }

        public KitMotor(string codigoKitMotor)
        {
            this.codigoKitMotor = codigoKitMotor;
        }

        public KitMotor(string id, string codigoKitMotor, string itensKit, string marca, string observacao)
        {
            this.id = id;
            this.codigoKitMotor = codigoKitMotor;
            this.itensKit = itensKit;
            this.marca = marca;
            this.observacao = observacao;
        }

        public string CodigoKitMotor { get => codigoKitMotor; set => codigoKitMotor = value; }
        public string ItensKit { get => itensKit; set => itensKit = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Id { get => id; set => id = value; }

        /// <summary>
        /// Método para retornar ficha tecnica do item, precisa passar o codigo como parametro
        /// </summary>
        /// <param name="codigo">Codigo do item usado para pesquisar o mesmo no banco de dados</param>
        /// <returns></returns>
        public static KitMotor retornaFichaTecnicaPorCodigo(string codigo)
        {
            KitMotor kitMotor = new KitMotor();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_kitmotor WHERE codigo LIKE '" + codigo + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    kitMotor = new KitMotor(Convert.ToString(row["id"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["itenskit"]),
                        Convert.ToString(row["Marca"]),
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
            return kitMotor;
        }

        public static KitMotor retornaFichaTecnicaPorId(string id)
        {
            KitMotor kitMotor = new KitMotor();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_kitmotor WHERE id LIKE '" + id + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    kitMotor = new KitMotor(Convert.ToString(row["id"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["itenskit"]),
                        Convert.ToString(row["Marca"]),
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
            return kitMotor;
        }
        public static List<KitMotor> retornaTodosKitMotor()
        {
            List<KitMotor> lista = new List<KitMotor>();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_kitmotor";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    lista.Add(new KitMotor(Convert.ToString(row["id"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["itenskit"]),
                        Convert.ToString(row["Marca"]),
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
