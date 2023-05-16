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
            this.button_TimeSpan = new System.Windows.Forms.Button();
            this.button_DateTime = new System.Windows.Forms.Button();
            this.button_Color = new System.Windows.Forms.Button();
            this.button_Font = new System.Windows.Forms.Button();
            this.button_Environment = new System.Windows.Forms.Button();
            this.button_Application = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_MessageBox
            // 
            this.button_MessageBox.Location = new System.Drawing.Point(12, 430);
            this.button_MessageBox.Name = "button_MessageBox";
            this.button_MessageBox.Size = new System.Drawing.Size(136, 56);
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
            this.label_resultado.Size = new System.Drawing.Size(784, 427);
            this.label_resultado.TabIndex = 1;
            this.label_resultado.Text = "Resultado";
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Random
            // 
            this.button_Random.Location = new System.Drawing.Point(168, 430);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(136, 56);
            this.button_Random.TabIndex = 2;
            this.button_Random.Text = "Random";
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_Random_Click);
            // 
            // button_TimeSpan
            // 
            this.button_TimeSpan.Location = new System.Drawing.Point(324, 430);
            this.button_TimeSpan.Name = "button_TimeSpan";
            this.button_TimeSpan.Size = new System.Drawing.Size(136, 56);
            this.button_TimeSpan.TabIndex = 3;
            this.button_TimeSpan.Text = "TimeSpan";
            this.button_TimeSpan.UseVisualStyleBackColor = true;
            this.button_TimeSpan.Click += new System.EventHandler(this.button_TimeSpan_Click);
            // 
            // button_DateTime
            // 
            this.button_DateTime.Location = new System.Drawing.Point(480, 430);
            this.button_DateTime.Name = "button_DateTime";
            this.button_DateTime.Size = new System.Drawing.Size(136, 56);
            this.button_DateTime.TabIndex = 4;
            this.button_DateTime.Text = "DateTime";
            this.button_DateTime.UseVisualStyleBackColor = true;
            this.button_DateTime.Click += new System.EventHandler(this.button_DateTime_Click);
            // 
            // button_Color
            // 
            this.button_Color.Location = new System.Drawing.Point(636, 430);
            this.button_Color.Name = "button_Color";
            this.button_Color.Size = new System.Drawing.Size(136, 56);
            this.button_Color.TabIndex = 5;
            this.button_Color.Text = "Color";
            this.button_Color.UseVisualStyleBackColor = true;
            this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // button_Font
            // 
            this.button_Font.Location = new System.Drawing.Point(12, 493);
            this.button_Font.Name = "button_Font";
            this.button_Font.Size = new System.Drawing.Size(136, 56);
            this.button_Font.TabIndex = 6;
            this.button_Font.Text = "Font";
            this.button_Font.UseVisualStyleBackColor = true;
            this.button_Font.Click += new System.EventHandler(this.button_Font_Click);
            // 
            // button_Environment
            // 
            this.button_Environment.Location = new System.Drawing.Point(168, 492);
            this.button_Environment.Name = "button_Environment";
            this.button_Environment.Size = new System.Drawing.Size(136, 56);
            this.button_Environment.TabIndex = 7;
            this.button_Environment.Text = "Environment";
            this.button_Environment.UseVisualStyleBackColor = true;
            this.button_Environment.Click += new System.EventHandler(this.button_Environment_Click);
            // 
            // button_Application
            // 
            this.button_Application.Location = new System.Drawing.Point(324, 492);
            this.button_Application.Name = "button_Application";
            this.button_Application.Size = new System.Drawing.Size(136, 56);
            this.button_Application.TabIndex = 8;
            this.button_Application.Text = "Application";
            this.button_Application.UseVisualStyleBackColor = true;
            this.button_Application.Click += new System.EventHandler(this.button_Application_Click);
            // 
            // ClassesImportantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_Application);
            this.Controls.Add(this.button_Environment);
            this.Controls.Add(this.button_Font);
            this.Controls.Add(this.button_Color);
            this.Controls.Add(this.button_DateTime);
            this.Controls.Add(this.button_TimeSpan);
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
        private System.Windows.Forms.Button button_TimeSpan;
        private System.Windows.Forms.Button button_DateTime;
        private System.Windows.Forms.Button button_Color;
        private System.Windows.Forms.Button button_Font;
        private System.Windows.Forms.Button button_Environment;
        private System.Windows.Forms.Button button_Application;
    }
}

