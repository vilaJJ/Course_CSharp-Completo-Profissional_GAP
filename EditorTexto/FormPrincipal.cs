using EditorTexto.Classes;

namespace EditorTexto
{
    public partial class FormPrincipal : Form
    {
        #region Construtores

        public FormPrincipal(bool isNovaJanela = false)
        {
            InitializeComponent();

            if (isNovaJanela)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        #endregion

        #region Eventos do Formul�rio

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultadoMensagem = MessageBox.Show(
                "Deseja realmente sair?",
                "Editor de Texto",
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

        #region Menus de Op��es

        #region Arquivo

        private void ToolStripMenuItem_Opcoes_Arquivo_Novo_Click(object sender, EventArgs e)
        {
            Gerenciador.RestaurarValoresPadroes();
            RichTextBox_Texto.Clear();
            DefinirTituloJanela();
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
            string? path;

            DialogResult resultadoDialogo = OpenFileDialog_AbrirArquivo.ShowDialog();

            if (resultadoDialogo != DialogResult.OK)
            {
                return;
            }

            path = OpenFileDialog_AbrirArquivo.FileName;

            if (File.Exists(path) is false)
            {
                return;
            }

            AbrirArquivo(path);
        }

        private void ToolStripMenuItem_Opcoes_Arquivo_Salvar_Click(object sender, EventArgs e)
        {
            string? path = null;

            if (Gerenciador.IsArquivoNovo && File.Exists(Gerenciador.DestinoArquivo) is false)
            {
                SaveFileDialog_SalvarArquivo.Title = "Salvar o arquivo...";
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
            string? path;

            SaveFileDialog_SalvarArquivo.Title = "Salvar o arquivo como...";
            SaveFileDialog_SalvarArquivo.FileName = string.Empty;

            var resultadoDialogo = SaveFileDialog_SalvarArquivo.ShowDialog();

            if (resultadoDialogo != DialogResult.OK)
            {
                return;
            }

            path = SaveFileDialog_SalvarArquivo.FileName;
            SalvarArquivo(path);
        }

        private void ToolStripMenuItem_Opcoes_Arquivo_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Editar

        private void ToolStripMenuItem_Opcoes_Editar_Desfazer_Click(object sender, EventArgs e)
        {
            if (RichTextBox_Texto.CanUndo is false)
            {
                return;
            }
            RichTextBox_Texto.Undo();
        }

        private void ToolStripMenuItem_Opcoes_Editar_Refazer_Click(object sender, EventArgs e)
        {
            RichTextBox_Texto.Redo();
        }

        private void ToolStripMenuItem_Opcoes_Editar_Recortar_Click(object sender, EventArgs e)
        {
            RichTextBox_Texto.Cut();
        }

        private void ToolStripMenuItem_Opcoes_Editar_Copiar_Click(object sender, EventArgs e)
        {
            RichTextBox_Texto.Copy();
        }

        private void ToolStripMenuItem_Opcoes_Editar_Colar_Click(object sender, EventArgs e)
        {
            RichTextBox_Texto.Paste();
        }

        private void ToolStripMenuItem_Opcoes_Editar_Excluir_Click(object sender, EventArgs e)
        {
            int selectionStart = RichTextBox_Texto.SelectionStart;
            int selectionLength = RichTextBox_Texto.SelectionLength;

            string textoEditado = RichTextBox_Texto.Text.Remove(
                selectionStart,
                selectionLength
                );

            if (selectionStart > textoEditado.Length)
            {
                selectionStart = textoEditado.Length;
            }

            RichTextBox_Texto.Text = textoEditado;
            RichTextBox_Texto.SelectionStart = selectionStart;
        }

        private void ToolStripMenuItem_Opcoes_Editar_DataHora_Click(object sender, EventArgs e)
        {
            DateTime dataHoraAtual = DateTime.Now;
            string dataHoraAtualFormatada = dataHoraAtual.ToString("dd/MM/yyyy HH:mm:ss");
            int selectionStart = RichTextBox_Texto.SelectionStart;
            string textoEditado = RichTextBox_Texto.Text.Insert(selectionStart, dataHoraAtualFormatada);

            selectionStart += dataHoraAtualFormatada.Length;

            RichTextBox_Texto.Text = textoEditado;
            RichTextBox_Texto.SelectionStart = selectionStart;
        }

        #endregion

        #region Formatar

        private void ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha.Checked;
            RichTextBox_Texto.WordWrap = isChecked is true;
        }

        private void ToolStripMenuItem_Opcoes_Formatar_Fonte_Click(object sender, EventArgs e)
        {
            Font fonteAtual = RichTextBox_Texto.Font;
            Color corAtual = RichTextBox_Texto.ForeColor;

            FontDialog_FonteTexto.Font = fonteAtual;
            FontDialog_FonteTexto.Color = corAtual;

            DialogResult resultadoDialogo = FontDialog_FonteTexto.ShowDialog();

            if (resultadoDialogo is not DialogResult.OK)
            {
                return;
            }

            Font fonteSelecionada = FontDialog_FonteTexto.Font;
            Color corSelecionada = FontDialog_FonteTexto.Color;

            RichTextBox_Texto.Font = fonteSelecionada;
            RichTextBox_Texto.ForeColor = corSelecionada;
        }

        #endregion

        #region Exibir

        #endregion

        #region Ajuda

        #endregion

        #endregion

        #region Caixa de edi��o

        private void RichTextBox_Texto_TextChanged(object sender, EventArgs e)
        {
            if (Gerenciador.IsArquivoSalvo is true)
            {
                Gerenciador.IsArquivoSalvo = false;

                string? path = Gerenciador.IsArquivoNovo is true
                    ? string.Empty
                    : Gerenciador.DestinoArquivo;

                DefinirTituloJanela(path);
            }
        }

        #endregion

        #region Helpers

        private void AbrirArquivo(string path)
        {
            try
            {
                FileInfo infoArquivo = new(path);

                int indexPontoExt = infoArquivo.Name.LastIndexOf('.');

                Gerenciador.PastaDestino = infoArquivo.DirectoryName + @"";
                Gerenciador.NomeArquivo = infoArquivo.Name.Remove(indexPontoExt);
                Gerenciador.NomeExtensao = infoArquivo.Extension.Remove(0, 1);

                using StreamReader leitor = new(path);

                string textoArquivo = leitor.ReadToEnd();

                DefinirTextoEditor(textoArquivo);

                Gerenciador.IsArquivoNovo = false;
                Gerenciador.IsArquivoSalvo = true;

                DefinirTituloJanela(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "N�o foi poss�vel abrir o arquivo.\n\n" + ex.Message,
                    "Abrir o arquivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void SalvarArquivo(string? path = null)
        {
            path ??= Gerenciador.DestinoArquivo;

            try
            {
                var documento = RichTextBox_Texto.Text;

                // Respons�vel por escrever o arquivo
                using StreamWriter escritor = new(path, false);

                escritor.Write(documento);

                Gerenciador.IsArquivoNovo = false;
                Gerenciador.IsArquivoSalvo = true;

                AtualizarArquivoEmUso(path);
                DefinirTituloJanela(path);

                OpenFileDialog_AbrirArquivo.FileName = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   "N�o foi poss�vel salvar o arquivo.\n\n" + ex.Message,
                   "Salvar o arquivo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
            }
        }

        private void DefinirTituloJanela(string? path = null)
        {
            string nomeAplicacao = "Editor de Texto";

            if (path is null)
            {
                Text = nomeAplicacao;
                return;
            }

            Text = string.Format(
                "{0}{1}{2}",
                nomeAplicacao,
                Gerenciador.IsArquivoSalvo is true ? string.Empty : " (n�o salvo)",
                string.IsNullOrWhiteSpace(path) ? string.Empty : $" - {path}"
                );
        }

        private void DefinirTextoEditor(string texto)
        {
            RichTextBox_Texto.Text = texto;
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
