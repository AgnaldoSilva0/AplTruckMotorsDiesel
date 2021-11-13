using AplTruckMotorsDiesel.Model;
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
    public partial class ListarItens : MetroFramework.Forms.MetroForm
    {
        public ListarItens()
        {
            InitializeComponent();
        }

        private void btListarPistao_Click(object sender, EventArgs e)
        {
            listViewItens.Items.Clear();
            foreach (Pistao item in Pistao.retornaTodosPistao())
            {
                listViewItens.Items.Add(new ListViewItem(new string[] {
                                Convert.ToString(item.Id),
                                Convert.ToString(item.CodigoPistao), 
                                Convert.ToString(item.CodigoOriginal),
                                Convert.ToString(item.Marca),
                                Convert.ToString(item.Observacao)}));
            }
        }

        private void btListarAneis_Click(object sender, EventArgs e)
        {
            listViewItens.Items.Clear();
            foreach (Aneis item in Aneis.retornaTodosAneis())
            {
                listViewItens.Items.Add(new ListViewItem(new string[] {
                                Convert.ToString(item.Id),
                                Convert.ToString(item.CodigoAneis),
                                Convert.ToString(item.CodigoOriginal),
                                Convert.ToString(item.Marca),
                                Convert.ToString(item.Observacao)}));
            }
        }

        private void btListarBAgua_Click(object sender, EventArgs e)
        {
            listViewItens.Items.Clear();
            foreach (BombaAgua item in BombaAgua.retornaTodosBombaAgua())
            {
                listViewItens.Items.Add(new ListViewItem(new string[] {
                                Convert.ToString(item.Id),
                                Convert.ToString(item.CodigoBombaAgua),
                                Convert.ToString(item.CodigoOriginal),
                                Convert.ToString(item.Marca),
                                Convert.ToString(item.Observacao)}));
            }
        }

        private void btListarBOleo_Click(object sender, EventArgs e)
        {
            listViewItens.Items.Clear();
            foreach (BombaOleo item in BombaOleo.retornaTodosBombaOleo())
            {
                listViewItens.Items.Add(new ListViewItem(new string[] {
                                Convert.ToString(item.Id),
                                Convert.ToString(item.CodigoBombaOleo),
                                Convert.ToString(item.CodigoOriginal),
                                Convert.ToString(item.Marca),
                                Convert.ToString(item.Observacao)}));
            }
        }

        private void btListarBBiela_Click(object sender, EventArgs e)
        {
            listViewItens.Items.Clear();
            foreach (BronzinaBiela item in BronzinaBiela.retornaTodosBronzinaBiela())
            {
                listViewItens.Items.Add(new ListViewItem(new string[] {
                                Convert.ToString(item.Id),
                                Convert.ToString(item.CodigoBBiela),
                                Convert.ToString(item.CodigoOriginal),
                                Convert.ToString(item.Marca),
                                Convert.ToString(item.Observacao)}));
            }
        }

        private void btListarBMancal_Click(object sender, EventArgs e)
        {
            listViewItens.Items.Clear();
            foreach (BronzinaMancal item in BronzinaMancal.retornaTodosBronzinaMancal())
            {
                listViewItens.Items.Add(new ListViewItem(new string[] {
                                Convert.ToString(item.Id),
                                Convert.ToString(item.CodigoBMancal),
                                Convert.ToString(item.CodigoOriginal),
                                Convert.ToString(item.Marca),
                                Convert.ToString(item.Observacao)}));
            }
        }

        private void btListarJunta_Click(object sender, EventArgs e)
        {
            listViewItens.Items.Clear();
            foreach (Junta item in Junta.retornaTodosJunta())
            {
                listViewItens.Items.Add(new ListViewItem(new string[] {
                                Convert.ToString(item.Id),
                                Convert.ToString(item.CodigoJunta),
                                Convert.ToString(item.CodigoOriginal),
                                Convert.ToString(item.Marca),
                                Convert.ToString(item.Observacao)}));
            }
        }

        private void btListarKitMotor_Click(object sender, EventArgs e)
        {
            listViewItens.Items.Clear();
            foreach (KitMotor item in KitMotor.retornaTodosKitMotor())
            {
                listViewItens.Items.Add(new ListViewItem(new string[] {
                                Convert.ToString(item.Id),
                                Convert.ToString(item.CodigoKitMotor),
                                Convert.ToString(item.ItensKit),
                                Convert.ToString(item.Marca),
                                Convert.ToString(item.Observacao)}));
            }
        }

        private void btListarMotor_Click(object sender, EventArgs e)
        {
            listViewItens.Items.Clear();
            foreach (Motor item in Motor.retornaTodosMotor())
            {
                listViewItens.Items.Add(new ListViewItem(new string[] {
                                Convert.ToString(item.IdMotor),
                                Convert.ToString(item.ModeloMotor),
                                Convert.ToString(item.ModeloVeiculo),
                                Convert.ToString(item.Observacao)}));
            }
        }
    }
}
