namespace Formulario
{
    partial class FormSecundaria
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
            this.button_TelaPrincipal = new System.Windows.Forms.Button();
            this.textBox_Mensagem = new System.Windows.Forms.TextBox();
            this.button_Retorno = new System.Windows.Forms.Button();
            this.button_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(0, 0);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(784, 179);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Segundo Formulário";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_TelaPrincipal
            // 
            this.button_TelaPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TelaPrincipal.Location = new System.Drawing.Point(338, 482);
            this.button_TelaPrincipal.Name = "button_TelaPrincipal";
            this.button_TelaPrincipal.Size = new System.Drawing.Size(214, 67);
            this.button_TelaPrincipal.TabIndex = 1;
            this.button_TelaPrincipal.Text = "Tela Principal\r\n(Thread)";
            this.button_TelaPrincipal.UseVisualStyleBackColor = true;
            this.button_TelaPrincipal.Click += new System.EventHandler(this.button_TelaPrincipal_Click);
            // 
            // textBox_Mensagem
            // 
            this.textBox_Mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Mensagem.Location = new System.Drawing.Point(222, 265);
            this.textBox_Mensagem.Name = "textBox_Mensagem";
            this.textBox_Mensagem.Size = new System.Drawing.Size(340, 31);
            this.textBox_Mensagem.TabIndex = 2;
            // 
            // button_Retorno
            // 
            this.button_Retorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Retorno.Location = new System.Drawing.Point(558, 482);
            this.button_Retorno.Name = "button_Retorno";
            this.button_Retorno.Size = new System.Drawing.Size(214, 67);
            this.button_Retorno.TabIndex = 3;
            this.button_Retorno.Text = "Retorno";
            this.button_Retorno.UseVisualStyleBackColor = true;
            this.button_Retorno.Click += new System.EventHandler(this.button_Retorno_Click);
            // 
            // button_Fechar
            // 
            this.button_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Fechar.Location = new System.Drawing.Point(12, 525);
            this.button_Fechar.Name = "button_Fechar";
            this.button_Fechar.Size = new System.Drawing.Size(80, 24);
            this.button_Fechar.TabIndex = 4;
            this.button_Fechar.Text = "Fechar";
            this.button_Fechar.UseVisualStyleBackColor = true;
            this.button_Fechar.Click += new System.EventHandler(this.button_Fechar_Click);
            // 
            // FormSecundaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_Fechar);
            this.Controls.Add(this.button_Retorno);
            this.Controls.Add(this.textBox_Mensagem);
            this.Controls.Add(this.button_TelaPrincipal);
            this.Controls.Add(this.label_titulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormSecundaria";
            this.Text = "Formulário Secundário";
            this.Load += new System.EventHandler(this.FormSecundaria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button button_TelaPrincipal;
        private System.Windows.Forms.TextBox textBox_Mensagem;
        private System.Windows.Forms.Button button_Retorno;
        private System.Windows.Forms.Button button_Fechar;
    }
}