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

        public async Task<UI.Model.Imagens.Imagem?> Buscar(Guid codigo)
        {
            try
            {
                Domain.Imagens.Imagem? imagem;

                {
                    using ImagensRepository repository = new();
                    imagem = await repository.Buscar(codigo);
                }

                if (imagem is null)
                {
                    return null;
                }

                return ConverterImagemDominio(imagem);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Falha ao buscar imagem no Banco de Dados pelo código. {ex.Message}"
                    );
            }
        }

        public async Task<bool> Inserir(UI.Model.Imagens.Imagem imagem)
        {
            try
            {
                int linhasRetornadas;
                Domain.Imagens.Imagem imagemInserir = await ObterImagem(imagem);

                {
                    using ImagensRepository repository = new();
                    linhasRetornadas = await repository.Inserir(imagemInserir);
                }

                return linhasRetornadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Falha ao inserir imagem no Banco de Dados. {ex.Message}"
                    );
            }
        }

        public async Task<List<UI.Model.Imagens.Imagem>> ObterDadosImagens()
        {
            try
            {
                List<Domain.Imagens.Imagem> imagensBanco;
                List<UI.Model.Imagens.Imagem> imagensDados;

                {
                    using ImagensRepository repository = new();
                    imagensBanco = await repository.BuscarApenasDados();
                }

                imagensDados = ConverterImagemDominio(imagensBanco);

                return imagensDados;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Falha ao buscar os dados de imagens no Banco. {ex.Message}"
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
                if (imagem.Data is null)
                {
                    throw new ArgumentNullException("imagem.Data",
                                                    "Os dados de imagem estão nulos.");
                }

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

        #region Conversão de dados

        private static async Task<MemoryStream> ObterMemoryStreamImagem(Image imagem)
        {
            return await imagem.ObterMemoryStream();
        }

        private static async Task<byte[]> ObterBytesDaStream(MemoryStream stream) 
        {
            return await stream.ObterBytesDaStream();
        }

        private static UI.Model.Imagens.Imagem ConverterImagemDominio(Domain.Imagens.Imagem imagemDominio)
        {
            return new(codigo: imagemDominio.Codigo,
                       nome: imagemDominio.Nome, 
                       data: imagemDominio.Data is not null ? null : null,
                       bytes: imagemDominio.Data);
        }

        private static List<UI.Model.Imagens.Imagem> ConverterImagemDominio(List<Domain.Imagens.Imagem> imagensDominio)
        {
            List<UI.Model.Imagens.Imagem> imagens = [];

            foreach (Domain.Imagens.Imagem imagem in imagensDominio)
            {
                imagens.Add(ConverterImagemDominio(imagem));
            }

            return imagens;
        }

        #endregion

        #endregion

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
