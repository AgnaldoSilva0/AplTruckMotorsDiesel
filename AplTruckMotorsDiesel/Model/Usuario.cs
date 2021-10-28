using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Model
{
    class Usuario
    {
        private string nome;
        private string senha;
        private string permissao;

        public Usuario(string nome, string senha, string permissao)
        {
            this.nome = nome;
            this.senha = senha;
            this.permissao = permissao;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        
        public string Permissao
        {
            get
            {

                if (permissao == "2")
                {
                    return permissao = "Comprador";
                }  
                
                else if (permissao == "3")
                {
                    return permissao = "Administrador";
                }
                else
                {
                    return permissao = "Visitante";
                }
            }
        }
    }
}
