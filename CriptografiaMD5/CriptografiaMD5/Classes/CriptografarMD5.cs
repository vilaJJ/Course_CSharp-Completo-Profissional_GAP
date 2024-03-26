using System;
using System.Security.Cryptography;
using System.Text;

namespace CriptografiaMD5.Classes
{
    internal class CriptografarMD5 : IDisposable
    {
        internal string Criptografar(string entrada)
        {
            using (var md5Hash = MD5.Create())
            {
                return ObterHash(md5Hash, entrada);
            }
        }

        internal bool Comparar(string entrada, string hash)
        {
            var entradaHash = Criptografar(entrada);
            return VerificarHash(entradaHash, hash);
        }

        private string ObterHash(MD5 md5Hash, string entrada)
        {
            var bytesEntrada = Encoding.UTF8.GetBytes(entrada);
            var dados = md5Hash.ComputeHash(bytesEntrada);

            var builder = new StringBuilder();

            foreach (var valor in dados)
            {
                var valorConvertido = valor.ToString("X2");
                builder.Append(valorConvertido);
            }

            return builder.ToString();
        }

        private bool VerificarHash(string entrada, string hash)
        {
            var comparador = StringComparer.OrdinalIgnoreCase;

            var saoIguais = comparador.Compare(entrada, hash) is 0;
            return saoIguais;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
