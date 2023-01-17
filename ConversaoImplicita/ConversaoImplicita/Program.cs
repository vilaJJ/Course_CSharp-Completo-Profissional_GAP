using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoImplicita
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Conversão Implicita
			/*
			byte valor1 = 200;
			ushort valor2;

			float altura = 1.84f;
			double altura_double = altura;

			valor2 = valor1;

			char letra = 'J';
			int codigo_ascii = letra;

			Console.WriteLine(valor2);
			Console.WriteLine(altura_double);
			Console.WriteLine(codigo_ascii);
			Console.ReadKey();
			*/
			#endregion

			#region Conversão Explícita
			/*
			ushort valor1 = 500;
			byte valor2 = (byte)valor1;

			float valor3 = 2500.99f;
			int valor4 = (int)valor3;

			char letra = (char)77;

			Console.WriteLine(valor2);
			Console.WriteLine(valor4);
			Console.WriteLine(letra);
			Console.ReadKey();
			*/
			#endregion

			#region Método Parse
			/*
			string txt_numero = "2004";
			int int_numero = int.Parse(txt_numero);

			float altura = float.Parse("1,84");
			double peso = double.Parse("71,92");

			Console.WriteLine(int_numero);
			Console.WriteLine(altura);
			Console.WriteLine(peso);
			Console.ReadKey();
			*/
			#endregion

			#region Classe Convert
			/*
			string txt = Convert.ToString(2500);
			double booleano = Convert.ToDouble(true);
			int valor1 = Convert.ToInt32('J');

			Console.WriteLine(txt);
			Console.WriteLine(booleano);
			Console.WriteLine(valor1);
			Console.ReadKey();
			*/
			#endregion
		}
	}
}
