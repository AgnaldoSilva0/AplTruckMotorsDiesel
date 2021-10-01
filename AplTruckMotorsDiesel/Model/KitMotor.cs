using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class KitMotor
    {
        private string codigoKitMotor;

        public KitMotor(string codigoKitMotor)
        {
            this.codigoKitMotor = codigoKitMotor;
        }

        public string CodigoKitMotor { get => codigoKitMotor; set => codigoKitMotor = value; }
    }
}
