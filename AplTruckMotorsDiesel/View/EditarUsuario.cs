using AplTruckMotorsDiesel.Model;
using AplTruckMotorsDiesel.Model_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.View
{
    public partial class EditarUsuario : MetroFramework.Forms.MetroForm
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        public EditarUsuario(string nome, string senha, int permissao, int id)
        {
            InitializeComponent();
            tbNomeUsuarioEditar.Text = nome;
            tbNovaSenhaEditar.Text = senha;
            cbPermissaoEditar.SelectedIndex = permissao - 1;
            metroLabel1.Text = Convert.ToString(id);
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked == true)
            {
                tbNovaSenhaEditar.PasswordChar = '\0';
                Console.WriteLine("s");
            }
            else
            {
                tbNovaSenhaEditar.PasswordChar = '*';
                Console.WriteLine("d");
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            //Criptografia
            Cr5DM cr5DM = new Cr5DM();

            string nome = tbNomeUsuarioEditar.Text.ToUpper();
            string senha = cr5DM.RetornarMD5(tbNovaSenhaEditar.Text);
            int permissao = Convert.ToInt16(cbPermissaoEditar.Text.Substring(0,1));
            int id = Convert.ToInt16(metroLabel1.Text);

            Editar.StringEditarUsuario(nome, senha, permissao, id);
        }

        private void cbEditarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if(cbEditarSenha.Checked == true)
            {
                tbNovaSenhaEditar.Enabled = true;
            } else
            {
                tbNovaSenhaEditar.Enabled = false;
            }
        }
    }
}
