namespace CriptografarArquivos.Formularios
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
            this.Button_ImportarChavePublica = new System.Windows.Forms.Button();
            this.Button_ObterChavePrivada = new System.Windows.Forms.Button();
            this.Button_ExportarChavePublica = new System.Windows.Forms.Button();
            this.Button_CriptografarArquivo = new System.Windows.Forms.Button();
            this.Button_CriarChaves = new System.Windows.Forms.Button();
            this.Button_DescriptografarArquivo = new System.Windows.Forms.Button();
            this.Label_Status = new System.Windows.Forms.Label();
            this.TextBox_Chave = new System.Windows.Forms.TextBox();
            this.Label_Chave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_ImportarChavePublica
            // 
            this.Button_ImportarChavePublica.Location = new System.Drawing.Point(7, 299);
            this.Button_ImportarChavePublica.Name = "Button_ImportarChavePublica";
            this.Button_ImportarChavePublica.Size = new System.Drawing.Size(185, 50);
            this.Button_ImportarChavePublica.TabIndex = 4;
            this.Button_ImportarChavePublica.Text = "&Importar chave pública";
            this.Button_ImportarChavePublica.UseVisualStyleBackColor = true;
            // 
            // Button_ObterChavePrivada
            // 
            this.Button_ObterChavePrivada.Location = new System.Drawing.Point(389, 299);
            this.Button_ObterChavePrivada.Name = "Button_ObterChavePrivada";
            this.Button_ObterChavePrivada.Size = new System.Drawing.Size(185, 50);
            this.Button_ObterChavePrivada.TabIndex = 6;
            this.Button_ObterChavePrivada.Text = "&Obter chave privada";
            this.Button_ObterChavePrivada.UseVisualStyleBackColor = true;
            // 
            // Button_ExportarChavePublica
            // 
            this.Button_ExportarChavePublica.Location = new System.Drawing.Point(198, 299);
            this.Button_ExportarChavePublica.Name = "Button_ExportarChavePublica";
            this.Button_ExportarChavePublica.Size = new System.Drawing.Size(185, 50);
            this.Button_ExportarChavePublica.TabIndex = 5;
            this.Button_ExportarChavePublica.Text = "&Exportar chave pública";
            this.Button_ExportarChavePublica.UseVisualStyleBackColor = true;
            // 
            // Button_CriptografarArquivo
            // 
            this.Button_CriptografarArquivo.Location = new System.Drawing.Point(7, 243);
            this.Button_CriptografarArquivo.Name = "Button_CriptografarArquivo";
            this.Button_CriptografarArquivo.Size = new System.Drawing.Size(185, 50);
            this.Button_CriptografarArquivo.TabIndex = 1;
            this.Button_CriptografarArquivo.Text = "&Criptografar arquivo";
            this.Button_CriptografarArquivo.UseVisualStyleBackColor = true;
            // 
            // Button_CriarChaves
            // 
            this.Button_CriarChaves.Location = new System.Drawing.Point(389, 243);
            this.Button_CriarChaves.Name = "Button_CriarChaves";
            this.Button_CriarChaves.Size = new System.Drawing.Size(185, 50);
            this.Button_CriarChaves.TabIndex = 3;
            this.Button_CriarChaves.Text = "Criar c&haves";
            this.Button_CriarChaves.UseVisualStyleBackColor = true;
            // 
            // Button_DescriptografarArquivo
            // 
            this.Button_DescriptografarArquivo.Location = new System.Drawing.Point(198, 243);
            this.Button_DescriptografarArquivo.Name = "Button_DescriptografarArquivo";
            this.Button_DescriptografarArquivo.Size = new System.Drawing.Size(185, 50);
            this.Button_DescriptografarArquivo.TabIndex = 2;
            this.Button_DescriptografarArquivo.Text = "&Descriptografar arquivo";
            this.Button_DescriptografarArquivo.UseVisualStyleBackColor = true;
            // 
            // Label_Status
            // 
            this.Label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status.Location = new System.Drawing.Point(12, 9);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(560, 191);
            this.Label_Status.TabIndex = 0;
            this.Label_Status.Text = "Chave não definida";
            this.Label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_Chave
            // 
            this.TextBox_Chave.Location = new System.Drawing.Point(7, 217);
            this.TextBox_Chave.Name = "TextBox_Chave";
            this.TextBox_Chave.Size = new System.Drawing.Size(565, 20);
            this.TextBox_Chave.TabIndex = 0;
            // 
            // Label_Chave
            // 
            this.Label_Chave.AutoSize = true;
            this.Label_Chave.Location = new System.Drawing.Point(4, 200);
            this.Label_Chave.Name = "Label_Chave";
            this.Label_Chave.Size = new System.Drawing.Size(38, 13);
            this.Label_Chave.TabIndex = 0;
            this.Label_Chave.Text = "Cha&ve";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Label_Chave);
            this.Controls.Add(this.TextBox_Chave);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.Button_CriptografarArquivo);
            this.Controls.Add(this.Button_CriarChaves);
            this.Controls.Add(this.Button_DescriptografarArquivo);
            this.Controls.Add(this.Button_ImportarChavePublica);
            this.Controls.Add(this.Button_ObterChavePrivada);
            this.Controls.Add(this.Button_ExportarChavePublica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criptografia de Arquivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button_ImportarChavePublica;
        internal System.Windows.Forms.Button Button_ObterChavePrivada;
        internal System.Windows.Forms.Button Button_ExportarChavePublica;
        internal System.Windows.Forms.Button Button_CriptografarArquivo;
        internal System.Windows.Forms.Button Button_CriarChaves;
        internal System.Windows.Forms.Button Button_DescriptografarArquivo;
        internal System.Windows.Forms.Label Label_Status;
        internal System.Windows.Forms.TextBox TextBox_Chave;
        internal System.Windows.Forms.Label Label_Chave;
    }
}

