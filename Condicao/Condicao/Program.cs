using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 10;

            if (valor == 10)
            {
                Console.WriteLine("Condição verdadeira.");
            }
            else
            {
                Console.WriteLine("Condição falsa.");
            }

            Console.ReadKey();
        }
    }
}
