using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro dogao = new Cachorro();
            dogao.SetNome("");
            dogao.SetAltura(1.10);
            dogao.SetPeso(80);
            dogao.SetRaca("");
        }
    }
}
