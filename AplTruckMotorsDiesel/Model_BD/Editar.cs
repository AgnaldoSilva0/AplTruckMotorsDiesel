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

        public static void StringEditarKitMotor(string tabela, int id, string codigo, string itensKit, string marca, string observacao)
        {
            string comando = "UPDATE table_kitmotor SET codigo = '" + codigo + "', itensKit = '" + itensKit + "', Marca = '" + marca + "', observacao = '" + observacao + "' " +
                            " WHERE id LIKE '" + id + "' ";
            Conexao.ExecutarComandoSql(comando);
        }
    }
}
