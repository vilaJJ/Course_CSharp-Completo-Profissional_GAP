using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();
            Console.Write("\nDigite o primeiro número: ");
            double num1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Double.Parse(Console.ReadLine());

            Operacao:
            Console.WriteLine("\nEscolha a operação desejada" +
                "\n\t1 para soma" +
                "\n\t2 para subtração" +
                "\n\t3 para multiplicação" +
                "\n\t4 para divisão");

            Console.Write("Insira o código da operação: ");
            int operacao = int.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    goto Operacao;
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("\nO resultado da soma é " + resultado);
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("\nO resultado da subtração é " + resultado);
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("\nO resultado da multiplicação é " + resultado);
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("\nNão é possivel dividir por zero\n");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("\nO resultado da divisão é " + resultado);
                    }
                    break;
            }

            TentarNovamenteSaida:
            Console.Write("Deseja finalizar o programa, ou realizar outra operação? (s para sim, n para não):");
            char finalizar = char.ToLower(char.Parse(Console.ReadLine()));
            switch (finalizar)
            {               
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    goto TentarNovamenteSaida;
                case 's':
                    goto Inicio;
                case 'n':
                    Console.WriteLine("\nPrograma finalizado!");
                    break;
            }

            Console.Write("Pressione qualquer tecla para fechar o programa...");
            Console.ReadKey();
        }
    }
}
