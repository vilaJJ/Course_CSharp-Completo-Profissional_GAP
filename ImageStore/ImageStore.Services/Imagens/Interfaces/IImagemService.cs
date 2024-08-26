
namespace ImageStore.Services.Imagens.Interfaces
{
    public interface IImagemService
    {
        Task<bool> Inserir(UI.Model.Imagens.Imagem imagem);
    }
}
