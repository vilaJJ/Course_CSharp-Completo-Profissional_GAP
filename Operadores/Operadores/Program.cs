using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Operações matemáticos
			/*
			int valor1, valor2, resultado2;

			valor1 = 15;
			valor2= 20;

			int resultado = 18 + 12;
			resultado2 = valor1 + valor2;

			int subtracao = 15 - 7;
			double multiplicacao = 15 * 2;
			float divisao = 12 / 2;
			decimal resto_divisao = 15 % 4;

			Console.WriteLine(resultado);
			Console.WriteLine(resultado2);

			Console.WriteLine(subtracao);
			Console.WriteLine(multiplicacao);
			Console.WriteLine(divisao);
			Console.WriteLine(resto_divisao);
			Console.ReadKey();
			*/
			#endregion

			#region Precedência de Operadores aritméticos
			/*
			double valor1 = 150;
			double valor2 = 10;
			double valor3 = 5;
			double resultado = (valor1 + valor2) * valor3 / 7;

			Console.WriteLine(resultado);
			Console.ReadKey();
			*/
			#endregion

			#region Operadores de incremento e decremento
			/*
			int valor1 = 10;
			int valor2 = 10;
			int valor3 = 10;
			int valor4 = 10;
			// valor1 = 10 + 1;
			valor1++;

			// valor2 = 10 - 1;
			valor2--;

			Console.WriteLine(valor1);
			Console.WriteLine(valor2);
			Console.WriteLine(++valor3);
			Console.WriteLine(valor4++);
			Console.ReadKey();
			*/
			#endregion

			#region Operadores de concatenação
			/*
			string nome = "Juan";
			string espaco = " ";
			string sobrenome = "Felipe";

			string nomeComposto = nome + espaco + sobrenome + espaco + 2004;

			Console.WriteLine(nomeComposto);
			Console.ReadKey();
			*/
			#endregion

			#region Operadores de atribuição
			/*
			int valor1 = 10;
			int valor2 = 8;
			int valor3 = 16;
			int valor4 = 20;
			int valor5 = 15;

			valor1 += 9;
			valor2 -= 3;
			valor3 *= 2;
			valor4 /= 4;
			valor5 %= 2;

			string nome = "Juan Felipe ";
			string sobrenome = "Alves Flores";

			nome += sobrenome;

			Console.WriteLine(valor1);
			Console.WriteLine(valor2);
			Console.WriteLine(valor3);
			Console.WriteLine(valor4);
			Console.WriteLine(valor5);

			Console.WriteLine(nome);
			Console.ReadKey();
			*/
			#endregion

			#region Operadores de igualdade
			/*
			bool resultado1, resultado2, resultado3;

			resultado1 = (100 == 50 * 2);
			resultado2 = (100 != (50 * 2));

			string nome1 = "Juan";
			string nome2 = "Nicole";

			resultado3 = (nome1) != (nome2);

			Console.WriteLine(resultado1);
			Console.WriteLine(resultado2);
			Console.WriteLine(resultado3);
			Console.ReadKey();
			*/
			#endregion

			#region Operadores relacionais
			/*
			bool resultado1 = (10 * 3) < (2 * 15);
            bool resultado2 = (10 * 3) >= (2 * 15);


            Console.WriteLine(resultado1);
			Console.WriteLine(resultado2);
			Console.ReadKey();
			*/
			#endregion

			#region Operadores lógicos
			/*
			bool resultado1 = 100 > 50;
			bool resultado2 = 50 == 50;
			bool resultado3 = "Juan" == "Nicole";

			bool final1 = resultado1 && resultado2;
			bool final2 = resultado1 && resultado3;
			bool final3 = resultado1 || resultado3;

			Console.WriteLine(final1);
			Console.WriteLine(final2);
			Console.WriteLine(final3);
			Console.ReadKey();
			*/
			#endregion
		}
    }
}