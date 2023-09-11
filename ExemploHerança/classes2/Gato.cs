using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerança.classes2
{
    internal class Gato: Mamíferos
    {
        public string cor_dos_olhos { get; set; }
        public override void Barulho()
        {
            Console.WriteLine("miayy!");
        }
    }
}
