using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.Model_BD
{
    class Deletar
    {
        public static bool DeletarUsuario(string usuario, string senha)
        {
            bool resultado = false;
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;
                comando.CommandText = "DELETE FROM table_login WHERE usuario LIKE '" + usuario.ToUpper() + "' AND senha LIKE '" + senha.ToUpper() + "'";

                comando.ExecuteNonQuery();
                comando.Dispose();

                resultado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            return resultado;
        }

        /// <summary>
        /// Metodo para excluir um implemento, os UPDATE antes serve para colocar NULL na tabela Aplicação onde o item excluido está vinculado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="codigo"></param>
        /// <param name="operacao"></param>
        public static void DeletarItem(int id ,string codigo, int operacao)
        {
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                conexao.Open();
                string comandoString = "";

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                switch (operacao)
                {
                    case 1:
                        Conexao.ExecutarComandoSql("UPDATE table_aplicacao SET idPistao = NULL WHERE idPistao LIKE '" + id + "' ");
                        comandoString = "DELETE FROM table_pistao WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 2:
                        Conexao.ExecutarComandoSql("UPDATE table_aplicacao SET idAneis = NULL WHERE idAneis LIKE '" + id + "' ");
                        comandoString = "DELETE FROM table_aneis WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 3:
                        Conexao.ExecutarComandoSql("UPDATE table_aplicacao SET idBombaAgua = NULL WHERE idBombaAgua LIKE '" + id + "' ");
                        comandoString = "DELETE FROM table_bombaagua WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 4:
                        Conexao.ExecutarComandoSql("UPDATE table_aplicacao SET idBombaOleo = NULL WHERE idBombaOleo LIKE '" + id + "' ");
                        comandoString = "DELETE FROM table_bombaoleo WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 5:
                        Conexao.ExecutarComandoSql("UPDATE table_aplicacao SET idBBiela = NULL WHERE idBBiela LIKE '" + id + "' ");
                        comandoString = "DELETE FROM table_bbiela WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 6:
                        Conexao.ExecutarComandoSql("UPDATE table_aplicacao SET idBMancal = NULL WHERE idBMancal LIKE '" + id + "' ");
                        comandoString = "DELETE FROM table_bmancal WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 7:
                        Conexao.ExecutarComandoSql("UPDATE table_aplicacao SET idJunta = NULL WHERE idJunta LIKE '" + id + "' ");
                        comandoString = "DELETE FROM table_junta WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 8:
                        Conexao.ExecutarComandoSql("UPDATE table_aplicacao SET idKitMotor = NULL WHERE idKitMotor LIKE '" + id + "' ");
                        comandoString = "DELETE FROM table_kitmotor WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 9:
                        comandoString = "DELETE FROM table_motor WHERE id LIKE '" + id + "' ";
                        break;
                    case 10:
                        Conexao.ExecutarComandoSql("UPDATE table_aplicacao SET idOutra = NULL WHERE idOutra LIKE '" + id + "' ");
                        comandoString = "DELETE FROM table_outra WHERE id LIKE '" + id + "' ";
                        break;
                }

                comando.CommandText = comandoString;

                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                //Caso seja deletado um motor, também será deletado todos os registro do motor da tabela aplicação
                if (operacao == 9)
                {
                    deletarMotorTabelaAplicacao(id);
                }
            }
        }

        private static void deletarMotorTabelaAplicacao(int id)
        {
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                conexao.Open();
                string comandoString = "DELETE FROM table_aplicacao WHERE idMotor LIKE '" + id + "' "; ;

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = comandoString;

                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
