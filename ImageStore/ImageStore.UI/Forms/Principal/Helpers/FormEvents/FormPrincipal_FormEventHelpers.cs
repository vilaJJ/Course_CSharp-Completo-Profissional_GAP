using ImageStore.UI.Mensagens;
using ImageStore.UI.Model.Mensagens.Enums;

namespace ImageStore.UI.Forms.Principal.Helpers.FormEvents
{
    internal static class FormPrincipal_FormEventHelpers
    {
        internal static void LoadEvent(this FormPrincipal form)
        {
			try
			{
                form.InicializarFormulario();
			}
			catch (Exception ex)
			{
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro,
                                                  texto: $"Não foi possível inicializar as configurações. {ex.Message}"));
                form.FecharFormulario();
            }
        }
    }
}
