using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar acesso = new Acessar();

            if (acesso.Login("123123"))
            {
                Console.WriteLine("Senha correta. Acesso liberado.");
            }
            else
            {
                Console.WriteLine("Senha errada. Acesso negado");
            }

            Console.ReadKey();
        }
    }
}
