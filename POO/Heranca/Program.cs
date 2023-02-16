using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            /*Carro skyline = new Carro();
            Bicicleta caloi = new Bicicleta();

            skyline.Cor = "Azul";
            caloi.Cor = "Preta";

            skyline.Acelerar();
            caloi.Acelerar();*/
            #endregion

            Humano a = new Humano();
            Pessoa b = new Pessoa();
            Homem c = new Homem();

            Console.WriteLine("Humano:");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("\nPessoa: ");
            b.Olhos();
            b.Cabelos();

            Console.WriteLine("\nHomem: ");
            c.Olhos();
            c.Cabelos();

            Console.ReadKey();
        }
    }
}