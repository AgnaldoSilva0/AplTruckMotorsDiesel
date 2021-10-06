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

        #region Classe para chamar o metodo responsavel pelo insert passado por parametro
        public static void chamaMetodo(int idMetodo, string codigo, string codigoOriginal, string marca)
        {
            switch (idMetodo)
            {
                //1 Pistão
                case 1:
                    inserirItem(codigo, codigoOriginal, marca, "table_pistao");
                    break;
                //2 Aneis
                case 2:
                    inserirItem(codigo, codigoOriginal, marca, "table_aneis");
                    break;
                //3 Bronzina Biela
                case 3:
                    inserirItem(codigo, codigoOriginal, marca, "table_bbiela");
                    break;
                //4 Junta
                case 4:
                    inserirItem(codigo, codigoOriginal, marca, "table_junta");
                    break;
                //5 Bomba Oleo
                case 5:
                    inserirItem(codigo, codigoOriginal, marca, "table_bombaoleo");
                    break;
                //6 Bronzina Mancal
                case 6:
                    inserirItem(codigo, codigoOriginal, marca, "table_bmancal");
                    break;
                //7 Bomba de Agua
                case 7:
                    inserirItem(codigo, codigoOriginal, marca, "table_bombaagua");
                    break;
                //7 Bomba de Agua
                case 8:
                    inserirModeloMotor(codigo, codigoOriginal, marca);
                    break;
            }
        }

        #endregion

        #region Comando String para Inserir Motor
        public static void inserirModeloMotor(string modeloVeiculo, string modeloMotor, string observacao)
        {
            string comandoTexto = "INSERT INTO table_motor (modeloVeiculo, modeloMotor, observacao) " +
                    "VALUES ('"+ modeloVeiculo +"', '"+ modeloMotor +"', '"+ observacao +"')";
            inserirConexao(comandoTexto);
        }
        #endregion

        #region Comando String para Inserir Item
        public static void inserirItem(string codigo, string codigoOriginal, string marca, string tabela)
        {
            string comandoTexto = "INSERT INTO '"+ tabela +"' (codigo, codigoOriginal, marca) " +
                        "VALUES ('" + codigo + "', '" + codigoOriginal + "', '" + marca + "')";
            inserirConexao(comandoTexto);
        }
        #endregion

        #region Comando String para Vincular Aplicação
        public static void vincularPecas(int idMotor, 
            string idPistao, 
            string idAneis, 
            string idBBiela,
            string idBMancal,
            string idBombaAgua,
            string idBombaOleo,
            string idJunta,
            string observacao,
            string kitMotor)
        {
            string comandoTexto = "INSERT INTO table_aplicacao (idMotor, idPistao, idAneis, idBBiela, idBMancal, idBombaAgua, idBombaOleo, idJunta, idobservacao, idKitMotor) " +
                        "VALUES ('" + idMotor + "', " +
                        "'" + idPistao + "', " +
                        "'" + idAneis + "', " +
                        "'"+ idBBiela +"', " +
                        "'"+ idBMancal +"', " +
                        "'"+ idBombaAgua +"', " +
                        "'"+ idBombaOleo +"', " +
                        "'"+ idJunta +"', " +
                        "'"+ observacao +"', " +
                        "'"+ kitMotor +"')";
            inserirConexao(comandoTexto);
        }
        #endregion
    }
}
