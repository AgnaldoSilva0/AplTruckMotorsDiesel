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
    public partial class NovoUsuario : MetroFramework.Forms.MetroForm
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked == true)
            {
                tbNovaSenha.PasswordChar = '\0';
                Console.WriteLine("s");
            }
            else
            {
                tbNovaSenha.PasswordChar = '*';
                Console.WriteLine("d");
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //SubString pega o primeiro caractere da string, que eu quero o numero, não o nome
            int permissao = Convert.ToInt16(cbPermissao.Text.Substring(0, 1));
            Inserir.inserirUsuario(tbNomeUsuario.Text, tbNovaSenha.Text, permissao);
        }
    }
}
