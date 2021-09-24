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
    public partial class NovoRegistro : MetroFramework.Forms.MetroForm
    {
        public NovoRegistro()
        {
            InitializeComponent();
        }

        private void btNovoPistao_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            pictureBoxCadastro.Image = Image.FromFile("pictures/pistao.png");
            lbItemSelecionado.Text = "Pistão";
        }

        private void btNovoBBiela_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            pictureBoxCadastro.Image = Image.FromFile("pictures/bronzina.png");
            lbItemSelecionado.Text = "Bronzina Biela";
        }

        private void btNovoJunta_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            pictureBoxCadastro.Image = Image.FromFile("pictures/junta.png");
            lbItemSelecionado.Text = "Jogo Junta";
        }

        private void btNovoBOleo_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            pictureBoxCadastro.Image = Image.FromFile("pictures/bombaOleo.png");
            lbItemSelecionado.Text = "Bomba de Oleo";
        }

        private void btNovoBMancal_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            pictureBoxCadastro.Image = Image.FromFile("pictures/bronzina.png");
            lbItemSelecionado.Text = "Bronzina Mancal";
        }

        private void btNovoBAgua_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            pictureBoxCadastro.Image = Image.FromFile("pictures/bombaAgua.png");
            lbItemSelecionado.Text = "Bomba Agua";
        }

        private void verificarPanelVisivel(Panel panel)
        {
            if (panel.Visible != true)
            {
                panel.Visible = true;
            }
        }

        private int ItemParaInserir;
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
