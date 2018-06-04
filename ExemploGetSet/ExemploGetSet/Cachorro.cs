using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Cachorro
    {
        private string Nome;
        private string Raca;
        private double Peso;
        private double Altura;


        // Set serve para acessar outra classe em private, tendo como objetivo definir a informação, guardar determinada informação;
        // Exemplo: Definir senha - Adrian.SetSenha(123);


        public void SetNome(string nome)
        {

            if (nome.Count() < 3)
            {
                throw new Exception("Nome deve conter no mínimo três caracteres");
            }

            if (nome.Count() > 40)
            {
                throw new Exception("Nome deve conter no máximo quarenta caracteres");
            }
            Nome = nome;
        }

        public void SetAltura(double altura)
        {
            if (altura <= 0)
            {
                throw new Exception("Altura não pode ser negativa");
            }


            if (altura > 2)
            {
                throw new Exception("A altura deve ser menor que dois metros");
            }

            Altura = altura;
        }


        public void SetPeso(double peso)
        {
            if (peso <= 0)
            {
                throw new Exception("O peso não pode ser negativo");
            }

            if (peso > 150)
            {
                throw new Exception("O peso não pode ultrapassar cento e cinquenta quilos");
            }

            Peso = peso;
        }

        public void SetRaca(string raca)
        {
            if (raca.Count() < 3)
            {
                throw new Exception("A raça deve conter no mínimo três caracteres");
            }

            if (raca.Count() > 40)
            {
                throw new Exception("A raça não pode ultrapassar de quarenta caracteres");
            }

            Raca = raca;
        }

        // Get você pega a informação, set atribui;
        // Obter informação guardada;
        public string GetNome()
        {
            return Nome;
        }

        public string GetRaca()
        {
            return Raca;
        }

        public double GetAltura()
        {
            return Altura;
        }

        public double GetPeso()
        {
            return Peso;
        }

    }
}
