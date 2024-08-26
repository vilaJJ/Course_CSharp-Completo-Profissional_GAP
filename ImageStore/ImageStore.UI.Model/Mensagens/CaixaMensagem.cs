using ImageStore.UI.Model.Mensagens.Enums;

namespace ImageStore.UI.Model.Mensagens
{
    public class CaixaMensagem(TipoMensagem tipo, string texto)
    {
        #region Campos

        public readonly TipoMensagem Tipo = tipo;
        public readonly string Texto = texto;
        public readonly string? Titulo;

        #endregion

        #region Construtores

        public CaixaMensagem(
            TipoMensagem tipo,
            string mensagem,
            string titulo) : this(tipo, mensagem)
        {
            Texto = titulo;
        }

        #endregion
    }
}
