﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplTruckMotorsDiesel.Model
{
    class BombaAgua
    {
        private string codigoBombaAgua;
        private string codigoOriginal;
        private string marca;
        private string observacao;

        public BombaAgua()
        {
        }

        public BombaAgua(string codigoBombaAgua)
        {
            this.codigoBombaAgua = codigoBombaAgua;
        }

        public BombaAgua(string codigoBombaAgua, string codigoOriginal, string marca, string observacao) : this(codigoBombaAgua)
        {
            this.codigoOriginal = codigoOriginal;
            this.marca = marca;
            this.observacao = observacao;
        }

        public string CodigoBombaAgua { get => codigoBombaAgua; set => codigoBombaAgua = value; }
        public string CodigoOriginal { get => codigoOriginal; set => codigoOriginal = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Observacao { get => observacao; set => observacao = value; }

        /// <summary>
        /// Método para retornar ficha tecnica do item, precisa passar o codigo como parametro
        /// </summary>
        /// <param name="codigo">Codigo do item usado para pesquisar o mesmo no banco de dados</param>
        /// <returns></returns>
        public static BombaAgua retornaFichaTecnica(string codigo)
        {
            BombaAgua bombaAgua = new BombaAgua();
            string baseDados = "C:\\BDs\\dds\\AplTruckMotorsBD.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            try
            {
                string query = "SELECT * FROM table_bombaagua WHERE codigo LIKE '" + codigo + "' ";

                DataTable dados = new DataTable();

                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (System.Data.DataRow row in dados.Rows)
                {
                    bombaAgua = new BombaAgua(Convert.ToString(row["codigo"]),
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
            return bombaAgua;
        }

    }
}
