using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task Parte 1
            /*
            Task t1 = new Task(Tarefa);
            t1.Start();

            Task t2 = Task.Run(Tarefa);
            Task.Run(Tarefa);
            */

            /*
            Task.Factory.StartNew(Tarefa);
            
            Task.Run(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Anônimo.");
                    }
                }
            );

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal.");
            }
            */
            #endregion

            #region Task Parte 2
            /*
            Task[] tasks =
            {
                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Tarefa #1");
                }),

                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Tarefa #2");
                }),

                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Tarefa #3");
                })
            };
            Task.WaitAll(tasks);
            */


            /*
            Task t1 = Task.Run(() => Console.WriteLine("Task t1"));
            Task t2 = Task.Run(() => Console.WriteLine("Task t2"));
            Task t3 = Task.Run(() => Console.WriteLine("Task t3"));

            Task.WaitAll(t1, t2, t3);
            Console.WriteLine("Principal.");
            */
            #endregion

            #region Task Parte 3
            /*
            Task<int> tarefa1 = Task.Factory.StartNew(() => Quadrado(8));
            Console.WriteLine(tarefa1.Result);
            */
            
            // Dependência de tarefas. A tarefa3 aguarda a tarefa2, que aguarda a tarefa1 para executar.
            Task<int> tarefa1 = Task.Factory.StartNew(() =>
            {
                Console.Write("Insira um valor inteiro para elevar ao quadrado: ");

                int valor;
                try
                {
                    valor = int.Parse(Console.ReadLine());
                    return valor;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nNão foi possivel continuar. Você inseriu um valor inválido.\nPressione qualquer tecla para fechar...");
                    Console.ReadKey();

                    Environment.Exit(0);

                    return 0;
                }
            });

            Task<int> tarefa2 = tarefa1.ContinueWith((num) =>
            {
                return num.Result * num.Result;
            });

            Task<string> tarefa3 = tarefa2.ContinueWith((num) =>
            {
                return $"Valor final: {num.Result}.";
            });

            Console.WriteLine(tarefa3.Result);
            #endregion

            Console.ReadKey();
        }

        static private int Quadrado(int num)
        {
            return num * num;
        } 

        static private void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task.");
            }
        }
    }
}
