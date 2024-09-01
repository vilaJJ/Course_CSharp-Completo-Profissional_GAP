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

        internal static async Task Button_Excluir_ClickEvent(this FormRecuperarImagemBanco form)
        {
            try
            {
                DialogResult resultadoDialogo = 
                    CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Pergunta,
                                                      texto: "Tem certeza de que deseja apagar a imagem selecionada?"));

                if (resultadoDialogo is not DialogResult.Yes)
                {
                    return;
                }

                await form.ExcluirImagemSelecionada();
            }
            catch (Exception ex)
            {
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro,
                                                  texto: $"Não foi possível excluir a imagem selecionada. {ex.Message}"));
            }
        }
    }
}
