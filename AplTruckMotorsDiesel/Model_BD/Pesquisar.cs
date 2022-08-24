using AplTruckMotorsDiesel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.Model_BD
{
    class Pesquisar
    {
        /// <summary>
        /// Este método retorna a lista de motores cadastrado no banco de dados, se for passado algum codigo de pesquisa
        /// ele irá retornar o motor com o codigo informado
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static List<Motor> RetornarMotor(string codigo, int operacao)
        {
            List<Motor> lista = new List<Motor>();
            lista.Clear();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_motor";
                switch (operacao)
                {
                    case 1:
                        //Coloca o % como se fosse um CONTAINS
                        //Essa query retorna uma lista de motores de acordo com o Modelo Veiculo passado
                        query = "SELECT * FROM table_motor WHERE modeloVeiculo LIKE '%" + codigo + "%' ";
                        break;
                    case 2:
                        //Essa query retorna apenas um MOTOR, usado para quando precisa apenas de um motor especifico
                        query = "SELECT * FROM table_motor WHERE modeloVeiculo LIKE '" + codigo + "' ";
                        break;
                    case 3:
                        //Essa query retorna uma lista de motores de acordo com o Motor passado
                        query = "SELECT * FROM table_motor WHERE modeloMotor LIKE '%" + codigo + "%' ";
                        break;
                }

                DataTable dados = new DataTable();
                
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    lista.Add(new Motor(Convert.ToInt32(row["id"]), 
                        Convert.ToString(row["modeloMotor"]),
                        Convert.ToString(row["modeloVeiculo"]), 
                        Convert.ToString(row["observacao"])));
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
            return lista;
        }

        /// <summary>
        /// Esse método retorna a lista de itens de acordo com o motor clicado na listview, precisa passar trÊs parametros
        /// pra ele, que estão comentador abaixo:
        /// </summary>
        /// <param name="idDoItemRetorno"> Precisa passar como parametro o nome da coluna na tebela APLICAÇÃO</param>
        /// <param name="queryParametro"> Precisa passar a query que será executada pelo SQLite, cada MODEL tem sua própria query</param>
        /// <param name="objetoPeca"> Precisa passar um identificador para ser usado no SWITH, para criar o objeto especifico para ser retornador</param>
        /// <returns></returns>
        public static List<Object> retornaPeca(string idDoItemRetorno, string itemSelecionado, int objetoPeca)
        {
            List<Object> lista = new List<Object>();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                DataTable dados = new DataTable();
                
                string query = "SELECT * FROM table_aplicacao " +
                    "INNER JOIN table_motor ON table_aplicacao.idMotor = table_motor.id " +
                    "WHERE table_motor.modeloVeiculo LIKE '%" + itemSelecionado + "%' ";

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);
                foreach (System.Data.DataRow row in dados.Rows)
                {
                    switch (objetoPeca)
                    {
                        case 1:
                            string idPistaoAplicacao = Convert.ToString(row["idPistao"]);
                            lista.Add(new Pistao(Convert.ToString(Pistao.retornaFichaTecnicaPorId(idPistaoAplicacao).CodigoPistao)));
                            break;
                        case 2:
                            string idBBielaAplicacao = Convert.ToString(row["idBBiela"]);
                            lista.Add(new BronzinaBiela(Convert.ToString(BronzinaBiela.retornaFichaTecnicaPorId(idBBielaAplicacao).CodigoBBiela)));
                            break;
                        case 3:
                            string idJuntaAplicacao = Convert.ToString(row["idJunta"]);
                            lista.Add(new Junta(Convert.ToString(Junta.retornaFichaTecnicaPorId(idJuntaAplicacao).CodigoJunta)));
                            break;
                        case 4:
                            string idAneisAplicacao = Convert.ToString(row["idAneis"]);
                            lista.Add(new Aneis(Convert.ToString(Aneis.retornaFichaTecnicaPorId(idAneisAplicacao).CodigoAneis)));
                            break;
                        case 5:
                            string idBMancalAplicacao = Convert.ToString(row["idBMancal"]);
                            lista.Add(new BronzinaMancal(Convert.ToString(BronzinaMancal.retornaFichaTecnicaPorId(idBMancalAplicacao).CodigoBMancal)));
                            break;
                        case 6:
                            string idBombaAguaAplicacao = Convert.ToString(row["idBombaAgua"]);
                            lista.Add(new BombaAgua(Convert.ToString(BombaAgua.retornaFichaTecnicaPorId(idBombaAguaAplicacao).CodigoBombaAgua)));
                            break;
                        case 7:
                            string idBombaOleoAplicacao = Convert.ToString(row["idBombaOleo"]);
                            lista.Add(new BombaOleo(Convert.ToString(BombaOleo.retornaFichaTecnicaPorId(idBombaOleoAplicacao).CodigoBombaOleo)));
                            break;
                        case 8:
                            string idKitMotorAplicacao = Convert.ToString(row["idKitMotor"]);
                            lista.Add(new KitMotor(Convert.ToString(KitMotor.retornaFichaTecnicaPorId(idKitMotorAplicacao).CodigoKitMotor)));
                            break;
                        case 9:
                            string idOutraPeca = Convert.ToString(row["idOutra"]);
                            lista.Add(new Outra(Convert.ToString(Outra.retornaFichaTecnicaPorId(idOutraPeca).Descricao)));
                            break;
                    }
                    
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
            return lista;
        }

        /// <summary>
        /// Classe usada para preencher os ComboBox na Form VincularAplicacao
        /// </summary>
        /// <param name="tabela">Precisa passar a tabela no banco de dados</param>
        /// <param name="identificadorSwith">Usado para passar o inteiro para ser usado no swith</param>
        /// <returns></returns>
        public static List<Object> retornaPecasComboBox(string tabela, int identificadorSwith)
        {
            List<Object> lista = new List<Object>();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                DataTable dados = new DataTable();

                string query = "SELECT * FROM '"+ tabela +"' ";

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);
                foreach (System.Data.DataRow row in dados.Rows)
                {
                    switch (identificadorSwith)
                    {
                        case 0:
                            lista.Add(new Motor(Convert.ToString(row["modeloVeiculo"])));
                            break;
                        case 1:
                            lista.Add(new Pistao(Convert.ToString(row["codigo"])));
                            break;
                        case 2:
                            lista.Add(new BronzinaBiela(Convert.ToString(row["codigo"])));
                            break;
                        case 3:
                            lista.Add(new Junta(Convert.ToString(row["codigo"])));
                            break;
                        case 4:
                            lista.Add(new Aneis(Convert.ToString(row["codigo"])));
                            break;
                        case 5:
                            lista.Add(new BronzinaMancal(Convert.ToString(row["codigo"])));
                            break;
                        case 6:
                            lista.Add(new BombaAgua(Convert.ToString(row["codigo"])));
                            break;
                        case 7:
                            lista.Add(new BombaOleo(Convert.ToString(row["codigo"])));
                            break;
                        case 8:
                            lista.Add(new KitMotor(Convert.ToString(row["codigo"])));
                            break;
                        case 9:
                            lista.Add(new Outra(Convert.ToString(row["descricao"])));
                            break;
                    }

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
            return lista;
        }

        /// <summary>
        /// Retorna todos os usuários para a lista que chamar
        /// </summary>
        /// <returns></returns>
        public static List<Usuario> retornaListaUsuario()
        {
            List<Usuario> lista = new List<Usuario>();

            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                DataTable dados = new DataTable();

                string query = "SELECT * FROM table_login";

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    lista.Add(new Usuario(Convert.ToString(row["usuario"]), Convert.ToString(row["senha"]), Convert.ToString(row["permissao"])));
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
            return lista;
        }

        public static List<Produto> retornaProdutosAmalcaburio(string fonte)
        {
            List<Produto> lista = new List<Produto>();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                DataTable dados = new DataTable();

                string query = "SELECT * FROM table_produto WHERE codigo LIKE '%" + fonte + "%' OR descricao LIKE '%" + fonte + "%' ";

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);
                foreach (System.Data.DataRow row in dados.Rows)
                {
                    lista.Add(new Produto() { 
                    codigo = Convert.ToString(row["codigo"]),
                    descricao = Convert.ToString(row["descricao"]),
                    precoCompra = Convert.ToDouble(row["preco"]),
                    ipi = Convert.ToInt32(row["ipi"])
                    });
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
            return lista;
        }
    }
}
