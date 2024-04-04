namespace EditorTexto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal(bool isNovaJanela = false)
        {
            InitializeComponent();

            if (isNovaJanela)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        #region Eventos do Formulário

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultadoMensagem = MessageBox.Show(
                "Deseja realmente sair?",
                Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                );

            if (resultadoMensagem != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region Menus de Opções

        #region Arquivo

        private void ToolStripMenuItem_Opcoes_Arquivo_Novo_Click(object sender, EventArgs e)
        {
            RichTextBox_Texto.Clear();
        }

        private void ToolStripMenuItem_Opcoes_Arquivo_NovaJanela_Click(object sender, EventArgs e)
        {
            var novaJanelaThread = new Thread(() =>
            {
                Application.Run(new FormPrincipal(true));
            });

            novaJanelaThread.SetApartmentState(ApartmentState.STA);

            novaJanelaThread.Start();
        }

        private void ToolStripMenuItem_Opcoes_Arquivo_Abrir_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Opcoes_Arquivo_Salvar_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Opcoes_Arquivo_SalvarComo_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Opcoes_Arquivo_Fechar_Click(object sender, EventArgs e)
        {
            Close();   
        }

        #endregion

        #region Editar

        #endregion

        #region Formatar

        #endregion

        #region Exibir

        #endregion

        #region Ajuda

        #endregion

        #endregion
    }
}
