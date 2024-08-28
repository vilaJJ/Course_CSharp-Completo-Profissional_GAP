using ImageStore.UI.Mensagens;
using ImageStore.UI.Model.Mensagens.Enums;

namespace ImageStore.UI.Forms.RecuperarImagemBanco.Helpers.FormEvents
{
    internal static class FormRecuperarImagemBanco_FormEventHelpers
    {
        internal static async Task ShownEvent(this FormRecuperarImagemBanco form)
        {
			try
			{
                await form.InicializarFormulario();
			}
			catch (Exception ex)
			{
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro,
                                                  texto: $"Não foi possível inicializar os dados necessários. {ex.Message}"));
                form.FecharFormulario();
            }
        }
    }
}
