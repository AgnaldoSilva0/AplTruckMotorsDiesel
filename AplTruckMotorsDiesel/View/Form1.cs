using AplTruckMotorsDiesel.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCriarNovo_Click(object sender, EventArgs e)
        {
            NovoRegistro novoRegistro = new NovoRegistro();
            novoRegistro.ShowDialog();
        }

        public static bool dialogResult = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (dialogResult != true)
            {
                Application.Exit();
                return;
            }
        }
    }
}
