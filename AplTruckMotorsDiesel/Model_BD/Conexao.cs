﻿using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.Model_BD
{
    class Conexao
    {
        #region Conectar ou Criar Banco
        public static void conexao()
        {
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
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
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConexao = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConexao);

            try
            {
                conexao.Open();
                SQLiteCommand comando = new SQLiteCommand();

                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_aneis (id INTEGER, codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_bbiela (id INTEGER, codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_bmancal (id INTEGER, codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_bombaagua (id INTEGER, codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_bombaoleo (id INTEGER, codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_junta (id INTEGER, codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_kitmotor (id INTEGER, codigo TEXT, itenskit TEXT, Marca TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_pistao (id INTEGER, codigo TEXT, codigoOriginal TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_motor (id INTEGER, modeloVeiculo TEXT, modeloMotor TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_login (id INTEGER, usuario TEXT, senha TEXT, permissao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_outra (id INTEGER, descricao TEXT, codigo TEXT, marca TEXT, observacao TEXT, PRIMARY KEY (id)) ";
                comando.ExecuteNonQuery();

                comando.CommandText = "CREATE TABLE IF NOT EXISTS table_aplicacao " +
                    "(idMotor TEXT, idPistao TEXT, idAneis TEXT, idBBiela TEXT, idBMancal TEXT, idBombaAgua TEXT, idBombaOleo TEXT, idJunta TEXT, idobservacao TEXT, idKitMotor TEXT, " +
                    "FOREIGN KEY(idJunta) REFERENCES table_junta(id), " +
                    "FOREIGN KEY(idAneis) REFERENCES table_aneis(id), " +
                    "FOREIGN KEY(idPistao) REFERENCES table_pistao(id), " +
                    "FOREIGN KEY(idMotor) REFERENCES table_motor(id), " +
                    "FOREIGN KEY(idBombaOleo) REFERENCES table_bombaoleo(id), " +
                    "FOREIGN KEY(idBMancal) REFERENCES table_bmancal(id), " +
                    "FOREIGN KEY(idBBiela) REFERENCES table_bbiela(id), " +
                    "FOREIGN KEY(idOutra) REFERENCES table_outra(id), " +
                    "FOREIGN KEY(idBombaAgua) REFERENCES table_bombaagua(id)) ";
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
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
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
