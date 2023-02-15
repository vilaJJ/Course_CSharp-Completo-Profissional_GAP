using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0 1 1 2 3 5 8 13 21 34 55 89 ...
            int anterior1 = 0, anterior2 = 1, resultado = 0;

            Inicio:
            Console.Clear();
            Console.Write("Quantos valores da Sequência de Fibonacci deseja gerar? ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSequência de Fibonnaci com " + quantidade + " valores:");

            for (int i = 0; i < quantidade; i++)
            {
                if(i < (quantidade - 1))
                {
                    Console.Write(anterior1 + ", ");
                }
                else
                {
                    Console.Write(anterior1 + ".");
                }
                

                resultado = anterior1 + anterior2;
                anterior1 = anterior2;
                anterior2 = resultado;
            }

            TentarSaidaNovamente:
            Console.Write("\n\nDeseja gerar outra sequência com outros valores? (s para sim, n para não): ");
            char opcaoSaida = char.ToLower(char.Parse(Console.ReadLine()));

            switch (opcaoSaida)
            {
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    goto TentarSaidaNovamente;
                case 's':
                    goto Inicio;
                case 'n':
                    break;
            }

            Console.Write("\nPrograma finalizado!\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
