using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();

            //t.nome = "Juan";
            t.sobrenome = "Flores";
            //t.Metodo1();
            t.Executar();
        }
    }
}
