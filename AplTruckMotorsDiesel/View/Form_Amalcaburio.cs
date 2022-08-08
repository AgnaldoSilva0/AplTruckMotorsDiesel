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
    public partial class Form_Amalcaburio : MetroFramework.Forms.MetroForm
    {
        public Form_Amalcaburio()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            ListViewProdutos.Items.Clear();
            foreach (var item in Pesquisar.retornaProdutosAmalcaburio(tbPesquisar.Text))
            {
                ListViewProdutos.Items.Add(new ListViewItem(new String[] {
                item.codigo,
                item.descricao,
                item.precoCompra.ToString(),
                item.ipi.ToString()
                } ));
            }
        }

        private void ListViewProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            lbDescricao.Text = ListViewProdutos.SelectedItems[0].SubItems[1].Text;
            double precoVenda = Convert.ToDouble(ListViewProdutos.SelectedItems[0].SubItems[2].Text) * 2;
            lbPrecoVenda.Text = precoVenda.ToString();
        }
    }
}
