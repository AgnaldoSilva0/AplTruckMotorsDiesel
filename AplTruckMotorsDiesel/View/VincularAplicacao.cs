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
    public partial class VincularAplicacao : MetroFramework.Forms.MetroForm
    {
        public VincularAplicacao()
        {
            InitializeComponent();
            carregarComboPistao();
        }

        private void btVincular_Click(object sender, EventArgs e)
        {
            int idMotor = 0;
            foreach (Motor item in Pesquisar.RetornarMotor(cbModeloVeiculo.Text, 2))
            {
                idMotor = item.IdMotor;
            }

            string pistao = Pistao.retornaFichaTecnicaPorCodigo(cbPistao.Text).Id;
            string aneis = Aneis.retornaFichaTecnicaPorCodigo(cbAneis.Text).Id;
            string bBiela = BronzinaBiela.retornaFichaTecnicaPorCodigo(cbBbiela.Text).Id;
            string bMancal = BronzinaMancal.retornaFichaTecnicaPorCodigo(cbBmancal.Text).Id;
            string bAgua = BombaAgua.retornaFichaTecnicaPorCodigo(cbBagua.Text).Id;
            string bOleo = BombaOleo.retornaFichaTecnicaPorCodigo(cbBoleo.Text).Id;
            string junta = Junta.retornaFichaTecnicaPorCodigo(cbJunta.Text).Id;
            string kitMotor = KitMotor.retornaFichaTecnicaPorCodigo(cbKitMotor.Text).Id;
            int outra = Outra.retornaFichaTecnicaPorCodigo(cbOutrasPecas.Text).Id;

            Inserir.vincularPecas(idMotor, pistao, aneis, bBiela, bMancal, bAgua, bOleo, junta, "NULL", kitMotor, outra);
            LimparComboBox();
        }

        /// <summary>
        /// Usado para preencher todos ComboBox
        /// </summary>
        private void carregarComboPistao()
        {
            foreach (Motor item in Pesquisar.retornaPecasComboBox("table_motor", 0))
            {
                cbModeloVeiculo.Items.Add(item.ModeloVeiculo);
            }

            foreach (Pistao item in Pesquisar.retornaPecasComboBox("table_pistao", 1))
            {
                cbPistao.Items.Add(item.CodigoPistao);
            }

            foreach (BronzinaBiela item in Pesquisar.retornaPecasComboBox("table_bbiela", 2))
            {
                cbBbiela.Items.Add(item.CodigoBBiela);
            }

            foreach (Junta item in Pesquisar.retornaPecasComboBox("table_junta", 3))
            {
                cbJunta.Items.Add(item.CodigoJunta);
            }

            foreach (Aneis item in Pesquisar.retornaPecasComboBox("table_aneis", 4))
            {
                cbAneis.Items.Add(item.CodigoAneis);
            }

            foreach (BronzinaMancal item in Pesquisar.retornaPecasComboBox("table_bmancal", 5))
            {
                cbBmancal.Items.Add(item.CodigoBMancal);
            }

            foreach (BombaAgua item in Pesquisar.retornaPecasComboBox("table_bombaagua", 6))
            {
                cbBagua.Items.Add(item.CodigoBombaAgua);
            }

            foreach (BombaOleo item in Pesquisar.retornaPecasComboBox("table_bombaoleo", 7))
            {
                cbBoleo.Items.Add(item.CodigoBombaOleo);
            }

            foreach (KitMotor item in Pesquisar.retornaPecasComboBox("table_kitmotor", 8))
            {
                cbKitMotor.Items.Add(item.CodigoKitMotor);
            }

            foreach (Outra item in Pesquisar.retornaPecasComboBox("table_outra", 9))
            {
                cbOutrasPecas.Items.Add(item.Descricao);
            }
        }

        private void LimparComboBox()
        {
            cbModeloVeiculo.SelectedIndex = -1;
            cbAneis.SelectedIndex = -1;
            cbBagua.SelectedIndex = -1;
            cbBbiela.SelectedIndex = -1;
            cbBmancal.SelectedIndex = -1;
            cbBoleo.SelectedIndex = -1;
            cbJunta.SelectedIndex = -1;
            cbKitMotor.SelectedIndex = -1;
            cbPistao.SelectedIndex = -1;
            cbOutrasPecas.SelectedIndex = -1;
        }

        #region Comandos para alterar label ao selecionar algum item!
        private void cbModeloVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbVeiculoSelecionado.Text = cbModeloVeiculo.Text;
        }

        private void cbPistao_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPistaoSelecionado.Text = Pistao.retornaFichaTecnicaPorCodigo(cbPistao.Text).Observacao;
        }

        private void cbAneis_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAneisSelecionado.Text = Aneis.retornaFichaTecnicaPorCodigo(cbAneis.Text).Observacao;
        }

        private void cbBbiela_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBielaSelecionado.Text = BronzinaBiela.retornaFichaTecnicaPorCodigo(cbBbiela.Text).Observacao;
        }

        private void cbBmancal_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMancalSelecionado.Text = BronzinaMancal.retornaFichaTecnicaPorCodigo(cbBmancal.Text).Observacao;
        }

        private void cbJunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbJuntaSelecionado.Text = Junta.retornaFichaTecnicaPorCodigo(cbJunta.Text).Observacao;
        }

        private void cbBoleo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBombaOleoSelecionado.Text = BombaOleo.retornaFichaTecnicaPorCodigo(cbBoleo.Text).Observacao;
        }

        private void cbBagua_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBombaAguaSelecionado.Text = BombaAgua.retornaFichaTecnicaPorCodigo(cbBagua.Text).Observacao;
        }

        private void cbKitMotor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbKitSelecionado.Text = KitMotor.retornaFichaTecnicaPorCodigo(cbKitMotor.Text).Observacao;
        }
        #endregion

        private void btLimparTudo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja limpar todos os campos?", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                LimparComboBox();
            }
        }
    }
}
