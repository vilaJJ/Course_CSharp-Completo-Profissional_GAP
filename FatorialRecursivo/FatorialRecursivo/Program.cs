using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um valor para calcular seu fatorial: ");
            ulong n = ulong.Parse(Console.ReadLine());  
            Console.WriteLine("\n" + n + "! = " + Fatorial(n));

            Console.ReadKey();

        }

        static ulong Fatorial(ulong n)
        {
            if(n <= 0) 
            {
                return 1;
            }
            return n * Fatorial(n - 1);
        } 
    }
}
