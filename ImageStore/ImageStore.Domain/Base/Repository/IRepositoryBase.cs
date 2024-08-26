using System.Linq.Expressions;

namespace ImageStore.Domain.Base.Repository
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        string NomeTabela { get; }

        Task<int> Inserir(TEntity entity);
        Task<List<TEntity>> Buscar();
        Task<List<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> Buscar(Guid id);
    }
}
