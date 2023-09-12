using ExemploHerança.classes;
using ExemploHerança.classes2;

public class Program
{
    static void Main(string[] args)
    {// poliforfismo (comportamentos diferentes)

        // Pessoa
         Aluno aluno = new Aluno();

        aluno.Cpf = "000";
        aluno.Nome = "João da silva";
        aluno.Datanasci = DateOnly.Parse("2004-09-16");
        aluno.Sexo = "Menine";
        Funcionario f = new Funcionario();
        f.Cpf = "111";
        f.Nome = "Nathan";
        f.Datanasci = DateOnly.Parse("2007-02-12");
        // Mamífero
        Cachorro cachorro = new Cachorro();
        cachorro.Raca = "Hashi shibirianu";
        cachorro.barulho = "Ai zé da manga";
        cachorro.Peso = 30;
        cachorro.Datanasci = DateOnly.Parse("2007-02-12");
        cachorro.Barulho();

        Gato gato = new Gato();
        gato.Raca = "Vira lara";
        gato.cor_dos_olhos = "Azule";
        gato.barulho = "Miauuu";
        gato.Barulho();
    }
}