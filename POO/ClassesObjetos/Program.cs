using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            /*MinhaClasse minhaClasse1 = new MinhaClasse();
            MinhaClasse minhaClasse2 = null;
            OutraClasse outraClasse1 = new OutraClasse();
            OutraClasse outraClasse2 = null;*/
            #endregion

            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Maria Eduarda";
            pessoa1.sobrenome = "Batista de Sousa";
            pessoa1.anoNascimento = 2004;

            Pessoa pessoa2 = new Pessoa()
            {
                nome = "Nicole Gabrielle",
                sobrenome = "Almeida Botelho",
                anoNascimento = 2004
            };

            pessoa2.nome = "Nickk Gaby";

            Console.WriteLine("Pessoa 1: " + pessoa1.nome);
            Console.WriteLine("Pessoa 1: " + pessoa1.sobrenome);
            Console.WriteLine("Pessoa 1: " + pessoa1.anoNascimento);
            pessoa1.Cumprimentar();

            Console.WriteLine("\nPessoa 2: " + pessoa2.nome);
            Console.WriteLine("Pessoa 2: " + pessoa2.sobrenome);
            Console.WriteLine("Pessoa 2: " + pessoa2.anoNascimento);
            pessoa2.Cumprimentar();

            Console.ReadKey();
        }
    }

    class MinhaClasse
    {

    }
}
