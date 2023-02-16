using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste teste = new Teste();

            teste.Nome = "Juan";
            teste.Idade = 18;

            Console.WriteLine(teste.Nome + " " + teste.Sobrenome);
            Console.WriteLine(teste.Idade);

            Console.ReadKey();
        }
    }
}
