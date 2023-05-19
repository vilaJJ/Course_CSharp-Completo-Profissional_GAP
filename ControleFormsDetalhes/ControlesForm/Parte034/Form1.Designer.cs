namespace Parte034
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
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.button_ConfPag = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument1;
            this.pageSetupDialog.EnableMetric = true;
            this.pageSetupDialog.ShowHelp = true;
            // 
            // button_ConfPag
            // 
            this.button_ConfPag.Location = new System.Drawing.Point(12, 12);
            this.button_ConfPag.Name = "button_ConfPag";
            this.button_ConfPag.Size = new System.Drawing.Size(260, 237);
            this.button_ConfPag.TabIndex = 0;
            this.button_ConfPag.Text = "Configurar Página";
            this.button_ConfPag.UseVisualStyleBackColor = true;
            this.button_ConfPag.Click += new System.EventHandler(this.button_ConfPag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_ConfPag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.Button button_ConfPag;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

