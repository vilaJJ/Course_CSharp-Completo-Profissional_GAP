namespace SocketChatClient.Formularios
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
            this.Button_Conectar = new System.Windows.Forms.Button();
            this.Label_Porta = new System.Windows.Forms.Label();
            this.NumericUpDown_Porta = new System.Windows.Forms.NumericUpDown();
            this.Label_EnderecoIP = new System.Windows.Forms.Label();
            this.TextBox_EnderecoIP = new System.Windows.Forms.TextBox();
            this.Label_NomeUsuario = new System.Windows.Forms.Label();
            this.TextBox_NomeUsuario = new System.Windows.Forms.TextBox();
            this.StatusStrip_StatusConexao = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel_StatusConectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBox_Mensagem = new System.Windows.Forms.TextBox();
            this.Button_EnviarMensagem = new System.Windows.Forms.Button();
            this.TextBox_MensagensRecebidas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Porta)).BeginInit();
            this.StatusStrip_StatusConexao.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Conectar
            // 
            this.Button_Conectar.Location = new System.Drawing.Point(195, 27);
            this.Button_Conectar.Name = "Button_Conectar";
            this.Button_Conectar.Size = new System.Drawing.Size(137, 59);
            this.Button_Conectar.TabIndex = 3;
            this.Button_Conectar.Text = "&Conectar";
            this.Button_Conectar.UseVisualStyleBackColor = true;
            this.Button_Conectar.Click += new System.EventHandler(this.Button_Conectar_Click);
            // 
            // Label_Porta
            // 
            this.Label_Porta.AutoSize = true;
            this.Label_Porta.Location = new System.Drawing.Point(115, 11);
            this.Label_Porta.Name = "Label_Porta";
            this.Label_Porta.Size = new System.Drawing.Size(32, 13);
            this.Label_Porta.TabIndex = 1;
            this.Label_Porta.Text = "&Porta";
            // 
            // NumericUpDown_Porta
            // 
            this.NumericUpDown_Porta.Location = new System.Drawing.Point(118, 27);
            this.NumericUpDown_Porta.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumericUpDown_Porta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown_Porta.Name = "NumericUpDown_Porta";
            this.NumericUpDown_Porta.Size = new System.Drawing.Size(61, 20);
            this.NumericUpDown_Porta.TabIndex = 1;
            this.NumericUpDown_Porta.Value = new decimal(new int[] {
            7895,
            0,
            0,
            0});
            // 
            // Label_EnderecoIP
            // 
            this.Label_EnderecoIP.AutoSize = true;
            this.Label_EnderecoIP.Location = new System.Drawing.Point(9, 11);
            this.Label_EnderecoIP.Name = "Label_EnderecoIP";
            this.Label_EnderecoIP.Size = new System.Drawing.Size(66, 13);
            this.Label_EnderecoIP.TabIndex = 0;
            this.Label_EnderecoIP.Text = "&Endereço IP";
            // 
            // TextBox_EnderecoIP
            // 
            this.TextBox_EnderecoIP.Location = new System.Drawing.Point(12, 27);
            this.TextBox_EnderecoIP.Name = "TextBox_EnderecoIP";
            this.TextBox_EnderecoIP.Size = new System.Drawing.Size(100, 20);
            this.TextBox_EnderecoIP.TabIndex = 0;
            this.TextBox_EnderecoIP.Text = "127.0.0.1";
            // 
            // Label_NomeUsuario
            // 
            this.Label_NomeUsuario.AutoSize = true;
            this.Label_NomeUsuario.Location = new System.Drawing.Point(9, 50);
            this.Label_NomeUsuario.Name = "Label_NomeUsuario";
            this.Label_NomeUsuario.Size = new System.Drawing.Size(89, 13);
            this.Label_NomeUsuario.TabIndex = 2;
            this.Label_NomeUsuario.Text = "Nome de &Usuário";
            // 
            // TextBox_NomeUsuario
            // 
            this.TextBox_NomeUsuario.Location = new System.Drawing.Point(12, 66);
            this.TextBox_NomeUsuario.Name = "TextBox_NomeUsuario";
            this.TextBox_NomeUsuario.Size = new System.Drawing.Size(167, 20);
            this.TextBox_NomeUsuario.TabIndex = 2;
            this.TextBox_NomeUsuario.Text = "vilaJJ";
            // 
            // StatusStrip_StatusConexao
            // 
            this.StatusStrip_StatusConexao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel_StatusConectado});
            this.StatusStrip_StatusConexao.Location = new System.Drawing.Point(0, 419);
            this.StatusStrip_StatusConexao.Name = "StatusStrip_StatusConexao";
            this.StatusStrip_StatusConexao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusStrip_StatusConexao.Size = new System.Drawing.Size(344, 22);
            this.StatusStrip_StatusConexao.SizingGrip = false;
            this.StatusStrip_StatusConexao.TabIndex = 7;
            this.StatusStrip_StatusConexao.Text = "StatusStrip_StatusConexao";
            // 
            // ToolStripStatusLabel_StatusConectado
            // 
            this.ToolStripStatusLabel_StatusConectado.Name = "ToolStripStatusLabel_StatusConectado";
            this.ToolStripStatusLabel_StatusConectado.Size = new System.Drawing.Size(88, 17);
            this.ToolStripStatusLabel_StatusConectado.Text = "Não conectado";
            // 
            // TextBox_Mensagem
            // 
            this.TextBox_Mensagem.Enabled = false;
            this.TextBox_Mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox_Mensagem.Location = new System.Drawing.Point(12, 393);
            this.TextBox_Mensagem.Name = "TextBox_Mensagem";
            this.TextBox_Mensagem.Size = new System.Drawing.Size(239, 23);
            this.TextBox_Mensagem.TabIndex = 5;
            this.TextBox_Mensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Mensagem_KeyPress);
            // 
            // Button_EnviarMensagem
            // 
            this.Button_EnviarMensagem.Enabled = false;
            this.Button_EnviarMensagem.Location = new System.Drawing.Point(257, 393);
            this.Button_EnviarMensagem.Name = "Button_EnviarMensagem";
            this.Button_EnviarMensagem.Size = new System.Drawing.Size(75, 23);
            this.Button_EnviarMensagem.TabIndex = 6;
            this.Button_EnviarMensagem.Text = "En&viar";
            this.Button_EnviarMensagem.UseVisualStyleBackColor = true;
            this.Button_EnviarMensagem.Click += new System.EventHandler(this.Button_EnviarMensagem_Click);
            // 
            // TextBox_MensagensRecebidas
            // 
            this.TextBox_MensagensRecebidas.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox_MensagensRecebidas.Location = new System.Drawing.Point(12, 92);
            this.TextBox_MensagensRecebidas.MaxLength = 2147483647;
            this.TextBox_MensagensRecebidas.Multiline = true;
            this.TextBox_MensagensRecebidas.Name = "TextBox_MensagensRecebidas";
            this.TextBox_MensagensRecebidas.ReadOnly = true;
            this.TextBox_MensagensRecebidas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_MensagensRecebidas.Size = new System.Drawing.Size(320, 295);
            this.TextBox_MensagensRecebidas.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.TextBox_MensagensRecebidas);
            this.Controls.Add(this.Button_EnviarMensagem);
            this.Controls.Add(this.TextBox_Mensagem);
            this.Controls.Add(this.StatusStrip_StatusConexao);
            this.Controls.Add(this.Label_NomeUsuario);
            this.Controls.Add(this.TextBox_NomeUsuario);
            this.Controls.Add(this.Button_Conectar);
            this.Controls.Add(this.Label_Porta);
            this.Controls.Add(this.NumericUpDown_Porta);
            this.Controls.Add(this.Label_EnderecoIP);
            this.Controls.Add(this.TextBox_EnderecoIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 480);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat - Socket";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Porta)).EndInit();
            this.StatusStrip_StatusConexao.ResumeLayout(false);
            this.StatusStrip_StatusConexao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button_Conectar;
        internal System.Windows.Forms.Label Label_Porta;
        internal System.Windows.Forms.NumericUpDown NumericUpDown_Porta;
        internal System.Windows.Forms.Label Label_EnderecoIP;
        internal System.Windows.Forms.TextBox TextBox_EnderecoIP;
        internal System.Windows.Forms.Label Label_NomeUsuario;
        internal System.Windows.Forms.TextBox TextBox_NomeUsuario;
        internal System.Windows.Forms.StatusStrip StatusStrip_StatusConexao;
        internal System.Windows.Forms.TextBox TextBox_Mensagem;
        internal System.Windows.Forms.Button Button_EnviarMensagem;
        internal System.Windows.Forms.TextBox TextBox_MensagensRecebidas;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_StatusConectado;
    }
}

