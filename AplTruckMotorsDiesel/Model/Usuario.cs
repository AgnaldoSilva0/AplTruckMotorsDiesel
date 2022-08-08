using AplTruckMotorsDiesel.Model_BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.Model
{
    class Usuario
    {
        private int id;
        private string nome;
        private string senha;
        private string permissao;

        public Usuario()
        {
        }

        public Usuario(string nome, string senha, string permissao)
        {
            this.nome = nome;
            this.senha = senha;
            this.permissao = permissao;
        }

        public Usuario(int id, string nome, string senha, string permissao)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.permissao = permissao;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }


        
        public string Permissao
        {
            get
            {

                if (permissao == "2")
                {
                    return permissao = "2 Comprador";
                }  
                
                else if (permissao == "3")
                {
                    return permissao = "3 Administrador";
                }
                else
                {
                    return permissao = "1 Visitante";
                }
            }
            set
            {
                permissao = value;
            }
        }

        public int Id { get => id; set => id = value; }
        

        public static Usuario RetornarIdUsuario(string nome, string senha)
        {
            Usuario usuario = new Usuario();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                DataTable dados = new DataTable();

                string query = "SELECT * FROM table_login WHERE usuario LIKE '"+nome+"' AND senha LIKE '"+senha+"'";

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    usuario.Id = Convert.ToInt16(row["id"]);
                    usuario.Nome = Convert.ToString(row["usuario"]);
                    usuario.Senha = Convert.ToString(row["senha"]);
                    usuario.Permissao = Convert.ToString(row["permissao"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return usuario;
        }

    }
}
