namespace Parte016
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
            this.curso_TADS = new System.Windows.Forms.RadioButton();
            this.curso_GPI = new System.Windows.Forms.RadioButton();
            this.curso_Biotec = new System.Windows.Forms.RadioButton();
            this.curso_Info = new System.Windows.Forms.RadioButton();
            this.button_Executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // curso_TADS
            // 
            this.curso_TADS.AutoSize = true;
            this.curso_TADS.Location = new System.Drawing.Point(12, 12);
            this.curso_TADS.Name = "curso_TADS";
            this.curso_TADS.Size = new System.Drawing.Size(213, 17);
            this.curso_TADS.TabIndex = 1;
            this.curso_TADS.TabStop = true;
            this.curso_TADS.Text = "Análise e Desenvolvimento de Sistemas";
            this.curso_TADS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.curso_TADS.UseVisualStyleBackColor = true;
            this.curso_TADS.CheckedChanged += new System.EventHandler(this.curso_TADS_CheckedChanged);
            // 
            // curso_GPI
            // 
            this.curso_GPI.AutoSize = true;
            this.curso_GPI.Location = new System.Drawing.Point(12, 35);
            this.curso_GPI.Name = "curso_GPI";
            this.curso_GPI.Size = new System.Drawing.Size(168, 17);
            this.curso_GPI.TabIndex = 2;
            this.curso_GPI.TabStop = true;
            this.curso_GPI.Text = "Gestão da Produção Industrial";
            this.curso_GPI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.curso_GPI.UseVisualStyleBackColor = true;
            this.curso_GPI.CheckedChanged += new System.EventHandler(this.curso_GPI_CheckedChanged);
            // 
            // curso_Biotec
            // 
            this.curso_Biotec.AutoSize = true;
            this.curso_Biotec.Location = new System.Drawing.Point(12, 58);
            this.curso_Biotec.Name = "curso_Biotec";
            this.curso_Biotec.Size = new System.Drawing.Size(148, 17);
            this.curso_Biotec.TabIndex = 3;
            this.curso_Biotec.TabStop = true;
            this.curso_Biotec.Text = "Técnico em Biotecnologia";
            this.curso_Biotec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.curso_Biotec.UseVisualStyleBackColor = true;
            this.curso_Biotec.CheckedChanged += new System.EventHandler(this.curso_Biotec_CheckedChanged);
            // 
            // curso_Info
            // 
            this.curso_Info.AutoSize = true;
            this.curso_Info.Location = new System.Drawing.Point(12, 81);
            this.curso_Info.Name = "curso_Info";
            this.curso_Info.Size = new System.Drawing.Size(136, 17);
            this.curso_Info.TabIndex = 4;
            this.curso_Info.TabStop = true;
            this.curso_Info.Text = "Técnico em Informática";
            this.curso_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.curso_Info.UseVisualStyleBackColor = true;
            this.curso_Info.CheckedChanged += new System.EventHandler(this.curso_Info_CheckedChanged);
            // 
            // button_Executar
            // 
            this.button_Executar.Location = new System.Drawing.Point(297, 106);
            this.button_Executar.Name = "button_Executar";
            this.button_Executar.Size = new System.Drawing.Size(75, 23);
            this.button_Executar.TabIndex = 0;
            this.button_Executar.Text = "Executar";
            this.button_Executar.UseVisualStyleBackColor = true;
            this.button_Executar.Click += new System.EventHandler(this.button_Executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.button_Executar);
            this.Controls.Add(this.curso_Info);
            this.Controls.Add(this.curso_Biotec);
            this.Controls.Add(this.curso_GPI);
            this.Controls.Add(this.curso_TADS);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 180);
            this.MinimumSize = new System.Drawing.Size(400, 180);
            this.Name = "Form1";
            this.Text = "Cursos do IFTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton curso_TADS;
        private System.Windows.Forms.RadioButton curso_GPI;
        private System.Windows.Forms.RadioButton curso_Biotec;
        private System.Windows.Forms.RadioButton curso_Info;
        private System.Windows.Forms.Button button_Executar;
    }
}

