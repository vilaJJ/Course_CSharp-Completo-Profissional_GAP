namespace ImageStore.UI.Model.Imagens
{
    public class Imagem(string nome, Image data)
    {
        #region Campos

        public readonly Image Data = data;

        #endregion

        #region Propriedades

        public string Nome { get; set; } = nome;

        #endregion
    }
}
