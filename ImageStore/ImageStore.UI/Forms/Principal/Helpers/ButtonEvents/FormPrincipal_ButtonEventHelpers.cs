using ImageStore.UI.Mensagem;
using ImageStore.UI.Model.Mensagens.Enums;

namespace ImageStore.UI.Forms.Principal.Helpers.ButtonEvents
{
    internal static class FormPrincipal_ButtonEventHelpers
    {
        internal static void Button_EscolherLocal_ClickEvent(this FormPrincipal form)
        {
            try
            {
                form.EscolherImagemLocal();
            }
            catch (Exception ex)
            {
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro ,
                                                  texto: $"Não foi possível escolher a imagem localmente. {ex.Message}"));
            }            
        }
    }
}
