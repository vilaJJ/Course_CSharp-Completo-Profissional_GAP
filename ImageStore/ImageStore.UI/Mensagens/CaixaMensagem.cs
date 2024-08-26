using ImageStore.UI.Model.Mensagens.Enums;

namespace ImageStore.UI.Mensagens
{
    public static class CaixaMensagem
    {
        #region Métodos Públicos

        public static DialogResult RealizarDialogo(Model.Mensagens.CaixaMensagem caixaMensagem)
        {
            TipoMensagem tipo = caixaMensagem.Tipo;

            string texto = caixaMensagem.Texto;
            string titulo = caixaMensagem.Titulo ?? tipo.ObterTitulo();
            MessageBoxIcon messageBoxIcon = tipo.ObterIconeMensagem();
            MessageBoxButtons messageBoxButtons = tipo.ObterBotoes();
            MessageBoxDefaultButton messageBoxDefaultButton = tipo.ObterBotaoPadrao();

            return RealizarDialogo(
                texto: texto,
                titulo: titulo,
                botoes: messageBoxButtons,
                icone: messageBoxIcon,
                botaoPadrao: messageBoxDefaultButton
                );
        }

        #endregion

        #region Métodos Privados

        private static DialogResult RealizarDialogo(string? texto,
                                                    string? titulo,
                                                    MessageBoxButtons botoes,
                                                    MessageBoxIcon icone,
                                                    MessageBoxDefaultButton botaoPadrao)
        {
            return MessageBox.Show(
                text: texto,
                caption: titulo,
                buttons: botoes,
                icon: icone,
                defaultButton: botaoPadrao
                );
        }

        private static string ObterTitulo(this TipoMensagem tipoMensagem)
        {
            return tipoMensagem switch
            {
                TipoMensagem.Alerta => "Alerta",
                TipoMensagem.Erro => "Erro",
                TipoMensagem.Informacao => "Informação",
                TipoMensagem.Pergunta => "Pergunta",
                _ => "Mensagem",
            };
        }

        private static MessageBoxIcon ObterIconeMensagem(this TipoMensagem tipoMensagem)
        {
            return (MessageBoxIcon)(int)tipoMensagem;
        }

        private static MessageBoxButtons ObterBotoes(this TipoMensagem tipoMensagem)
        {
            return tipoMensagem switch
            {
                TipoMensagem.Pergunta => MessageBoxButtons.YesNo,
                _ => default,
            };
        }

        private static MessageBoxDefaultButton ObterBotaoPadrao(this TipoMensagem tipoMensagem)
        {
            return tipoMensagem switch
            {
                TipoMensagem.Pergunta => MessageBoxDefaultButton.Button2,
                _ => default,
            };
        }

        #endregion
    }
}
