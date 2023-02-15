using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            pessoa1.nome = "Yasmin";

            Console.WriteLine(pessoa1.nome);
            Console.WriteLine(pessoa1.sobrenome);
            Console.WriteLine(pessoa1.anoNascimento);
            Console.WriteLine(pessoa1.idade);

            Console.WriteLine();

            Pessoa pessoa2 = new Pessoa("Yasmin", "Garcia");

            Console.WriteLine(pessoa2.nome);
            Console.WriteLine(pessoa2.sobrenome);
            Console.WriteLine(pessoa2.anoNascimento);
            Console.WriteLine(pessoa2.idade);

            Console.WriteLine();

            Pessoa pessoa3 = new Pessoa("Iandra", "Flores", 2006);

            Console.WriteLine(pessoa3.nome);
            Console.WriteLine(pessoa3.sobrenome);
            Console.WriteLine(pessoa3.anoNascimento);
            Console.WriteLine(pessoa3.idade);

            Console.ReadKey();
        }
    }
}
