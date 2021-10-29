using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.Model_BD
{
    class Conexao
    {
        #region Conectar ou Criar Banco
        public static void conexao()
        {
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            if (!File.Exists(baseDados))
            {
                SQLiteConnection.CreateFile(baseDados);
                criarTabelas();
            }

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            conexao.ConnectionString = strConection;

            try
            {
                conexao.Open();
                MessageBox.Show("Status do Banco de dados: OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar SQLite \n" + ex);
            }
            finally
            {
                conexao.Close();
                Console.WriteLine("Banco de dados fechado");
            }
        }
        #endregion

        private static void criarTabelas()
        {
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConexao = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConexao);

            try
            {
                conexao.Open();
                SQLiteCommand comando = new SQLiteCommand();

                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_aneis (codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (codigo)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_bbiela (codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (codigo)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_bmancal (codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (codigo)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_bombaagua (codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (codigo)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_bombaoleo (codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (codigo)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_junta (codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (codigo)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_kitmotor (codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (codigo)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_pistao (codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (codigo)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_motor (id INTEGER, modeloVeiculo TEXT, modeloMotor TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_aplicacao " +
                    "(idMotor TEXT, idPistao TEXT, idAneis TEXT, idBBiela TEXT, idBMancal TEXT, idBombaAgua TEXT, idBombaOleo TEXT, idJunta TEXT, idobservacao TEXT, idKitMotor TEXT, " +
                    "FOREIGN KEY(idJunta) REFERENCES table_junta(codigo), " +
                    "FOREIGN KEY(idAneis) REFERENCES table_aneis(codigo), " +
                    "FOREIGN KEY(idPistao) REFERENCES table_pistao(codigo), " +
                    "FOREIGN KEY(idMotor) REFERENCES table_motor(id), " +
                    "FOREIGN KEY(idBombaOleo) REFERENCES table_bombaoleo(codigo), " +
                    "FOREIGN KEY(idBMancal) REFERENCES table_bmancal(codigo), " +
                    "FOREIGN KEY(idBBiela) REFERENCES table_bbiela(codigo), " +
                    "FOREIGN KEY(idBombaAgua) REFERENCES table_bombaagua(codigo)) ";
                comando.ExecuteNonQuery();

                MessageBox.Show("Tabela Criada ");
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

        public static void ExecutarComandoSql(string comandoTexto)
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

                MessageBox.Show("Registro Editado ");
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
