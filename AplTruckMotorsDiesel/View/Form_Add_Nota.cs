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
    public partial class Form_Add_Nota : MetroFramework.Forms.MetroForm
    {
        public Form_Add_Nota()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Cliente = tbCliente.Text.ToUpper();
            nota.Numero = tbNumero.Text.ToUpper();
            nota.Modelo = tbModelo.Text.ToUpper();
            nota.Placa = tbPlaca.Text.ToUpper();
            nota.Data = DateTimeNota.Text;
            nota.Observacao = tbObservacao.Text.ToUpper();
            Nota.inserirNota(nota);
            limparCampos();
        }

        private void limparCampos()
        {
            tbNumero.Clear();
            tbModelo.Clear();
            tbPlaca.Clear();
            tbObservacao.Clear();
        }
    }
}
