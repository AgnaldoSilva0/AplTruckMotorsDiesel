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
    public partial class Sistemas : MetroFramework.Forms.MetroForm
    {
        public Sistemas()
        {
            InitializeComponent();
        }

        private void btAplicacoesDiesel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btNotas_Click(object sender, EventArgs e)
        {
            Form_ListaNota form_ListaNota = new Form_ListaNota();
            form_ListaNota.ShowDialog();
        }

        private void btAmalcaburio_Click(object sender, EventArgs e)
        {

        }

        //Variavel criada para dar sinal de positivo ou não para a form de login
        public static bool dialogResult = false;
        private void Sistemas_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            //Se der erro no login, a aplicação fecha
            if (dialogResult != true)
            {
                Application.Exit();
                return;
            }
        }
    }
}
