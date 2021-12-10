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
    public partial class NovoRegistro : MetroFramework.Forms.MetroForm
    {
        public NovoRegistro()
        {
            InitializeComponent();
        }

        private void btNovoPistao_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            IdMetodoInsert = 1;
            pictureBoxCadastro.Image = Icones.ImgPistao;
            lbItemSelecionado.Text = "Pistão";
            alterarWaterMark(2);
        }

        private void btAneis_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            IdMetodoInsert = 2;
            pictureBoxCadastro.Image = Icones.ImgPistao;
            lbItemSelecionado.Text = "Anéis";
            alterarWaterMark(2);
        }

        private void btNovoBBiela_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            IdMetodoInsert = 3;
            pictureBoxCadastro.Image = Icones.ImgBronzina;
            lbItemSelecionado.Text = "Bronzina Biela";
            alterarWaterMark(2);
        }

        private void btNovoJunta_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            IdMetodoInsert = 4;
            pictureBoxCadastro.Image = Icones.ImgJunta;
            lbItemSelecionado.Text = "Jogo Junta";
            alterarWaterMark(2);
        }

        private void btNovoBOleo_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            IdMetodoInsert = 5;
            pictureBoxCadastro.Image = Icones.ImgBombaOleo;
            lbItemSelecionado.Text = "Bomba de Oleo";
            alterarWaterMark(2);
        }

        private void btNovoBMancal_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            IdMetodoInsert = 6;
            pictureBoxCadastro.Image = Icones.ImgBronzina;
            lbItemSelecionado.Text = "Bronzina Mancal";
            alterarWaterMark(2);
        }

        private void btNovoBAgua_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            IdMetodoInsert = 7;
            pictureBoxCadastro.Image = Icones.ImgBombaAgua;
            lbItemSelecionado.Text = "Bomba Agua";
            alterarWaterMark(2);
        }

        private void btCadastrarMotor_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            IdMetodoInsert = 8;
            pictureBoxCadastro.Image = Icones.ImgMotor;
            lbItemSelecionado.Text = "Motor";
            alterarWaterMark(1);
        }

        private void btKitMotor_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            IdMetodoInsert = 9;
            pictureBoxCadastro.Image = Icones.ImgKitMotor;
            lbItemSelecionado.Text = "Kit Motor";
            alterarWaterMark(3);
        }

        private void btCadastrarOutrasPecas_Click(object sender, EventArgs e)
        {
            verificarPanelVisivel(panelCadastro);
            IdMetodoInsert = 10;
            pictureBoxCadastro.Image = Icones.ImgPistao;
            lbItemSelecionado.Text = "Outras Peças";
            alterarWaterMark(4);
        }

        private void verificarPanelVisivel(Panel panel)
        {
            if (panel.Visible != true)
            {
                panel.Visible = true;
            }
        }

        private int IdMetodoInsert;
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Inserir.chamaMetodo(IdMetodoInsert, tbCodigo.Text, tbCodigoOriginal.Text, tbMarca.Text, tbObervacao.Text);

            tbCodigo.Text = "";
            tbCodigoOriginal.Text = "";
            tbMarca.Text = "";
            tbObervacao.Text = "";
        }

        private void alterarWaterMark(int botaoSelecionado)
        {
            switch (botaoSelecionado)
            {
                case 1: //Motor
                    tbCodigo.WaterMark = "Modelo Veiculo";
                    tbCodigoOriginal.WaterMark = "Modelo Motor";
                    tbMarca.WaterMark = "Observação";
                    break;
                case 2: //Itens Comuns
                    tbCodigo.WaterMark = "Código";
                    tbCodigoOriginal.WaterMark = "Código Original";
                    tbMarca.WaterMark = "Marca";
                    break;
                case 3: //Kit Motor
                    tbCodigo.WaterMark = "Código";
                    tbCodigoOriginal.WaterMark = "Itens do Kit";
                    tbMarca.WaterMark = "Marca";
                    break;
                case 4: //Outras Peças
                    tbCodigo.WaterMark = "Código";
                    tbCodigoOriginal.WaterMark = "Descrição";
                    tbMarca.WaterMark = "Marca";
                    break;
            }
        }

        
    }
}
