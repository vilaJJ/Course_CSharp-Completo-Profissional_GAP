using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch-case
            /*int escolha = 0;

            switch (escolha)
            {
                default:
                    Console.WriteLine("Opção padrão");
                    break;
                case 1:
                    Console.WriteLine("Caso 1");
                    break;
                case 2:
                    Console.WriteLine("Caso 2");
                    break;
                case 3:
                    Console.WriteLine("Caso 3");
                    break;
            }

            Console.ReadKey();*/
            #endregion

            #region goto
            Inicio:
            Console.Write("Insira uma opção: ");

            int opcao = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (opcao)
            {
                default:
                    Console.WriteLine("Opção inválida. Tente Novamente.\n");
                    goto Inicio;
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
            }

            Console.WriteLine("Valor final: " + valor);

            Console.Write("\nPressione uma tecla para sair...");
            Console.ReadKey();
            #endregion
        }
    }
}
