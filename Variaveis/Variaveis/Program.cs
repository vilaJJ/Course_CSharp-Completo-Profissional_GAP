using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
	internal class Program
	{
		enum Notas
		{
			Minimo = 0, 
			Média = 5, 
			Máxima = 10
		}

		struct Aluno
		{
			public string nome;
			public int idade;
			public string curso;
		}
		static void Main(string[] args)
		{
			#region Variáveis Númericas Integrais
			/*
			sbyte var_sbyte1 = 10;
			sbyte var_sbyte2;
			var_sbyte1 = 10 + 5;
			var_sbyte2 = var_sbyte1;
			

			Console.WriteLine(var_sbyte1);
			Console.WriteLine(var_sbyte2);
			Console.ReadKey();
			*/
			#endregion

			#region Varíáveis Númericas Reais
			/*
			float var_float = 15.2f;
			double var_double = 178.2;
			decimal var_decimal = -21.2m;

			Console.WriteLine(var_float);
			Console.WriteLine(var_double);
			Console.WriteLine(var_decimal);
			Console.ReadKey();
			*/
			#endregion

			#region Variável Caractere
			/*
			char var_char = 'J';
			char var_char1 = '\u0071';
			char escape = '\\';

			Console.WriteLine(var_char);
			Console.WriteLine(var_char1);
			Console.WriteLine(escape);
			Console.ReadKey();
			*/
			#endregion

			#region Variável bool
			/*
			bool var_verdadeiro = true;
			bool var_falso = false;

			Console.WriteLine(var_verdadeiro);
			Console.WriteLine(var_falso);
			Console.ReadKey();
			*/
			#endregion

			#region Variável string
			/*
			// o @ ignora os caracteres de escape
			string nome = @"Juan Felipe Alves Flores\n18 anos";
			string valor_null = null;
			valor_null = nome;

			Console.WriteLine(valor_null);
			Console.WriteLine(nome);
			Console.ReadKey();
			*/
			#endregion

			#region Variável Implicito (var)
			/*
			var var1 = 152.8;
			var var2 = "Olá mundo";

			Console.WriteLine(var1);
			Console.WriteLine(var2);
			Console.ReadKey();
			*/
			#endregion

			#region Variável Object
			/*
			object objeto1 = "Juan";
			objeto1 = 2004;

			Console.WriteLine(objeto1);
			Console.ReadKey();
			*/
			#endregion

			#region Variáveis Constantes
			/*
			const double pi = 3.141569;
			const int ano_nascimento = 2004;

			Console.WriteLine(pi);
			Console.WriteLine(ano_nascimento);
			Console.ReadKey();
			*/
			#endregion

			#region Variáveis Enumeradas
			/*
			Notas notas_alunos = Notas.Minimo;

			Console.WriteLine(notas_alunos);
			Console.ReadKey();
			*/
			#endregion

			#region Estruturas
			/*
			Aluno id_1 = new Aluno();

			id_1.nome = "Juan Felipe Alves Flores";
			id_1.idade = 18;
			id_1.curso = "Técnico em Análise e Desenvolvimento de Sistemas";

			Aluno id_2 = new Aluno()
			{
				nome = "Nicole Gabrielle Almeida Boteho",
				idade = 18,
				curso = "Técnico em Biotecnologia"
			};

			Console.WriteLine(id_1.nome);
			Console.WriteLine(id_1.idade);
			Console.WriteLine(id_1.curso);

			Console.WriteLine();

			Console.WriteLine(id_2.nome);
			Console.WriteLine(id_2.idade);
			Console.WriteLine(id_2.curso);
			Console.ReadKey();
			*/
			#endregion
		}
	}
}
