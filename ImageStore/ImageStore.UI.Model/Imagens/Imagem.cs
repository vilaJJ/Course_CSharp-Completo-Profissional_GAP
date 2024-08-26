namespace ImageStore.UI.Model.Imagens
{
    public class Imagem(string nome, Image data)
    {
        #region Campos

        public readonly string Nome = nome;
        public readonly Image Data = data;

        #endregion
    }
}
