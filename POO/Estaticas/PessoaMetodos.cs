using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal partial class Pessoa 
    {
        public void Apresentar()
        {
            Console.WriteLine("Olá, meu nome é " + nome + ", tenho " + idade + " anos.");
        }
        public static int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
