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
    }
}
