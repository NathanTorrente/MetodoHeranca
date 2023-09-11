using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerança.classes
{
    internal class Funcionario: Pessoa              // No caso o Pai é Pessoa que tem atributos em func, e em aluno
    {                                               // Quem recebe é a clas funcionario
        public double salario { get; set; }
        public string siap { get; set; }
        public int cargahoraria { get; set; }


    }
}
