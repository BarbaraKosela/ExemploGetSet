using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCabeloECasaco
{
    class Cabelo
    {
            public int TamanhoFio;
            public double GrossuraFio;
            public string CorFio;


        public void SetTamanhoFio(int tamanhoFio/*tamanhoFio*/)
        {
            if (tamanhoFio < 1)
            
            {
                throw new Exception("Tamanho do fio deve ser de pelo menos 1");
            }

            if (tamanhoFio > 90)
            
            {
                throw new Exception("Tamanho do fio deve ser ao máximo de 90");
            }
            TamanhoFio = tamanhoFio;
        }

        public void SetGrossuraFio(double grossuraFio/*grossuraFio*/)
        {
            if (grossuraFio <= 0)
            {
               throw new Exception("Grossura do fio deve ser ao mínimo de 0.1");

            }

            if (grossuraFio > 1)
            {
                throw new Exception("Grossura do fio deve ser ao máximo de 1");
            }

            GrossuraFio = grossuraFio;
        }

        public void SetCorFio(string corFio/*corFio*/)
        {
            if (corFio.Count() < 7)
            {
                throw new Exception("Cor do fio deve ser ao mínimo de 7 caracteres");
            }


            if (corFio.Count() > 20)
            {
                throw new Exception("Cor do fio deve ser ao máximo de 20 caracteres");
            }

            CorFio = corFio;
        }

        //Return to... Não feito no papel.

        public /*void*/ int GetTamanhoFio()
        {
            return TamanhoFio;
        }

        public /*void*/ double GetGrossuraFio()
        {
            return GrossuraFio;
        }

        public /*void*/ string GetCorFio()
        {
            return CorFio;
        }

       

    }
}
