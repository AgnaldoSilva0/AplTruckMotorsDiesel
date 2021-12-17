using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AplTruckMotorsDiesel
{
    class Cr5DM
    {
        //Classe pública para usar fora da classe Principal
        public string RetornarMD5(string senhaDigitada)
        {
            //Usa o using para que não fique aberto ocupando memoria, assim quando acabar de ser executado ele fecha
            using (MD5 md5Hash = MD5.Create())
            {
                return RetornarHash(md5Hash, senhaDigitada);
            }
        }

        //Classe pública para comparar a senha digitada com a senha do banco de dados, pode ser usada fora da classe
        public bool CompararMD5(string senhaEntrada, string senhaMD5)
        {
            string senha = RetornarMD5(senhaEntrada);
            if (VerificarHash(senhaMD5, senha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Classe privada para ser usada apenas dentro da classe pelo metodo RetornarMD5
        private string RetornarHash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }

            return sBuilder.ToString();
        }

        //Classe privada para ser usada pelo metodo CompararMD5
        private bool VerificarHash(string senhaDigitada, string hash)
        {
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;
            if (comparar.Compare(senhaDigitada, hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
