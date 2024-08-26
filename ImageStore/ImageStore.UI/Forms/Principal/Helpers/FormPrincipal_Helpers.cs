using ImageStore.UI.Mensagens;
using ImageStore.UI.Model.Imagens;
using ImageStore.UI.Model.Mensagens.Enums;

namespace ImageStore.UI.Forms.Principal.Helpers
{
    internal static class FormPrincipal_Helpers
    {
        #region Métodos Internos

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

            form.AtualizarEstadoBotoes(isAtivo);
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
            string nomeArquivo = form.OpenFileDialog_EscolherLocal.SafeFileName;
            Image imagem = ObterImagemPorPath(caminhoArquivo);
            form.Imagem = new(nomeArquivo, imagem);
        }

        #endregion

        #region Salvar dados

        internal async static Task InserirImagem(this FormPrincipal form)
        {
            if (form.ObterImagemEscolhida() is not Imagem imagem)
            {
                return;
            }

            using Services.Imagens.Imagem imagemService = new();
            bool isInserida = await imagemService.Inserir(imagem);

            ExibirResultadoInsercao(isInserida);
            form.Imagem = null;
        }

        #endregion

        #endregion

        #region Métodos Privados

        #region Atualizar estado

        private static void AtualizarEstadoBotoes(this FormPrincipal form, bool isAtivo)
        {
            form.Button_Inserir.Enabled =
                isAtivo;
        }

        private static void AtualizarEstadoCampos(this FormPrincipal form, bool isAtivo)
        {
            form.TextBox_NomeImagem.Enabled =
                isAtivo;
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

        #endregion

        #endregion
    }
}
