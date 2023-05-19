namespace Parte041
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
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SelecFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontDialog
            // 
            this.fontDialog.ShowApply = true;
            this.fontDialog.ShowColor = true;
            this.fontDialog.Apply += new System.EventHandler(this.fontDialog_Apply);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 288);
            this.label1.TabIndex = 0;
            this.label1.Text = "Label 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_SelecFont
            // 
            this.button_SelecFont.Location = new System.Drawing.Point(236, 308);
            this.button_SelecFont.Name = "button_SelecFont";
            this.button_SelecFont.Size = new System.Drawing.Size(136, 41);
            this.button_SelecFont.TabIndex = 1;
            this.button_SelecFont.Text = "Selecione uma Fonte";
            this.button_SelecFont.UseVisualStyleBackColor = true;
            this.button_SelecFont.Click += new System.EventHandler(this.button_SelecFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.button_SelecFont);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SelecFont;
    }
}

