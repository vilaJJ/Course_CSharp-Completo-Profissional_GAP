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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PrintDocument_Impressao = new System.Drawing.Printing.PrintDocument();
            this.Button_Imprimir = new System.Windows.Forms.Button();
            this.PrintPreviewControl_Documento = new System.Windows.Forms.PrintPreviewControl();
            this.Button_Visualizar = new System.Windows.Forms.Button();
            this.Button_Anterior = new System.Windows.Forms.Button();
            this.Button_Proximo = new System.Windows.Forms.Button();
            this.Button_VisualizarPadrao = new System.Windows.Forms.Button();
            this.PrintPreviewDialog_Impressao = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDialog_ConfiguracaoImpressao = new System.Windows.Forms.PrintDialog();
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
            this.Button_Imprimir.TabIndex = 4;
            this.Button_Imprimir.Text = "&Imprimir";
            this.Button_Imprimir.UseVisualStyleBackColor = true;
            this.Button_Imprimir.Click += new System.EventHandler(this.Button_Imprimir_Click);
            // 
            // PrintPreviewControl_Documento
            // 
            this.PrintPreviewControl_Documento.Location = new System.Drawing.Point(12, 12);
            this.PrintPreviewControl_Documento.Name = "PrintPreviewControl_Documento";
            this.PrintPreviewControl_Documento.Size = new System.Drawing.Size(574, 537);
            this.PrintPreviewControl_Documento.TabIndex = 0;
            // 
            // Button_Visualizar
            // 
            this.Button_Visualizar.Location = new System.Drawing.Point(608, 12);
            this.Button_Visualizar.Name = "Button_Visualizar";
            this.Button_Visualizar.Size = new System.Drawing.Size(164, 51);
            this.Button_Visualizar.TabIndex = 1;
            this.Button_Visualizar.Text = "&Visualizar";
            this.Button_Visualizar.UseVisualStyleBackColor = true;
            this.Button_Visualizar.Click += new System.EventHandler(this.Button_Visualizar_Click);
            // 
            // Button_Anterior
            // 
            this.Button_Anterior.Location = new System.Drawing.Point(608, 69);
            this.Button_Anterior.Name = "Button_Anterior";
            this.Button_Anterior.Size = new System.Drawing.Size(80, 51);
            this.Button_Anterior.TabIndex = 2;
            this.Button_Anterior.Text = "&Anterior";
            this.Button_Anterior.UseVisualStyleBackColor = true;
            this.Button_Anterior.Click += new System.EventHandler(this.Button_Anterior_Click);
            // 
            // Button_Proximo
            // 
            this.Button_Proximo.Location = new System.Drawing.Point(694, 69);
            this.Button_Proximo.Name = "Button_Proximo";
            this.Button_Proximo.Size = new System.Drawing.Size(80, 51);
            this.Button_Proximo.TabIndex = 3;
            this.Button_Proximo.Text = "&Próximo";
            this.Button_Proximo.UseVisualStyleBackColor = true;
            this.Button_Proximo.Click += new System.EventHandler(this.Button_Proximo_Click);
            // 
            // Button_VisualizarPadrao
            // 
            this.Button_VisualizarPadrao.Location = new System.Drawing.Point(608, 441);
            this.Button_VisualizarPadrao.Name = "Button_VisualizarPadrao";
            this.Button_VisualizarPadrao.Size = new System.Drawing.Size(164, 51);
            this.Button_VisualizarPadrao.TabIndex = 5;
            this.Button_VisualizarPadrao.Text = "Vis&ualizador Padrão";
            this.Button_VisualizarPadrao.UseVisualStyleBackColor = true;
            this.Button_VisualizarPadrao.Click += new System.EventHandler(this.Button_VisualizarPadrao_Click);
            // 
            // PrintPreviewDialog_Impressao
            // 
            this.PrintPreviewDialog_Impressao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog_Impressao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog_Impressao.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog_Impressao.Enabled = true;
            this.PrintPreviewDialog_Impressao.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog_Impressao.Icon")));
            this.PrintPreviewDialog_Impressao.Name = "PrintPreviewDialog_Impressao";
            this.PrintPreviewDialog_Impressao.Visible = false;
            // 
            // PrintDialog_ConfiguracaoImpressao
            // 
            this.PrintDialog_ConfiguracaoImpressao.UseEXDialog = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Button_VisualizarPadrao);
            this.Controls.Add(this.Button_Proximo);
            this.Controls.Add(this.Button_Anterior);
            this.Controls.Add(this.Button_Visualizar);
            this.Controls.Add(this.PrintPreviewControl_Documento);
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
        internal System.Windows.Forms.PrintPreviewControl PrintPreviewControl_Documento;
        internal System.Windows.Forms.Button Button_Visualizar;
        internal System.Windows.Forms.Button Button_Anterior;
        internal System.Windows.Forms.Button Button_Proximo;
        internal System.Windows.Forms.Button Button_VisualizarPadrao;
        internal System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog_Impressao;
        internal System.Windows.Forms.PrintDialog PrintDialog_ConfiguracaoImpressao;
    }
}

