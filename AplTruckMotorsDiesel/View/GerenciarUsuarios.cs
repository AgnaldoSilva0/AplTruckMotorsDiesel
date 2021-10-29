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
    public partial class GerenciarUsuarios : MetroFramework.Forms.MetroForm
    {
        public GerenciarUsuarios()
        {
            InitializeComponent();
            carregarLista();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = ListViewUsuario.SelectedItems[0].SubItems[0].Text;
                string senha = ListViewUsuario.SelectedItems[0].SubItems[1].Text;
                int id = Usuario.RetornarIdUsuario(nome, senha).Id;
                int permissao = Convert.ToInt16(ListViewUsuario.SelectedItems[0].SubItems[2].Text.Substring(0, 1));

                EditarUsuario editarUsuario = new EditarUsuario(nome, senha, permissao, id);
                editarUsuario.ShowDialog();
            }
            catch (System.ArgumentOutOfRangeException) {
                MessageBox.Show("Selecione um usuário para editar");
            }   
        }

        private void btCriarNovo_Click(object sender, EventArgs e)
        {
            NovoUsuario novoUsuario = new NovoUsuario();
            novoUsuario.ShowDialog();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Deletar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            string nome = ListViewUsuario.SelectedItems[0].SubItems[0].Text;
            string senha = ListViewUsuario.SelectedItems[0].SubItems[1].Text;
            if (resultado == DialogResult.Yes)
            {
                if(Deletar.DeletarUsuario(nome, senha))
                {
                    MessageBox.Show("Usuário Excluido");
                }
                else
                {
                    MessageBox.Show("Usuário não excluido");
                }
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Usuário não excluido!");
            }
        }

        private void carregarLista()
        {
            ListViewUsuario.Items.Clear();
            foreach (Usuario item in Pesquisar.retornaListaUsuario())
            {
                ListViewUsuario.Items.Add(new ListViewItem(new string[] {
                        Convert.ToString(item.Nome),
                        Convert.ToString(item.Senha),
                        Convert.ToString(item.Permissao)}));
            }
        }

    }
}
