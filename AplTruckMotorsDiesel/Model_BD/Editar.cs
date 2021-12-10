using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model_BD
{
    class Editar
    {
        public static void StringEditarUsuario(string nome, string senha, int permissao, int id)
        {
            string comando = "UPDATE table_login SET usuario = '" + nome + "', senha = '" + senha + "', permissao = '" + permissao + "' " +
                " WHERE id LIKE '"+id+"' ";
            Conexao.ExecutarComandoSql(comando);
        }

        public static void StringEditarItem(string tabela, int id, string codigo, string codigoOriginal, string marca, string observacao)
        {
            string comando = "UPDATE '"+ tabela +"' SET codigo = '" + codigo + "', codigoOriginal = '" + codigoOriginal + "', marca = '" + marca + "', observacao = '" + observacao + "' " +
                            " WHERE id LIKE '" + id + "' ";
            Conexao.ExecutarComandoSql(comando);
        }

        public static void StringEditarKitMotor(int id, string codigo, string itensKit, string marca, string observacao)
        {
            string comando = "UPDATE table_kitmotor SET codigo = '" + codigo + "', itensKit = '" + itensKit + "', Marca = '" + marca + "', observacao = '" + observacao + "' " +
                            " WHERE id LIKE '" + id + "' ";
            Conexao.ExecutarComandoSql(comando);
        }

        public static void StringEditarMotor(int idMotor, string modeloVeiculo, string modeloMotor, string observacao)
        {
            string comando = "UPDATE table_motor SET modeloVeiculo = '" + modeloVeiculo + "', modeloMotor = '" + modeloMotor + "', observacao = '" + observacao + "' " +
                            " WHERE id LIKE '" + idMotor + "' ";
            Conexao.ExecutarComandoSql(comando);
        }

        public static void StringEditarOutra(int id, string descricao, string codigo, string marca, string observacao)
        {
            string comando = "UPDATE table_outra SET descricao = '" + descricao + "', codigo = '" + codigo + "', marca = '" + marca + "', observacao = '"+ observacao +"' " +
                            " WHERE id LIKE '" + id + "' ";
            Conexao.ExecutarComandoSql(comando);
        }
    }
}
