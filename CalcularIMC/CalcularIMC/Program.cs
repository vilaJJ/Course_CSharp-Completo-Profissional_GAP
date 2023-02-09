using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // peso / altura²

            Console.Write("Informe o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valor_imc = (peso / (altura * altura));

            Console.Write("Seu IMC é: " + valor_imc + ". ");
            if (valor_imc < 20)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if ((valor_imc >= 20) && (valor_imc <= 24))
            {
                Console.WriteLine("Seu peso esta normal.");
            }
            else if ((valor_imc > 24) && (valor_imc <= 29))
            {
                Console.WriteLine("Você está acima do peso.");
            }
            else if ((valor_imc > 29) && (valor_imc <= 34))
            {
                Console.WriteLine("Você está obeso.");
            }
            else
            {
                Console.Write("Você está muito obeso.");
            }

            Console.ReadKey();
        }
    }
}
