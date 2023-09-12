using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerança.classes2
{
    internal class Cachorro:Mamíferos
    {
        public double Peso { get; set; }

        public Cachorro()
        {
            //sobrescrita de metodo
        }
        public Cachorro(double peso, string raca, DateOnly datanasci)
            :base(datanasci,raca)
        {

            Raca = raca;
                Peso = peso;
        }


        public override void Barulho()
        {
            Console.WriteLine("AUAUAU!");
        }
    }
}
