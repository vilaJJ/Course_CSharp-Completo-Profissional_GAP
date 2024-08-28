namespace ImageStore.UI.Model.Imagens
{
    public class Imagem(string nome)
    {
        #region Campos

        public readonly Guid? Codigo;
        public readonly string? Path;
        public readonly Image? Data;
        public readonly byte[]? Bytes;

        #endregion

        #region Propriedades

        public string Nome { get; set; } = nome;

        #endregion

        #region Construtores

        public Imagem(Guid codigo, string nome) : this(nome)
        {
            Codigo = codigo;
        }

        public Imagem(string nome, Image? data) : this(nome)
        {
            Data = data;
        }

        public Imagem(Guid codigo, string nome, Image? data) : this(codigo, nome)
        {
            Data = data;
        }

        public Imagem(string path, string nome, Image? data) : this(nome, data) 
        {
            Path = path;
            Data = data;
        }

        public Imagem(Guid codigo, string nome, Image? data, byte[]? bytes) : this(codigo, nome, data)
        {
            Bytes = bytes;
        }

        #endregion
    }
}
