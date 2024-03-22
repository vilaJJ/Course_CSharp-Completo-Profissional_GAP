namespace ConsumirDLL
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
            this.Button_ExibirDataHoraAtual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_ExibirDataHoraAtual
            // 
            this.Button_ExibirDataHoraAtual.Location = new System.Drawing.Point(70, 19);
            this.Button_ExibirDataHoraAtual.Name = "Button_ExibirDataHoraAtual";
            this.Button_ExibirDataHoraAtual.Size = new System.Drawing.Size(145, 23);
            this.Button_ExibirDataHoraAtual.TabIndex = 0;
            this.Button_ExibirDataHoraAtual.Text = "&Exibir data e hora atual";
            this.Button_ExibirDataHoraAtual.UseVisualStyleBackColor = true;
            this.Button_ExibirDataHoraAtual.Click += new System.EventHandler(this.Button_ExibirDataHoraAtual_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.Button_ExibirDataHoraAtual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 100);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 100);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumo de DLL";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button_ExibirDataHoraAtual;
    }
}

