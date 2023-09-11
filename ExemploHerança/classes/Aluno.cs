using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHerança.classes
{
    // interno permite usar a classe através do nomespace // private so da acesso dentro da classe // public qualque um
    internal class Aluno: Pessoa    // Classe Aluno é filho de Pessoa.                        
    {
        public double responsavel { get; set; }
        public string turma { get; set; }
        public int matricula { get; set; }
        public DateOnly Datanasci { get; set; }
    }
}
