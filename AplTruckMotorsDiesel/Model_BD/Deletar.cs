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
                        comandoString = "DELETE FROM table_pistao WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 2:
                        comandoString = "DELETE FROM table_aneis WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 3:
                        comandoString = "DELETE FROM table_bombaagua WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 4:
                        comandoString = "DELETE FROM table_bombaoleo WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 5:
                        comandoString = "DELETE FROM table_bbiela WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 6:
                        comandoString = "DELETE FROM table_bmancal WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 7:
                        comandoString = "DELETE FROM table_junta WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
                        break;
                    case 8:
                        comandoString = "DELETE FROM table_kitmotor WHERE id LIKE '" + id + "' AND codigo LIKE '" + codigo + "'";
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
            }
        }
    }
}
