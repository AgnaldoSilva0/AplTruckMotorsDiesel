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
    }
}
