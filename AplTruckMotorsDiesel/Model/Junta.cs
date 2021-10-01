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
    }
}
