
namespace ImageStore.Services.Imagens.Interfaces
{
    public interface IImagemService
    {
        Task<UI.Model.Imagens.Imagem?> Buscar(Guid codigo);
        Task<bool> Inserir(UI.Model.Imagens.Imagem imagem);
        Task<List<UI.Model.Imagens.Imagem>> ObterDadosImagens();
    }
}
