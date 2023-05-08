namespace ManipularString
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
            this.label_texto = new System.Windows.Forms.Label();
            this.button_executar = new System.Windows.Forms.Button();
            this.groupBox_itens = new System.Windows.Forms.GroupBox();
            this.groupBox_itens.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_texto
            // 
            this.label_texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_texto.Location = new System.Drawing.Point(3, 16);
            this.label_texto.Name = "label_texto";
            this.label_texto.Size = new System.Drawing.Size(778, 237);
            this.label_texto.TabIndex = 0;
            this.label_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_executar
            // 
            this.button_executar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_executar.Location = new System.Drawing.Point(649, 406);
            this.button_executar.MaximumSize = new System.Drawing.Size(123, 43);
            this.button_executar.MinimumSize = new System.Drawing.Size(123, 43);
            this.button_executar.Name = "button_executar";
            this.button_executar.Size = new System.Drawing.Size(123, 43);
            this.button_executar.TabIndex = 1;
            this.button_executar.Text = "Executar";
            this.button_executar.UseVisualStyleBackColor = true;
            this.button_executar.Click += new System.EventHandler(this.button_executar_Click);
            // 
            // groupBox_itens
            // 
            this.groupBox_itens.Controls.Add(this.label_texto);
            this.groupBox_itens.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_itens.Location = new System.Drawing.Point(0, 0);
            this.groupBox_itens.Name = "groupBox_itens";
            this.groupBox_itens.Size = new System.Drawing.Size(784, 256);
            this.groupBox_itens.TabIndex = 2;
            this.groupBox_itens.TabStop = false;
            this.groupBox_itens.Text = "Área de escrita";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox_itens);
            this.Controls.Add(this.button_executar);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_itens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_texto;
        private System.Windows.Forms.Button button_executar;
        private System.Windows.Forms.GroupBox groupBox_itens;
    }
}

