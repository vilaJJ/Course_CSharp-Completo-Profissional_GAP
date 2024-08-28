using ImageStore.UI.Forms.RecuperarImagemBanco.Helpers.BindingSourceEvents;
using ImageStore.UI.Forms.RecuperarImagemBanco.Helpers.ButtonEvents;
using ImageStore.UI.Forms.RecuperarImagemBanco.Helpers.FormEvents;
using ImageStore.UI.Forms.RecuperarImagemBanco.Helpers.LabelEvents;
using System.ComponentModel;

namespace ImageStore.UI.Forms.RecuperarImagemBanco
{
    internal partial class FormRecuperarImagemBanco : Form
    {
        #region Construtores

        internal FormRecuperarImagemBanco()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Events

        private async void FormRecuperarImagemBanco_Shown(object sender, EventArgs e) =>
            await this.ShownEvent();

        #endregion

        #region Button Events

        private void Button_Salvar_Click(object sender, EventArgs e) =>
            this.Button_Salvar_ClickEvent();

        private void Button_Excluir_Click(object sender, EventArgs e) =>
            this.Button_Excluir_ClickEvent();

        #endregion

        #region BindingSource Events

        private async void BindingSource_Imagens_CurrentChanged(object sender, EventArgs e) =>
            await this.BindingSource_Imagens_CurrentChangedEvent();

        private void BindingSource_Imagens_ListChanged(object sender, ListChangedEventArgs e) =>
            this.BindingSource_Imagens_ListChangedEvent();

        #endregion

        #region Label Events

        private void Label_Imagem_Codigo_TextChanged(object sender, EventArgs e) =>
            this.Label_Imagem_Codigo_TextChangedEvent();

        private void Label_Imagem_Tamanho_TextChanged(object sender, EventArgs e) =>
            this.Label_Imagem_Tamanho_TextChangedEvent();

        #endregion
    }
}
