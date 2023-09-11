using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerança.classes2
{
    internal class Cachorro:Mamíferos
    {
        public double peso { get; set; }
        public override void Barulho()
        {
            Console.WriteLine("AUAUAU!");
        }
    }
}
