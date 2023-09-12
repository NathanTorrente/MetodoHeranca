using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerança.classes2
{
    internal class Mamíferos
    {
        public DateOnly Datanasci { get; set; }
        public string Raca { get; set; }
        public string barulho { get; set;}


        public Mamíferos()
        {

        }
        public Mamíferos(DateOnly datanasci, string raca)
        {
            Datanasci = datanasci;
            Raca = raca;
            
        }

        public virtual void Barulho()
        {
            Console.WriteLine(this.Raca + "Fazendo Barulho!");
        }
    }
}
