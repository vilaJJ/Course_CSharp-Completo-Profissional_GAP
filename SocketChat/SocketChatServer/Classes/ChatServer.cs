using SocketChatServer.Eventos;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketChatServer.Classes
{
    /// <summary>
    /// Este <i>delegate</i> é necessário para especificar os parâmetros que estamos passando com o nosso evento.
    /// </summary>
    /// <param name="sender">Objeto invocador do evento.</param>
    /// <param name="e">Argumentos do evento.</param>
    internal delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);

    /// <summary>
    /// Servidor responsável pela comunicação dos clientes no chat.
    /// </summary>
    internal class ChatServer
    {
        #region Propriedades internas

        /// <summary>
        /// Tabela que armazena os usuários (acessando/consultando por usuário).
        /// </summary>
        internal static Hashtable Usuarios { get; private set; }

        /// <summary>
        /// Tabela que armazena as conexões (acessando/consultando por usuário).
        /// </summary>
        internal static Hashtable Conexoes { get; private set; }

        #endregion

        #region Propriedades privadas

        /// <summary>
        /// Armazena o endereço IP do Servidor.
        /// </summary>
        private IPAddress EnderecoIP { get; set; }

        /// <summary>
        /// Armazena a porta de conexão do Servidor.
        /// </summary>
        private int Porta { get; set; }

        /// <summary>
        /// Armazena o <i>TCP Client</i> do Servidor.
        /// </summary>
        private TcpClient TcpCliente { get; set; }

        /// <summary>
        /// Argumentos do evento.
        /// </summary>
        private static StatusChangedEventArgs EventArgs { get; set; }

        /// <summary>
        /// Irá tratar o escutador de conexões.
        /// </summary>
        private Thread Escutador { get; set; }

        /// <summary>
        /// Irá escutar as conexões.
        /// </summary>
        private TcpListener EscutadorTcp { get; set; }

        /// <summary>
        /// Indica se deverá manter o monitoramento das conexões.
        /// </summary>
        private bool ServidorRodando { get; set; }

        #endregion

        #region Eventos

        /// <summary>
        /// O evento e o seu argumento irá notificar o formulário quando um usuário se conecta, desconecta,
        /// envia uma mensagem, etc...
        /// </summary>
        internal static event StatusChangedEventHandler StatusChanged;

        #endregion

        /// <summary>
        /// Define o endereço IP para aquele retornado da instanciação do objeto.
        /// </summary>
        /// <param name="endereco">Endereço de IP do servidor.</param>
        /// <param name="porta">Porta de conexão do servidor.</param>
        internal ChatServer(string endereco, int porta)
        {
            try
            {
                Usuarios = new Hashtable(30);
                Conexoes = new Hashtable(30);

                EnderecoIP = IPAddress.Parse(endereco);
                Porta = porta;

                ServidorRodando = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Realiza a inclusão do usuário na tabela.
        /// </summary>
        /// <param name="tcpUsuario"><i>TCP</i> do usuário.</param>
        /// <param name="username">Nome do usuário.</param>
        internal static void IncluirUsuario(TcpClient tcpUsuario, string username)
        {
            // Incluí nome e conexão em ambas tabelas.
            Usuarios.Add(username, tcpUsuario);
            Conexoes.Add(tcpUsuario, username);

            // Informa a todos os usuários de uma nova conexão.
            EnviarMensagemAdmin(
                string.Format(
                    "{0} entrou na sessão.",
                    username
                    )
                );
        }

        /// <summary>
        /// Remove do usuário das tabelas.
        /// </summary>
        /// <param name="usuario">Usuário <i>TCP</i>.</param>
        internal static void RemoverUsuario(TcpClient usuario)
        {
            // Verifica se o usuário existe
            if (Conexoes[usuario] is null)
            {
                return;
            }

            EnviarMensagemAdmin(
                string.Format(
                    "{0} saiu da sessão.",
                    Conexoes[usuario]
                    )
                );

            Usuarios.Remove(Conexoes[usuario]);
            Conexoes.Remove(usuario);
        }

        /// <summary>
        /// Envia mensagens de nível administrador.
        /// </summary>
        /// <param name="mensagem">Mensagem a ser enviada.</param>
        internal static void EnviarMensagemAdmin(string mensagem)
        {
            // Exibe a notificação para os clientes.
            EventArgs = new StatusChangedEventArgs("Admin: " + mensagem);
            OnStatusChanged(EventArgs);

            // Cria um array de clientrs TCPs do tamanho do número de clientes existentes.
            var clientesTcp = new TcpClient[Usuarios.Count];

            // Copia os objetos TcpClient no array
            Usuarios.Values.CopyTo(clientesTcp, 0);

            // Percorre a lista de clientes TCP
            for (int i = 0; i < clientesTcp.Length; i++)
            {
                // Tenta enviar uma mensagem para cada cliente.
                try
                {
                    // Se a mensagem estiver em branco ou a conexão for nula, sair.
                    if (string.IsNullOrEmpty(mensagem.Trim()) || clientesTcp[i] is null)
                    {
                        continue;
                    }

                    // Envia a mensagem para o usuário atual do laço
                    var streamSender = new StreamWriter(clientesTcp[i].GetStream());
                    streamSender.WriteLine("Admin: " + mensagem);

                    streamSender.Flush();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    RemoverUsuario(clientesTcp[i]);
                }
            }
        }

        /// <summary>
        /// Envia mensagens de um usuário para todos os outros.
        /// </summary>
        /// <param name="origem">Origem da mensagem.</param>
        /// <param name="mensagem">Conteúdo da mensagem.</param>
        internal static void EnviarMensagem(string origem, string mensagem)
        {
            // Exibe a notificação para os clientes.
            EventArgs = new StatusChangedEventArgs(
                string.Format(
                    "{0} disse: {1}",
                    origem,
                    mensagem
                    )
                );
            OnStatusChanged(EventArgs);

            // Cria um array de clientrs TCPs do tamanho do número de clientes existentes.
            var clientesTcp = new TcpClient[Usuarios.Count];

            // Copia os objetos TcpClient no array
            Usuarios.Values.CopyTo(clientesTcp, 0);

            // Percorre a lista de clientes TCP
            for (int i = 0; i < clientesTcp.Length; i++)
            {
                // Tenta enviar uma mensagem para cada cliente.
                try
                {
                    // Se a mensagem estiver em branco ou a conexão for nula, sair.
                    if (string.IsNullOrEmpty(mensagem.Trim()) || clientesTcp[i] is null)
                    {
                        continue;
                    }

                    // Envia a mensagem para o usuário atual do laço
                    var streamSender = new StreamWriter(clientesTcp[i].GetStream());
                    streamSender.WriteLine(
                        string.Format(
                            "{0} disse: {1}",
                            origem,
                            mensagem
                            )
                        );

                    streamSender.Flush();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    RemoverUsuario(clientesTcp[i]);
                }
            }
        }

        /// <summary>
        /// Para disparar o evento <i>StatusChanged</i>.
        /// </summary>
        /// <param name="eventArgs">Argumentos do evento.</param>
        internal static void OnStatusChanged(StatusChangedEventArgs eventArgs)
        {
            var statusHandler = StatusChanged;

            if (statusHandler is null)
            {
                return;
            }

            statusHandler(null, eventArgs);
        }

        /// <summary>
        /// Inicia o atendimento do servidor
        /// </summary>
        internal void IniciarAtendimento()
        {
            try
            {
                // Pega os dados do servidor.
                var ipLocal = EnderecoIP;
                var porta = Porta;

                // Cria um objeto TCP Listener, usando o IP do servidor e porta definidas.
                EscutadorTcp = new TcpListener(ipLocal, porta);

                // Inicia o TCP Listener e escuta as conexões.
                EscutadorTcp.Start();

                // Verifica se o servidor está rodando antes de checar as conexões
                ServidorRodando = true;

                // Inicia uma nova thread, que hospeda o Listener.
                Escutador = new Thread(MantemAtendimento)
                {
                    IsBackground = true
                };

                Escutador.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region Métodos privados

        /// <summary>
        /// Responsável por manter os atendimentos ativos.
        /// </summary>
        private void MantemAtendimento()
        {
            // Enquanto o servidor estiver rodando
            while (ServidorRodando is true)
            {
                // Aceita uma conexão pendente.
                TcpCliente = EscutadorTcp.AcceptTcpClient();

                // Cria uma nova instância de conexão
                new Conexao(TcpCliente);
            }
        }

        #endregion
    }
}
