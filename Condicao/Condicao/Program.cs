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
            #region Condição encadeada
            /*uint valor = 25;
            if (valor < 10)
            {
                Console.WriteLine("Condição alternativa 1.");
            }
            else if (valor >= 10 && valor < 20)
            {
                Console.WriteLine("Condição alternativa 2.");
            }
            else if (valor >= 20 && valor < 30)
            {
                Console.WriteLine("Condição alternativa 3.");
            }
            else
            {
                Console.WriteLine("Condição alternativa 4");
            }

            Console.ReadKey();*/
            #endregion

            #region Condições aninhadas
            /*int num = 10;

            if (num > 5)
            {
                Console.Write("O número é maior que 5");

                if ((num % 2) == 0)
                {
                    Console.WriteLine(" e também é par.");
                }
                else
                {
                    Console.WriteLine(" e também é impar.");
                }
            }
            else if (num == 5)
            {
                Console.Write("O número é igual a 5.");
            }
            else
            {
                Console.Write("O número é menor que 5");
            }

            Console.ReadKey();*/
            #endregion

            #region Operador ternário
            /*int valor = 50;
            string msg = "";

            *//*if (valor > 50)
            {
                msg = "Maior que 50.";
            }
            else
            {
                msg = "Menor que 50.";
            }*//*

            // Sintaxe: condição ? true : false;

            msg = valor > 50 ? "Maior que 50." : "Menor que 50.";

            Console.WriteLine(msg);
            Console.ReadKey();*/
            #endregion
        }
    }
}