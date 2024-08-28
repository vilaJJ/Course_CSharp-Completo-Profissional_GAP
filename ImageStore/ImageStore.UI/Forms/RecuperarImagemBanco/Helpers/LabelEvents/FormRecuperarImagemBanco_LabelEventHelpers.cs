namespace ImageStore.UI.Forms.RecuperarImagemBanco.Helpers.LabelEvents
{
    internal static class FormRecuperarImagemBanco_LabelEventHelpers
    {
        internal static void Label_Imagem_Codigo_TextChangedEvent(this FormRecuperarImagemBanco form)
        {
            form.Label_Imagem_Codigo.Visible = form.Label_Imagem_Codigo.Text is not null;
        }

        internal static void Label_Imagem_Tamanho_TextChangedEvent(this FormRecuperarImagemBanco form)
        {
            form.Label_Imagem_Tamanho.Visible = form.Label_Imagem_Tamanho.Text is not null;
        }
    }
}
