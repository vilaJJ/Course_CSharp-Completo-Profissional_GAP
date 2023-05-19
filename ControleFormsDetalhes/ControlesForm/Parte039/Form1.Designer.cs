namespace Parte039
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label_Cor = new System.Windows.Forms.Label();
            this.button_Cor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.ShowHelp = true;
            // 
            // label_Cor
            // 
            this.label_Cor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Cor.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cor.Location = new System.Drawing.Point(0, 0);
            this.label_Cor.Name = "label_Cor";
            this.label_Cor.Size = new System.Drawing.Size(384, 295);
            this.label_Cor.TabIndex = 0;
            this.label_Cor.Text = "Selecione a cor";
            this.label_Cor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Cor
            // 
            this.button_Cor.Location = new System.Drawing.Point(12, 318);
            this.button_Cor.Name = "button_Cor";
            this.button_Cor.Size = new System.Drawing.Size(86, 31);
            this.button_Cor.TabIndex = 1;
            this.button_Cor.Text = "Selecionar Cor";
            this.button_Cor.UseVisualStyleBackColor = true;
            this.button_Cor.Click += new System.EventHandler(this.button_Cor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button_Cor);
            this.Controls.Add(this.label_Cor);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label_Cor;
        private System.Windows.Forms.Button button_Cor;
    }
}

