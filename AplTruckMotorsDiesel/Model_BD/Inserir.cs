using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.Model_BD
{
    class Inserir
    {
        #region Classe para conectar e executar a string COMANDO passada por parametro
        private static void inserirConexao(string comandoTexto)
        {
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConexao = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConexao);

            try
            {
                conexao.Open();
                SQLiteCommand comando = new SQLiteCommand();

                comando.Connection = conexao;

                comando.CommandText = comandoTexto;

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
        #endregion

        #region InserirMotor
        public static void inserirModeloMotor(string modeloVeiculo, string modeloMotor, string observacao)
        {
            string comandoTexto = "INSERT INTO table_motor (modeloVeiculo, modeloMotor, observacao) " +
                    "VALUES ('"+ modeloVeiculo +"', '"+ modeloMotor +"', '"+ observacao +"')";
            inserirConexao(comandoTexto);
        }
        #endregion

        public static void inserirPistao(string codigo, string codigoOriginal, string marca)
        {
            string comandoTexto = "INSERT INTO table_pistao (codigo, codigoOriginal, marca) " +
                        "VALUES ('" + codigo + "', '" + codigoOriginal + "', '" + marca + "')";
            inserirConexao(comandoTexto);
        }
    }
}
