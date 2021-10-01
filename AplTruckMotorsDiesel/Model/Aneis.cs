using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class Aneis
    {
        private string codigoAneis;

        public Aneis(string codigoAneis)
        {
            this.codigoAneis = codigoAneis;
        }

        public string CodigoAneis { get => codigoAneis; set => codigoAneis = value; }
    }
}
