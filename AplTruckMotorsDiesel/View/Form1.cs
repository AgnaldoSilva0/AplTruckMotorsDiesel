using AplTruckMotorsDiesel.Model;
using AplTruckMotorsDiesel.Model_BD;
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

        //Variavel criada para dar sinal de positivo ou não para a form de login
        public static bool dialogResult = false;
        private void Form1_Load(object sender, EventArgs e)
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

        private void btPesquisaGeral_Click(object sender, EventArgs e)
        {
            listViewMotor.Items.Clear();
            foreach (Motor item in Pesquisar.RetornarMotor(tbFonte.Text))
            {
                    listViewMotor.Items.Add(new ListViewItem(new string[] { 
                        Convert.ToString(item.IdMotor),
                        Convert.ToString(item.ModeloVeiculo), 
                        Convert.ToString(item.ModeloMotor), 
                        Convert.ToString(item.Observacao) }));
            }
        }

        private void listViewMotor_MouseClick(object sender, MouseEventArgs e)
        {
            string selecionado = listViewMotor.SelectedItems[0].SubItems[2].Text;
            listViewPistao.Items.Clear();
            string query = "SELECT * FROM table_aplicacao " +
                    "INNER JOIN table_pistao ON table_aplicacao.idPistao = table_pistao.codigo " +
                    "INNER JOIN table_motor ON table_aplicacao.idMotor = table_motor.id " +
                    "WHERE table_motor.modeloMotor LIKE '%" + selecionado + "%' ";
            foreach (Pistao item in Pesquisar.retornaPistao("idPistao", query))
            {
                listViewPistao.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(item.CodigoPistao) }));
            }
        }
    }
}
