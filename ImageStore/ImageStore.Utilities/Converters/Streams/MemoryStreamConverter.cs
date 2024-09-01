namespace ImageStore.Utilities.Converters.Streams
{
    public static class MemoryStreamConverter
    {
        public static async Task<MemoryStream?> ObterMemoryStream(this byte[]? bytes)
        {
            if (bytes is null)
            {
                return null;
            }

            return await Task.Run(() =>
            {
                return new MemoryStream(bytes);
;           });
        }

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

        public static async Task<Image?> ObterImage(this MemoryStream? stream)
        {
            if (stream is null)
            {
                return null;
            }

            return await Task.Run(() =>
            {
                return Image.FromStream(stream);
            });
        }
    }
}
