using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class BombaAgua
    {
        private string codigoBombaAgua;

        public BombaAgua(string codigoBombaAgua)
        {
            this.codigoBombaAgua = codigoBombaAgua;
        }

        public string CodigoBombaAgua { get => codigoBombaAgua; set => codigoBombaAgua = value; }
    }
}
