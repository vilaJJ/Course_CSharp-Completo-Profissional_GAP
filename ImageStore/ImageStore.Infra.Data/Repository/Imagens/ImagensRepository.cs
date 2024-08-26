using ImageStore.Domain.Imagens;
using ImageStore.Domain.Imagens.Repository;
using ImageStore.Infra.Data.Context;
using System.Linq.Expressions;

namespace ImageStore.Infra.Data.Repository.Imagens
{
    public class ImagensRepository : ImageStoreContext, IImagemRepository, IDisposable
    {
        #region Propriedades

        public string NomeTabela => "Imagens";

        #endregion

        #region Construtores

        public ImagensRepository() : base() { }

        #endregion

        #region Métodos Públicos

        public Task<List<Imagem>> Buscar()
        {
            throw new NotImplementedException();
        }

        public Task<List<Imagem>> Buscar(Expression<Func<Imagem, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Imagem> Buscar(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Inserir(Imagem entity)
        {
            string insertSql = $"INSERT INTO {NomeTabela} VALUES (@Codigo, @Nome, @Data)";
            return await Executar(insertSql, entity);
        }

        #endregion

        public new void Dispose()
        {
            GC.SuppressFinalize(this);
            base.Dispose();
        }        
    }
}
