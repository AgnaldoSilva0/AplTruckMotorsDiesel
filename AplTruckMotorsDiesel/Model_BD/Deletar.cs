﻿using System;
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
    }
}
