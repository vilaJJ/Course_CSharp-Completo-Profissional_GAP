using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Média Geral dos Alunos";

            Console.Write("Quantos alunos? ");
            int qntd_alunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[qntd_alunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();

                Console.Write("Aluno #" + (i + 1) + " | Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Aluno #" + (i + 1) + " | Quantidade de provas: ");
                int qntd_provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, qntd_provas);

                Console.WriteLine("Insira as notas do aluno #" + (i + 1) + " | Nome: " + nome);
                alunos[i].InserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Média: " + aluno.Media);
                Console.WriteLine();

                mediaGeral += aluno.Media;
            }

            double resultadoFinal = mediaGeral / qntd_alunos;
            Console.WriteLine("Média geral dos alunos: " + resultadoFinal);

            Console.ReadKey();
        }
    }
}
