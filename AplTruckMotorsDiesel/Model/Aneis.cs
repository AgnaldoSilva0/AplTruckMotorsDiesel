﻿using AplTruckMotorsDiesel.Model_BD;
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
    class Aneis
    {
        private string id;
        private string codigoAneis;
        private string codigoOriginal;
        private string marca;
        private string observacao;

        public Aneis()
        {
        }

        public Aneis(string codigoAneis)
        {
            this.codigoAneis = codigoAneis;
        }

        public Aneis(string id, string codigoAneis, string codigoOriginal, string marca, string observacao)
        {
            this.id = id;
            this.codigoAneis = codigoAneis;
            this.codigoOriginal = codigoOriginal;
            this.marca = marca;
            this.observacao = observacao;
        }

        public string CodigoAneis { get => codigoAneis; set => codigoAneis = value; }
        public string CodigoOriginal { get => codigoOriginal; set => codigoOriginal = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Id { get => id; set => id = value; }



        /// <summary>
        /// Método para retornar ficha tecnica do item, precisa passar o codigo como parametro
        /// </summary>
        /// <param name="codigo">Codigo do item usado para pesquisar o mesmo no banco de dados</param>
        /// <returns></returns>
        public static Aneis retornaFichaTecnicaPorId(string id)
        {
            Aneis aneis = new Aneis();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_aneis WHERE id LIKE '" + id + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    aneis = new Aneis(Convert.ToString(row["id"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["codigoOriginal"]),
                        Convert.ToString(row["marca"]),
                        Convert.ToString(row["observacao"]));
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
            return aneis;
        }

        public static Aneis retornaFichaTecnicaPorCodigo(string codigo)
        {
            Aneis aneis = new Aneis();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_aneis WHERE codigo LIKE '" + codigo + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    aneis = new Aneis(Convert.ToString(row["id"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["codigoOriginal"]),
                        Convert.ToString(row["marca"]),
                        Convert.ToString(row["observacao"]));
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
            return aneis;
        }

        public static List<Aneis> retornaTodosAneis()
        {
            List<Aneis> lista = new List<Aneis>();
            string baseDados = DiretorioBD.CaminhoBancoDadosPrincipal;
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_aneis";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    lista.Add(new Aneis(Convert.ToString(row["id"]),
                        Convert.ToString(row["codigo"]),
                        Convert.ToString(row["codigoOriginal"]),
                        Convert.ToString(row["marca"]),
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

    }
}
