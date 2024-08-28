namespace ImageStore.UI.Forms.RecuperarImagemBanco
{
    partial class FormRecuperarImagemBanco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PictureBox_ImagemSelecionada = new PictureBox();
            DataGridView_Imagens = new DataGridView();
            DataGridView_Imagens_Nome = new DataGridViewTextBoxColumn();
            BindingSource_Imagens = new BindingSource(components);
            Button_Fechar = new Button();
            Button_Salvar = new Button();
            Button_Excluir = new Button();
            Label_Imagem_Tamanho = new Label();
            Label_Imagem_Codigo = new Label();
            PictureBox_CarregandoAcao = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox_ImagemSelecionada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Imagens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BindingSource_Imagens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_CarregandoAcao).BeginInit();
            SuspendLayout();
            // 
            // PictureBox_ImagemSelecionada
            // 
            PictureBox_ImagemSelecionada.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox_ImagemSelecionada.BorderStyle = BorderStyle.FixedSingle;
            PictureBox_ImagemSelecionada.Location = new Point(12, 12);
            PictureBox_ImagemSelecionada.Name = "PictureBox_ImagemSelecionada";
            PictureBox_ImagemSelecionada.Size = new Size(460, 360);
            PictureBox_ImagemSelecionada.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_ImagemSelecionada.TabIndex = 1;
            PictureBox_ImagemSelecionada.TabStop = false;
            // 
            // DataGridView_Imagens
            // 
            DataGridView_Imagens.AllowUserToAddRows = false;
            DataGridView_Imagens.AllowUserToDeleteRows = false;
            DataGridView_Imagens.AllowUserToResizeRows = false;
            DataGridView_Imagens.AutoGenerateColumns = false;
            DataGridView_Imagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridView_Imagens.BackgroundColor = SystemColors.ControlLight;
            DataGridView_Imagens.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DataGridView_Imagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridView_Imagens.Columns.AddRange(new DataGridViewColumn[] { DataGridView_Imagens_Nome });
            DataGridView_Imagens.DataSource = BindingSource_Imagens;
            DataGridView_Imagens.Location = new Point(478, 12);
            DataGridView_Imagens.MultiSelect = false;
            DataGridView_Imagens.Name = "DataGridView_Imagens";
            DataGridView_Imagens.ReadOnly = true;
            DataGridView_Imagens.RowHeadersVisible = false;
            DataGridView_Imagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_Imagens.ShowCellErrors = false;
            DataGridView_Imagens.ShowCellToolTips = false;
            DataGridView_Imagens.ShowEditingIcon = false;
            DataGridView_Imagens.ShowRowErrors = false;
            DataGridView_Imagens.Size = new Size(294, 360);
            DataGridView_Imagens.TabIndex = 1;
            // 
            // DataGridView_Imagens_Nome
            // 
            DataGridView_Imagens_Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridView_Imagens_Nome.DataPropertyName = "Nome";
            DataGridView_Imagens_Nome.HeaderText = "Imagens Salvas";
            DataGridView_Imagens_Nome.MinimumWidth = 292;
            DataGridView_Imagens_Nome.Name = "DataGridView_Imagens_Nome";
            DataGridView_Imagens_Nome.ReadOnly = true;
            DataGridView_Imagens_Nome.Width = 292;
            // 
            // BindingSource_Imagens
            // 
            BindingSource_Imagens.CurrentChanged += BindingSource_Imagens_CurrentChanged;
            BindingSource_Imagens.ListChanged += BindingSource_Imagens_ListChanged;
            // 
            // Button_Fechar
            // 
            Button_Fechar.Location = new Point(697, 378);
            Button_Fechar.Name = "Button_Fechar";
            Button_Fechar.Size = new Size(75, 23);
            Button_Fechar.TabIndex = 4;
            Button_Fechar.Text = "&Fechar";
            Button_Fechar.UseVisualStyleBackColor = true;
            // 
            // Button_Salvar
            // 
            Button_Salvar.Enabled = false;
            Button_Salvar.Location = new Point(478, 378);
            Button_Salvar.Name = "Button_Salvar";
            Button_Salvar.Size = new Size(75, 23);
            Button_Salvar.TabIndex = 2;
            Button_Salvar.Text = "&Salvar";
            Button_Salvar.UseVisualStyleBackColor = true;
            Button_Salvar.Click += Button_Salvar_Click;
            // 
            // Button_Excluir
            // 
            Button_Excluir.Enabled = false;
            Button_Excluir.Location = new Point(559, 378);
            Button_Excluir.Name = "Button_Excluir";
            Button_Excluir.Size = new Size(75, 23);
            Button_Excluir.TabIndex = 3;
            Button_Excluir.Text = "&Excluir";
            Button_Excluir.UseVisualStyleBackColor = true;
            Button_Excluir.Click += Button_Excluir_Click;
            // 
            // Label_Imagem_Tamanho
            // 
            Label_Imagem_Tamanho.AutoSize = true;
            Label_Imagem_Tamanho.Location = new Point(12, 382);
            Label_Imagem_Tamanho.Name = "Label_Imagem_Tamanho";
            Label_Imagem_Tamanho.Size = new Size(119, 15);
            Label_Imagem_Tamanho.TabIndex = 5;
            Label_Imagem_Tamanho.Text = "Tamanho da Imagem";
            Label_Imagem_Tamanho.Visible = false;
            Label_Imagem_Tamanho.TextChanged += Label_Imagem_Tamanho_TextChanged;
            // 
            // Label_Imagem_Codigo
            // 
            Label_Imagem_Codigo.Location = new Point(238, 382);
            Label_Imagem_Codigo.Name = "Label_Imagem_Codigo";
            Label_Imagem_Codigo.Size = new Size(234, 15);
            Label_Imagem_Codigo.TabIndex = 6;
            Label_Imagem_Codigo.Text = "Código da Imagem";
            Label_Imagem_Codigo.TextAlign = ContentAlignment.MiddleRight;
            Label_Imagem_Codigo.Visible = false;
            Label_Imagem_Codigo.TextChanged += Label_Imagem_Codigo_TextChanged;
            // 
            // PictureBox_CarregandoAcao
            // 
            PictureBox_CarregandoAcao.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox_CarregandoAcao.Image = Properties.Resources.loading;
            PictureBox_CarregandoAcao.Location = new Point(668, 378);
            PictureBox_CarregandoAcao.Name = "PictureBox_CarregandoAcao";
            PictureBox_CarregandoAcao.Size = new Size(23, 23);
            PictureBox_CarregandoAcao.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_CarregandoAcao.TabIndex = 7;
            PictureBox_CarregandoAcao.TabStop = false;
            // 
            // FormRecuperarImagemBanco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Button_Fechar;
            ClientSize = new Size(784, 411);
            Controls.Add(PictureBox_CarregandoAcao);
            Controls.Add(Label_Imagem_Codigo);
            Controls.Add(Label_Imagem_Tamanho);
            Controls.Add(Button_Excluir);
            Controls.Add(Button_Salvar);
            Controls.Add(Button_Fechar);
            Controls.Add(DataGridView_Imagens);
            Controls.Add(PictureBox_ImagemSelecionada);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(800, 450);
            MinimizeBox = false;
            MinimumSize = new Size(800, 450);
            Name = "FormRecuperarImagemBanco";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Image Store - Recuperar Imagem do Banco";
            Shown += FormRecuperarImagemBanco_Shown;
            ((System.ComponentModel.ISupportInitialize)PictureBox_ImagemSelecionada).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Imagens).EndInit();
            ((System.ComponentModel.ISupportInitialize)BindingSource_Imagens).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_CarregandoAcao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal PictureBox PictureBox_ImagemSelecionada;
        internal DataGridView DataGridView_Imagens;
        internal Button Button_Fechar;
        internal Button Button_Salvar;
        internal Button Button_Excluir;
        internal BindingSource BindingSource_Imagens;
        internal Label Label_Imagem_Codigo;
        internal Label Label_Imagem_Tamanho;
        internal PictureBox PictureBox_CarregandoAcao;
        private DataGridViewTextBoxColumn DataGridView_Imagens_Nome;
    }
}