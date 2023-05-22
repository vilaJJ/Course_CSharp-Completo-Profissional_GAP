namespace ArquivoInfio
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
            this.button_Executar = new System.Windows.Forms.Button();
            this.listBox_Dados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Executar
            // 
            this.button_Executar.Location = new System.Drawing.Point(285, 485);
            this.button_Executar.Name = "button_Executar";
            this.button_Executar.Size = new System.Drawing.Size(214, 64);
            this.button_Executar.TabIndex = 0;
            this.button_Executar.Text = "Executar";
            this.button_Executar.UseVisualStyleBackColor = true;
            this.button_Executar.Click += new System.EventHandler(this.button_Executar_Click);
            // 
            // listBox_Dados
            // 
            this.listBox_Dados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Dados.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_Dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Dados.FormattingEnabled = true;
            this.listBox_Dados.ItemHeight = 25;
            this.listBox_Dados.Location = new System.Drawing.Point(0, 0);
            this.listBox_Dados.Name = "listBox_Dados";
            this.listBox_Dados.Size = new System.Drawing.Size(784, 452);
            this.listBox_Dados.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listBox_Dados);
            this.Controls.Add(this.button_Executar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Executar;
        private System.Windows.Forms.ListBox listBox_Dados;
    }
}

