using AplTruckMotorsDiesel.Model;
using AplTruckMotorsDiesel.Model_BD;
using AplTruckMotorsDiesel.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Conexao.conexao();
        }

        private void btCriarNovo_Click(object sender, EventArgs e)
        {
            NovoRegistro novoRegistro = new NovoRegistro();
            novoRegistro.ShowDialog();
        }

        //Variavel criada para dar sinal de positivo ou não para a form de login
        public static bool dialogResult = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            //Se der erro no login, a aplicação fecha
            if (dialogResult != true)
            {
                Application.Exit();
                return;
            }
        }

        private void btPesquisaGeral_Click(object sender, EventArgs e)
        {
            listViewMotor.Items.Clear();
            foreach (Motor item in Pesquisar.RetornarMotor(tbFonte.Text, 1))
            {
                listViewMotor.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(item.IdMotor),
                        Convert.ToString(item.ModeloVeiculo),
                        Convert.ToString(item.ModeloMotor),
                        Convert.ToString(item.Observacao) }));
            }
        }

        private void btPesquisaAplicacao_Click(object sender, EventArgs e)
        {
            listViewMotor.Items.Clear();
            foreach (Motor item in Pesquisar.RetornarMotor(tbAplicacao.Text, 1))
            {
                listViewMotor.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(item.IdMotor),
                        Convert.ToString(item.ModeloVeiculo),
                        Convert.ToString(item.ModeloMotor),
                        Convert.ToString(item.Observacao) }));
            }
        }

        private void btPesquisaMotor_Click(object sender, EventArgs e)
        {
            listViewMotor.Items.Clear();
            foreach (Motor item in Pesquisar.RetornarMotor(tbMotor.Text, 3))
            {
                listViewMotor.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(item.IdMotor),
                        Convert.ToString(item.ModeloVeiculo),
                        Convert.ToString(item.ModeloMotor),
                        Convert.ToString(item.Observacao) }));
            }
        }

        private void listViewMotor_MouseClick(object sender, MouseEventArgs e)
        {
            string selecionado = listViewMotor.SelectedItems[0].SubItems[2].Text;
            limparTodasListas();

            foreach (Pistao pistao in Pesquisar.retornaPeca("idPistao", selecionado, 1))
            {
                listViewPistao.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(pistao.CodigoPistao) }));

                foreach (BronzinaBiela bbiela in Pesquisar.retornaPeca("idBBiela", selecionado, 2))
                {
                    listViewBBiela.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(bbiela.CodigoBBiela) }));
                }

                foreach (Junta junta in Pesquisar.retornaPeca("idJunta",selecionado, 3))
                {
                    listViewJunta.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(junta.CodigoJunta) }));
                }

                foreach (Aneis aneis in Pesquisar.retornaPeca("idAneis", selecionado, 4))
                {
                    listViewAneis.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(aneis.CodigoAneis) }));
                }

                foreach (BronzinaMancal bMancal in Pesquisar.retornaPeca("idBMancal", selecionado, 5))
                {
                    listViewBMancal.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(bMancal.CodigoBMancal) }));
                }

                foreach (BombaAgua bombaAgua in Pesquisar.retornaPeca("idBombaAgua", selecionado, 6))
                {
                    listViewBombaAgua.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(bombaAgua.CodigoBombaAgua) }));
                }

                foreach (BombaOleo bombaOleo in Pesquisar.retornaPeca("idBombaOleo", selecionado, 7))
                {
                    listViewBombaOleo.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(bombaOleo.CodigoBombaOleo) }));
                }

                foreach (KitMotor kitMotor in Pesquisar.retornaPeca("idKitMotor", selecionado, 8))
                {
                    listViewKitMotor.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(kitMotor.CodigoKitMotor) }));
                }
            }
        }

        private void limparTodasListas()
        {
            listViewPistao.Items.Clear();
            listViewBBiela.Items.Clear();
            listViewJunta.Items.Clear();
            listViewAneis.Items.Clear();
            listViewBMancal.Items.Clear();
            listViewBombaAgua.Items.Clear();
            listViewBombaOleo.Items.Clear();
            listViewKitMotor.Items.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void listViewPistao_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                FichaTecnica fichaTecnica = new FichaTecnica(listViewPistao.SelectedItems[0].Text, 1);
                fichaTecnica.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void listViewAneis_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                FichaTecnica fichaTecnica = new FichaTecnica(listViewAneis.SelectedItems[0].Text, 2);
                fichaTecnica.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Tente Novamente");
            }
        }

        private void listViewBombaAgua_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                FichaTecnica fichaTecnica = new FichaTecnica(listViewBombaAgua.SelectedItems[0].Text, 3);
                fichaTecnica.ShowDialog();
            } catch(System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Tente Novamente");
            }
        }

        private void listViewBombaOleo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                FichaTecnica fichaTecnica = new FichaTecnica(listViewBombaOleo.SelectedItems[0].Text, 4);
                fichaTecnica.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Tente Novamente");
            }
        }

        private void listViewBBiela_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                FichaTecnica fichaTecnica = new FichaTecnica(listViewBBiela.SelectedItems[0].Text, 5);
                fichaTecnica.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Tente Novamente");
            }
        }

        private void listViewBMancal_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FichaTecnica fichaTecnica = new FichaTecnica(listViewBMancal.SelectedItems[0].Text, 6);
                fichaTecnica.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Tente Novamente");
            }
        }

        private void listViewJunta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                FichaTecnica fichaTecnica = new FichaTecnica(listViewJunta.SelectedItems[0].Text, 7);
                fichaTecnica.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Tente Novamente");
            }
        }

        private void listViewKitMotor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FichaTecnica fichaTecnica = new FichaTecnica(listViewKitMotor.SelectedItems[0].Text, 8);
                fichaTecnica.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Tente Novamente");
            }
        }
    }
}
