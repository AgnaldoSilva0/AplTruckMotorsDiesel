using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class BombaOleo
    {
        private string codigoBombaOleo;

        public BombaOleo(string codigoBombaOleo)
        {
            this.codigoBombaOleo = codigoBombaOleo;
        }

        public string CodigoBombaOleo { get => codigoBombaOleo; set => codigoBombaOleo = value; }
    }
}
