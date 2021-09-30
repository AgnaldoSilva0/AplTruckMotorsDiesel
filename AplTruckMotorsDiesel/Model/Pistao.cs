using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class Pistao
    {
        private string codigoPistao;

        public string CodigoPistao { get => codigoPistao; set => codigoPistao = value; }

        public Pistao(string codigoPistao)
        {
            this.codigoPistao = codigoPistao;
        }

        public static string queryPistao(string itemSelecionado)
        {
            return "SELECT * FROM table_aplicacao " +
                    "INNER JOIN table_pistao ON table_aplicacao.idPistao = table_pistao.codigo " +
                    "INNER JOIN table_motor ON table_aplicacao.idMotor = table_motor.id " +
                    "WHERE table_motor.modeloMotor LIKE '%" + itemSelecionado + "%' ";
        }

    }
}
