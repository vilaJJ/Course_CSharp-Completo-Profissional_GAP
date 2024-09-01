using ImageStore.UI.Mensagens;
using ImageStore.UI.Model.Mensagens.Enums;
using ImageStore.Utilities.Converters.Arquivos;

namespace ImageStore.UI.Forms.RecuperarImagemBanco.Helpers
{
    internal static class FormRecuperarImagemBanco_Helpers
    {
        #region Métodos Internos

        #region Ações de formulário

        internal static void FecharFormulario(this FormRecuperarImagemBanco form)
        {
            form.RealizarInvoke(form.Close);
        }

        #endregion

        #region Atualizar exibições

        internal static async Task AlterarImagemVisualizacao(this FormRecuperarImagemBanco form)
        {
            form.ControlarIndicadorCarregamento(true);

            try
            {
                Model.Imagens.Imagem imagemSelecionada = form.ObterImagemSelecionada();
                Model.Imagens.Imagem? imagem = await BuscarImagem(imagemSelecionada.Codigo);

                if (imagem is null)
                {
                    CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Alerta,
                                                      texto: "Não foi encontrada a imagem selecionada. Talvez ela tenha sido removida do Banco de Dados."));
                    form.RemoverItemSelecionado();
                    return;
                }

                form.ExibirImagem(imagem);
            }
            finally
            {
                form.ControlarIndicadorCarregamento(false);
            }            
        }

        #endregion

        #region Controles de componentes

        internal static void ControlarAtivacaoBotoesAcaoImagem(this FormRecuperarImagemBanco form)
        {
            bool isAtivo = form.BindingSource_Imagens.Count is not 0;

            form.Button_Salvar.Enabled =
            form.Button_Excluir.Enabled =
                isAtivo;
        }

        internal static void ControlarIndicadorCarregamento(this FormRecuperarImagemBanco form, bool isCarregando)
        {
            form.PictureBox_CarregandoAcao.Visible = isCarregando;
        }

        #endregion

        #region Excluir dados

        internal static async Task ExcluirImagemSelecionada(this FormRecuperarImagemBanco form)
        {
            Model.Imagens.Imagem imagemSelecionada = form.ObterImagemSelecionada();

            if (imagemSelecionada.Codigo is not Guid codigo)
            {
                throw new NullReferenceException("A imagem não possuí um código.");
            }

            bool? isExcluida = null;
            bool existeImagemNoBanco = await IsImagemExisteBanco(codigo);

            TipoMensagem tipoMensagem;
            string mensagem;

            if (existeImagemNoBanco is false)
            {
                tipoMensagem = TipoMensagem.Alerta;
                mensagem = "Não foi encontrada a imagem selecionada. Talvez ela tenha sido removida do Banco de Dados.";                
            }
            else
            {
                isExcluida = await ExcluirImagem(codigo);

                if (isExcluida is true)
                {
                    tipoMensagem = TipoMensagem.Informacao;
                    mensagem = "Imagem excluída com sucesso.";
                }
                else
                {
                    tipoMensagem = TipoMensagem.Alerta;
                    mensagem = "A imagem selecionada não foi excluída. Tente novamente mais tarde.";
                }
            }

            if (existeImagemNoBanco is false || isExcluida is true)
            {
                form.RemoverItemSelecionado();
            }

            CaixaMensagem.RealizarDialogo(new(tipo: tipoMensagem,
                                              texto: mensagem));
        }

        #endregion

        #region Inicializações

        internal static async Task InicializarFormulario(this FormRecuperarImagemBanco form)
        {
            await form.PopularBindingSource();
            form.ValidarSeHaImagens();
        }

        #endregion

        #region Salvar dados

        internal static void SalvarImagemSelecionada(this FormRecuperarImagemBanco form)
        {

        }

        #endregion

        #endregion

        #region Métodos Privados

        #region Controle de formulário

        private static void RealizarInvoke(this FormRecuperarImagemBanco form, Action action)
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

        #region Exibir dados

        private static void ExibirImagem(this FormRecuperarImagemBanco form, Model.Imagens.Imagem? imagem)
        {
            form.PictureBox_ImagemSelecionada.Image = imagem?.Data;
            form.Label_Imagem_Codigo.Text = imagem?.Codigo?.ToString();
            form.Label_Imagem_Tamanho.Text = ObterTamanhoArquivoFormatado(imagem?.Bytes?.Length);
        }

        #endregion

        #region Excluir dados

        private static async Task<bool> ExcluirImagem(Guid id)
        {
            {
                using Services.Imagens.Imagem imagemService = new();
                return await imagemService.Excluir(id);
            }
        }

        #endregion

        #region Inicializar dados

        private static async Task PopularBindingSource(this FormRecuperarImagemBanco form)
        {
            List<Model.Imagens.Imagem> imagens = await ObterDadosImagens();
            form.RealizarInvoke(() => form.BindingSource_Imagens.DataSource = imagens);
        }

        #endregion

        #region Obter dados

        private static async Task<List<Model.Imagens.Imagem>> ObterDadosImagens()
        {
            {
                using Services.Imagens.Imagem imagemService = new();
                return await imagemService.ObterDadosImagens();
            }
        }

        private static async Task<Model.Imagens.Imagem?> BuscarImagem(Guid? codigo)
        {
            if (codigo is null)
            {
                return null;
            }

            {
                using Services.Imagens.Imagem imagemService = new();
                return await imagemService.Buscar((Guid)codigo);
            }
        }

        private static Model.Imagens.Imagem ObterImagemSelecionada(this FormRecuperarImagemBanco form)
        {
            return (Model.Imagens.Imagem)form.BindingSource_Imagens.Current;
        }

        private static string ObterTamanhoArquivoFormatado(int? quantidadeBytes)
        {
            if (quantidadeBytes is null)
            {
                return "Tamanho desconhecido";
            }

            return ArquivosConverter.ObterTamanhoApresentavel((int)quantidadeBytes);
        }

        #endregion

        #region Remover itens

        private static void RemoverItemSelecionado(this FormRecuperarImagemBanco form)
        {
            form.BindingSource_Imagens.RemoveCurrent();
        }

        #endregion

        #region Validações

        private static void ValidarSeHaImagens(this FormRecuperarImagemBanco form)
        {
            int quantidadeItens = form.BindingSource_Imagens.Count;

            if (quantidadeItens is 0)
            {
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Alerta,
                                                  texto: "Não existem imagens salvas no Banco de Dados."));
                form.FecharFormulario();
            }
        }

        private static async Task<bool> IsImagemExisteBanco(Guid codigo)
        {
            {
                using Services.Imagens.Imagem imagemService = new();
                return await imagemService.Existe(codigo);
            }
        }

        #endregion

        #endregion
    }
}
