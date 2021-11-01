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
    class Motor
    {
        private int idMotor;
        private string modeloMotor;
        private string modeloVeiculo;
        private string observacao;
        private string aplicacao { get; set; }
        private string codigoOriginal { get; set; }
        private string marca { get; set; }

        public Motor(int idMotor, string modeloMotor, string modeloVeiculo, string observacao)
        {
            this.idMotor = idMotor;
            this.modeloMotor = modeloMotor;
            this.modeloVeiculo = modeloVeiculo;
            this.observacao = observacao;
        }

        public Motor(string modeloVeiculo)
        {
            this.modeloVeiculo = modeloVeiculo;
        }

        public Motor()
        {
        }

        public string ModeloMotor { get => modeloMotor; set => modeloMotor = value; }
        public string ModeloVeiculo { get => modeloVeiculo; set => modeloVeiculo = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public int IdMotor { get => idMotor; set => idMotor = value; }

        public static Motor retornaFichaTecnicaPorModelo(string modeloVeiculo)
        {
            Motor pistao = new Motor();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_motor WHERE modeloVeiculo LIKE '" + modeloVeiculo + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    pistao = new Motor(Convert.ToInt32(row["id"]),
                        Convert.ToString(row["modeloVeiculo"]),
                        Convert.ToString(row["modeloMotor"]),
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

    }
}
