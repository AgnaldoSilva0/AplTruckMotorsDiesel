using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class BronzinaBiela
    {
        private string codigoBBiela;

        public BronzinaBiela(string codigoBBiela)
        {
            this.codigoBBiela = codigoBBiela;
        }

        public string CodigoBBiela { get => codigoBBiela; set => codigoBBiela = value; }
    }
}
