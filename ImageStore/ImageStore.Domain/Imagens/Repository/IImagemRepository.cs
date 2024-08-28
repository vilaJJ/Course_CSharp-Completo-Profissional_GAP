using ImageStore.Domain.Base.Repository;

namespace ImageStore.Domain.Imagens.Repository
{
    public interface IImagemRepository : IRepositoryBase<Imagem> 
    {
        Task<List<Imagem>> BuscarApenasDados();
    }
}
