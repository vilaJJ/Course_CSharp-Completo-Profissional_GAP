using ImageStore.UI.Forms.Principal.Helpers;
using ImageStore.UI.Forms.Principal.Helpers.ButtonEvents;
using ImageStore.UI.Forms.Principal.Helpers.TextBoxEvents;
using ImageStore.UI.Model.Imagens;

namespace ImageStore.UI.Forms.Principal
{
    public partial class FormPrincipal : Form
    {
        #region Campos

        private Imagem? imagem;

        #endregion

        #region Propriedades

        internal Imagem? Imagem
        {
            get
            {
                return imagem;
            }
            set
            {
                imagem = value;

                this.ExibirImagem();
                this.AtualizarEstados();
            }
        }

        #endregion

        #region Construtores

        public FormPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Button Events

        private void Button_EscolherLocal_Click(object sender, EventArgs e) =>
            this.Button_EscolherLocal_ClickEvent();

        private async void Button_Inserir_Click(object sender, EventArgs e) =>
            await this.Button_Inserir_ClickEvent();

        private void Button_RecuperarDoBanco_Click(object sender, EventArgs e) =>
            this.Button_RecuperarDoBanco_ClickEvent();

        #endregion

        #region TextBox Events

        private void TextBox_NomeImagem_TextChanged(object sender, EventArgs e) =>
            this.TextBox_NomeImagem_TextChangedEvent();

        #endregion
    }
}
