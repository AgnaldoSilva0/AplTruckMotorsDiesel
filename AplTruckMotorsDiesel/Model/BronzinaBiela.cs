using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class BronzinaBiela
    {
        private string BBiela;

        public BronzinaBiela(string bBiela)
        {
            BBiela = bBiela;
        }

        public string BBiela1 { get => BBiela; set => BBiela = value; }

        public static string queryBiela(string itemSelecionado)
        {
            return "SELECT * FROM table_aplicacao " +
                    "INNER JOIN table_bbiela ON table_aplicacao.idBBiela = table_bbiela.codigo " +
                    "INNER JOIN table_motor ON table_aplicacao.idMotor = table_motor.id " +
                    "WHERE table_motor.modeloMotor LIKE '%" + itemSelecionado + "%' ";
        }
    }
}
