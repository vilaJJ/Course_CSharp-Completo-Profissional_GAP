using EditorTexto.Classes;

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
            string? path = null;

            if (File.Exists(Gerenciador.DestinoArquivo) is false)
            {
                SaveFileDialog_SalvarArquivo.FileName = string.Empty;

                var resultadoDialogo = SaveFileDialog_SalvarArquivo.ShowDialog();

                if (resultadoDialogo != DialogResult.OK)
                {                    
                    return;
                }

                path = SaveFileDialog_SalvarArquivo.FileName;
            }

            SalvarArquivo(path);
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

        #region Helpers

        private void SalvarArquivo(string? path = null)
        {
            path ??= Gerenciador.DestinoArquivo;

            try
            {
                var documento = RichTextBox_Texto.Text;

                // Responsável por escrever o arquivo
                using StreamWriter escritor = new(path, false);

                escritor.Write(documento);

                AtualizarArquivoEmUso(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   "Não foi possível salvar o arquivo.\n\n" + ex.Message,
                   "Salvar o arquivo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
            }
        }

        private static void AtualizarArquivoEmUso(string path)
        {
            var informacoes = new FileInfo(path);

            if (informacoes.DirectoryName is string pastaDestino)
            {
                Gerenciador.PastaDestino = pastaDestino;
            }

            Gerenciador.NomeArquivo = informacoes.Name.Remove(informacoes.Name.LastIndexOf('.'));
            Gerenciador.NomeExtensao = informacoes.Extension[1..];
        }

        #endregion
    }
}
