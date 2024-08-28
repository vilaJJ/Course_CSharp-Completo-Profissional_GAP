using ImageStore.UI.Mensagens;
using ImageStore.UI.Model.Mensagens.Enums;

namespace ImageStore.UI.Forms.RecuperarImagemBanco.Helpers.ButtonEvents
{
    internal static class FormRecuperarImagemBanco_ButtonEventHelpers
    {
        internal static void Button_Salvar_ClickEvent(this FormRecuperarImagemBanco form)
        {
            try
            {
                form.SalvarImagemSelecionada();
            }
            catch (Exception ex)
            {
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro,
                                                  texto: $"Não foi possível salvar a imagem selecionada. {ex.Message}"));
            }
        }

        internal static void Button_Excluir_ClickEvent(this FormRecuperarImagemBanco form)
        {
            try
            {
                form.ExcluirImagemSelecionada();
            }
            catch (Exception ex)
            {
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro,
                                                  texto: $"Não foi possível excluir a imagem selecionada. {ex.Message}"));
            }
        }
    }
}
