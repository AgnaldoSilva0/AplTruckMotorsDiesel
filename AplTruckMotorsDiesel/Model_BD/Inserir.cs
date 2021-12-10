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
        public static void chamaMetodo(int idMetodo, string codigo, string codigoOriginal, string marca, string observacao)
        {
            switch (idMetodo)
            {
                
                case 1: //1 Pistão
                    inserirItem(codigo, codigoOriginal, marca, "table_pistao", observacao);
                    break;
                case 2: //2 Aneis
                    inserirItem(codigo, codigoOriginal, marca, "table_aneis", observacao);
                    break;
                case 3: //3 Bronzina Biela
                    inserirItem(codigo, codigoOriginal, marca, "table_bbiela", observacao);
                    break;
                case 4: //4 Junta
                    inserirItem(codigo, codigoOriginal, marca, "table_junta", observacao);
                    break;
                case 5: //5 Bomba Oleo
                    inserirItem(codigo, codigoOriginal, marca, "table_bombaoleo", observacao);
                    break;
                case 6: //6 Bronzina Mancal
                    inserirItem(codigo, codigoOriginal, marca, "table_bmancal", observacao);
                    break;
                case 7: //7 Bomba de Agua
                    inserirItem(codigo, codigoOriginal, marca, "table_bombaagua", observacao);
                    break;
                case 8: //8 Motor
                    inserirModeloMotor(codigo, codigoOriginal, marca);
                    break;
                case 9: //Kit Motor
                    inserirKitMotor(codigo, codigoOriginal, marca, "table_kitmotor", observacao);
                    break;
                case 10: //Kit Motor
                    inserirOutrosItens(codigo, codigoOriginal, marca, observacao);
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
        public static void inserirItem(string codigo, string codigoOriginal, string marca, string tabela, string observacao)
        {
            string comandoTexto = "INSERT INTO '"+ tabela +"' (codigo, codigoOriginal, marca, observacao) " +
                        "VALUES ('" + codigo + "', '" + codigoOriginal + "', '" + marca + "', '"+ observacao +"')";
            inserirConexao(comandoTexto);
        }
        #endregion

        #region Comando String para Inserir Outros Itens
        public static void inserirOutrosItens(string codigo, string descricao, string marca, string observacao)
        {
            string comandoTexto = "INSERT INTO table_outra (codigo, descricao, marca, observacao) " +
                        "VALUES ('" + codigo + "', '" + descricao + "', '" + marca + "', '" + observacao + "')";
            inserirConexao(comandoTexto);
        }
        #endregion

        #region Comando String para Inserir KitMotor
        public static void inserirKitMotor(string codigo, string codigoOriginal, string marca, string tabela, string observacao)
        {
            string comandoTexto = "INSERT INTO '" + tabela + "' (codigo, itenskit, Marca, observacao) " +
                        "VALUES ('" + codigo + "', '" + codigoOriginal + "', '" + marca + "', '"+ observacao +"')";
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
            string kitMotor,
            int outra)
        {
            string comandoTexto = "INSERT INTO table_aplicacao (idMotor, idPistao, idAneis, idBBiela, idBMancal, idBombaAgua, idBombaOleo, idJunta, idobservacao, idKitMotor, idOutra) " +
                        "VALUES ('" + idMotor + "', " +
                        "'" + idPistao + "', " +
                        "'" + idAneis + "', " +
                        "'"+ idBBiela +"', " +
                        "'"+ idBMancal +"', " +
                        "'"+ idBombaAgua +"', " +
                        "'"+ idBombaOleo +"', " +
                        "'"+ idJunta +"', " +
                        "'"+ observacao +"', " +
                        "'"+ kitMotor +"', " +
                        "'" + outra + "')";
            inserirConexao(comandoTexto);
        }
        #endregion

        #region Comando String para Inserir Usuario
        public static void inserirUsuario(string nome, string senha, int permissao)
        {
            string comando = "INSERT INTO table_login (usuario, senha, permissao) " +
                "VALUES ('" + nome.ToUpper() + "', '" + senha.ToUpper() + "', '" + permissao + "') ";
            inserirConexao(comando);
        }
        #endregion
    }
}
