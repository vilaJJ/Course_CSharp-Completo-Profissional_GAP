namespace Parte043
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
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SaveArch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveFile
            // 
            this.saveFile.Title = "Salvar o arquivo";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 296);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo salvo: Nenhum arquivo salvo.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_SaveArch
            // 
            this.button_SaveArch.Location = new System.Drawing.Point(272, 313);
            this.button_SaveArch.Name = "button_SaveArch";
            this.button_SaveArch.Size = new System.Drawing.Size(100, 36);
            this.button_SaveArch.TabIndex = 1;
            this.button_SaveArch.Text = "Salvar Arquivo";
            this.button_SaveArch.UseVisualStyleBackColor = true;
            this.button_SaveArch.Click += new System.EventHandler(this.button_SaveArch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button_SaveArch);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SaveArch;
    }
}

