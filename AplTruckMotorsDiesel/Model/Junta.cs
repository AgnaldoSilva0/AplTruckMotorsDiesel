using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class Junta
    {
        private string codigoJunta;

        public Junta(string codigoJunta)
        {
            this.codigoJunta = codigoJunta;
        }

        public string CodigoJunta { get => codigoJunta; set => codigoJunta = value; }

        public static string queryJunta(string itemSelecionado)
        {
            return "SELECT * FROM table_aplicacao " +
                    "INNER JOIN table_junta ON table_aplicacao.idJunta = table_junta.codigo " +
                    "INNER JOIN table_motor ON table_aplicacao.idMotor = table_motor.id " +
                    "WHERE table_motor.modeloMotor LIKE '%" + itemSelecionado + "%' ";
        }
    }
}
