namespace ImageStore.Utilities.Converters.Streams
{
    public static class StreamConverter
    {
        public static async Task<MemoryStream> ObterMemoryStream(this Image imagem)
        {
            return await Task.Run(() => 
            {
                MemoryStream stream = new();
                imagem.Save(stream, imagem.RawFormat);

                return stream;
            });
        }

        public static async Task<byte[]> ObterBytesDaStream(this MemoryStream stream)
        {
            return await Task.Run(stream.ToArray);            
        }
    }
}
