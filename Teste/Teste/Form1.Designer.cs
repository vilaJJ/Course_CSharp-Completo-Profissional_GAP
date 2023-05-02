namespace Teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_exe = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exe
            // 
            this.btn_exe.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_exe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exe.ForeColor = System.Drawing.Color.Black;
            this.btn_exe.Location = new System.Drawing.Point(243, 106);
            this.btn_exe.Name = "btn_exe";
            this.btn_exe.Size = new System.Drawing.Size(250, 125);
            this.btn_exe.TabIndex = 0;
            this.btn_exe.Text = "Executar";
            this.btn_exe.UseVisualStyleBackColor = false;
            this.btn_exe.Click += new System.EventHandler(this.button1_Click);
            this.btn_exe.MouseEnter += new System.EventHandler(this.btn_exe_MouseEnter);
            this.btn_exe.MouseLeave += new System.EventHandler(this.btn_exe_MouseLeave);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.White;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(720, 70);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Título da Aplicação";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 336);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_exe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(250, 250);
            this.MaximumSize = new System.Drawing.Size(964, 787);
            this.MinimumSize = new System.Drawing.Size(364, 215);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha aplicação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.MeuMetodo);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exe;
        private System.Windows.Forms.Label lbl_titulo;
    }
}

