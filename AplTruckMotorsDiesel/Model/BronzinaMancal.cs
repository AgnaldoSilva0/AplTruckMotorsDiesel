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
    }
}
