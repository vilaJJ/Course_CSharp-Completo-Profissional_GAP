using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string nome1, nome2, nome3, nome4, auxiliar;

			Console.Write("Digite o nome 1: ");
			nome1 = Console.ReadLine();

			Console.Write("Digite o nome 2: ");
			nome2 = Console.ReadLine();

			Console.Write("Digite o nome 3: ");
			nome3 = Console.ReadLine();

			Console.Write("Digite o nome 4: ");
			nome4 = Console.ReadLine();

			// Mecanismo para inverter nomes
			auxiliar = nome1;
			nome1 = nome4;
			nome4 = auxiliar;
			auxiliar = nome2;
			nome2 = nome3;
			nome3 = auxiliar;

			Console.WriteLine();
			Console.WriteLine("Nomes inseridos na ordem invetida: ");
			Console.WriteLine(nome1);
			Console.WriteLine(nome2);
			Console.WriteLine(nome3);
			Console.WriteLine(nome4);

			Console.ReadKey();
		}
	}
}
