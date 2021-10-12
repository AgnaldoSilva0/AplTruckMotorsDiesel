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
        }

        private void btSair_Click(object sender, EventArgs e)
        {

        }

        private void PreencherDados(string codigoItem, int operacao)
        {
            switch (operacao)
            {
                case 1:
                    Pistao pistao = Pistao.retornaFichaTecnica(codigoItem);
                    lbCodigo.Text = pistao.CodigoPistao;
                    lbCodigoOriginal.Text = pistao.CodigoOriginal;
                    lbMarca.Text = pistao.Marca;
                    lbObservacao.Text = pistao.Observacao;
                    break;
                case 2:
                    Aneis aneis = Aneis.retornaFichaTecnica(codigoItem);
                    lbCodigo.Text = aneis.CodigoAneis;
                    lbCodigoOriginal.Text = aneis.CodigoOriginal;
                    lbMarca.Text = aneis.Marca;
                    lbObservacao.Text = aneis.Observacao;
                    break;
                case 3:
                    BombaAgua bombaAgua = BombaAgua.retornaFichaTecnica(codigoItem);
                    lbCodigo.Text = bombaAgua.CodigoBombaAgua;
                    lbCodigoOriginal.Text = bombaAgua.CodigoOriginal;
                    lbMarca.Text = bombaAgua.Marca;
                    lbObservacao.Text = bombaAgua.Observacao;
                    break;
                case 4:
                    BombaOleo bombaOleo = BombaOleo.retornaFichaTecnica(codigoItem);
                    lbCodigo.Text = bombaOleo.CodigoBombaOleo;
                    lbCodigoOriginal.Text = bombaOleo.CodigoOriginal;
                    lbMarca.Text = bombaOleo.Marca;
                    lbObservacao.Text = bombaOleo.Observacao;
                    break;
                case 5:
                    BronzinaBiela bronzinaBiela = BronzinaBiela.retornaFichaTecnica(codigoItem);
                    lbCodigo.Text = bronzinaBiela.CodigoBBiela;
                    lbCodigoOriginal.Text = bronzinaBiela.CodigoOriginal;
                    lbMarca.Text = bronzinaBiela.Marca;
                    lbObservacao.Text = bronzinaBiela.Observacao;
                    break;
                case 6:
                    BronzinaMancal bronzinaMancal = BronzinaMancal.retornaFichaTecnica(codigoItem);
                    lbCodigo.Text = bronzinaMancal.CodigoBMancal;
                    lbCodigoOriginal.Text = bronzinaMancal.CodigoOriginal;
                    lbMarca.Text = bronzinaMancal.Marca;
                    lbObservacao.Text = bronzinaMancal.Observacao;
                    break;
                case 7:
                    Junta junta = Junta.retornaFichaTecnica(codigoItem);
                    lbCodigo.Text = junta.CodigoJunta;
                    lbCodigoOriginal.Text = junta.CodigoOriginal;
                    lbMarca.Text = junta.Marca;
                    lbObservacao.Text = junta.Observacao;
                    break;
                case 8:
                    KitMotor kitMotor = KitMotor.retornaFichaTecnica(codigoItem);
                    lbCodigo.Text = kitMotor.CodigoKitMotor;
                    lbCodigoOriginal.Text = kitMotor.ItensKit;
                    lbMarca.Text = kitMotor.Marca;
                    lbObservacao.Text = kitMotor.Observacao;
                    break;
            }
        }

    }
}
