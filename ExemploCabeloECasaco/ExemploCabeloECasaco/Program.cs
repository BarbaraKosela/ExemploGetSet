using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCabeloECasaco
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pedaços arrumados de código; 
            Cabelo cabelo = new Cabelo();
            /*public string TamanhoFio;
            public double GrossuraFio;
            public string CorFio;*/


            //parte não feita:

            cabelo.SetTamanhoFio(10); //No caso, a parte do Set foi trocada por Get e o ''cabelo'' não foi colocado.
            cabelo.SetGrossuraFio(0.12);
            cabelo.SetCorFio("Vermelinho");


            Console.WriteLine(cabelo.GetTamanhoFio());
            Console.WriteLine(cabelo.GetGrossuraFio());
            Console.WriteLine(cabelo.GetCorFio());
            
        }
    }
}
