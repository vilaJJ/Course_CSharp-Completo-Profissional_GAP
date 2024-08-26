namespace ImageStore.Domain.Imagens
{
    public class Imagem(string nome, byte[] data)
    {
        #region Propriedadades

        public Guid Codigo { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = nome;
        public byte[] Data { get; set; } = data;

        #endregion
    }
}
