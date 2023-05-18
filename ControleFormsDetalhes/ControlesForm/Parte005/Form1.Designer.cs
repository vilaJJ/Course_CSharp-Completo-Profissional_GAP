namespace Parte005
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
            this.checkBox_Opcao1 = new System.Windows.Forms.CheckBox();
            this.checkBox_Opcao2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Opcao3 = new System.Windows.Forms.CheckBox();
            this.button_Checados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_Opcao1
            // 
            this.checkBox_Opcao1.AutoSize = true;
            this.checkBox_Opcao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBox_Opcao1.Location = new System.Drawing.Point(367, 194);
            this.checkBox_Opcao1.Name = "checkBox_Opcao1";
            this.checkBox_Opcao1.Size = new System.Drawing.Size(67, 17);
            this.checkBox_Opcao1.TabIndex = 0;
            this.checkBox_Opcao1.Text = "Opção 1";
            this.checkBox_Opcao1.UseVisualStyleBackColor = true;
            this.checkBox_Opcao1.CheckedChanged += new System.EventHandler(this.checkBox_Opcao1_CheckedChanged);
            // 
            // checkBox_Opcao2
            // 
            this.checkBox_Opcao2.AutoSize = true;
            this.checkBox_Opcao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBox_Opcao2.Location = new System.Drawing.Point(367, 217);
            this.checkBox_Opcao2.Name = "checkBox_Opcao2";
            this.checkBox_Opcao2.Size = new System.Drawing.Size(67, 17);
            this.checkBox_Opcao2.TabIndex = 1;
            this.checkBox_Opcao2.Text = "Opção 2";
            this.checkBox_Opcao2.UseVisualStyleBackColor = true;
            this.checkBox_Opcao2.CheckedChanged += new System.EventHandler(this.checkBox_Opcao2_CheckedChanged);
            // 
            // checkBox_Opcao3
            // 
            this.checkBox_Opcao3.AutoSize = true;
            this.checkBox_Opcao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkBox_Opcao3.Location = new System.Drawing.Point(367, 240);
            this.checkBox_Opcao3.Name = "checkBox_Opcao3";
            this.checkBox_Opcao3.Size = new System.Drawing.Size(67, 17);
            this.checkBox_Opcao3.TabIndex = 2;
            this.checkBox_Opcao3.Text = "Opção 3";
            this.checkBox_Opcao3.UseVisualStyleBackColor = true;
            this.checkBox_Opcao3.CheckedChanged += new System.EventHandler(this.checkBox_Opcao3_CheckedChanged);
            // 
            // button_Checados
            // 
            this.button_Checados.Location = new System.Drawing.Point(363, 282);
            this.button_Checados.Name = "button_Checados";
            this.button_Checados.Size = new System.Drawing.Size(75, 23);
            this.button_Checados.TabIndex = 3;
            this.button_Checados.Text = "Checados";
            this.button_Checados.UseVisualStyleBackColor = true;
            this.button_Checados.Click += new System.EventHandler(this.button_Checados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Checados);
            this.Controls.Add(this.checkBox_Opcao3);
            this.Controls.Add(this.checkBox_Opcao2);
            this.Controls.Add(this.checkBox_Opcao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Opcao1;
        private System.Windows.Forms.CheckBox checkBox_Opcao2;
        private System.Windows.Forms.CheckBox checkBox_Opcao3;
        private System.Windows.Forms.Button button_Checados;
    }
}

