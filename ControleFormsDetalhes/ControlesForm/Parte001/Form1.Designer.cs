namespace Parte001
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
            this.label_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoEllipsis = true;
            this.label_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.ForeColor = System.Drawing.Color.White;
            this.label_Titulo.Image = global::Parte001.Properties.Resources.gradiente_roxo;
            this.label_Titulo.Location = new System.Drawing.Point(157, 78);
            this.label_Titulo.Margin = new System.Windows.Forms.Padding(10);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Padding = new System.Windows.Forms.Padding(20);
            this.label_Titulo.Size = new System.Drawing.Size(486, 295);
            this.label_Titulo.TabIndex = 0;
            this.label_Titulo.Text = "Juan Felipe\r\nCurso de C# Completo e Profissional";
            this.label_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Titulo.Click += new System.EventHandler(this.label_Titulo_Click);
            this.label_Titulo.MouseEnter += new System.EventHandler(this.label_Titulo_MouseEnter);
            this.label_Titulo.MouseLeave += new System.EventHandler(this.label_Titulo_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Titulo;
    }
}

