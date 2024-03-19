namespace TransferenciaArquivosServer.Formularios
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
            this.TextBox_EnderecoIP = new System.Windows.Forms.TextBox();
            this.NumericUpDown_Porta = new System.Windows.Forms.NumericUpDown();
            this.Label_IP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_EstabelecerConexao = new System.Windows.Forms.Button();
            this.Button_PararServidor = new System.Windows.Forms.Button();
            this.LinkLabel_SelecionarPasta = new System.Windows.Forms.LinkLabel();
            this.ListBox_Logs = new System.Windows.Forms.ListBox();
            this.FolderBrowserDialog_DestinoArquivos = new System.Windows.Forms.FolderBrowserDialog();
            this.ToolTip_Auxilios = new System.Windows.Forms.ToolTip();
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
            this.Label_Titulo.TabIndex = 0;
            this.Label_Titulo.Text = "Servidor para Transferência de Arquivos";
            this.Label_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_EnderecoIP
            // 
            this.TextBox_EnderecoIP.Location = new System.Drawing.Point(15, 66);
            this.TextBox_EnderecoIP.Name = "TextBox_EnderecoIP";
            this.TextBox_EnderecoIP.Size = new System.Drawing.Size(207, 20);
            this.TextBox_EnderecoIP.TabIndex = 1;
            this.TextBox_EnderecoIP.Text = "127.0.0.1";
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
            this.NumericUpDown_Porta.TabIndex = 2;
            this.NumericUpDown_Porta.Value = new decimal(new int[] {
            7895,
            0,
            0,
            0});
            // 
            // Label_IP
            // 
            this.Label_IP.AutoSize = true;
            this.Label_IP.Location = new System.Drawing.Point(12, 50);
            this.Label_IP.Name = "Label_IP";
            this.Label_IP.Size = new System.Drawing.Size(66, 13);
            this.Label_IP.TabIndex = 1;
            this.Label_IP.Text = "&Endereço IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Porta";
            // 
            // Button_EstabelecerConexao
            // 
            this.Button_EstabelecerConexao.Location = new System.Drawing.Point(15, 92);
            this.Button_EstabelecerConexao.Name = "Button_EstabelecerConexao";
            this.Button_EstabelecerConexao.Size = new System.Drawing.Size(134, 23);
            this.Button_EstabelecerConexao.TabIndex = 3;
            this.Button_EstabelecerConexao.Text = "Estabelecer &Conexão";
            this.Button_EstabelecerConexao.UseVisualStyleBackColor = true;
            this.Button_EstabelecerConexao.Click += new System.EventHandler(this.Button_EstabelecerConexao_Click);
            // 
            // Button_PararServidor
            // 
            this.Button_PararServidor.Location = new System.Drawing.Point(158, 92);
            this.Button_PararServidor.Name = "Button_PararServidor";
            this.Button_PararServidor.Size = new System.Drawing.Size(134, 23);
            this.Button_PararServidor.TabIndex = 4;
            this.Button_PararServidor.Text = "Parar o &Servidor";
            this.ToolTip_Auxilios.SetToolTip(this.Button_PararServidor, "Esta ação para os serviços existentes e reinicia a aplicação.\r\n\r\nPara encerrar o " +
        "servidor de vez, clique no botão \'X\', no canto superior direito da tela, ou pres" +
        "sione ALT + F4.");
            this.Button_PararServidor.UseVisualStyleBackColor = true;
            this.Button_PararServidor.Click += new System.EventHandler(this.Button_PararServidor_Click);
            // 
            // LinkLabel_SelecionarPasta
            // 
            this.LinkLabel_SelecionarPasta.AutoEllipsis = true;
            this.LinkLabel_SelecionarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel_SelecionarPasta.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LinkLabel_SelecionarPasta.Location = new System.Drawing.Point(12, 132);
            this.LinkLabel_SelecionarPasta.Name = "LinkLabel_SelecionarPasta";
            this.LinkLabel_SelecionarPasta.Size = new System.Drawing.Size(280, 14);
            this.LinkLabel_SelecionarPasta.TabIndex = 5;
            this.LinkLabel_SelecionarPasta.TabStop = true;
            this.LinkLabel_SelecionarPasta.Text = "Cli&que para selecionar a pasta...";
            this.LinkLabel_SelecionarPasta.VisitedLinkColor = System.Drawing.Color.Blue;
            this.LinkLabel_SelecionarPasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_SelecionarPasta_LinkClicked);
            // 
            // ListBox_Logs
            // 
            this.ListBox_Logs.BackColor = System.Drawing.SystemColors.Info;
            this.ListBox_Logs.FormattingEnabled = true;
            this.ListBox_Logs.HorizontalScrollbar = true;
            this.ListBox_Logs.Location = new System.Drawing.Point(15, 158);
            this.ListBox_Logs.Name = "ListBox_Logs";
            this.ListBox_Logs.Size = new System.Drawing.Size(277, 264);
            this.ListBox_Logs.TabIndex = 6;
            // 
            // ToolTip_Auxilios
            // 
            this.ToolTip_Auxilios.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip_Auxilios.ToolTipTitle = "Informação";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ListBox_Logs);
            this.Controls.Add(this.LinkLabel_SelecionarPasta);
            this.Controls.Add(this.Button_PararServidor);
            this.Controls.Add(this.Button_EstabelecerConexao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_IP);
            this.Controls.Add(this.NumericUpDown_Porta);
            this.Controls.Add(this.TextBox_EnderecoIP);
            this.Controls.Add(this.Label_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 480);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferência de Arquivos (Server Socket)";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Porta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label_Titulo;
        internal System.Windows.Forms.TextBox TextBox_EnderecoIP;
        internal System.Windows.Forms.NumericUpDown NumericUpDown_Porta;
        internal System.Windows.Forms.Label Label_IP;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button Button_EstabelecerConexao;
        internal System.Windows.Forms.Button Button_PararServidor;
        internal System.Windows.Forms.LinkLabel LinkLabel_SelecionarPasta;
        internal System.Windows.Forms.ListBox ListBox_Logs;
        internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog_DestinoArquivos;
        internal System.Windows.Forms.ToolTip ToolTip_Auxilios;
    }
}

