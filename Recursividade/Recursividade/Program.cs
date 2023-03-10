using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursiva r = new Recursiva();
            r.Executar("É 1 real, a palma da banana!", 3);

            r.ExecutarRecursivo("ANA!", 5);

            Console.ReadKey();
        }
    }
}
