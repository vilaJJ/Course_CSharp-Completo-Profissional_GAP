using System;
using System.IO;
using System.Security.Cryptography;

namespace CriptografarArquivos.Classes
{
    /// <summary>
    /// Classe para operações de criptografia.
    /// </summary>
    internal class Criptografia
    {
        // Serviços
        internal static CspParameters ParametrosCsp { get; set; }
        internal static RSACryptoServiceProvider ProvedorCriptografiaRSA { get; set; }

        private static string _pastaParaCriptografados;

        /// <summary>
        /// Pasta para os arquivos criptografados
        /// </summary>
        internal static string PastaParaCriptografados 
        {
            get
            {
                return _pastaParaCriptografados;
            }
            set
            {
                _pastaParaCriptografados = value;
            }
        }
        /// <summary>
        /// Pasta para os arquivos descriptografados.
        /// </summary>
        internal static string DestinoDescriptografados { get; set; }
        
        /// <summary>
        /// Pasta raiz de origem do arquivo. 
        /// </summary>
        internal static string PastaOrigem { get; set; }

        /// <summary>
        /// Arquivo para a chave pública
        /// </summary>
        private static string _chavePublicaArquivo = _pastaParaCriptografados + "rsaPublicKey.txt";

        /// <summary>
        /// Chave contendo o nome para private/public key value pair.
        /// </summary>
        internal static string NomeChave { get; set; }

        /// <summary>
        /// Método para criar a chave púbglica
        /// </summary>
        /// <returns>Chave pública.</returns>
        internal static string CriarChaveAssimetrica()
        {
            string resultado;

            if (string.IsNullOrEmpty(NomeChave))
            {
                return "Chave pública não definida";
            }

            ParametrosCsp.KeyContainerName = NomeChave;
            ProvedorCriptografiaRSA = new RSACryptoServiceProvider(ParametrosCsp)
            {
                PersistKeyInCsp = true
            };

            resultado = string.Format(
                "Key: {0} - {1}", 
                ParametrosCsp.KeyContainerName,
                ProvedorCriptografiaRSA.PublicOnly ? "Somente Pública" : "Key Pair Completa"
                );

            return resultado;
        }

        /// <summary>
        /// Método para exportar a chave pública em um arquivo.
        /// </summary>
        /// <returns>Chave pública exportada.</returns>
        internal static bool ExportarChavePublica()
        {
            var exportado = true;

            if (ProvedorCriptografiaRSA is null)
            {
                return false;
            }

            if (Directory.Exists(PastaParaCriptografados) is false)
            {
                Directory.CreateDirectory(PastaParaCriptografados);
            }

            try
            {
                using (var writer = new StreamWriter(_chavePublicaArquivo, false))
                {
                    writer.Write(ProvedorCriptografiaRSA.ToXmlString(false));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            

            return exportado;
        }

        /// <summary>
        /// Método para importar a chave pública de um arquivo.
        /// </summary>
        /// <returns>Status da chave importada.</returns>
        internal static string ImportarChavePublica()
        {
            string resultado;

            if (File.Exists(_chavePublicaArquivo) is false)
            {
                return "Arquivo de Chave Pública não encontrado.";
            }

            if (string.IsNullOrEmpty(NomeChave))
            {
                return "Chave Pública não definida.";
            }

            try
            {
                using (var reader = new StreamReader(_chavePublicaArquivo))
                {
                    ParametrosCsp.KeyContainerName = NomeChave;
                    ProvedorCriptografiaRSA = new RSACryptoServiceProvider(ParametrosCsp);

                    var textoChave = reader.ReadToEnd();

                    ProvedorCriptografiaRSA.FromXmlString(textoChave);
                    ProvedorCriptografiaRSA.PersistKeyInCsp = true;

                    resultado = string.Format(
                        "Key: {0} - {1}",
                        ParametrosCsp.KeyContainerName,
                        ProvedorCriptografiaRSA.PublicOnly ? "Somente Pública" : "Key Pair Completa"
                        );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Não foi possível.";
            }

            return resultado;
        }

        /// <summary>
        /// Método para criar uma chave primária à partir de um valor definido.
        /// </summary>
        /// <returns>Status.</returns>
        internal static string ObterChavePrivada()
        {
            string resultado;

            if (string.IsNullOrEmpty(NomeChave))
            {
                return "Chave privada não definida";
            }

            ParametrosCsp.KeyContainerName = NomeChave;
            ProvedorCriptografiaRSA = new RSACryptoServiceProvider(ParametrosCsp)
            {
                PersistKeyInCsp = true
            };

            resultado = string.Format(
                "Key: {0} - {1}",
                ParametrosCsp.KeyContainerName,
                ProvedorCriptografiaRSA.PublicOnly ? "Somente Privada" : "Key Pair Completa"
                );

            return resultado;
        }

        /// <summary>
        /// Método para criptografar um arquivo.
        /// </summary>
        /// <param name="pathArquivo">Caminho do arquivo.</param>
        /// <returns>Status</returns>
        internal static string EncriptografarArquivo(string pathArquivo)
        {
            using (var aes = Aes.Create())
            using (var transformador = aes.CreateEncryptor())
            {
                var chaveEncriptografada = ProvedorCriptografiaRSA.Encrypt(aes.Key, false);
                
                var chaveLength = new byte[4];
                var inicializadorLength = new byte[4];

                var tamanhoChave = chaveEncriptografada.Length;
                chaveLength = BitConverter.GetBytes(tamanhoChave);

                var tamanhoInicializador = aes.IV.Length;
                inicializadorLength = BitConverter.GetBytes(tamanhoInicializador);

                // Escreva o seguinte FileStream
                // para o arquivo criptografado(outFs)
                // - Comprimento da chave
                // - Comprimento do IV
                // - Chave criptografada
                // - O IV
                // - O conteudo da cifra criptografada

                var startFileName = pathArquivo.LastIndexOf("\\") + 1;
                var outFile = PastaParaCriptografados + pathArquivo.Substring(startFileName) + ".enc";

                try
                {
                    using (var inputFileStream = new FileStream(pathArquivo, FileMode.Open))
                    using (var outFileStream = new FileStream(outFile, FileMode.Create))
                    using (var outStreamEncrypted = new CryptoStream(outFileStream, transformador, CryptoStreamMode.Write))
                    {
                        outFileStream.Write(chaveLength, 0, chaveLength.Length);
                        outFileStream.Write(inicializadorLength, 0, inicializadorLength.Length);
                        outFileStream.Write(chaveEncriptografada, 0, tamanhoChave);
                        outFileStream.Write(aes.IV, 0, tamanhoInicializador);

                        // Criptografar por laços, para economizar memória
                        int count, offset, bytesRead;
                        count = offset = bytesRead = 0;

                        // blockSizeBytes pode ter qualquer tamanho arbitrário.
                        var blockSizeBytes = aes.BlockSize / 8;

                        var dados = new byte[blockSizeBytes];

                        do
                        {
                            count = inputFileStream.Read(dados, 0, blockSizeBytes);
                            offset += count;

                            outStreamEncrypted.Write(dados, 0, count);
                            bytesRead += blockSizeBytes;
                        } while (count > 0);

                        outStreamEncrypted.FlushFinalBlock();
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

                return string.Format(
                    "Arquivo criptografado:\n\nOrigem: {0}\nDestino: {1}",
                    pathArquivo,
                    outFile
                    );
            }
        }

        /// <summary>
        /// Método para descriptografar um arquivo.
        /// </summary>
        /// <param name="pathArquivo">Caminho do arquivo.</param>
        /// <returns>Status</returns>
        internal static string DescriptografarArquivo(string pathArquivo)
        {
            // Matrizes de bytes 
            var lenKey = new byte[4];
            var lenIV = new byte[4];

            var outFile = DestinoDescriptografados + pathArquivo.Substring(0, pathArquivo.LastIndexOf("."));

            // Cria instância de AES para descriptografar de forma simétrica.
            using (var aes = Aes.Create())
            using (var inputFileStream = new FileStream(PastaParaCriptografados + pathArquivo, FileMode.Open))
            using (var outFileStream = new FileStream(pathArquivo, FileMode.Create))
            {
                try
                {
                    inputFileStream.Seek(0, SeekOrigin.Begin);
                    inputFileStream.Seek(0, SeekOrigin.Begin);

                    inputFileStream.Read(lenKey, 0, 3);

                    inputFileStream.Seek(4, SeekOrigin.Begin);

                    inputFileStream.Read(lenIV, 0, 3);

                    // Converte os comprimentos em valores inteiros
                    var keyLength = BitConverter.ToInt32(lenKey, 0);
                    var ivLength = BitConverter.ToInt32(lenIV, 0);

                    // Determina a posição inicial do texto cifrado e seu comprimento
                    var startC = keyLength + ivLength + 8;
                    var lenC = (int)inputFileStream.Length - startC;

                    // Matrizes para chave criptografada, IV e texto cifrado
                    var chaveEncriptografada = new byte[keyLength];
                    var iv = new byte[ivLength];

                    // Extrair a chave e IV
                    inputFileStream.Seek(8, SeekOrigin.Begin);
                    inputFileStream.Read(chaveEncriptografada, 0, keyLength);

                    inputFileStream.Seek(8 + keyLength, SeekOrigin.Begin);
                    inputFileStream.Read(iv, 0, ivLength);

                    if (Directory.Exists(DestinoDescriptografados) is false)
                    {
                        Directory.CreateDirectory(DestinoDescriptografados);
                    }

                    // Usar RSACryptoServiceProvider para descriptografar a chave AES
                    var chaveDescriptografada = ProvedorCriptografiaRSA.Decrypt(chaveEncriptografada, false);

                    // Descriptografar a chave
                    using (var transformador = aes.CreateDecryptor(chaveDescriptografada, iv))
                    {
                        int count, offset;
                        count = offset = 0;

                        // blockSizeBytes pode ter qualquer tamanho arbitrário
                        var blockSizeBytes = aes.BlockSize / 8;
                        var dados = new byte[blockSizeBytes];

                        // Começar no início do texto cifrado.
                        inputFileStream.Seek(startC, SeekOrigin.Begin);

                        using (var outStreamDecrypted = new CryptoStream(outFileStream, transformador, CryptoStreamMode.Write))
                        {
                            do
                            {
                                count = inputFileStream.Read(dados, 0, blockSizeBytes);
                                offset += count;
                                outStreamDecrypted.Write(dados, 0, count);
                            } while (count > 0);

                            outStreamDecrypted.FlushFinalBlock();
                        }
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }                
            }

            return string.Format(
                "Arquivo criptografado:\n\nOrigem: {0}\nDestino: {1}",
                pathArquivo,
                outFile
                );
        }
    }
}
