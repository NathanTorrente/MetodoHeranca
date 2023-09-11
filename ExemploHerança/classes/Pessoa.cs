using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerança.classes // nome space é um agrupamento lógico, serve para organizar o código em grupos, para ficar melhor de compreender, com uso de
    // pastas, onde tem o nome da pasta e o nome de outra classe com nome das pastinha.
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateOnly Datanasci { get; set; }
        public string Sexo { get; set; }
    }
    
}
