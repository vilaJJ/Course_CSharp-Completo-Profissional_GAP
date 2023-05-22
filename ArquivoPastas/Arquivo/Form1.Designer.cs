namespace Arquivo
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
            this.label_Resultado = new System.Windows.Forms.Label();
            this.button_Executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Resultado
            // 
            this.label_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Resultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.Location = new System.Drawing.Point(0, 0);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(784, 185);
            this.label_Resultado.TabIndex = 0;
            this.label_Resultado.Text = "Resultado";
            this.label_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Executar
            // 
            this.button_Executar.Location = new System.Drawing.Point(308, 286);
            this.button_Executar.Name = "button_Executar";
            this.button_Executar.Size = new System.Drawing.Size(169, 63);
            this.button_Executar.TabIndex = 1;
            this.button_Executar.Text = "Executar";
            this.button_Executar.UseVisualStyleBackColor = true;
            this.button_Executar.Click += new System.EventHandler(this.button_Executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button_Executar);
            this.Controls.Add(this.label_Resultado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.Button button_Executar;
    }
}

