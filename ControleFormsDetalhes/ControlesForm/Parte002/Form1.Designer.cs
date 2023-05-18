namespace Parte002
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
            this.button_Executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Executar
            // 
            this.button_Executar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Executar.BackgroundImage = global::Parte002.Properties.Resources.gradiente_roxo;
            this.button_Executar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Executar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Executar.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.button_Executar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button_Executar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_Executar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Executar.ForeColor = System.Drawing.Color.White;
            this.button_Executar.Location = new System.Drawing.Point(280, 185);
            this.button_Executar.MaximumSize = new System.Drawing.Size(240, 80);
            this.button_Executar.MinimumSize = new System.Drawing.Size(240, 80);
            this.button_Executar.Name = "button_Executar";
            this.button_Executar.Size = new System.Drawing.Size(240, 80);
            this.button_Executar.TabIndex = 0;
            this.button_Executar.Text = "Executar";
            this.button_Executar.UseVisualStyleBackColor = false;
            this.button_Executar.Click += new System.EventHandler(this.button_Executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Executar);
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Executar;
    }
}

