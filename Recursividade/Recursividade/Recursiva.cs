using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Recursiva
    {
        // Não recursivo
        public void Executar(string mensagem, uint n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mensagem);
            }
        }

        // Recursivo
        public void ExecutarRecursivo(string mensagem, uint n)
        {
            if(n != 0)
            {
                Console.WriteLine(mensagem);
                ExecutarRecursivo(mensagem, n - 1);
            }
            
        }
    }
}
