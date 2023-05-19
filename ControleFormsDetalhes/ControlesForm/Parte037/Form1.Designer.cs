namespace Parte037
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
            this.printPreview = new System.Windows.Forms.PrintPreviewControl();
            this.txtPrint = new System.Windows.Forms.RichTextBox();
            this.button_Imprimir = new System.Windows.Forms.Button();
            this.button_Visualizar = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // printPreview
            // 
            this.printPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.printPreview.Location = new System.Drawing.Point(467, 0);
            this.printPreview.Name = "printPreview";
            this.printPreview.Size = new System.Drawing.Size(333, 450);
            this.printPreview.TabIndex = 0;
            this.printPreview.Zoom = 0.38323353293413176D;
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(12, 12);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(449, 381);
            this.txtPrint.TabIndex = 1;
            this.txtPrint.Text = "";
            // 
            // button_Imprimir
            // 
            this.button_Imprimir.Location = new System.Drawing.Point(12, 399);
            this.button_Imprimir.Name = "button_Imprimir";
            this.button_Imprimir.Size = new System.Drawing.Size(108, 39);
            this.button_Imprimir.TabIndex = 2;
            this.button_Imprimir.Text = "Imprimir";
            this.button_Imprimir.UseVisualStyleBackColor = true;
            this.button_Imprimir.Click += new System.EventHandler(this.button_Imprimir_Click);
            // 
            // button_Visualizar
            // 
            this.button_Visualizar.Location = new System.Drawing.Point(353, 399);
            this.button_Visualizar.Name = "button_Visualizar";
            this.button_Visualizar.Size = new System.Drawing.Size(108, 39);
            this.button_Visualizar.TabIndex = 3;
            this.button_Visualizar.Text = "Visualizar";
            this.button_Visualizar.UseVisualStyleBackColor = true;
            this.button_Visualizar.Click += new System.EventHandler(this.button_Visualizar_Click);
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "Documento";
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Visualizar);
            this.Controls.Add(this.button_Imprimir);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.printPreview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl printPreview;
        private System.Windows.Forms.RichTextBox txtPrint;
        private System.Windows.Forms.Button button_Imprimir;
        private System.Windows.Forms.Button button_Visualizar;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}

