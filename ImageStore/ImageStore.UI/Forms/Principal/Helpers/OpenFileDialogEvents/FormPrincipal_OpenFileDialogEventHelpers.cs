using ImageStore.UI.Mensagens;
using ImageStore.UI.Model.Mensagens.Enums;
using System.ComponentModel;

namespace ImageStore.UI.Forms.Principal.Helpers.OpenFileDialogEvents
{
    internal static class FormPrincipal_OpenFileDialogEventHelpers
    {
        internal static void OpenFileDialog_EscolherLocal_FileOkEvent(this FormPrincipal form, CancelEventArgs eventArgs)
        {
            bool? isValido = null;

            try
            {
                isValido = form.ValidarExtensaoArquivoSelecionado();

                if (isValido is false)
                {
                    CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Alerta,
                                                  texto: $"A extensão do arquivo selecionado não é válido."));
                }
            }
            catch (Exception ex)
            {
                CaixaMensagem.RealizarDialogo(new(tipo: TipoMensagem.Erro,
                                                  texto: $"Não foi possível validar se a extensão da imagem é válida. {ex.Message}"));
            }
            finally
            {
                eventArgs.Cancel = isValido is false;
            }            
        }
    }
}
