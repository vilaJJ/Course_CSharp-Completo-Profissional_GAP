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
            this.button_ReadTxt = new System.Windows.Forms.Button();
            this.Button_Limpar = new System.Windows.Forms.Button();
            this.Button_ReadBin = new System.Windows.Forms.Button();
            this.Button_WriteBin = new System.Windows.Forms.Button();
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
            this.button_WriteTxt.Click += new System.EventHandler(this.Button_WriteTxt_Click);
            // 
            // button_ReadTxt
            // 
            this.button_ReadTxt.Location = new System.Drawing.Point(138, 506);
            this.button_ReadTxt.Name = "button_ReadTxt";
            this.button_ReadTxt.Size = new System.Drawing.Size(120, 43);
            this.button_ReadTxt.TabIndex = 2;
            this.button_ReadTxt.Text = "Ler .txt";
            this.button_ReadTxt.UseVisualStyleBackColor = true;
            this.button_ReadTxt.Click += new System.EventHandler(this.Button_ReadTxt_Click);
            // 
            // Button_Limpar
            // 
            this.Button_Limpar.Location = new System.Drawing.Point(697, 526);
            this.Button_Limpar.Name = "Button_Limpar";
            this.Button_Limpar.Size = new System.Drawing.Size(75, 23);
            this.Button_Limpar.TabIndex = 3;
            this.Button_Limpar.Text = "Limpar";
            this.Button_Limpar.UseVisualStyleBackColor = true;
            this.Button_Limpar.Click += new System.EventHandler(this.Button_Limpar_Click);
            // 
            // Button_ReadBin
            // 
            this.Button_ReadBin.Location = new System.Drawing.Point(264, 506);
            this.Button_ReadBin.Name = "Button_ReadBin";
            this.Button_ReadBin.Size = new System.Drawing.Size(120, 43);
            this.Button_ReadBin.TabIndex = 4;
            this.Button_ReadBin.Text = "Ler Binary";
            this.Button_ReadBin.UseVisualStyleBackColor = true;
            this.Button_ReadBin.Click += new System.EventHandler(this.Button_ReadBin_Click);
            // 
            // Button_WriteBin
            // 
            this.Button_WriteBin.Location = new System.Drawing.Point(390, 506);
            this.Button_WriteBin.Name = "Button_WriteBin";
            this.Button_WriteBin.Size = new System.Drawing.Size(120, 43);
            this.Button_WriteBin.TabIndex = 5;
            this.Button_WriteBin.Text = "Escrever Binary";
            this.Button_WriteBin.UseVisualStyleBackColor = true;
            this.Button_WriteBin.Click += new System.EventHandler(this.Button_WriteBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Button_WriteBin);
            this.Controls.Add(this.Button_ReadBin);
            this.Controls.Add(this.Button_Limpar);
            this.Controls.Add(this.button_ReadTxt);
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
        private System.Windows.Forms.Button button_ReadTxt;
        private System.Windows.Forms.Button Button_Limpar;
        private System.Windows.Forms.Button Button_ReadBin;
        private System.Windows.Forms.Button Button_WriteBin;
    }
}

