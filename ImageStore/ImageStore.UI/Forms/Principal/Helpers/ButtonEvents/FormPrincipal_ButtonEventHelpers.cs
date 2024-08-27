using ImageStore.UI.Mensagens;
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

        internal static async Task Button_Inserir_ClickEvent(this FormPrincipal form)
        {
            try
            {
                await form.InserirImagem();
            }
            catch (Exception ex)
            {
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro,
                                                  texto: $"Não foi possível inserir a imagem. {ex.Message}"));
            }
        }

        internal static void Button_RecuperarDoBanco_ClickEvent(this FormPrincipal form)
        {
            try
            {
                form.AbrirFormularioRecuperarImagemBanco();
            }
            catch (Exception ex)
            {
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro,
                                                  texto: $"Falha na exibição do módulo de recuperação de imagem no banco. {ex.Message}"));
            }
        }
    }
}
