using ImageStore.Infra.Data.Repository.Imagens;
using ImageStore.Services.Imagens.Interfaces;
using ImageStore.Utilities.Converters.Streams;
using System.Drawing;

namespace ImageStore.Services.Imagens
{
    public class Imagem : IImagemService, IDisposable
    {
        #region Construtores

        public Imagem() { }

        #endregion

        #region Métodos Públicos

        public async Task<bool> Inserir(UI.Model.Imagens.Imagem imagem)
        {
            try
            {
                int linhasRetornadas;
                Domain.Imagens.Imagem imagemInserir = await ObterImagem(imagem);
                
                using ImagensRepository repository = new();
                linhasRetornadas = await repository.Inserir(imagemInserir);

                return linhasRetornadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Falha ao inserir imagem no Banco de Dados. {ex.Message}"
                    );
            }
        }

        #endregion

        #region Métodos Privados

        private static async Task<Domain.Imagens.Imagem> ObterImagem(UI.Model.Imagens.Imagem imagem)
        {
            MemoryStream? stream = null;

            try
            {
                stream = await ObterMemoryStreamImagem(imagem.Data);
                byte[] bytes = await ObterBytesDaStream(stream);

                return new Domain.Imagens.Imagem(
                    imagem.Nome,
                    bytes
                    );
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                stream?.Dispose();
            }
            
        }

        private static async Task<MemoryStream> ObterMemoryStreamImagem(Image imagem)
        {
            return await imagem.ObterMemoryStream();
        }

        private static async Task<byte[]> ObterBytesDaStream(MemoryStream stream) 
        {
            return await stream.ObterBytesDaStream();
        }

        #endregion

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
