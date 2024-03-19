using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketServer
{
    internal class Program
    {
        static void Main()
        {
            // Definindo propriedades do programa.
            Console.Title = "Servidor Socket";

            // Definindo as propriedades do servidor Socket.
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Informações para acessar o servidor Socket.
            var endPointAddress = IPAddress.Parse("127.0.0.1");
            var porta = 7895;

            // Criando end-points para o servidor.
            var endPoint = new IPEndPoint(endPointAddress, porta);

            // Adicionando end-points no servidor Socket.
            socket.Bind(endPoint);

            // Colocando o socket em escuta, até 5 vezes.
            socket.Listen(5);

            // Indica que o servidor está escutando.
            Console.WriteLine("Escutando...");

            // Socket escutando as requisições.
            var socketListener = socket.Accept();

            // Tratamento para erro no recebimento de mensagens.
            try
            {
                // Convertendo a mensagem recebida.
                var bytes = new byte[255];
                int length = socketListener.Receive(bytes, 0, bytes.Length, SocketFlags.None);

                // Eliminando possíveis campos vazios no Array.
                Array.Resize(ref bytes, length);

                // Exibindo mensagem do cliente.
                var mensagemRecebida = Encoding.Default.GetString(bytes);

                var mensagemApresentada = string.Format(
                    "\nMensagem recebida pelo cliente: \n\t-> {0}",
                    mensagemRecebida
                    );

                Console.WriteLine(mensagemApresentada);
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível continuar a conexão com o cliente...");
            }
            finally
            {
                // Encerrando o servidor Socket.
                socket.Close();

                Console.WriteLine();
                Console.WriteLine("Servidor Socket finalizado.");
                Console.WriteLine("Pressione qualquer tecla para finalizar...");

                Console.ReadKey();
            }
        }
    }
}
