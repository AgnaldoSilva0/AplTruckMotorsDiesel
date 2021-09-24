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
            }

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            conexao.ConnectionString = strConection;

            try
            {
                conexao.Open();
                MessageBox.Show("Conectado SQLite");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar SQLite \n" + ex);
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion
    }
}
