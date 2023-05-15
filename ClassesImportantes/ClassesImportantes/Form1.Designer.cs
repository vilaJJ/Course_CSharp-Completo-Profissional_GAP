namespace ClassesImportantes
{
    partial class ClassesImportantes
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
            this.button_MessageBox = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.button_Random = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_MessageBox
            // 
            this.button_MessageBox.Location = new System.Drawing.Point(12, 493);
            this.button_MessageBox.Name = "button_MessageBox";
            this.button_MessageBox.Size = new System.Drawing.Size(153, 56);
            this.button_MessageBox.TabIndex = 0;
            this.button_MessageBox.Text = "MessageBox";
            this.button_MessageBox.UseVisualStyleBackColor = true;
            this.button_MessageBox.Click += new System.EventHandler(this.button_MessageBox_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.Location = new System.Drawing.Point(0, 0);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(784, 133);
            this.label_resultado.TabIndex = 1;
            this.label_resultado.Text = "Resultado";
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Random
            // 
            this.button_Random.Location = new System.Drawing.Point(171, 493);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(153, 56);
            this.button_Random.TabIndex = 2;
            this.button_Random.Text = "Random";
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_Random_Click);
            // 
            // ClassesImportantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_Random);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_MessageBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ClassesImportantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classes Importantes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_MessageBox;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button button_Random;
    }
}

