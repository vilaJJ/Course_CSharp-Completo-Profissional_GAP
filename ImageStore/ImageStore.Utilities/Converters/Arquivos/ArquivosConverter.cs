namespace ImageStore.Utilities.Converters.Arquivos
{
    public static class ArquivosConverter
    {
        public static string ObterTamanhoApresentavel(int quantidadeBytes)
        {
            double valor;
            string medida;

            if (quantidadeBytes < 1000)
            {
                valor = quantidadeBytes;
                medida = "bytes";
            }
            else if (quantidadeBytes < 1000000)
            {
                valor = (double)quantidadeBytes / 1000;
                medida = "KB";
            }
            else
            {
                valor = (double)quantidadeBytes / 1000000;
                medida = "MB";
            }

            return $"{valor:N2} {medida}";
        }
    }
}
