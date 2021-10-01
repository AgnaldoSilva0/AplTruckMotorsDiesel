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
    }
}
