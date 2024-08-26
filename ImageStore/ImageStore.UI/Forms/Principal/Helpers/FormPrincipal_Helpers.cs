using ImageStore.UI.Model.Imagens;

namespace ImageStore.UI.Forms.Principal.Helpers
{
    internal static class FormPrincipal_Helpers
    {
        #region Métodos Internos

        #region Atualizar Estado

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
            if (form.Imagem is not Imagem imagem)
            {
                return;
            }

            form.ExibirImagem(imagem.Data);
            form.ExibirNomeArquivo(imagem.Nome);
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

        #endregion

        #region Métodos Privados

        #region Atualizar Estado

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

        private static void ExibirImagem(this FormPrincipal form, Image imagem)
        {
            form.PictureBox_ImagemSelecionada.Image = imagem;
        }

        private static void ExibirNomeArquivo(this FormPrincipal form, string nome)
        {
            form.TextBox_NomeImagem.Text = nome;
        }

        #endregion

        #region Obter arquivos

        private static Image ObterImagemPorPath(string path)
        {
            return Image.FromFile(path);
        }

        #endregion

        #endregion
    }
}
