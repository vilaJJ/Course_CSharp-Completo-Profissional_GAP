namespace ManipularNumeros
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
            this.button_executar = new System.Windows.Forms.Button();
            this.groupBox_resultados = new System.Windows.Forms.GroupBox();
            this.label_resultados = new System.Windows.Forms.Label();
            this.groupBox_resultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_executar
            // 
            this.button_executar.Location = new System.Drawing.Point(618, 294);
            this.button_executar.Name = "button_executar";
            this.button_executar.Size = new System.Drawing.Size(154, 55);
            this.button_executar.TabIndex = 0;
            this.button_executar.Text = "Executar";
            this.button_executar.UseVisualStyleBackColor = true;
            this.button_executar.Click += new System.EventHandler(this.button_executar_Click);
            // 
            // groupBox_resultados
            // 
            this.groupBox_resultados.Controls.Add(this.label_resultados);
            this.groupBox_resultados.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_resultados.Location = new System.Drawing.Point(0, 0);
            this.groupBox_resultados.Name = "groupBox_resultados";
            this.groupBox_resultados.Size = new System.Drawing.Size(784, 279);
            this.groupBox_resultados.TabIndex = 1;
            this.groupBox_resultados.TabStop = false;
            this.groupBox_resultados.Text = "Resultados";
            // 
            // label_resultados
            // 
            this.label_resultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_resultados.Location = new System.Drawing.Point(3, 16);
            this.label_resultados.Name = "label_resultados";
            this.label_resultados.Size = new System.Drawing.Size(778, 260);
            this.label_resultados.TabIndex = 0;
            this.label_resultados.Text = "Resultados";
            this.label_resultados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.groupBox_resultados);
            this.Controls.Add(this.button_executar);
            this.Name = "FormPrincipal";
            this.Text = "Manipular Números";
            this.groupBox_resultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_executar;
        private System.Windows.Forms.GroupBox groupBox_resultados;
        private System.Windows.Forms.Label label_resultados;
    }
}

