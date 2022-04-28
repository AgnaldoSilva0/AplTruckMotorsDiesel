using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.View
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            if (RetornarLogin(tbUsuario.Text, tbSenha.Text) == true)
            {
                Form1.dialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
        }

        public static Boolean RetornarLogin(string usuario, string senha)
        {
            //Criptografia
            Cr5DM cr5DM = new Cr5DM();

            bool autorizado = false;
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                //string query = "SELECT * FROM table_login WHERE usuario LIKE '" + usuario.ToUpper() + "' AND senha LIKE '"+ senha.ToUpper() +"' ";
                string query = "SELECT * FROM table_login WHERE usuario LIKE '" + usuario.ToUpper() + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    autorizado = cr5DM.CompararMD5(senha, Convert.ToString(row["senha"]));
                    Program.VarGlobalPermissaoUsuario = Convert.ToInt32(row["permissao"]);
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
            return autorizado;
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked == true)
            {
                tbSenha.PasswordChar = '\0';
                Console.WriteLine("s");
            }
            else
            {
                tbSenha.PasswordChar = '*';
                Console.WriteLine("d");
            }
        }

        private void lbCriarUsuario_Click(object sender, EventArgs e)
        {
            NovoUsuario novoUsuario = new NovoUsuario("Novo usuário visitante");
            novoUsuario.ShowDialog();
        }
    }
}
