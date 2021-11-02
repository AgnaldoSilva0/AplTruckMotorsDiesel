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
    public partial class FichaTecnica : MetroFramework.Forms.MetroForm
    {
        public FichaTecnica()
        {
            InitializeComponent();
        }

        public FichaTecnica(string codigoItem, int operacao)
        {
            InitializeComponent();
            PreencherDados(codigoItem, operacao);
            itemSelecionado = operacao;
        }

        private void btSair_Click(object sender, EventArgs e)
        {

        }

        private void PreencherDados(string codigoItem, int operacao)
        {
            switch (operacao)
            {
                case 1:
                    Pistao pistao = Pistao.retornaFichaTecnicaPorCodigo(codigoItem);
                    lbCodigo.Text = pistao.CodigoPistao;
                    lbCodigoOriginal.Text = pistao.CodigoOriginal;
                    lbMarca.Text = pistao.Marca;
                    lbObservacao.Text = pistao.Observacao;
                    lbId.Text = pistao.Id;
                    break;
                case 2:
                    Aneis aneis = Aneis.retornaFichaTecnicaPorCodigo(codigoItem);
                    lbCodigo.Text = aneis.CodigoAneis;
                    lbCodigoOriginal.Text = aneis.CodigoOriginal;
                    lbMarca.Text = aneis.Marca;
                    lbObservacao.Text = aneis.Observacao;
                    lbId.Text = aneis.Id;
                    break;
                case 3:
                    BombaAgua bombaAgua = BombaAgua.retornaFichaTecnicaPorCodigo(codigoItem);
                    lbCodigo.Text = bombaAgua.CodigoBombaAgua;
                    lbCodigoOriginal.Text = bombaAgua.CodigoOriginal;
                    lbMarca.Text = bombaAgua.Marca;
                    lbObservacao.Text = bombaAgua.Observacao;
                    lbId.Text = bombaAgua.Id;
                    break;
                case 4:
                    BombaOleo bombaOleo = BombaOleo.retornaFichaTecnicaPorCodigo(codigoItem);
                    lbCodigo.Text = bombaOleo.CodigoBombaOleo;
                    lbCodigoOriginal.Text = bombaOleo.CodigoOriginal;
                    lbMarca.Text = bombaOleo.Marca;
                    lbObservacao.Text = bombaOleo.Observacao;
                    lbId.Text = bombaOleo.Id;
                    break;
                case 5:
                    BronzinaBiela bronzinaBiela = BronzinaBiela.retornaFichaTecnicaPorCodigo(codigoItem);
                    lbCodigo.Text = bronzinaBiela.CodigoBBiela;
                    lbCodigoOriginal.Text = bronzinaBiela.CodigoOriginal;
                    lbMarca.Text = bronzinaBiela.Marca;
                    lbObservacao.Text = bronzinaBiela.Observacao;
                    lbId.Text = bronzinaBiela.Id;
                    break;
                case 6:
                    BronzinaMancal bronzinaMancal = BronzinaMancal.retornaFichaTecnicaPorCodigo(codigoItem);
                    lbCodigo.Text = bronzinaMancal.CodigoBMancal;
                    lbCodigoOriginal.Text = bronzinaMancal.CodigoOriginal;
                    lbMarca.Text = bronzinaMancal.Marca;
                    lbObservacao.Text = bronzinaMancal.Observacao;
                    lbId.Text = bronzinaMancal.Id;
                    break;
                case 7:
                    Junta junta = Junta.retornaFichaTecnicaPorCodigo(codigoItem);
                    lbCodigo.Text = junta.CodigoJunta;
                    lbCodigoOriginal.Text = junta.CodigoOriginal;
                    lbMarca.Text = junta.Marca;
                    lbObservacao.Text = junta.Observacao;
                    lbId.Text = junta.Id;
                    break;
                case 8:
                    KitMotor kitMotor = KitMotor.retornaFichaTecnicaPorCodigo(codigoItem);
                    lbCodigo.Text = kitMotor.CodigoKitMotor;
                    lbCodigoOriginal.Text = kitMotor.ItensKit;
                    lbMarca.Text = kitMotor.Marca;
                    lbObservacao.Text = kitMotor.Observacao;
                    lbId.Text = kitMotor.Id;
                    break;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (Program.VarGlobalPermissaoUsuario > 1)
            {
                if (btEditar.Text == "Editar")
                {
                    lbCodigo.ReadOnly = false;
                    lbCodigoOriginal.ReadOnly = false;
                    lbMarca.ReadOnly = false;
                    lbObservacao.ReadOnly = false;
                    btEditar.BackColor = Color.Green;
                    btEditar.Text = "Salvar";
                }
                else
                {
                    editarItem();
                    lbCodigo.ReadOnly = true;
                    lbCodigoOriginal.ReadOnly = true;
                    lbMarca.ReadOnly = true;
                    lbObservacao.ReadOnly = true;
                    btEditar.BackColor = Color.Cyan;
                    btEditar.Text = "Editar";
                }
            } else
            {
                MessageBox.Show("Usuário não tem permissão para essa ação");
            }
        }

        private int itemSelecionado;
        private void editarItem()
        {
            string codigo = lbCodigo.Text;
            string codigoOriginal = lbCodigoOriginal.Text;
            string marca = lbMarca.Text;
            string observacao = lbObservacao.Text;
            int id = Convert.ToInt32(lbId.Text);
            switch (itemSelecionado)
            {
                case 1: //Pistao
                    Editar.StringEditarItem("table_pistao", id, codigo, codigoOriginal, marca, observacao);
                    break;
                case 2: //Aneis
                    Editar.StringEditarItem("table_aneis", id, codigo, codigoOriginal, marca, observacao);
                    break;
                case 3: //BombaAgua
                    Editar.StringEditarItem("table_bombaagua", id, codigo, codigoOriginal, marca, observacao);
                    break;
                case 4: //BombaOleo
                    Editar.StringEditarItem("table_bombaoleo", id, codigo, codigoOriginal, marca, observacao);
                    break;
                case 5: //BronzinaBiela
                    Editar.StringEditarItem("table_bbiela", id, codigo, codigoOriginal, marca, observacao);
                    break;
                case 6: //BombaMancal
                    Editar.StringEditarItem("table_bmancal", id, codigo, codigoOriginal, marca, observacao);
                    break;
                case 7: //Junta
                    Editar.StringEditarItem("table_junta", id, codigo, codigoOriginal, marca, observacao);
                    break;
                case 8: //KitMotor
                    Editar.StringEditarKitMotor("table_kitmotor", id, codigo, codigoOriginal, marca, observacao);
                    break;
            }
        }

    }
}
