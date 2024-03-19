using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TransferenciaArquivosServer.Classes
{
    internal class FTServer
    {
        internal readonly ListBox ListaMensagens;

        internal IPAddress EnderecoIP { get; private set; }
        internal int Porta { get; private set; }
        internal string PathArquivos { get; private set; }

        internal FTServer(string enderecoIP, int porta, ListBox listaMensagens, string pathArquivos = null)
        {
            try
            {
                EnderecoIP = IPAddress.Parse(enderecoIP);
                Porta = porta;
                ListaMensagens = listaMensagens;

                PathArquivos = pathArquivos
                    ?? string.Format(
                            "{0}\\",
                            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                            );

                
            }
            catch (Exception ex)
            {
                AdicionarMensagem("Erro ao iniciar o servidor. " + ex.Message);
            }            
        }

        internal void Iniciar()
        {
            var ocorreuErro = false;

            var endPoint = new IPEndPoint(EnderecoIP, Porta);
            var socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                #region Iniciando o servidor

                socketServidor.Bind(endPoint);

                socketServidor.Listen(100);

                AdicionarMensagem("Servidor em atendimento, aguardando arquivos...");

                #endregion

                #region Escutando clientes e gravando arquivo

                using (var socketClient = socketServidor.Accept())
                {
                    // Definindo tamanho do buffer.
                    socketClient.ReceiveBufferSize = 16384;

                    var bytes = new byte[1024 * 50000];
                    var fileLength = socketClient.Receive(bytes, bytes.Length, SocketFlags.None);

                    // Informações do nome do arquivo.
                    var archiveNameLength = BitConverter.ToInt32(bytes, 0);
                    var archiveName = Encoding.UTF8.GetString(bytes, 4, archiveNameLength);

                    using (var file = File.Open(PathArquivos + archiveName, FileMode.Append))
                    using (var binaryWriter = new BinaryWriter(file))
                    {
                        var index = archiveNameLength + 4;
                        var count = fileLength - archiveNameLength - 4;

                        binaryWriter.Write(bytes, index, count);

                        #region Ciclo while para receber arquivos

                        while (fileLength > 0)
                        {
                            fileLength = socketClient.Receive(bytes, bytes.Length, SocketFlags.None);

                            if (fileLength == 0)
                            {
                                break;
                            }
                            else
                            {
                                binaryWriter.Write(bytes, 0, fileLength);
                            }                            
                        }

                        AdicionarMensagem(
                            string.Format(
                                "Arquivo '{0}' recebido e gravado.",
                                archiveName
                                ));

                        #endregion
                    }
                }        

                #endregion
            }
            catch (SocketException ex)
            {
                AdicionarMensagem("Erro ao receber o arquivo. " + ex.Message);
                ocorreuErro = true;
            }
            finally
            {
                socketServidor.Close();

                if (ocorreuErro is false)
                {
                    Iniciar();
                }               
            }
        }

        internal void AdicionarMensagem(string mensagem)
        {
            ListaMensagens.Invoke(new Action(() =>
            {
                ListaMensagens.Items.Add(mensagem);

                ListaMensagens.SetSelected(
                    ListaMensagens.Items.Count - 1,
                    true
                    );
            }));
        }

        internal void DefinirPathArquivos(string path)
        {
            if (Directory.Exists(path) is false)
            {
                AdicionarMensagem("O caminho informado não existe. Alteração não realizada.");
                return;
            }

            PathArquivos = path;
        }
    }
}
