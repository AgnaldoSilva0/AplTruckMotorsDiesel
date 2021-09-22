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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "teste" && tbSenha.Text == "teste")
            {
                Form1.dialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
            
        }
    }
}
