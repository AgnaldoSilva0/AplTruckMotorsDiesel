using AplTruckMotorsDiesel.Model;
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
    public partial class Form_ListaNota : MetroFramework.Forms.MetroForm
    {
        public Form_ListaNota()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            listViewListaNotas.Items.Clear();
            foreach (var item in Nota.RetornaListaNotas("d", 10))
            {
                listViewListaNotas.Items.Add(new ListViewItem(new String[] {
                    item.Numero,
                    item.Cliente,
                    item.Modelo,
                    item.Placa,
                    item.Data,
                    item.Observacao
            }));
            }
            
        }

        private void btPesquisarNumero_Click(object sender, EventArgs e)
        {
            listViewListaNotas.Items.Clear();
            foreach (var item in Nota.RetornaListaNotas(tbPesquisaNumero.Text, 1))
            {
                listViewListaNotas.Items.Add(new ListViewItem(new String[] {
                    item.Numero,
                    item.Cliente,
                    item.Modelo,
                    item.Placa,
                    item.Data,
                    item.Observacao
            }));
            }
        }

        private void btPesquisarModelo_Click(object sender, EventArgs e)
        {
            listViewListaNotas.Items.Clear();
            foreach (var item in Nota.RetornaListaNotas(tbPesquisaModelo.Text, 2))
            {
                listViewListaNotas.Items.Add(new ListViewItem(new String[] {
                    item.Numero,
                    item.Cliente,
                    item.Modelo,
                    item.Placa,
                    item.Data,
                    item.Observacao
            }));
            }
        }

        private void btPesquisarPlaca_Click(object sender, EventArgs e)
        {
            listViewListaNotas.Items.Clear();
            foreach (var item in Nota.RetornaListaNotas(tbPesquisaPlaca.Text, 3))
            {
                listViewListaNotas.Items.Add(new ListViewItem(new String[] {
                    item.Numero,
                    item.Cliente,
                    item.Modelo,
                    item.Placa,
                    item.Data,
                    item.Observacao
            }));
            }
        }

        private void btPesquisarData_Click(object sender, EventArgs e)
        {
            listViewListaNotas.Items.Clear();
            foreach (var item in Nota.RetornaListaNotas(tbPesquisaData.Text, 4))
            {
                listViewListaNotas.Items.Add(new ListViewItem(new String[] {
                    item.Numero,
                    item.Cliente,
                    item.Modelo,
                    item.Placa,
                    item.Data,
                    item.Observacao
            }));
            }
        }

        private void btPesquisarCliente_Click(object sender, EventArgs e)
        {
            listViewListaNotas.Items.Clear();
            foreach (var item in Nota.RetornaListaNotas(tbPesquisarCliente.Text, 5))
            {
                listViewListaNotas.Items.Add(new ListViewItem(new String[] {
                    item.Numero,
                    item.Cliente,
                    item.Modelo,
                    item.Placa,
                    item.Data,
                    item.Observacao
            }));
            }
        }

        private void btNovaNota_Click(object sender, EventArgs e)
        {
            Form_Add_Nota form_Add_Nota = new Form_Add_Nota();
            form_Add_Nota.ShowDialog();
        }
    }
}
