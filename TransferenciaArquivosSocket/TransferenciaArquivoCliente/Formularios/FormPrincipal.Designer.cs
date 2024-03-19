namespace TransferenciaArquivoCliente.Formularios
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
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.Label_Porta = new System.Windows.Forms.Label();
            this.Label_IP = new System.Windows.Forms.Label();
            this.NumericUpDown_Porta = new System.Windows.Forms.NumericUpDown();
            this.TextBox_EnderecoIP = new System.Windows.Forms.TextBox();
            this.LinkLabel_SelecionarArquivo = new System.Windows.Forms.LinkLabel();
            this.Button_EnviarArquivo = new System.Windows.Forms.Button();
            this.Label_Status = new System.Windows.Forms.Label();
            this.OpenFileDialog_SelecionarArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Porta)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(91)))));
            this.Label_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(304, 50);
            this.Label_Titulo.TabIndex = 1;
            this.Label_Titulo.Text = "Cliente para Transferência de Arquivos";
            this.Label_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Porta
            // 
            this.Label_Porta.AutoSize = true;
            this.Label_Porta.Location = new System.Drawing.Point(225, 50);
            this.Label_Porta.Name = "Label_Porta";
            this.Label_Porta.Size = new System.Drawing.Size(32, 13);
            this.Label_Porta.TabIndex = 5;
            this.Label_Porta.Text = "&Porta";
            // 
            // Label_IP
            // 
            this.Label_IP.AutoSize = true;
            this.Label_IP.Location = new System.Drawing.Point(12, 50);
            this.Label_IP.Name = "Label_IP";
            this.Label_IP.Size = new System.Drawing.Size(66, 13);
            this.Label_IP.TabIndex = 3;
            this.Label_IP.Text = "&Endereço IP";
            // 
            // NumericUpDown_Porta
            // 
            this.NumericUpDown_Porta.Location = new System.Drawing.Point(228, 66);
            this.NumericUpDown_Porta.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumericUpDown_Porta.Name = "NumericUpDown_Porta";
            this.NumericUpDown_Porta.Size = new System.Drawing.Size(64, 20);
            this.NumericUpDown_Porta.TabIndex = 6;
            this.NumericUpDown_Porta.Value = new decimal(new int[] {
            7895,
            0,
            0,
            0});
            // 
            // TextBox_EnderecoIP
            // 
            this.TextBox_EnderecoIP.Location = new System.Drawing.Point(15, 66);
            this.TextBox_EnderecoIP.Name = "TextBox_EnderecoIP";
            this.TextBox_EnderecoIP.Size = new System.Drawing.Size(207, 20);
            this.TextBox_EnderecoIP.TabIndex = 4;
            this.TextBox_EnderecoIP.Text = "127.0.0.1";
            // 
            // LinkLabel_SelecionarArquivo
            // 
            this.LinkLabel_SelecionarArquivo.AutoEllipsis = true;
            this.LinkLabel_SelecionarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_SelecionarArquivo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LinkLabel_SelecionarArquivo.Location = new System.Drawing.Point(12, 98);
            this.LinkLabel_SelecionarArquivo.Name = "LinkLabel_SelecionarArquivo";
            this.LinkLabel_SelecionarArquivo.Size = new System.Drawing.Size(280, 14);
            this.LinkLabel_SelecionarArquivo.TabIndex = 7;
            this.LinkLabel_SelecionarArquivo.TabStop = true;
            this.LinkLabel_SelecionarArquivo.Text = "&Clique para selecionar um arquivo...";
            this.LinkLabel_SelecionarArquivo.VisitedLinkColor = System.Drawing.Color.Blue;
            this.LinkLabel_SelecionarArquivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_SelecionarArquivo_LinkClicked);
            // 
            // Button_EnviarArquivo
            // 
            this.Button_EnviarArquivo.Location = new System.Drawing.Point(15, 125);
            this.Button_EnviarArquivo.Name = "Button_EnviarArquivo";
            this.Button_EnviarArquivo.Size = new System.Drawing.Size(277, 23);
            this.Button_EnviarArquivo.TabIndex = 8;
            this.Button_EnviarArquivo.Text = "Enviar &Arquivo";
            this.Button_EnviarArquivo.UseVisualStyleBackColor = true;
            this.Button_EnviarArquivo.Click += new System.EventHandler(this.Button_EnviarArquivo_Click);
            // 
            // Label_Status
            // 
            this.Label_Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Label_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(91)))));
            this.Label_Status.Location = new System.Drawing.Point(0, 151);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(304, 50);
            this.Label_Status.TabIndex = 9;
            this.Label_Status.Text = "Status";
            this.Label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.Button_EnviarArquivo);
            this.Controls.Add(this.LinkLabel_SelecionarArquivo);
            this.Controls.Add(this.Label_Porta);
            this.Controls.Add(this.Label_IP);
            this.Controls.Add(this.NumericUpDown_Porta);
            this.Controls.Add(this.TextBox_EnderecoIP);
            this.Controls.Add(this.Label_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferência de Arquivos (Cliente Socket)";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Porta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label_Titulo;
        internal System.Windows.Forms.Label Label_Porta;
        internal System.Windows.Forms.Label Label_IP;
        internal System.Windows.Forms.NumericUpDown NumericUpDown_Porta;
        internal System.Windows.Forms.TextBox TextBox_EnderecoIP;
        internal System.Windows.Forms.LinkLabel LinkLabel_SelecionarArquivo;
        internal System.Windows.Forms.Label Label_Status;
        internal System.Windows.Forms.Button Button_EnviarArquivo;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_SelecionarArquivo;
    }
}

