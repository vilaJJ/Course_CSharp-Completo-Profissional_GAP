using System;

namespace TransferenciaArquivoCliente.Models
{
    [Serializable]
    internal class EnvioResultModel
    {
        internal bool Sucesso { get; private set; }
        internal string Mensagem { get; private set; }

        internal EnvioResultModel() 
        {
            Sucesso = true;
            Mensagem = "Enviado com sucesso";
        }

        internal EnvioResultModel(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }
    }
}
