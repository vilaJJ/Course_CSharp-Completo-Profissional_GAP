using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using TransferenciaArquivoCliente.Models;

namespace TransferenciaArquivoCliente.Classes
{
    internal class FTClient : IDisposable
    {
        internal IPAddress EnderecoIP { get; private set; }
        internal int Porta { get; private set; }

        internal FTClient(string enderecoIP, int porta)
        {
            EnderecoIP = IPAddress.Parse(enderecoIP);
            Porta = porta;
        }

        internal EnvioResultModel EnviarArquivo(string arquivo)
        {
            var endPoint = new IPEndPoint(EnderecoIP, Porta);

            var socketClient = new Socket(
                AddressFamily.InterNetwork, 
                SocketType.Stream, 
                ProtocolType.IP
                );

            try
            {
                #region Validações

                ValidarTamanhoArquivo(arquivo);

                #endregion

                #region Configurando bytes

                var fileName = ObterNomeArquivo(arquivo);
                var fileNameBytes = ObterNomeArquivoBytes(fileName);
                var fileNameLength = ObterNomeArquivoLength(fileNameBytes);

                var fileBytes = ObterBytesArquivo(arquivo);
                var clientData = ObterDadosCliente(fileNameBytes, fileBytes);

                fileNameLength.CopyTo(clientData, 0);
                fileNameBytes.CopyTo(clientData, 4);
                fileBytes.CopyTo(clientData, 4 + fileNameBytes.Length);

                #endregion

                #region Conectando no servidor

                socketClient.Connect(endPoint);
                socketClient.Send(clientData, 0, clientData.Length, SocketFlags.None);

                #endregion

                return new EnvioResultModel();
            }
            catch (Exception ex)
            {
                return new EnvioResultModel(
                    false,
                    "Erro ao transferir arquivo. " + ex.Message
                    );
            }
            finally
            {
                socketClient.Close();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #region Métodos Privados

        private void ValidarTamanhoArquivo(string arquivo)
        {
            using (var file = new FileStream(arquivo, FileMode.Open))
            {
                var fileLength = file.Length;

                if (fileLength > 50000 * 1024)
                {
                    throw new InvalidOperationException("O tamanho do arquivo é superior a 50mb. Envie arquivos menores.");
                }
            }
        }

        private byte[] ObterBytesArquivo(string arquivo)
        {
            return File.ReadAllBytes(arquivo);
        }

        private string ObterNomeArquivo(string arquivo)
        {
            return arquivo.Substring(arquivo.LastIndexOf('\\') + 1);
        }

        private byte[] ObterNomeArquivoBytes(string nomeArquivo)
        {
            return Encoding.UTF8.GetBytes(nomeArquivo);
        }

        private byte[] ObterDadosCliente(byte[] fileNameBytes, byte[] fileBytes)
        {
            return new byte[4 + fileNameBytes.Length + fileBytes.Length];
        }

        private byte[] ObterNomeArquivoLength(byte[] filneNameBytes)
        {
            return BitConverter.GetBytes(filneNameBytes.Length);
        }

        #endregion
    }
}
