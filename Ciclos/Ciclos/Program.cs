using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while
            /*int valor = 1;
            while (valor <= 10)
            {
                Console.WriteLine("Valor = " + valor);
                valor++;
            }

            Console.Write("\nPrograma finalizado! \nPressione qualquer tecla para sair...");
            Console.ReadKey();*/
            #endregion

            #region do-while
            /*int valor = 20;
            do
            {
                Console.WriteLine("Valor: " + valor);
                valor++;
            } while (valor <= 15);

            Console.Write("\nPrograma finalizado!\nPressione qualquer tecla para sair...");
            Console.ReadKey();*/
            #endregion

            #region for
            /*for (int i = 1, x = 10; i <= 10 && x >= 1; i++, x--)
            {
                Console.WriteLine("\nValor de (i): " + i);
                Console.WriteLine("Valor de (x): " + x);
            }

            Console.Write("\nPrograma finalizado!\nPressione qualquer tecla para finalizar...");
            Console.ReadKey();*/
            #endregion

            #region foreach
            string[] nomes =
            {
                "Juan Felipe Alves Flores",
                "Maria Eduarda Batista de Sousa",
                "Hiago de Oliveira Santana",
                "Kevin Matheus Queiroz de Santana"
            };

            foreach (string item in nomes)
            {
                Console.WriteLine("Nome: " + item);
            }

            Console.Write("\nPrograma finalizado!\nPressione qualquer tecla para sair...");
            Console.ReadKey();
            #endregion
        }
    }
}
