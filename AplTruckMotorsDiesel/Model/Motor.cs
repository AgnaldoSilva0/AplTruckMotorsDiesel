using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class Motor
    {
        private int idMotor;
        private string modeloMotor;
        private string modeloVeiculo;
        private string observacao;
        private string aplicacao { get; set; }
        private string codigoOriginal { get; set; }
        private string marca { get; set; }

        public Motor(int idMotor, string modeloMotor, string modeloVeiculo, string observacao)
        {
            this.idMotor = idMotor;
            this.modeloMotor = modeloMotor;
            this.modeloVeiculo = modeloVeiculo;
            this.observacao = observacao;
        }
        public string ModeloMotor { get => modeloMotor; set => modeloMotor = value; }
        public string ModeloVeiculo { get => modeloVeiculo; set => modeloVeiculo = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public int IdMotor { get => idMotor; set => idMotor = value; }
    }
}
