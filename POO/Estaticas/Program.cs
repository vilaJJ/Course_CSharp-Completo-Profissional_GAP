using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classe Estática
            /*Matematica.taxa = 10;

            int valor1 = Matematica.Adicionar(50);
            int valor2 = Matematica.Diminuir(25);

            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);

            Console.WriteLine("\nPrograma finalizado!\nPressione qualquer tecla para sair...");
            Console.ReadKey();*/
            #endregion

            Pessoa.maioridade = 21;

            Pessoa pessoa1 = new Pessoa();

            pessoa1.nome = "Karla Andrea Pinheiro";
            pessoa1.idade = Pessoa.CalcularIdade(2004);

            pessoa1.Apresentar();

            Console.ReadKey();
        }
    }
}
