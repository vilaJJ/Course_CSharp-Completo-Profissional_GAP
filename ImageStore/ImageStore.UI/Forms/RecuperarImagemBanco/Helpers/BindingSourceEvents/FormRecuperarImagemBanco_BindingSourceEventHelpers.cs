using ImageStore.UI.Mensagens;
using ImageStore.UI.Model.Mensagens.Enums;

namespace ImageStore.UI.Forms.RecuperarImagemBanco.Helpers.BindingSourceEvents
{
    internal static class FormRecuperarImagemBanco_BindingSourceEventHelpers
    {
        internal static async Task BindingSource_Imagens_CurrentChangedEvent(this FormRecuperarImagemBanco form)
        {
			try
			{
                await form.AlterarImagemVisualizacao();
			}
			catch (Exception ex)
			{
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro,
                                                  texto: $"Não foi exibir os dados do item selecionado da imagem selecionada na lista. {ex.Message}"));
                form.FecharFormulario();
            }
        }

        internal static void BindingSource_Imagens_ListChangedEvent(this FormRecuperarImagemBanco form)
        {
            try
            {
                form.ControlarAtivacaoBotoesAcaoImagem();
            }
            catch (Exception ex)
            {
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro,
                                                  texto: $"Não foi controlar a ativação dos controles de imagem. {ex.Message}"));
                form.FecharFormulario();
            }
        }
    }
}
