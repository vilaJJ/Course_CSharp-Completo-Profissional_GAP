namespace ImageStore.Utilities.Converters.Streams
{
    public static class StreamConverter
    {
        public static MemoryStream ObterMemoryStream(this Image imagem)
        {
            MemoryStream stream = new();
            imagem.Save(stream, imagem.RawFormat);

            return stream;
        }

        public static byte[] ObterBytesDaStream(this MemoryStream stream)
        {
            return stream.ToArray();
        }
    }
}
