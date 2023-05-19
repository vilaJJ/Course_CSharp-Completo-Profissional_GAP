namespace Parte036
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
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button_Imprimir = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.button_CfgPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "Documento";
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(260, 187);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // button_Imprimir
            // 
            this.button_Imprimir.Location = new System.Drawing.Point(12, 205);
            this.button_Imprimir.Name = "button_Imprimir";
            this.button_Imprimir.Size = new System.Drawing.Size(118, 44);
            this.button_Imprimir.TabIndex = 1;
            this.button_Imprimir.Text = "Imprimir";
            this.button_Imprimir.UseVisualStyleBackColor = true;
            this.button_Imprimir.Click += new System.EventHandler(this.button_Imprimir_Click);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            this.pageSetupDialog.EnableMetric = true;
            this.pageSetupDialog.ShowHelp = true;
            // 
            // button_CfgPage
            // 
            this.button_CfgPage.Location = new System.Drawing.Point(154, 205);
            this.button_CfgPage.Name = "button_CfgPage";
            this.button_CfgPage.Size = new System.Drawing.Size(118, 44);
            this.button_CfgPage.TabIndex = 2;
            this.button_CfgPage.Text = "Configurar e Imprimir";
            this.button_CfgPage.UseVisualStyleBackColor = true;
            this.button_CfgPage.Click += new System.EventHandler(this.button_CfgPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_CfgPage);
            this.Controls.Add(this.button_Imprimir);
            this.Controls.Add(this.richTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button button_Imprimir;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.Button button_CfgPage;
    }
}

