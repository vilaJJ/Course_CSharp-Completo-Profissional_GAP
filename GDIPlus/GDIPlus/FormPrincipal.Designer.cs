namespace GDIPlus
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
            this.PictureBox_Resultado = new System.Windows.Forms.PictureBox();
            this.Button_Desenhar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Resultado
            // 
            this.PictureBox_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_Resultado.Location = new System.Drawing.Point(16, 15);
            this.PictureBox_Resultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox_Resultado.Name = "pictureBox_Resultado";
            this.PictureBox_Resultado.Size = new System.Drawing.Size(1233, 569);
            this.PictureBox_Resultado.TabIndex = 0;
            this.PictureBox_Resultado.TabStop = false;
            // 
            // button_Desenhar
            // 
            this.Button_Desenhar.Location = new System.Drawing.Point(1060, 592);
            this.Button_Desenhar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Desenhar.Name = "button_Desenhar";
            this.Button_Desenhar.Size = new System.Drawing.Size(189, 68);
            this.Button_Desenhar.TabIndex = 1;
            this.Button_Desenhar.Text = "&Desenhar";
            this.Button_Desenhar.UseVisualStyleBackColor = true;
            this.Button_Desenhar.Click += new System.EventHandler(this.Button_Desenhar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Button_Desenhar);
            this.Controls.Add(this.PictureBox_Resultado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDI+";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Resultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Resultado;
        private System.Windows.Forms.Button Button_Desenhar;
    }
}

