using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetor - Array unidimensional
            /*
            int[] numeros = new int[3];
            numeros[0] = 1981;
            numeros[1] = 2019;
            numeros[2] = 2021;

            string[] titulos = 
                { 
                    "Copa do Brasil 2022", 
                    "Copa Libertadores da América 2022" 
                };

            Console.WriteLine(numeros[0]);
            Console.WriteLine(titulos[1]);
            Console.ReadKey();
            */
            #endregion

            #region Matriz - Array bidimensional
            int[,] numeros = new int[2, 3];

            numeros[0, 0] = 19;
            numeros[0, 1] = 31;
            numeros[0, 2] = 22;

            numeros[1, 0] = 13;
            numeros[1, 1] = 17;
            numeros[1, 2] = 25;

            string[,] nomes =
            {
                { "Juan", "Vitor", "Jefferson" },
                { "Nicole", "Larissa", "Aline" }
            };

            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.Write("[" + numeros[0, 2] + "]");

            Console.WriteLine();

            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.Write("[" + numeros[1, 2] + "]");

            Console.WriteLine();
            Console.WriteLine(nomes[1, 0]);

            Console.ReadKey();
            #endregion
        }
    }
}
