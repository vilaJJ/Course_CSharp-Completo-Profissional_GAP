namespace Parte003
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
            this.textBox_Mensagem = new System.Windows.Forms.TextBox();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Mensagem
            // 
            this.textBox_Mensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Mensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Mensagem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Mensagem.ForeColor = System.Drawing.Color.Magenta;
            this.textBox_Mensagem.Location = new System.Drawing.Point(149, 144);
            this.textBox_Mensagem.Multiline = true;
            this.textBox_Mensagem.Name = "textBox_Mensagem";
            this.textBox_Mensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Mensagem.Size = new System.Drawing.Size(502, 163);
            this.textBox_Mensagem.TabIndex = 0;
            this.textBox_Mensagem.TextChanged += new System.EventHandler(this.textBox_Mensagem_TextChanged);
            // 
            // label_Resultado
            // 
            this.label_Resultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.Location = new System.Drawing.Point(0, 0);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(800, 124);
            this.label_Resultado.TabIndex = 1;
            this.label_Resultado.Text = "Resultado";
            this.label_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.textBox_Mensagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Mensagem;
        private System.Windows.Forms.Label label_Resultado;
    }
}

