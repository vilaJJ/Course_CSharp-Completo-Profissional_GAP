using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void Operacao(int num1, int num2);
        static void Main(string[] args)
        {
            Matematica math = new Matematica();
            Operacao operacao = null;

            // É possivel adicionar mais de um mesmo método no mesmo delegate
            operacao += math.Somar;
            operacao += math.Subtrair;
            operacao += math.Multiplicar;
            operacao += math.Multiplicar;
            operacao += math.Dividir;

            //É possivel subtrair os métodos do delegate

            operacao -= math.Multiplicar;

            operacao(10, 5);

            Console.ReadKey();
        }
    }
}
