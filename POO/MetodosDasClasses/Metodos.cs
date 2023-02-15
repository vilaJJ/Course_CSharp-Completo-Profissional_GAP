using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        // Métodos Simples
        public void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }

        // Métodos com parâmetros
        public void Somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            Console.WriteLine("\nA soma entre " + valor1 + " e " + valor2 + " é igual a " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("\nOlá, meu nome é " + nome + ", tenho " + idade + " anos.");
        }

        // Passagem de parâmetros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("\nValor final (por valor): " + valor);
        }

        // Passagem de parâmetros por referência
        public void AumentarReferencia(ref int valor)
        {
            valor += 10;
            Console.WriteLine("\nValor final (por referência): " + valor);
        }

        // Métodos com retorno de valores
        public string MontarNome(string nome, string sobrenome)
        {
            // string nome_completo = nome + " " + sobrenome;
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            return (int)caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }

        // Sobrecarga de métodos
        public void HelloWorld(string nome)
        {
            Console.WriteLine("Hello, World, " + nome + "!");
        }
        public void HelloWorld(string nome, int ano)
        {
            Console.WriteLine("Hello World, " + nome + "!" + " Você está no ano " + ano + ".");
        }

        public bool Comparar(int v1, int v2)
        {
            return v1 == v2;
        }
        public bool Comparar(double v1, double v2)
        {
            return v1 == v2;
        }
    }
}
