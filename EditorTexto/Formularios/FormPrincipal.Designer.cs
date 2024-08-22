namespace EditorTexto.Formularios
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            MenuStrip_Opcoes = new MenuStrip();
            ToolStripMenuItem_Opcoes_Arquivo = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Arquivo_Novo = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Arquivo_NovaJanela = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Arquivo_Separador1 = new ToolStripSeparator();
            ToolStripMenuItem_Opcoes_Arquivo_Abrir = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Arquivo_Salvar = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Arquivo_SalvarComo = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Arquivo_Separador2 = new ToolStripSeparator();
            ToolStripMenuItem_Opcoes_Arquivo_Fechar = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Editar = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Editar_Desfazer = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Editar_Refazer = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Editar_Separador1 = new ToolStripSeparator();
            ToolStripMenuItem_Opcoes_Editar_Recortar = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Editar_Copiar = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Editar_Colar = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Editar_Excluir = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Editar_Separador2 = new ToolStripSeparator();
            ToolStripMenuItem_Opcoes_Editar_DataHora = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Formatar = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Formatar_Fonte = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Exibir = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Exibir_Zoom = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Separador1 = new ToolStripSeparator();
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Restaurar = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Exibir_BarraStatus = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Ajuda = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Ajuda_Exibir = new ToolStripMenuItem();
            ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma = new ToolStripMenuItem();
            StatusStrip_Status = new StatusStrip();
            ToolStripStatusLabel_Status_Zoom = new ToolStripStatusLabel();
            RichTextBox_Texto = new RichTextBox();
            SaveFileDialog_SalvarArquivo = new SaveFileDialog();
            OpenFileDialog_AbrirArquivo = new OpenFileDialog();
            FontDialog_FonteTexto = new FontDialog();
            Process_AbrirAjuda = new System.Diagnostics.Process();
            ToolStrip_BarraFerramentas = new ToolStrip();
            ToolStripButton_BarraFerramenta_NovoDocumento = new ToolStripButton();
            ToolStripButton_BarraFerramenta_NovaJanela = new ToolStripButton();
            ToolStripButton_BarraFerramenta_AbrirArquivo = new ToolStripButton();
            ToolStripButton_BarraFerramenta_SalvarArquivo = new ToolStripButton();
            ToolStripSeparator_BarraFerramentas_1 = new ToolStripSeparator();
            ToolStripButton_BarraFerramenta_DataHoraAtual = new ToolStripButton();
            ToolStripSeparator_BarraFerramentas_2 = new ToolStripSeparator();
            ToolStripButton_BarraFerramenta_SelecionarFonte = new ToolStripButton();
            ToolStripSeparator_BarraFerramentas_3 = new ToolStripSeparator();
            ToolStripButton_BarraFerramenta_AumentarZoom = new ToolStripButton();
            ToolStripButton_BarraFerramenta_ReduzirZoom = new ToolStripButton();
            ToolStripButton_BarraFerramenta_RestaurarZoom = new ToolStripButton();
            MenuStrip_Opcoes.SuspendLayout();
            StatusStrip_Status.SuspendLayout();
            ToolStrip_BarraFerramentas.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip_Opcoes
            // 
            MenuStrip_Opcoes.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_Opcoes_Arquivo, ToolStripMenuItem_Opcoes_Editar, ToolStripMenuItem_Opcoes_Formatar, ToolStripMenuItem_Opcoes_Exibir, ToolStripMenuItem_Opcoes_Ajuda });
            MenuStrip_Opcoes.Location = new Point(0, 0);
            MenuStrip_Opcoes.Name = "MenuStrip_Opcoes";
            MenuStrip_Opcoes.Size = new Size(784, 24);
            MenuStrip_Opcoes.TabIndex = 0;
            MenuStrip_Opcoes.Text = "Menu de opções";
            // 
            // ToolStripMenuItem_Opcoes_Arquivo
            // 
            ToolStripMenuItem_Opcoes_Arquivo.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Opcoes_Arquivo_Novo, ToolStripMenuItem_Opcoes_Arquivo_NovaJanela, ToolStripMenuItem_Opcoes_Arquivo_Separador1, ToolStripMenuItem_Opcoes_Arquivo_Abrir, ToolStripMenuItem_Opcoes_Arquivo_Salvar, ToolStripMenuItem_Opcoes_Arquivo_SalvarComo, ToolStripMenuItem_Opcoes_Arquivo_Separador2, ToolStripMenuItem_Opcoes_Arquivo_Fechar });
            ToolStripMenuItem_Opcoes_Arquivo.Name = "ToolStripMenuItem_Opcoes_Arquivo";
            ToolStripMenuItem_Opcoes_Arquivo.Size = new Size(61, 20);
            ToolStripMenuItem_Opcoes_Arquivo.Text = "&Arquivo";
            // 
            // ToolStripMenuItem_Opcoes_Arquivo_Novo
            // 
            ToolStripMenuItem_Opcoes_Arquivo_Novo.Image = Properties.Resources.new_document;
            ToolStripMenuItem_Opcoes_Arquivo_Novo.Name = "ToolStripMenuItem_Opcoes_Arquivo_Novo";
            ToolStripMenuItem_Opcoes_Arquivo_Novo.ShortcutKeys = Keys.Control | Keys.N;
            ToolStripMenuItem_Opcoes_Arquivo_Novo.Size = new Size(211, 22);
            ToolStripMenuItem_Opcoes_Arquivo_Novo.Text = "&Novo";
            ToolStripMenuItem_Opcoes_Arquivo_Novo.Click += ToolStripMenuItem_Opcoes_Arquivo_Novo_Click;
            // 
            // ToolStripMenuItem_Opcoes_Arquivo_NovaJanela
            // 
            ToolStripMenuItem_Opcoes_Arquivo_NovaJanela.Image = Properties.Resources.notes;
            ToolStripMenuItem_Opcoes_Arquivo_NovaJanela.Name = "ToolStripMenuItem_Opcoes_Arquivo_NovaJanela";
            ToolStripMenuItem_Opcoes_Arquivo_NovaJanela.ShortcutKeys = Keys.Control | Keys.Alt | Keys.N;
            ToolStripMenuItem_Opcoes_Arquivo_NovaJanela.Size = new Size(211, 22);
            ToolStripMenuItem_Opcoes_Arquivo_NovaJanela.Text = "N&ova janela";
            ToolStripMenuItem_Opcoes_Arquivo_NovaJanela.Click += ToolStripMenuItem_Opcoes_Arquivo_NovaJanela_Click;
            // 
            // ToolStripMenuItem_Opcoes_Arquivo_Separador1
            // 
            ToolStripMenuItem_Opcoes_Arquivo_Separador1.Name = "ToolStripMenuItem_Opcoes_Arquivo_Separador1";
            ToolStripMenuItem_Opcoes_Arquivo_Separador1.Size = new Size(208, 6);
            // 
            // ToolStripMenuItem_Opcoes_Arquivo_Abrir
            // 
            ToolStripMenuItem_Opcoes_Arquivo_Abrir.Image = Properties.Resources.folder;
            ToolStripMenuItem_Opcoes_Arquivo_Abrir.Name = "ToolStripMenuItem_Opcoes_Arquivo_Abrir";
            ToolStripMenuItem_Opcoes_Arquivo_Abrir.ShortcutKeys = Keys.Control | Keys.O;
            ToolStripMenuItem_Opcoes_Arquivo_Abrir.Size = new Size(211, 22);
            ToolStripMenuItem_Opcoes_Arquivo_Abrir.Text = "&Abrir";
            ToolStripMenuItem_Opcoes_Arquivo_Abrir.Click += ToolStripMenuItem_Opcoes_Arquivo_Abrir_Click;
            // 
            // ToolStripMenuItem_Opcoes_Arquivo_Salvar
            // 
            ToolStripMenuItem_Opcoes_Arquivo_Salvar.Image = Properties.Resources.save;
            ToolStripMenuItem_Opcoes_Arquivo_Salvar.Name = "ToolStripMenuItem_Opcoes_Arquivo_Salvar";
            ToolStripMenuItem_Opcoes_Arquivo_Salvar.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItem_Opcoes_Arquivo_Salvar.Size = new Size(211, 22);
            ToolStripMenuItem_Opcoes_Arquivo_Salvar.Text = "&Salvar";
            ToolStripMenuItem_Opcoes_Arquivo_Salvar.Click += ToolStripMenuItem_Opcoes_Arquivo_Salvar_Click;
            // 
            // ToolStripMenuItem_Opcoes_Arquivo_SalvarComo
            // 
            ToolStripMenuItem_Opcoes_Arquivo_SalvarComo.Image = Properties.Resources.save;
            ToolStripMenuItem_Opcoes_Arquivo_SalvarComo.Name = "ToolStripMenuItem_Opcoes_Arquivo_SalvarComo";
            ToolStripMenuItem_Opcoes_Arquivo_SalvarComo.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            ToolStripMenuItem_Opcoes_Arquivo_SalvarComo.Size = new Size(211, 22);
            ToolStripMenuItem_Opcoes_Arquivo_SalvarComo.Text = "Salvar &como";
            ToolStripMenuItem_Opcoes_Arquivo_SalvarComo.Click += ToolStripMenuItem_Opcoes_Arquivo_SalvarComo_Click;
            // 
            // ToolStripMenuItem_Opcoes_Arquivo_Separador2
            // 
            ToolStripMenuItem_Opcoes_Arquivo_Separador2.Name = "ToolStripMenuItem_Opcoes_Arquivo_Separador2";
            ToolStripMenuItem_Opcoes_Arquivo_Separador2.Size = new Size(208, 6);
            // 
            // ToolStripMenuItem_Opcoes_Arquivo_Fechar
            // 
            ToolStripMenuItem_Opcoes_Arquivo_Fechar.Image = Properties.Resources.exit;
            ToolStripMenuItem_Opcoes_Arquivo_Fechar.Name = "ToolStripMenuItem_Opcoes_Arquivo_Fechar";
            ToolStripMenuItem_Opcoes_Arquivo_Fechar.ShortcutKeyDisplayString = "Alt+F4";
            ToolStripMenuItem_Opcoes_Arquivo_Fechar.Size = new Size(211, 22);
            ToolStripMenuItem_Opcoes_Arquivo_Fechar.Text = "&Fechar";
            ToolStripMenuItem_Opcoes_Arquivo_Fechar.Click += ToolStripMenuItem_Opcoes_Arquivo_Fechar_Click;
            // 
            // ToolStripMenuItem_Opcoes_Editar
            // 
            ToolStripMenuItem_Opcoes_Editar.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Opcoes_Editar_Desfazer, ToolStripMenuItem_Opcoes_Editar_Refazer, ToolStripMenuItem_Opcoes_Editar_Separador1, ToolStripMenuItem_Opcoes_Editar_Recortar, ToolStripMenuItem_Opcoes_Editar_Copiar, ToolStripMenuItem_Opcoes_Editar_Colar, ToolStripMenuItem_Opcoes_Editar_Excluir, ToolStripMenuItem_Opcoes_Editar_Separador2, ToolStripMenuItem_Opcoes_Editar_DataHora });
            ToolStripMenuItem_Opcoes_Editar.Name = "ToolStripMenuItem_Opcoes_Editar";
            ToolStripMenuItem_Opcoes_Editar.Size = new Size(49, 20);
            ToolStripMenuItem_Opcoes_Editar.Text = "&Editar";
            // 
            // ToolStripMenuItem_Opcoes_Editar_Desfazer
            // 
            ToolStripMenuItem_Opcoes_Editar_Desfazer.Name = "ToolStripMenuItem_Opcoes_Editar_Desfazer";
            ToolStripMenuItem_Opcoes_Editar_Desfazer.ShortcutKeyDisplayString = "Ctrl+Z";
            ToolStripMenuItem_Opcoes_Editar_Desfazer.Size = new Size(159, 22);
            ToolStripMenuItem_Opcoes_Editar_Desfazer.Text = "&Desfazer";
            ToolStripMenuItem_Opcoes_Editar_Desfazer.Click += ToolStripMenuItem_Opcoes_Editar_Desfazer_Click;
            // 
            // ToolStripMenuItem_Opcoes_Editar_Refazer
            // 
            ToolStripMenuItem_Opcoes_Editar_Refazer.Name = "ToolStripMenuItem_Opcoes_Editar_Refazer";
            ToolStripMenuItem_Opcoes_Editar_Refazer.ShortcutKeyDisplayString = "Ctrl+Y";
            ToolStripMenuItem_Opcoes_Editar_Refazer.Size = new Size(159, 22);
            ToolStripMenuItem_Opcoes_Editar_Refazer.Text = "&Refazer";
            ToolStripMenuItem_Opcoes_Editar_Refazer.Click += ToolStripMenuItem_Opcoes_Editar_Refazer_Click;
            // 
            // ToolStripMenuItem_Opcoes_Editar_Separador1
            // 
            ToolStripMenuItem_Opcoes_Editar_Separador1.Name = "ToolStripMenuItem_Opcoes_Editar_Separador1";
            ToolStripMenuItem_Opcoes_Editar_Separador1.Size = new Size(156, 6);
            // 
            // ToolStripMenuItem_Opcoes_Editar_Recortar
            // 
            ToolStripMenuItem_Opcoes_Editar_Recortar.Name = "ToolStripMenuItem_Opcoes_Editar_Recortar";
            ToolStripMenuItem_Opcoes_Editar_Recortar.ShortcutKeyDisplayString = "Ctrl+X";
            ToolStripMenuItem_Opcoes_Editar_Recortar.Size = new Size(159, 22);
            ToolStripMenuItem_Opcoes_Editar_Recortar.Text = "R&ecortar";
            ToolStripMenuItem_Opcoes_Editar_Recortar.Click += ToolStripMenuItem_Opcoes_Editar_Recortar_Click;
            // 
            // ToolStripMenuItem_Opcoes_Editar_Copiar
            // 
            ToolStripMenuItem_Opcoes_Editar_Copiar.Name = "ToolStripMenuItem_Opcoes_Editar_Copiar";
            ToolStripMenuItem_Opcoes_Editar_Copiar.ShortcutKeyDisplayString = "Ctrl+C";
            ToolStripMenuItem_Opcoes_Editar_Copiar.Size = new Size(159, 22);
            ToolStripMenuItem_Opcoes_Editar_Copiar.Text = "&Copiar";
            ToolStripMenuItem_Opcoes_Editar_Copiar.Click += ToolStripMenuItem_Opcoes_Editar_Copiar_Click;
            // 
            // ToolStripMenuItem_Opcoes_Editar_Colar
            // 
            ToolStripMenuItem_Opcoes_Editar_Colar.Name = "ToolStripMenuItem_Opcoes_Editar_Colar";
            ToolStripMenuItem_Opcoes_Editar_Colar.ShortcutKeyDisplayString = "Ctrl+V";
            ToolStripMenuItem_Opcoes_Editar_Colar.Size = new Size(159, 22);
            ToolStripMenuItem_Opcoes_Editar_Colar.Text = "C&olar";
            ToolStripMenuItem_Opcoes_Editar_Colar.Click += ToolStripMenuItem_Opcoes_Editar_Colar_Click;
            // 
            // ToolStripMenuItem_Opcoes_Editar_Excluir
            // 
            ToolStripMenuItem_Opcoes_Editar_Excluir.Name = "ToolStripMenuItem_Opcoes_Editar_Excluir";
            ToolStripMenuItem_Opcoes_Editar_Excluir.ShortcutKeyDisplayString = "Delete";
            ToolStripMenuItem_Opcoes_Editar_Excluir.Size = new Size(159, 22);
            ToolStripMenuItem_Opcoes_Editar_Excluir.Text = "&Excluir";
            ToolStripMenuItem_Opcoes_Editar_Excluir.Click += ToolStripMenuItem_Opcoes_Editar_Excluir_Click;
            // 
            // ToolStripMenuItem_Opcoes_Editar_Separador2
            // 
            ToolStripMenuItem_Opcoes_Editar_Separador2.Name = "ToolStripMenuItem_Opcoes_Editar_Separador2";
            ToolStripMenuItem_Opcoes_Editar_Separador2.Size = new Size(156, 6);
            // 
            // ToolStripMenuItem_Opcoes_Editar_DataHora
            // 
            ToolStripMenuItem_Opcoes_Editar_DataHora.Image = Properties.Resources.time_and_date;
            ToolStripMenuItem_Opcoes_Editar_DataHora.Name = "ToolStripMenuItem_Opcoes_Editar_DataHora";
            ToolStripMenuItem_Opcoes_Editar_DataHora.ShortcutKeys = Keys.F5;
            ToolStripMenuItem_Opcoes_Editar_DataHora.Size = new Size(159, 22);
            ToolStripMenuItem_Opcoes_Editar_DataHora.Text = "&Data e Hora";
            ToolStripMenuItem_Opcoes_Editar_DataHora.Click += ToolStripMenuItem_Opcoes_Editar_DataHora_Click;
            // 
            // ToolStripMenuItem_Opcoes_Formatar
            // 
            ToolStripMenuItem_Opcoes_Formatar.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha, ToolStripMenuItem_Opcoes_Formatar_Fonte });
            ToolStripMenuItem_Opcoes_Formatar.Name = "ToolStripMenuItem_Opcoes_Formatar";
            ToolStripMenuItem_Opcoes_Formatar.Size = new Size(67, 20);
            ToolStripMenuItem_Opcoes_Formatar.Text = "&Formatar";
            // 
            // ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha
            // 
            ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha.CheckOnClick = true;
            ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha.Name = "ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha";
            ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha.Size = new Size(221, 22);
            ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha.Text = "&Quebra automática de linha";
            ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha.CheckedChanged += ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha_CheckedChanged;
            // 
            // ToolStripMenuItem_Opcoes_Formatar_Fonte
            // 
            ToolStripMenuItem_Opcoes_Formatar_Fonte.Image = Properties.Resources.font;
            ToolStripMenuItem_Opcoes_Formatar_Fonte.Name = "ToolStripMenuItem_Opcoes_Formatar_Fonte";
            ToolStripMenuItem_Opcoes_Formatar_Fonte.Size = new Size(221, 22);
            ToolStripMenuItem_Opcoes_Formatar_Fonte.Text = "&Fonte";
            ToolStripMenuItem_Opcoes_Formatar_Fonte.Click += ToolStripMenuItem_Opcoes_Formatar_Fonte_Click;
            // 
            // ToolStripMenuItem_Opcoes_Exibir
            // 
            ToolStripMenuItem_Opcoes_Exibir.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Opcoes_Exibir_Zoom, ToolStripMenuItem_Opcoes_Exibir_BarraStatus });
            ToolStripMenuItem_Opcoes_Exibir.Name = "ToolStripMenuItem_Opcoes_Exibir";
            ToolStripMenuItem_Opcoes_Exibir.Size = new Size(48, 20);
            ToolStripMenuItem_Opcoes_Exibir.Text = "&Exibir";
            // 
            // ToolStripMenuItem_Opcoes_Exibir_Zoom
            // 
            ToolStripMenuItem_Opcoes_Exibir_Zoom.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar, ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir, ToolStripMenuItem_Opcoes_Exibir_Zoom_Separador1, ToolStripMenuItem_Opcoes_Exibir_Zoom_Restaurar });
            ToolStripMenuItem_Opcoes_Exibir_Zoom.Image = Properties.Resources.zoom;
            ToolStripMenuItem_Opcoes_Exibir_Zoom.Name = "ToolStripMenuItem_Opcoes_Exibir_Zoom";
            ToolStripMenuItem_Opcoes_Exibir_Zoom.ShowShortcutKeys = false;
            ToolStripMenuItem_Opcoes_Exibir_Zoom.Size = new Size(151, 22);
            ToolStripMenuItem_Opcoes_Exibir_Zoom.Text = "&Zoom";
            // 
            // ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar
            // 
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar.Name = "ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar";
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar.ShortcutKeyDisplayString = "Ctrl + +";
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar.ShortcutKeys = Keys.Control | Keys.Oemplus;
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar.Size = new Size(164, 22);
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar.Text = "&Ampliar";
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar.Click += ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar_Click;
            // 
            // ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir
            // 
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir.Name = "ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir";
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir.ShortcutKeyDisplayString = "Ctrl + -";
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir.ShortcutKeys = Keys.Control | Keys.OemMinus;
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir.Size = new Size(164, 22);
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir.Text = "&Reduzir";
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir.Click += ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir_Click;
            // 
            // ToolStripMenuItem_Opcoes_Exibir_Zoom_Separador1
            // 
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Separador1.Name = "ToolStripMenuItem_Opcoes_Exibir_Zoom_Separador1";
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Separador1.Size = new Size(161, 6);
            // 
            // ToolStripMenuItem_Opcoes_Exibir_Zoom_Restaurar
            // 
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Restaurar.Name = "ToolStripMenuItem_Opcoes_Exibir_Zoom_Restaurar";
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Restaurar.Size = new Size(164, 22);
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Restaurar.Text = "R&estaurar";
            ToolStripMenuItem_Opcoes_Exibir_Zoom_Restaurar.Click += ToolStripMenuItem_Opcoes_Exibir_Zoom_Restaurar_Click;
            // 
            // ToolStripMenuItem_Opcoes_Exibir_BarraStatus
            // 
            ToolStripMenuItem_Opcoes_Exibir_BarraStatus.Checked = true;
            ToolStripMenuItem_Opcoes_Exibir_BarraStatus.CheckOnClick = true;
            ToolStripMenuItem_Opcoes_Exibir_BarraStatus.CheckState = CheckState.Checked;
            ToolStripMenuItem_Opcoes_Exibir_BarraStatus.Name = "ToolStripMenuItem_Opcoes_Exibir_BarraStatus";
            ToolStripMenuItem_Opcoes_Exibir_BarraStatus.Size = new Size(151, 22);
            ToolStripMenuItem_Opcoes_Exibir_BarraStatus.Text = "&Barra de status";
            ToolStripMenuItem_Opcoes_Exibir_BarraStatus.CheckedChanged += ToolStripMenuItem_Opcoes_Exibir_BarraStatus_CheckedChanged;
            // 
            // ToolStripMenuItem_Opcoes_Ajuda
            // 
            ToolStripMenuItem_Opcoes_Ajuda.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Opcoes_Ajuda_Exibir, ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma });
            ToolStripMenuItem_Opcoes_Ajuda.Name = "ToolStripMenuItem_Opcoes_Ajuda";
            ToolStripMenuItem_Opcoes_Ajuda.Size = new Size(50, 20);
            ToolStripMenuItem_Opcoes_Ajuda.Text = "Aj&uda";
            // 
            // ToolStripMenuItem_Opcoes_Ajuda_Exibir
            // 
            ToolStripMenuItem_Opcoes_Ajuda_Exibir.Image = Properties.Resources.help;
            ToolStripMenuItem_Opcoes_Ajuda_Exibir.Name = "ToolStripMenuItem_Opcoes_Ajuda_Exibir";
            ToolStripMenuItem_Opcoes_Ajuda_Exibir.ShortcutKeys = Keys.F1;
            ToolStripMenuItem_Opcoes_Ajuda_Exibir.Size = new Size(169, 22);
            ToolStripMenuItem_Opcoes_Ajuda_Exibir.Text = "&Exibir ajuda";
            ToolStripMenuItem_Opcoes_Ajuda_Exibir.Click += ToolStripMenuItem_Opcoes_Ajuda_Exibir_Click;
            // 
            // ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma
            // 
            ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma.Image = Properties.Resources.text_editor;
            ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma.Name = "ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma";
            ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma.Size = new Size(169, 22);
            ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma.Text = "&Sobre o programa";
            ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma.Click += ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma_Click;
            // 
            // StatusStrip_Status
            // 
            StatusStrip_Status.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel_Status_Zoom });
            StatusStrip_Status.Location = new Point(0, 539);
            StatusStrip_Status.Name = "StatusStrip_Status";
            StatusStrip_Status.Size = new Size(784, 22);
            StatusStrip_Status.SizingGrip = false;
            StatusStrip_Status.TabIndex = 3;
            StatusStrip_Status.Text = "Barra de status do aplicativo";
            // 
            // ToolStripStatusLabel_Status_Zoom
            // 
            ToolStripStatusLabel_Status_Zoom.Name = "ToolStripStatusLabel_Status_Zoom";
            ToolStripStatusLabel_Status_Zoom.Size = new Size(35, 17);
            ToolStripStatusLabel_Status_Zoom.Text = "100%";
            // 
            // RichTextBox_Texto
            // 
            RichTextBox_Texto.Dock = DockStyle.Fill;
            RichTextBox_Texto.Location = new Point(0, 49);
            RichTextBox_Texto.Name = "RichTextBox_Texto";
            RichTextBox_Texto.Size = new Size(784, 490);
            RichTextBox_Texto.TabIndex = 2;
            RichTextBox_Texto.Text = "";
            RichTextBox_Texto.WordWrap = false;
            RichTextBox_Texto.TextChanged += RichTextBox_Texto_TextChanged;
            // 
            // SaveFileDialog_SalvarArquivo
            // 
            SaveFileDialog_SalvarArquivo.Filter = "Arquivo de texto rico|*.rtf|Arquivo de texto|*.txt|Todos os arquivos|*.*";
            SaveFileDialog_SalvarArquivo.Title = "Salvar o arquivo...";
            // 
            // OpenFileDialog_AbrirArquivo
            // 
            OpenFileDialog_AbrirArquivo.Filter = "Arquivo de texto rico|*.rtf|Arquivo de texto|*.txt|Todos os arquivos|*.*";
            OpenFileDialog_AbrirArquivo.Title = "Abrir o arquivo...";
            // 
            // FontDialog_FonteTexto
            // 
            FontDialog_FonteTexto.ShowColor = true;
            // 
            // Process_AbrirAjuda
            // 
            Process_AbrirAjuda.StartInfo.Arguments = "https://support.microsoft.com/pt-br/windows/ajuda-do-bloco-de-notas-do-windows-4d68c388-2ff2-0e7f-b706-35fb2ab88a8c";
            Process_AbrirAjuda.StartInfo.Domain = "";
            Process_AbrirAjuda.StartInfo.FileName = "explorer.exe";
            Process_AbrirAjuda.StartInfo.LoadUserProfile = false;
            Process_AbrirAjuda.StartInfo.Password = null;
            Process_AbrirAjuda.StartInfo.StandardErrorEncoding = null;
            Process_AbrirAjuda.StartInfo.StandardInputEncoding = null;
            Process_AbrirAjuda.StartInfo.StandardOutputEncoding = null;
            Process_AbrirAjuda.StartInfo.UseCredentialsForNetworkingOnly = false;
            Process_AbrirAjuda.StartInfo.UserName = "";
            Process_AbrirAjuda.SynchronizingObject = this;
            // 
            // ToolStrip_BarraFerramentas
            // 
            ToolStrip_BarraFerramentas.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip_BarraFerramentas.Items.AddRange(new ToolStripItem[] { ToolStripButton_BarraFerramenta_NovoDocumento, ToolStripButton_BarraFerramenta_NovaJanela, ToolStripButton_BarraFerramenta_AbrirArquivo, ToolStripButton_BarraFerramenta_SalvarArquivo, ToolStripSeparator_BarraFerramentas_1, ToolStripButton_BarraFerramenta_DataHoraAtual, ToolStripSeparator_BarraFerramentas_2, ToolStripButton_BarraFerramenta_SelecionarFonte, ToolStripSeparator_BarraFerramentas_3, ToolStripButton_BarraFerramenta_AumentarZoom, ToolStripButton_BarraFerramenta_ReduzirZoom, ToolStripButton_BarraFerramenta_RestaurarZoom });
            ToolStrip_BarraFerramentas.Location = new Point(0, 24);
            ToolStrip_BarraFerramentas.Name = "ToolStrip_BarraFerramentas";
            ToolStrip_BarraFerramentas.Size = new Size(784, 25);
            ToolStrip_BarraFerramentas.TabIndex = 1;
            ToolStrip_BarraFerramentas.Text = "Barra de Ferramentas";
            // 
            // ToolStripButton_BarraFerramenta_NovoDocumento
            // 
            ToolStripButton_BarraFerramenta_NovoDocumento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton_BarraFerramenta_NovoDocumento.Image = Properties.Resources.new_document;
            ToolStripButton_BarraFerramenta_NovoDocumento.ImageTransparentColor = Color.Magenta;
            ToolStripButton_BarraFerramenta_NovoDocumento.Name = "ToolStripButton_BarraFerramenta_NovoDocumento";
            ToolStripButton_BarraFerramenta_NovoDocumento.Size = new Size(23, 22);
            ToolStripButton_BarraFerramenta_NovoDocumento.ToolTipText = "Iniciar novo documento";
            ToolStripButton_BarraFerramenta_NovoDocumento.Click += ToolStripButton_BarraFerramenta_NovoDocumento_Click;
            // 
            // ToolStripButton_BarraFerramenta_NovaJanela
            // 
            ToolStripButton_BarraFerramenta_NovaJanela.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton_BarraFerramenta_NovaJanela.Image = Properties.Resources.notes;
            ToolStripButton_BarraFerramenta_NovaJanela.ImageTransparentColor = Color.Magenta;
            ToolStripButton_BarraFerramenta_NovaJanela.Name = "ToolStripButton_BarraFerramenta_NovaJanela";
            ToolStripButton_BarraFerramenta_NovaJanela.Size = new Size(23, 22);
            ToolStripButton_BarraFerramenta_NovaJanela.ToolTipText = "Abrir nova janela";
            ToolStripButton_BarraFerramenta_NovaJanela.Click += ToolStripButton_BarraFerramenta_NovaJanela_Click;
            // 
            // ToolStripButton_BarraFerramenta_AbrirArquivo
            // 
            ToolStripButton_BarraFerramenta_AbrirArquivo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton_BarraFerramenta_AbrirArquivo.Image = Properties.Resources.folder;
            ToolStripButton_BarraFerramenta_AbrirArquivo.ImageTransparentColor = Color.Magenta;
            ToolStripButton_BarraFerramenta_AbrirArquivo.Name = "ToolStripButton_BarraFerramenta_AbrirArquivo";
            ToolStripButton_BarraFerramenta_AbrirArquivo.Size = new Size(23, 22);
            ToolStripButton_BarraFerramenta_AbrirArquivo.ToolTipText = "Abrir o arquivo";
            ToolStripButton_BarraFerramenta_AbrirArquivo.Click += ToolStripButton_BarraFerramenta_AbrirArquivo_Click;
            // 
            // ToolStripButton_BarraFerramenta_SalvarArquivo
            // 
            ToolStripButton_BarraFerramenta_SalvarArquivo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton_BarraFerramenta_SalvarArquivo.Image = Properties.Resources.save;
            ToolStripButton_BarraFerramenta_SalvarArquivo.ImageTransparentColor = Color.Magenta;
            ToolStripButton_BarraFerramenta_SalvarArquivo.Name = "ToolStripButton_BarraFerramenta_SalvarArquivo";
            ToolStripButton_BarraFerramenta_SalvarArquivo.Size = new Size(23, 22);
            ToolStripButton_BarraFerramenta_SalvarArquivo.ToolTipText = "Salvar o arquivo";
            ToolStripButton_BarraFerramenta_SalvarArquivo.Click += ToolStripButton_BarraFerramenta_SalvarArquivo_Click;
            // 
            // ToolStripSeparator_BarraFerramentas_1
            // 
            ToolStripSeparator_BarraFerramentas_1.Name = "ToolStripSeparator_BarraFerramentas_1";
            ToolStripSeparator_BarraFerramentas_1.Size = new Size(6, 25);
            // 
            // ToolStripButton_BarraFerramenta_DataHoraAtual
            // 
            ToolStripButton_BarraFerramenta_DataHoraAtual.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton_BarraFerramenta_DataHoraAtual.Image = Properties.Resources.time_and_date;
            ToolStripButton_BarraFerramenta_DataHoraAtual.ImageTransparentColor = Color.Magenta;
            ToolStripButton_BarraFerramenta_DataHoraAtual.Name = "ToolStripButton_BarraFerramenta_DataHoraAtual";
            ToolStripButton_BarraFerramenta_DataHoraAtual.Size = new Size(23, 22);
            ToolStripButton_BarraFerramenta_DataHoraAtual.ToolTipText = "Escrever a data e hora atual";
            ToolStripButton_BarraFerramenta_DataHoraAtual.Click += ToolStripButton_BarraFerramenta_DataHoraAtual_Click;
            // 
            // ToolStripSeparator_BarraFerramentas_2
            // 
            ToolStripSeparator_BarraFerramentas_2.Name = "ToolStripSeparator_BarraFerramentas_2";
            ToolStripSeparator_BarraFerramentas_2.Size = new Size(6, 25);
            // 
            // ToolStripButton_BarraFerramenta_SelecionarFonte
            // 
            ToolStripButton_BarraFerramenta_SelecionarFonte.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton_BarraFerramenta_SelecionarFonte.Image = Properties.Resources.font;
            ToolStripButton_BarraFerramenta_SelecionarFonte.ImageTransparentColor = Color.Magenta;
            ToolStripButton_BarraFerramenta_SelecionarFonte.Name = "ToolStripButton_BarraFerramenta_SelecionarFonte";
            ToolStripButton_BarraFerramenta_SelecionarFonte.Size = new Size(23, 22);
            ToolStripButton_BarraFerramenta_SelecionarFonte.ToolTipText = "Selecionar a fonte";
            ToolStripButton_BarraFerramenta_SelecionarFonte.Click += ToolStripButton_BarraFerramenta_SelecionarFonte_Click;
            // 
            // ToolStripSeparator_BarraFerramentas_3
            // 
            ToolStripSeparator_BarraFerramentas_3.Name = "ToolStripSeparator_BarraFerramentas_3";
            ToolStripSeparator_BarraFerramentas_3.Size = new Size(6, 25);
            // 
            // ToolStripButton_BarraFerramenta_AumentarZoom
            // 
            ToolStripButton_BarraFerramenta_AumentarZoom.Image = Properties.Resources.zoom;
            ToolStripButton_BarraFerramenta_AumentarZoom.ImageTransparentColor = Color.Magenta;
            ToolStripButton_BarraFerramenta_AumentarZoom.Name = "ToolStripButton_BarraFerramenta_AumentarZoom";
            ToolStripButton_BarraFerramenta_AumentarZoom.Size = new Size(35, 22);
            ToolStripButton_BarraFerramenta_AumentarZoom.Text = "+";
            ToolStripButton_BarraFerramenta_AumentarZoom.ToolTipText = "Aumentar o zoom do texto";
            ToolStripButton_BarraFerramenta_AumentarZoom.Click += ToolStripButton_BarraFerramenta_AumentarZoom_Click;
            // 
            // ToolStripButton_BarraFerramenta_ReduzirZoom
            // 
            ToolStripButton_BarraFerramenta_ReduzirZoom.Image = Properties.Resources.zoom;
            ToolStripButton_BarraFerramenta_ReduzirZoom.ImageTransparentColor = Color.Magenta;
            ToolStripButton_BarraFerramenta_ReduzirZoom.Name = "ToolStripButton_BarraFerramenta_ReduzirZoom";
            ToolStripButton_BarraFerramenta_ReduzirZoom.Size = new Size(32, 22);
            ToolStripButton_BarraFerramenta_ReduzirZoom.Text = "-";
            ToolStripButton_BarraFerramenta_ReduzirZoom.ToolTipText = "Reduzir o zoom do texto";
            ToolStripButton_BarraFerramenta_ReduzirZoom.Click += ToolStripButton_BarraFerramenta_ReduzirZoom_Click;
            // 
            // ToolStripButton_BarraFerramenta_RestaurarZoom
            // 
            ToolStripButton_BarraFerramenta_RestaurarZoom.Image = Properties.Resources.zoom;
            ToolStripButton_BarraFerramenta_RestaurarZoom.ImageTransparentColor = Color.Magenta;
            ToolStripButton_BarraFerramenta_RestaurarZoom.Name = "ToolStripButton_BarraFerramenta_RestaurarZoom";
            ToolStripButton_BarraFerramenta_RestaurarZoom.Size = new Size(76, 22);
            ToolStripButton_BarraFerramenta_RestaurarZoom.Text = "Restaurar";
            ToolStripButton_BarraFerramenta_RestaurarZoom.ToolTipText = "Restaurar o zoom do texto";
            ToolStripButton_BarraFerramenta_RestaurarZoom.Click += ToolStripButton_BarraFerramenta_RestaurarZoom_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(RichTextBox_Texto);
            Controls.Add(StatusStrip_Status);
            Controls.Add(ToolStrip_BarraFerramentas);
            Controls.Add(MenuStrip_Opcoes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip_Opcoes;
            MinimumSize = new Size(800, 600);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor de Texto";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            MenuStrip_Opcoes.ResumeLayout(false);
            MenuStrip_Opcoes.PerformLayout();
            StatusStrip_Status.ResumeLayout(false);
            StatusStrip_Status.PerformLayout();
            ToolStrip_BarraFerramentas.ResumeLayout(false);
            ToolStrip_BarraFerramentas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal MenuStrip MenuStrip_Opcoes;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Arquivo;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Editar;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Formatar;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Exibir;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Ajuda;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Arquivo_Novo;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Arquivo_NovaJanela;
        internal ToolStripSeparator ToolStripMenuItem_Opcoes_Arquivo_Separador1;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Arquivo_Abrir;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Arquivo_Salvar;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Arquivo_SalvarComo;
        internal ToolStripSeparator ToolStripMenuItem_Opcoes_Arquivo_Separador2;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Arquivo_Fechar;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Editar_Desfazer;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Editar_Refazer;
        internal ToolStripSeparator ToolStripMenuItem_Opcoes_Editar_Separador1;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Editar_Recortar;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Editar_Copiar;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Editar_Colar;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Editar_Excluir;
        internal ToolStripSeparator ToolStripMenuItem_Opcoes_Editar_Separador2;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Editar_DataHora;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Formatar_QuebraAutoLinha;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Formatar_Fonte;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Exibir_Zoom;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Exibir_Zoom_Ampliar;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Exibir_Zoom_Reduzir;
        internal ToolStripSeparator ToolStripMenuItem_Opcoes_Exibir_Zoom_Separador1;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Exibir_Zoom_Restaurar;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Exibir_BarraStatus;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Ajuda_Exibir;
        internal ToolStripMenuItem ToolStripMenuItem_Opcoes_Ajuda_SobrePrograma;
        internal StatusStrip StatusStrip_Status;
        internal ToolStripStatusLabel ToolStripStatusLabel_Status_Zoom;
        internal RichTextBox RichTextBox_Texto;
        internal SaveFileDialog SaveFileDialog_SalvarArquivo;
        internal OpenFileDialog OpenFileDialog_AbrirArquivo;
        internal FontDialog FontDialog_FonteTexto;
        internal System.Diagnostics.Process Process_AbrirAjuda;
        internal ToolStrip ToolStrip_BarraFerramentas;
        internal ToolStripButton ToolStripButton_BarraFerramenta_NovoDocumento;
        internal ToolStripButton ToolStripButton_BarraFerramenta_NovaJanela;
        internal ToolStripButton ToolStripButton_BarraFerramenta_AbrirArquivo;
        internal ToolStripButton ToolStripButton_BarraFerramenta_SalvarArquivo;
        internal ToolStripButton ToolStripButton_BarraFerramenta_DataHoraAtual;
        internal ToolStripButton ToolStripButton_BarraFerramenta_SelecionarFonte;
        internal ToolStripButton ToolStripButton_BarraFerramenta_ReduzirZoom;
        internal ToolStripButton ToolStripButton_BarraFerramenta_AumentarZoom;
        internal ToolStripButton ToolStripButton_BarraFerramenta_RestaurarZoom;
        internal ToolStripSeparator ToolStripSeparator_BarraFerramentas_1;
        internal ToolStripSeparator ToolStripSeparator_BarraFerramentas_2;
        internal ToolStripSeparator ToolStripSeparator_BarraFerramentas_3;
    }
}
