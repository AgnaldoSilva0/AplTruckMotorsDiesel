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

            Inserir.vincularPecas(idMotor, cbPistao.Text, cbAneis.Text, cbBbiela.Text, cbBmancal.Text, cbBagua.Text, cbBoleo.Text, cbJunta.Text, "NULL", cbKitMotor.Text);
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
        }

        private void cbModeloVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbVeiculoSelecionado.Text = cbModeloVeiculo.Text;
        }
    }
}
