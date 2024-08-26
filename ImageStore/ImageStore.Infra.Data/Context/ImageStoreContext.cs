using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace ImageStore.Infra.Data.Context
{
    public abstract class ImageStoreContext : IDisposable
    {
        #region Campos

        private readonly MySqlConnection conexao;

        #endregion

        #region Constantes

        private const string SERVER =   "localhost";
        private const string USER =     "storeimage";
        private const string PASSWORD = "SVSKtWaq";
        private const string DATABASE = "storeimage";

        private const string CONEXAO = $"server={SERVER}; User id={USER}; password={PASSWORD}; database={DATABASE}";

        #endregion

        #region Construtores

        protected ImageStoreContext() 
        {
            conexao = new MySqlConnection(CONEXAO);
        }

        #endregion

        #region Métodos Protegidos

        protected async Task<int> Executar(string sql, object? parametro = null)
        {
            MySqlConnection conexao = await ObterConexao();
            int linhasAfetadas = await conexao.ExecuteAsync(sql, parametro);

            return linhasAfetadas;
        }

        protected async Task<TEntity> Obter<TEntity>(string sql, object? parametro = null)
        {
            MySqlConnection conexao = await ObterConexao();
            TEntity consulta = await conexao.QuerySingleAsync<TEntity>(sql, parametro);

            return consulta;
        }

        protected async Task<List<TEntity>> ObterLista<TEntity>(string sql, object? parametro = null)
        {
            MySqlConnection conexao = await ObterConexao();
            IEnumerable<TEntity> consulta = await conexao.QueryAsync<TEntity>(sql, parametro);

            return consulta.ToList();
        }

        #endregion

        #region Métodos Privados

        private async Task<MySqlConnection> ObterConexao()
        {
            if (conexao.State is not ConnectionState.Open)
            {
                await conexao.OpenAsync();
            }

            return conexao;
        }

        #endregion

        public void Dispose()
        {
            conexao.Close();
            conexao.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
