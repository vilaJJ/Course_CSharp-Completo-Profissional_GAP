using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta_juan = new Conta();

            conta_juan.Cliente = "Juan";

            // Depósito
            double deposito = 200;
            conta_juan.Depositar(deposito);

            // Saque
            double saque = 120;
            conta_juan.Sacar(saque);

            // Ler dados
            Console.WriteLine(conta_juan.Cliente);
            Console.WriteLine(conta_juan.Saldo);

            Console.ReadKey();
        }
    }
}
