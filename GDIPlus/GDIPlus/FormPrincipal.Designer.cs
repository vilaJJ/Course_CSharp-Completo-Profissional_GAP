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
            this.pictureBox_Resultado = new System.Windows.Forms.PictureBox();
            this.button_Desenhar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Resultado
            // 
            this.pictureBox_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Resultado.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Resultado.Name = "pictureBox_Resultado";
            this.pictureBox_Resultado.Size = new System.Drawing.Size(760, 476);
            this.pictureBox_Resultado.TabIndex = 0;
            this.pictureBox_Resultado.TabStop = false;
            // 
            // button_Desenhar
            // 
            this.button_Desenhar.Location = new System.Drawing.Point(630, 494);
            this.button_Desenhar.Name = "button_Desenhar";
            this.button_Desenhar.Size = new System.Drawing.Size(142, 55);
            this.button_Desenhar.TabIndex = 1;
            this.button_Desenhar.Text = "Desenhar";
            this.button_Desenhar.UseVisualStyleBackColor = true;
            this.button_Desenhar.Click += new System.EventHandler(this.button_Desenhar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_Desenhar);
            this.Controls.Add(this.pictureBox_Resultado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.Text = "GDI+";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Resultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Resultado;
        private System.Windows.Forms.Button button_Desenhar;
    }
}

