using ImageStore.Domain.Imagens;
using ImageStore.Domain.Imagens.Repository;
using ImageStore.Infra.Data.Context;

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

        public async Task<List<Imagem>> Buscar()
        {
            string selectSql = $"SELECT * FROM {NomeTabela}";
            return await ObterLista<Imagem>(selectSql);
        }

        public async Task<List<Imagem>> Buscar(Func<Imagem, bool> predicate)
        {
            List<Imagem> consulta = await Buscar();

            return consulta.Where(predicate)
                           .ToList();
        }

        public async Task<Imagem?> Buscar(Guid id)
        {
            string selectSql = $"SELECT * FROM {NomeTabela} WHERE Codigo = @Codigo";
            return await Obter<Imagem>(selectSql, new{ Codigo = id });
        }

        public async Task<int> Inserir(Imagem entity)
        {
            string insertSql = $"INSERT INTO {NomeTabela} VALUES (@Codigo, @Nome, @Data)";
            return await Executar(insertSql, entity);
        }

        public async Task<int> Excluir(Guid id)
        {
            string deleteSql = $"DELETE FROM {NomeTabela} WHERE Codigo = @Codigo";
            return await Executar(deleteSql, new{ Codigo = id });
        }

        public async Task<bool> Existe(Guid id)
        {
            string selectSql = $"SELECT 1 FROM {NomeTabela} WHERE Codigo = @Codigo";
            int? query = await Obter<int>(selectSql, new{ Codigo = id });
            return query is int;
        }

        public async Task<List<Imagem>> BuscarApenasDados()
        {
            string selectSql = $"SELECT Codigo, Nome FROM {NomeTabela}";
            return await ObterLista<Imagem>(selectSql);
        }

        #endregion

        public new void Dispose()
        {
            GC.SuppressFinalize(this);
            base.Dispose();
        }
    }
}
