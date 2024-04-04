namespace EditorTexto.Classes
{
    internal static class Gerenciador
    {
        #region Valores padrões

        internal static string PastaPadrao
        {
            get
            {
                var pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                return pastaDocumentos;
            }
        }

        internal static string NomeArquivoPadrao
        {
            get => "texto";
        }

        internal static string NomeExtensaoPadrao
        {
            get => "txt";
        }

        #endregion

        #region Valores em uso

        internal static string PastaDestino { get; set; } = PastaPadrao;
        internal static string NomeArquivo { get; set; } = NomeArquivoPadrao;
        internal static string NomeExtensao { get; set; } = NomeExtensaoPadrao;
        internal static string DestinoArquivo
        {
            get
            {
                return string.Format(
                    @"{0}\{1}.{2}",
                    PastaPadrao,
                    NomeArquivo,
                    NomeExtensao
                    );
            }
        }

        #endregion

    }
}
