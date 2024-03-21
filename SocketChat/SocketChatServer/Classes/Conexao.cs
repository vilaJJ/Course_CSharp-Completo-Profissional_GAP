using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace SocketChatServer.Classes
{
    /// <summary>
    /// Trata as conexões, serão tantas quanto as instâcias dos usuários conectados.
    /// </summary>
    internal class Conexao
    {
        private readonly TcpClient tcpClient;

        /// <summary>
        /// A thread que irá enviar a informação para o cliente.
        /// </summary>
        private Thread ThreadSender { get; set; }

        /// <summary>
        /// Recebe os dados.
        /// </summary>
        private StreamReader Receptor { get; set; }
        
        /// <summary>
        /// Envia os dados.
        /// </summary>
        private StreamWriter Enviador { get; set; }

        private string UsuarioAtual { get; set; }
        private string Resposta { get; set; }

        internal Conexao(TcpClient cliente)
        {
            tcpClient = cliente;

            // A thread que aceita o cliente e espera a mensagem
            ThreadSender = new Thread(AceitarCliente)
            {
                IsBackground = true
            };

            ThreadSender.Start();
        }

        /// <summary>
        /// Fecha os elementos em uso.
        /// </summary>
        private void FecharConexao()
        {
            Enviador.Flush();     

            Receptor.Close();
            Enviador.Close();

            tcpClient.Close();
        }

        private void AceitarCliente()
        {
            Receptor = new StreamReader(tcpClient.GetStream());
            Enviador = new StreamWriter(tcpClient.GetStream());

            // Lê a informação da conta do cliente.
            UsuarioAtual = Receptor.ReadLine();

            // Resposta do cliente.
            if (string.IsNullOrEmpty(UsuarioAtual))
            {
                FecharConexao();
            }
            else
            {
                // Armazena o nome do usuário na hashtable
                if (ChatServer.Usuarios.Contains(UsuarioAtual))
                {
                    // 0 -> Não conectado
                    Enviador.WriteLine("0|Este nome de usuário já existe.");
                    FecharConexao();
                }
                else if (UsuarioAtual is "Admin")
                {
                    // 0 -> Não conectado
                    Enviador.WriteLine("0|Este nome de usuário é reservado.");
                    FecharConexao();
                }
                else
                {
                    // 1 -> Conectado com sucesso
                    Enviador.WriteLine("1");
                    Enviador.Flush();

                    ChatServer.IncluirUsuario(tcpClient, UsuarioAtual);
                }
            }

            try
            {
                while (string.IsNullOrEmpty(Resposta = Receptor.ReadLine()) is false)
                {
                    // Se for inválido, remover
                    if (Resposta is null)
                    {
                        ChatServer.RemoverUsuario(tcpClient);
                    }
                    else
                    {
                        // Enviar a mensagem para todos os usuários.
                        ChatServer.EnviarMensagem(UsuarioAtual, Resposta);
                    }
                }
            }
            catch (Exception)
            {
                // Se houver um problema com este usuário, desconectar.
                ChatServer.RemoverUsuario(tcpClient);
            }
        }
    }
}
