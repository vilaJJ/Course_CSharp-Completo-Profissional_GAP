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


    }
}
