using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();

            #region Métodos Simples
            // metodos.HelloWorld();
            #endregion

            #region Métodos com parâmetros
            /*metodos.Somar(18, 7);
            metodos.Apresentar("Rebeca Alves Almeida Lopes", 17);*/
            #endregion

            #region Passagem de parâmetros por valor e por referência
            /*metodos.AumentarValor(17);

            int valor_ref = 15;
            int valor_valor = 15;

            metodos.AumentarValor(valor_valor);
            metodos.AumentarReferencia(ref valor_ref);

            Console.WriteLine("\nvalor_ref: " + valor_ref);
            Console.WriteLine("valor_valor: " + valor_valor);*/
            #endregion

            #region Métodos com retorno de valores
            /*Console.WriteLine("\n" + metodos.MontarNome("Juan Felipe", "Alves Flores"));
            Console.WriteLine("\n" + metodos.CodigoChar('J'));
            Console.WriteLine("\n" + metodos.ValorPI());*/
            #endregion

            metodos.HelloWorld();
            metodos.HelloWorld("Juan Felipe");
            metodos.HelloWorld("Beca", 2023);

            bool res1 = metodos.Comparar(50 * 2, 150 - 50);
            bool res2 = metodos.Comparar(3.14, 7.18);

            Console.Write(res1 + "\n" + res2);

            Console.Write("\nPrograma finalizado.\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}