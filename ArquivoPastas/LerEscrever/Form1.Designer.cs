namespace LerEscrever
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
            this.textBox_Conteudo = new System.Windows.Forms.TextBox();
            this.button_WriteTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Conteudo
            // 
            this.textBox_Conteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Conteudo.Location = new System.Drawing.Point(12, 12);
            this.textBox_Conteudo.Multiline = true;
            this.textBox_Conteudo.Name = "textBox_Conteudo";
            this.textBox_Conteudo.Size = new System.Drawing.Size(760, 488);
            this.textBox_Conteudo.TabIndex = 0;
            // 
            // button_WriteTxt
            // 
            this.button_WriteTxt.Location = new System.Drawing.Point(12, 506);
            this.button_WriteTxt.Name = "button_WriteTxt";
            this.button_WriteTxt.Size = new System.Drawing.Size(120, 43);
            this.button_WriteTxt.TabIndex = 1;
            this.button_WriteTxt.Text = "Escrever .txt";
            this.button_WriteTxt.UseVisualStyleBackColor = true;
            this.button_WriteTxt.Click += new System.EventHandler(this.button_WriteTxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_WriteTxt);
            this.Controls.Add(this.textBox_Conteudo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Ler e Escrever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Conteudo;
        private System.Windows.Forms.Button button_WriteTxt;
    }
}

