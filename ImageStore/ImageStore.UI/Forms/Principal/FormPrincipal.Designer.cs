namespace ImageStore.UI.Forms.Principal
{
    partial class FormPrincipal
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
            PictureBox_ImagemSelecionada = new PictureBox();
            Label_NomeImagem = new Label();
            TextBox_NomeImagem = new TextBox();
            Button_EscolherLocal = new Button();
            Button_Inserir = new Button();
            Button_RecuperarDoBanco = new Button();
            OpenFileDialog_EscolherLocal = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)PictureBox_ImagemSelecionada).BeginInit();
            SuspendLayout();
            // 
            // PictureBox_ImagemSelecionada
            // 
            PictureBox_ImagemSelecionada.BorderStyle = BorderStyle.FixedSingle;
            PictureBox_ImagemSelecionada.Location = new Point(12, 12);
            PictureBox_ImagemSelecionada.Name = "PictureBox_ImagemSelecionada";
            PictureBox_ImagemSelecionada.Size = new Size(460, 360);
            PictureBox_ImagemSelecionada.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_ImagemSelecionada.TabIndex = 0;
            PictureBox_ImagemSelecionada.TabStop = false;
            // 
            // Label_NomeImagem
            // 
            Label_NomeImagem.AutoSize = true;
            Label_NomeImagem.Location = new Point(9, 375);
            Label_NomeImagem.Name = "Label_NomeImagem";
            Label_NomeImagem.Size = new Size(103, 15);
            Label_NomeImagem.TabIndex = 1;
            Label_NomeImagem.Text = "&Nome da Imagem";
            // 
            // TextBox_NomeImagem
            // 
            TextBox_NomeImagem.Enabled = false;
            TextBox_NomeImagem.Location = new Point(12, 393);
            TextBox_NomeImagem.MaxLength = 100;
            TextBox_NomeImagem.Name = "TextBox_NomeImagem";
            TextBox_NomeImagem.Size = new Size(460, 23);
            TextBox_NomeImagem.TabIndex = 1;
            TextBox_NomeImagem.TextChanged += TextBox_NomeImagem_TextChanged;
            // 
            // Button_EscolherLocal
            // 
            Button_EscolherLocal.Location = new Point(12, 426);
            Button_EscolherLocal.Name = "Button_EscolherLocal";
            Button_EscolherLocal.Size = new Size(130, 23);
            Button_EscolherLocal.TabIndex = 2;
            Button_EscolherLocal.Text = "&Escolher Local";
            Button_EscolherLocal.UseVisualStyleBackColor = true;
            Button_EscolherLocal.Click += Button_EscolherLocal_Click;
            // 
            // Button_Inserir
            // 
            Button_Inserir.Enabled = false;
            Button_Inserir.Location = new Point(397, 426);
            Button_Inserir.Name = "Button_Inserir";
            Button_Inserir.Size = new Size(75, 23);
            Button_Inserir.TabIndex = 4;
            Button_Inserir.Text = "&Inserir";
            Button_Inserir.UseVisualStyleBackColor = true;
            Button_Inserir.Click += Button_Inserir_Click;
            // 
            // Button_RecuperarDoBanco
            // 
            Button_RecuperarDoBanco.Location = new Point(148, 426);
            Button_RecuperarDoBanco.Name = "Button_RecuperarDoBanco";
            Button_RecuperarDoBanco.Size = new Size(130, 23);
            Button_RecuperarDoBanco.TabIndex = 3;
            Button_RecuperarDoBanco.Text = "&Recuperar do Banco";
            Button_RecuperarDoBanco.UseVisualStyleBackColor = true;
            // 
            // OpenFileDialog_EscolherLocal
            // 
            OpenFileDialog_EscolherLocal.Filter = "Escolha a imagem (gif, jpg, png)|*.gif;*.jpg;*.png";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(Button_RecuperarDoBanco);
            Controls.Add(Button_Inserir);
            Controls.Add(Button_EscolherLocal);
            Controls.Add(TextBox_NomeImagem);
            Controls.Add(Label_NomeImagem);
            Controls.Add(PictureBox_ImagemSelecionada);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(500, 500);
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Store";
            ((System.ComponentModel.ISupportInitialize)PictureBox_ImagemSelecionada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal PictureBox PictureBox_ImagemSelecionada;
        internal Label Label_NomeImagem;
        internal TextBox TextBox_NomeImagem;
        internal Button Button_EscolherLocal;
        internal Button Button_Inserir;
        internal Button Button_RecuperarDoBanco;
        internal OpenFileDialog OpenFileDialog_EscolherLocal;
    }
}