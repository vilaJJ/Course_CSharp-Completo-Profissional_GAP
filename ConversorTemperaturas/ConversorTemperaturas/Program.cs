using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheint, kelvin;

            Console.WriteLine("### Conversor de Temperatura ###");

            Console.Write("Insira a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------------------------------------");

            // Fórmula de conversão de °C para °F: ((celsius * 9) / 5 ) + 32 = °F
            fahrenheint = ((celsius * 9) / 5) + 32;

            // Fórmula de conversão de °C para K: celsius + 273,15
            kelvin = celsius + 273.15;

            Console.WriteLine(celsius + "° C = " + fahrenheint + "° F");
            Console.WriteLine(celsius + "° C = " + kelvin + " K");

            Console.WriteLine("------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
