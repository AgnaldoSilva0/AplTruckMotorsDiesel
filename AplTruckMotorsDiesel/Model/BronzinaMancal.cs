using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class BronzinaMancal
    {
        private string codigoBMancal;

        public BronzinaMancal(string codigoBMancal)
        {
            this.codigoBMancal = codigoBMancal;
        }

        public string CodigoBMancal { get => codigoBMancal; set => codigoBMancal = value; }

        public static string queryBMancal(string itemSelecionado)
        {
            return "SELECT * FROM table_aplicacao " +
                    "INNER JOIN table_bmancal ON table_aplicacao.idBMancal = table_bmancal.codigo " +
                    "INNER JOIN table_motor ON table_aplicacao.idMotor = table_motor.id " +
                    "WHERE table_motor.modeloMotor LIKE '%" + itemSelecionado + "%' ";
        }
    }
}
