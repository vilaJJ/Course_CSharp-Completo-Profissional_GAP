namespace ImageStore.Domain.Imagens
{
    public class Imagem(string nome)
    {
        #region Propriedadades

        public Guid Codigo { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = nome;
        public byte[]? Data { get; set; }

        #endregion

        #region Construtores

        public Imagem(Guid codigo, string nome) : this(nome)
        {
            Codigo = codigo;
        }

        public Imagem(string nome, byte[] data) : this(nome) 
        {
            Data = data;
        }

        public Imagem(Guid codigo, string nome, byte[] data) : this(nome)
        {
            Codigo = codigo;
            Data = data;
        }

        #endregion
    }
}
