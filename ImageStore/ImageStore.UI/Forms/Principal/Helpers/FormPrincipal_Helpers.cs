using ImageStore.UI.Forms.RecuperarImagemBanco;
using ImageStore.UI.Mensagens;
using ImageStore.UI.Model.Imagens;
using ImageStore.UI.Model.Mensagens.Enums;

namespace ImageStore.UI.Forms.Principal.Helpers
{
    internal static class FormPrincipal_Helpers
    {
        #region Métodos Internos

        #region Abrir formulário

        internal static void AbrirFormularioRecuperarImagemBanco(this FormPrincipal form)
        {
            using FormRecuperarImagemBanco formRecuperarImagemBanco = new();
            formRecuperarImagemBanco.ShowDialog();

            form.BringToFront();
        }

        #endregion

        #region Atualizar dados

        internal static void AlterarNomeImagem(this FormPrincipal form)
        {
            string nome = form.TextBox_NomeImagem.Text;

            if (form.Imagem is Imagem imagem)
            {
                imagem.Nome = nome;
            }
        }

        #endregion

        #region Atualizar estado

        internal static void AtualizarEstados(this FormPrincipal form)
        {
            bool isAtivo = form.Imagem is not null;

            form.AtualizarBotaoInserir(isAtivo);
            form.AtualizarEstadoCampos(isAtivo);
        }

        #endregion

        #region Controlar componentes

        internal static void ExibirImagem(this FormPrincipal form)
        {
            Imagem? imagem = form.Imagem;

            form.ExibirImagem(imagem?.Data);
            form.ExibirNomeArquivo(imagem?.Nome);
        }        

        #endregion

        #region Diálogos

        internal static void EscolherImagemLocal(this FormPrincipal form)
        {
            DialogResult resultadoDialogo = form.OpenFileDialog_EscolherLocal.ShowDialog();

            if (resultadoDialogo is not DialogResult.OK)
            {
                return;
            }

            string caminhoArquivo = form.OpenFileDialog_EscolherLocal.FileName;

            if (ValidarTamanhoArquivo(caminhoArquivo) is false)
            {
                form.EscolherImagemLocal();
                return;
            }

            string nomeArquivo = form.OpenFileDialog_EscolherLocal.SafeFileName;
            Image imagem = ObterImagemPorPath(caminhoArquivo);

            form.Imagem = new(caminhoArquivo, nomeArquivo, imagem);
        }

        #endregion

        #region Salvar dados

        internal async static Task InserirImagem(this FormPrincipal form)
        {
            if (form.ObterImagemEscolhida() is not Imagem imagem)
            {
                return;
            }

            bool? isInserida = null;

            try
            {
                form.ExibirCarregamento(true);

                {
                    using Services.Imagens.Imagem imagemService = new();
                    isInserida = await imagemService.Inserir(imagem);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                form.ExibirCarregamento(false);

                if (isInserida is bool isImagemInserida)
                {
                    ExibirResultadoInsercao(isImagemInserida);
                    form.Imagem = null;
                }
            }            
        }

        #endregion

        #endregion

        #region Métodos Privados

        #region Atualizar estado

        private static void AtualizarBotaoInserir(this FormPrincipal form, bool isAtivo)
        {
            form.Button_Inserir.Enabled =
                isAtivo;
        }

        private static void AtualizarEstadoBotoes(this FormPrincipal form, bool isAtivo)
        {
            form.Button_EscolherLocal.Enabled =
            form.Button_RecuperarDoBanco.Enabled =
                isAtivo;

            form.AtualizarBotaoInserir(isAtivo);
        }

        private static void AtualizarEstadoCampos(this FormPrincipal form, bool isAtivo)
        {
            form.TextBox_NomeImagem.Enabled =
                isAtivo;
        }

        private static void AtualizarEstadoProgresso(this FormPrincipal form, bool isCarregando)
        {
            form.ProgressBar_Progresso.Enabled =
            form.ProgressBar_Progresso.Visible =
                isCarregando;
        }

        private static void RealizarInvoke(this FormPrincipal form, Action action)
        {
            if (form.InvokeRequired is true)
            {
                form.Invoke(action);
            }
            else
            {
                action();
            }
        }

        #endregion

        #region Controlar Componentes

        private static void ExibirImagem(this FormPrincipal form, Image? imagem)
        {
            form.PictureBox_ImagemSelecionada.Image = imagem;
        }

        private static void ExibirNomeArquivo(this FormPrincipal form, string? nome)
        {
            form.TextBox_NomeImagem.Text = nome;
        }

        private static void ExibirCarregamento(this FormPrincipal form, bool isCarregando)
        {
            bool isAtivo = isCarregando is false;

            form.RealizarInvoke(() =>
            {
                form.AtualizarEstadoCampos(isAtivo);
                form.AtualizarEstadoBotoes(isAtivo);
                form.AtualizarEstadoProgresso(isCarregando);
            });
        }

        #endregion

        #region Diálogos

        private static void ExibirResultadoInsercao(bool isInserido)
        {
            TipoMensagem tipoMensagem;
            string mensagem;

            if (isInserido is true)
            {
                tipoMensagem = TipoMensagem.Informacao;
                mensagem = "Imagem inserida com sucesso.";
            }
            else
            {
                tipoMensagem = TipoMensagem.Alerta;
                mensagem = "Não foi possivel inserir a imagem. Tente novamente mais tarde.";
            }

            CaixaMensagem.RealizarDialogo(new(tipoMensagem, mensagem));
        }

        #endregion

        #region Obter arquivos

        private static Image ObterImagemPorPath(string path)
        {
            return Image.FromFile(path);
        }

        #endregion

        #region Obter dados

        private static Imagem? ObterImagemEscolhida(this FormPrincipal form)
        {
            Imagem? imagem = form.Imagem;

            if (imagem is null)
            {
                CaixaMensagem.RealizarDialogo(new(TipoMensagem.Alerta,
                                                  "Escolha uma imagem para ser inserida."));
            }

            return imagem;
        }

        private static FileInfo ObterArquivoPorCaminho(string caminhoArquivo)
        {
            return new FileInfo(caminhoArquivo);
        }

        private static long ObterQuantidadeBytesArquivo(FileInfo informacoesArquivo)
        {
            return informacoesArquivo.Length;
        }

        #endregion

        #region Validações

        private static bool ValidarTamanhoArquivo(string caminhoArquivo)
        {
            FileInfo informacoesArquivo = ObterArquivoPorCaminho(caminhoArquivo);
            long quantidadeBytes = ObterQuantidadeBytesArquivo(informacoesArquivo);

            bool isValido = quantidadeBytes <= 15000000;

            if (isValido is false)
            {
                CaixaMensagem.RealizarDialogo(new(TipoMensagem.Alerta,
                                                  "O tamanho máximo da imagem deve ser de 15mb. Escolha uma imagem válida."));
            }

            return isValido;
        }

        #endregion

        #endregion
    }
}
