namespace Parte020
{
    partial class Form1
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label_url = new System.Windows.Forms.Label();
            this.button_Navegar = new System.Windows.Forms.Button();
            this.button_Voltar = new System.Windows.Forms.Button();
            this.button_Avancar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser.Location = new System.Drawing.Point(0, 41);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(800, 409);
            this.webBrowser.TabIndex = 0;
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(47, 9);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(560, 20);
            this.textBox_url.TabIndex = 2;
            this.textBox_url.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_url_KeyUp);
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(12, 12);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(29, 13);
            this.label_url.TabIndex = 3;
            this.label_url.Text = "URL";
            // 
            // button_Navegar
            // 
            this.button_Navegar.Location = new System.Drawing.Point(713, 9);
            this.button_Navegar.Name = "button_Navegar";
            this.button_Navegar.Size = new System.Drawing.Size(75, 23);
            this.button_Navegar.TabIndex = 4;
            this.button_Navegar.Text = "Navegar";
            this.button_Navegar.UseVisualStyleBackColor = true;
            this.button_Navegar.Click += new System.EventHandler(this.button_Navegar_Click);
            // 
            // button_Voltar
            // 
            this.button_Voltar.Location = new System.Drawing.Point(655, 9);
            this.button_Voltar.Name = "button_Voltar";
            this.button_Voltar.Size = new System.Drawing.Size(23, 23);
            this.button_Voltar.TabIndex = 5;
            this.button_Voltar.Text = "<";
            this.button_Voltar.UseVisualStyleBackColor = true;
            this.button_Voltar.Click += new System.EventHandler(this.button_Voltar_Click);
            // 
            // button_Avancar
            // 
            this.button_Avancar.Location = new System.Drawing.Point(684, 9);
            this.button_Avancar.Name = "button_Avancar";
            this.button_Avancar.Size = new System.Drawing.Size(23, 23);
            this.button_Avancar.TabIndex = 6;
            this.button_Avancar.Text = ">";
            this.button_Avancar.UseVisualStyleBackColor = true;
            this.button_Avancar.Click += new System.EventHandler(this.button_Avancar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Avancar);
            this.Controls.Add(this.button_Voltar);
            this.Controls.Add(this.button_Navegar);
            this.Controls.Add(this.label_url);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.webBrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Button button_Navegar;
        private System.Windows.Forms.Button button_Voltar;
        private System.Windows.Forms.Button button_Avancar;
    }
}

