namespace Parte042
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.button_SelecArch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lista_Arquivos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Multiselect = true;
            this.openFile.Title = "Selecione uma imagem";
            // 
            // button_SelecArch
            // 
            this.button_SelecArch.Location = new System.Drawing.Point(652, 317);
            this.button_SelecArch.Name = "button_SelecArch";
            this.button_SelecArch.Size = new System.Drawing.Size(120, 32);
            this.button_SelecArch.TabIndex = 0;
            this.button_SelecArch.Text = "Selecionar Arquivo";
            this.button_SelecArch.UseVisualStyleBackColor = true;
            this.button_SelecArch.Click += new System.EventHandler(this.button_SelecArch_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 194);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho do arquivo: não selecionado.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lista_Arquivos
            // 
            this.lista_Arquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lista_Arquivos.FormattingEnabled = true;
            this.lista_Arquivos.Location = new System.Drawing.Point(3, 16);
            this.lista_Arquivos.Name = "lista_Arquivos";
            this.lista_Arquivos.ScrollAlwaysVisible = true;
            this.lista_Arquivos.Size = new System.Drawing.Size(418, 133);
            this.lista_Arquivos.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lista_Arquivos);
            this.groupBox1.Location = new System.Drawing.Point(0, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivos selecionados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SelecArch);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button button_SelecArch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lista_Arquivos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

