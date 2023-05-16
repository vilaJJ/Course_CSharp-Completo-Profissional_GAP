namespace Formulario
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.button_TelaSecundaria = new System.Windows.Forms.Button();
            this.button_SegundaTela_Thread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(0, 0);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(784, 180);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Principal";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_TelaSecundaria
            // 
            this.button_TelaSecundaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TelaSecundaria.Location = new System.Drawing.Point(12, 467);
            this.button_TelaSecundaria.Name = "button_TelaSecundaria";
            this.button_TelaSecundaria.Size = new System.Drawing.Size(244, 82);
            this.button_TelaSecundaria.TabIndex = 1;
            this.button_TelaSecundaria.Text = "Segunda Tela";
            this.button_TelaSecundaria.UseVisualStyleBackColor = true;
            this.button_TelaSecundaria.Click += new System.EventHandler(this.button_TelaSecundaria_Click);
            // 
            // button_SegundaTela_Thread
            // 
            this.button_SegundaTela_Thread.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SegundaTela_Thread.Location = new System.Drawing.Point(262, 467);
            this.button_SegundaTela_Thread.Name = "button_SegundaTela_Thread";
            this.button_SegundaTela_Thread.Size = new System.Drawing.Size(244, 82);
            this.button_SegundaTela_Thread.TabIndex = 2;
            this.button_SegundaTela_Thread.Text = "Segunda Tela\r\n(Thread)\r\n";
            this.button_SegundaTela_Thread.UseVisualStyleBackColor = true;
            this.button_SegundaTela_Thread.Click += new System.EventHandler(this.button_SegundaTela_Thread_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_SegundaTela_Thread);
            this.Controls.Add(this.button_TelaSecundaria);
            this.Controls.Add(this.label_titulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button button_TelaSecundaria;
        private System.Windows.Forms.Button button_SegundaTela_Thread;
    }
}

