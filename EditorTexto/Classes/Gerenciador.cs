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

        internal static bool IsArquivoNovoPadrao
        {
            get => true;
        }

        internal static bool IsArquivoSalvoPadrao
        {
            get => true;
        }

        #endregion

        #region Valores em uso

        internal static string PastaDestino { get; set; } = PastaPadrao;
        internal static string NomeArquivo { get; set; } = NomeArquivoPadrao;
        internal static string NomeExtensao { get; set; } = NomeExtensaoPadrao;
        internal static bool IsArquivoNovo { get; set; } = IsArquivoNovoPadrao;
        internal static bool IsArquivoSalvo { get; set; } = IsArquivoSalvoPadrao;
        internal static string DestinoArquivo
        {
            get
            {
                return string.Format(
                    @"{0}\{1}.{2}",
                    PastaDestino,
                    NomeArquivo,
                    NomeExtensao
                    );
            }
        }

        #endregion

        #region Métodos internos

        internal static void RestaurarValoresPadroes()
        {
            PastaDestino = PastaPadrao;
            NomeArquivo = NomeArquivoPadrao;
            NomeExtensao = NomeExtensaoPadrao;
            IsArquivoNovo = IsArquivoNovoPadrao;
            IsArquivoSalvo = IsArquivoSalvoPadrao;
        }

        #endregion
    }
}
