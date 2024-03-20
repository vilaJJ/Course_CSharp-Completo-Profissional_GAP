namespace SocketChatServer.Formularios
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
            this.TextBox_EnderecoIP = new System.Windows.Forms.TextBox();
            this.Label_EnderecoIP = new System.Windows.Forms.Label();
            this.NumericUpDown_Porta = new System.Windows.Forms.NumericUpDown();
            this.Label_Porta = new System.Windows.Forms.Label();
            this.Button_IniciarServidor = new System.Windows.Forms.Button();
            this.ListBox_Logs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Porta)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_EnderecoIP
            // 
            this.TextBox_EnderecoIP.Location = new System.Drawing.Point(15, 25);
            this.TextBox_EnderecoIP.Name = "TextBox_EnderecoIP";
            this.TextBox_EnderecoIP.Size = new System.Drawing.Size(100, 20);
            this.TextBox_EnderecoIP.TabIndex = 0;
            this.TextBox_EnderecoIP.Text = "127.0.0.1";
            // 
            // Label_EnderecoIP
            // 
            this.Label_EnderecoIP.AutoSize = true;
            this.Label_EnderecoIP.Location = new System.Drawing.Point(12, 9);
            this.Label_EnderecoIP.Name = "Label_EnderecoIP";
            this.Label_EnderecoIP.Size = new System.Drawing.Size(66, 13);
            this.Label_EnderecoIP.TabIndex = 0;
            this.Label_EnderecoIP.Text = "&Endereço IP";
            // 
            // NumericUpDown_Porta
            // 
            this.NumericUpDown_Porta.Location = new System.Drawing.Point(121, 25);
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
            // Label_Porta
            // 
            this.Label_Porta.AutoSize = true;
            this.Label_Porta.Location = new System.Drawing.Point(118, 9);
            this.Label_Porta.Name = "Label_Porta";
            this.Label_Porta.Size = new System.Drawing.Size(32, 13);
            this.Label_Porta.TabIndex = 2;
            this.Label_Porta.Text = "&Porta";
            // 
            // Button_IniciarServidor
            // 
            this.Button_IniciarServidor.Location = new System.Drawing.Point(198, 9);
            this.Button_IniciarServidor.Name = "Button_IniciarServidor";
            this.Button_IniciarServidor.Size = new System.Drawing.Size(137, 36);
            this.Button_IniciarServidor.TabIndex = 3;
            this.Button_IniciarServidor.Text = "Iniciar &Servidor";
            this.Button_IniciarServidor.UseVisualStyleBackColor = true;
            this.Button_IniciarServidor.Click += new System.EventHandler(this.Button_IniciarServidor_Click);
            // 
            // ListBox_Logs
            // 
            this.ListBox_Logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListBox_Logs.FormattingEnabled = true;
            this.ListBox_Logs.ItemHeight = 16;
            this.ListBox_Logs.Location = new System.Drawing.Point(15, 51);
            this.ListBox_Logs.Name = "ListBox_Logs";
            this.ListBox_Logs.Size = new System.Drawing.Size(320, 196);
            this.ListBox_Logs.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.ListBox_Logs);
            this.Controls.Add(this.Button_IniciarServidor);
            this.Controls.Add(this.Label_Porta);
            this.Controls.Add(this.NumericUpDown_Porta);
            this.Controls.Add(this.Label_EnderecoIP);
            this.Controls.Add(this.TextBox_EnderecoIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 300);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor de Chat";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Porta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label_EnderecoIP;
        internal System.Windows.Forms.TextBox TextBox_EnderecoIP;
        internal System.Windows.Forms.NumericUpDown NumericUpDown_Porta;
        internal System.Windows.Forms.Label Label_Porta;
        internal System.Windows.Forms.Button Button_IniciarServidor;
        internal System.Windows.Forms.ListBox ListBox_Logs;
    }
}

