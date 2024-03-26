namespace CriptografiaMD5.Formularios
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
            this.TextBox_Entrada = new System.Windows.Forms.TextBox();
            this.TextBox_Saida = new System.Windows.Forms.TextBox();
            this.Button_Criptografar = new System.Windows.Forms.Button();
            this.Button_Comparar = new System.Windows.Forms.Button();
            this.Label_Entrada = new System.Windows.Forms.Label();
            this.Label_Saida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_Entrada
            // 
            this.TextBox_Entrada.Location = new System.Drawing.Point(12, 26);
            this.TextBox_Entrada.Multiline = true;
            this.TextBox_Entrada.Name = "TextBox_Entrada";
            this.TextBox_Entrada.Size = new System.Drawing.Size(360, 54);
            this.TextBox_Entrada.TabIndex = 0;
            // 
            // TextBox_Saida
            // 
            this.TextBox_Saida.Location = new System.Drawing.Point(12, 100);
            this.TextBox_Saida.Multiline = true;
            this.TextBox_Saida.Name = "TextBox_Saida";
            this.TextBox_Saida.Size = new System.Drawing.Size(360, 54);
            this.TextBox_Saida.TabIndex = 1;
            this.TextBox_Saida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Saida_KeyDown);
            // 
            // Button_Criptografar
            // 
            this.Button_Criptografar.Location = new System.Drawing.Point(12, 160);
            this.Button_Criptografar.Name = "Button_Criptografar";
            this.Button_Criptografar.Size = new System.Drawing.Size(177, 51);
            this.Button_Criptografar.TabIndex = 2;
            this.Button_Criptografar.Text = "&Criptografar";
            this.Button_Criptografar.UseVisualStyleBackColor = true;
            this.Button_Criptografar.Click += new System.EventHandler(this.Button_Criptografar_Click);
            // 
            // Button_Comparar
            // 
            this.Button_Comparar.Location = new System.Drawing.Point(195, 160);
            this.Button_Comparar.Name = "Button_Comparar";
            this.Button_Comparar.Size = new System.Drawing.Size(177, 51);
            this.Button_Comparar.TabIndex = 3;
            this.Button_Comparar.Text = "C&omparar";
            this.Button_Comparar.UseVisualStyleBackColor = true;
            this.Button_Comparar.Click += new System.EventHandler(this.Button_Comparar_Click);
            // 
            // Label_Entrada
            // 
            this.Label_Entrada.AutoSize = true;
            this.Label_Entrada.Location = new System.Drawing.Point(9, 10);
            this.Label_Entrada.Name = "Label_Entrada";
            this.Label_Entrada.Size = new System.Drawing.Size(44, 13);
            this.Label_Entrada.TabIndex = 0;
            this.Label_Entrada.Text = "&Entrada";
            // 
            // Label_Saida
            // 
            this.Label_Saida.AutoSize = true;
            this.Label_Saida.Location = new System.Drawing.Point(9, 84);
            this.Label_Saida.Name = "Label_Saida";
            this.Label_Saida.Size = new System.Drawing.Size(36, 13);
            this.Label_Saida.TabIndex = 1;
            this.Label_Saida.Text = "&Saída";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 221);
            this.Controls.Add(this.Label_Saida);
            this.Controls.Add(this.Label_Entrada);
            this.Controls.Add(this.Button_Comparar);
            this.Controls.Add(this.Button_Criptografar);
            this.Controls.Add(this.TextBox_Saida);
            this.Controls.Add(this.TextBox_Entrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 260);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criptografia MD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox_Entrada;
        internal System.Windows.Forms.TextBox TextBox_Saida;
        internal System.Windows.Forms.Button Button_Criptografar;
        internal System.Windows.Forms.Button Button_Comparar;
        internal System.Windows.Forms.Label Label_Entrada;
        internal System.Windows.Forms.Label Label_Saida;
    }
}

