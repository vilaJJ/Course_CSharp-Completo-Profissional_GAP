namespace Imprimir
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
            this.PrintDocument_Impressao = new System.Drawing.Printing.PrintDocument();
            this.Button_Imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrintDocument_Impressao
            // 
            this.PrintDocument_Impressao.DocumentName = "documento";
            this.PrintDocument_Impressao.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_Impressao_PrintPage);
            // 
            // Button_Imprimir
            // 
            this.Button_Imprimir.Location = new System.Drawing.Point(608, 498);
            this.Button_Imprimir.Name = "Button_Imprimir";
            this.Button_Imprimir.Size = new System.Drawing.Size(164, 51);
            this.Button_Imprimir.TabIndex = 0;
            this.Button_Imprimir.Text = "&Imprimir";
            this.Button_Imprimir.UseVisualStyleBackColor = true;
            this.Button_Imprimir.Click += new System.EventHandler(this.Button_Imprimir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Button_Imprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalhando com Impressão";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Drawing.Printing.PrintDocument PrintDocument_Impressao;
        internal System.Windows.Forms.Button Button_Imprimir;
    }
}

