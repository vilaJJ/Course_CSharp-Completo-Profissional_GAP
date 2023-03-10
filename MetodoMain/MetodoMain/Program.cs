using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nome = args[0];
            string senha = "05232004";

            if(senha == args[1])
            {
                Console.WriteLine("Olá, " + args[0]);
            }
            else
            {
                Console.WriteLine("Acesso Negado!");
            }            
        }
    }
}
