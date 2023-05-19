namespace Parte021
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
            this.panel_Sexo = new System.Windows.Forms.Panel();
            this.radioButton_masc = new System.Windows.Forms.RadioButton();
            this.radioButton_fem = new System.Windows.Forms.RadioButton();
            this.radioButton_Crianca = new System.Windows.Forms.RadioButton();
            this.radioButton_Adulto = new System.Windows.Forms.RadioButton();
            this.radioButton_Idoso = new System.Windows.Forms.RadioButton();
            this.panel_FaixaEtaria = new System.Windows.Forms.Panel();
            this.panel_Sexo.SuspendLayout();
            this.panel_FaixaEtaria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Sexo
            // 
            this.panel_Sexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Sexo.Controls.Add(this.radioButton_masc);
            this.panel_Sexo.Controls.Add(this.radioButton_fem);
            this.panel_Sexo.Location = new System.Drawing.Point(57, 11);
            this.panel_Sexo.Name = "panel_Sexo";
            this.panel_Sexo.Size = new System.Drawing.Size(88, 51);
            this.panel_Sexo.TabIndex = 0;
            // 
            // radioButton_masc
            // 
            this.radioButton_masc.AutoSize = true;
            this.radioButton_masc.Location = new System.Drawing.Point(3, 3);
            this.radioButton_masc.Name = "radioButton_masc";
            this.radioButton_masc.Size = new System.Drawing.Size(73, 17);
            this.radioButton_masc.TabIndex = 1;
            this.radioButton_masc.TabStop = true;
            this.radioButton_masc.Text = "Masculino";
            this.radioButton_masc.UseVisualStyleBackColor = true;
            // 
            // radioButton_fem
            // 
            this.radioButton_fem.AutoSize = true;
            this.radioButton_fem.Location = new System.Drawing.Point(3, 26);
            this.radioButton_fem.Name = "radioButton_fem";
            this.radioButton_fem.Size = new System.Drawing.Size(67, 17);
            this.radioButton_fem.TabIndex = 2;
            this.radioButton_fem.TabStop = true;
            this.radioButton_fem.Text = "Feminino";
            this.radioButton_fem.UseVisualStyleBackColor = true;
            // 
            // radioButton_Crianca
            // 
            this.radioButton_Crianca.AutoSize = true;
            this.radioButton_Crianca.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Crianca.Name = "radioButton_Crianca";
            this.radioButton_Crianca.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Crianca.TabIndex = 3;
            this.radioButton_Crianca.TabStop = true;
            this.radioButton_Crianca.Text = "Criança";
            this.radioButton_Crianca.UseVisualStyleBackColor = true;
            // 
            // radioButton_Adulto
            // 
            this.radioButton_Adulto.AutoSize = true;
            this.radioButton_Adulto.Location = new System.Drawing.Point(3, 26);
            this.radioButton_Adulto.Name = "radioButton_Adulto";
            this.radioButton_Adulto.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Adulto.TabIndex = 4;
            this.radioButton_Adulto.TabStop = true;
            this.radioButton_Adulto.Text = "Adulto";
            this.radioButton_Adulto.UseVisualStyleBackColor = true;
            // 
            // radioButton_Idoso
            // 
            this.radioButton_Idoso.AutoSize = true;
            this.radioButton_Idoso.Location = new System.Drawing.Point(3, 49);
            this.radioButton_Idoso.Name = "radioButton_Idoso";
            this.radioButton_Idoso.Size = new System.Drawing.Size(51, 17);
            this.radioButton_Idoso.TabIndex = 5;
            this.radioButton_Idoso.TabStop = true;
            this.radioButton_Idoso.Text = "Idoso";
            this.radioButton_Idoso.UseVisualStyleBackColor = true;
            // 
            // panel_FaixaEtaria
            // 
            this.panel_FaixaEtaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_FaixaEtaria.Controls.Add(this.radioButton_Crianca);
            this.panel_FaixaEtaria.Controls.Add(this.radioButton_Idoso);
            this.panel_FaixaEtaria.Controls.Add(this.radioButton_Adulto);
            this.panel_FaixaEtaria.Location = new System.Drawing.Point(57, 68);
            this.panel_FaixaEtaria.Name = "panel_FaixaEtaria";
            this.panel_FaixaEtaria.Size = new System.Drawing.Size(88, 76);
            this.panel_FaixaEtaria.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 155);
            this.Controls.Add(this.panel_FaixaEtaria);
            this.Controls.Add(this.panel_Sexo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_Sexo.ResumeLayout(false);
            this.panel_Sexo.PerformLayout();
            this.panel_FaixaEtaria.ResumeLayout(false);
            this.panel_FaixaEtaria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Sexo;
        private System.Windows.Forms.RadioButton radioButton_masc;
        private System.Windows.Forms.RadioButton radioButton_fem;
        private System.Windows.Forms.RadioButton radioButton_Crianca;
        private System.Windows.Forms.RadioButton radioButton_Adulto;
        private System.Windows.Forms.RadioButton radioButton_Idoso;
        private System.Windows.Forms.Panel panel_FaixaEtaria;
    }
}

