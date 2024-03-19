using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace SocketCliente
{
    internal class Program
    {
        static void Main()
        {
            // Definindo propriedades do programa.
            Console.Title = "Cliente Socket";

            // Definindo as propriedades do cliente Socket.
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Informações para acessar o servidor Socket.
            var endPointAddress = IPAddress.Parse("127.0.0.1");
            var porta = 7895;            

            // Tratamento para caso o servidor esteja indisponível.
            try
            {
                // Criando end-points para o servidor.
                var endPoint = new IPEndPoint(endPointAddress, porta);

                // Conectando com o servidor, atráves do end-point.
                socket.Connect(endPoint);
                Console.WriteLine("Conectado no servidor.");

                // Lendo mensagem do cliente a ser enviada.
                Console.Write("\nInsira uma mensagem a ser enviada: ");
                var mensagem = Console.ReadLine();

                // Convertendo mensagem do cliente para envio.
                var bytes = Encoding.Default.GetBytes(mensagem);

                // Tratamento para caso não consiga enviar a mensagem.
                try
                {
                    // Enviando mensagem para o servidor Socket.
                    socket.Send(bytes, 0, bytes.Length, SocketFlags.None);
                }
                catch (Exception)
                {
                    Console.WriteLine("Não foi possível enviar a mensagem para o servidor Socket...");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível conectar ao servidor...");
            }
            finally
            {
                // Encerrando o cliente Socket.
                socket.Close();

                Console.WriteLine();
                Console.WriteLine("Cliente Socket finalizado.");
                Console.WriteLine("Pressione qualquer tecla para finalizar...");

                Console.ReadKey();
            }
        }
    }
}
