namespace ProgramacaoAssincrona.Formularios
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
            this.ListBox_Resultado = new System.Windows.Forms.ListBox();
            this.Button_Executar = new System.Windows.Forms.Button();
            this.Button_ExecutarAssincrono = new System.Windows.Forms.Button();
            this.Button_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox_Resultado
            // 
            this.ListBox_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListBox_Resultado.FormattingEnabled = true;
            this.ListBox_Resultado.ItemHeight = 16;
            this.ListBox_Resultado.Location = new System.Drawing.Point(12, 9);
            this.ListBox_Resultado.Name = "ListBox_Resultado";
            this.ListBox_Resultado.Size = new System.Drawing.Size(401, 180);
            this.ListBox_Resultado.TabIndex = 0;
            // 
            // Button_Executar
            // 
            this.Button_Executar.Location = new System.Drawing.Point(419, 12);
            this.Button_Executar.Name = "Button_Executar";
            this.Button_Executar.Size = new System.Drawing.Size(153, 55);
            this.Button_Executar.TabIndex = 1;
            this.Button_Executar.Text = "&Executar";
            this.Button_Executar.UseVisualStyleBackColor = true;
            this.Button_Executar.Click += new System.EventHandler(this.Button_Executar_Click);
            // 
            // Button_ExecutarAssincrono
            // 
            this.Button_ExecutarAssincrono.Location = new System.Drawing.Point(419, 73);
            this.Button_ExecutarAssincrono.Name = "Button_ExecutarAssincrono";
            this.Button_ExecutarAssincrono.Size = new System.Drawing.Size(153, 55);
            this.Button_ExecutarAssincrono.TabIndex = 2;
            this.Button_ExecutarAssincrono.Text = "E&xecutar assíncrono";
            this.Button_ExecutarAssincrono.UseVisualStyleBackColor = true;
            this.Button_ExecutarAssincrono.Click += new System.EventHandler(this.Button_ExecutarAssincrono_Click);
            // 
            // Button_Limpar
            // 
            this.Button_Limpar.Location = new System.Drawing.Point(419, 134);
            this.Button_Limpar.Name = "Button_Limpar";
            this.Button_Limpar.Size = new System.Drawing.Size(153, 55);
            this.Button_Limpar.TabIndex = 3;
            this.Button_Limpar.Text = "&Limpar";
            this.Button_Limpar.UseVisualStyleBackColor = true;
            this.Button_Limpar.Click += new System.EventHandler(this.Button_Limpar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 201);
            this.Controls.Add(this.Button_Limpar);
            this.Controls.Add(this.Button_ExecutarAssincrono);
            this.Controls.Add(this.Button_Executar);
            this.Controls.Add(this.ListBox_Resultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 240);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programação Assíncrona";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox ListBox_Resultado;
        internal System.Windows.Forms.Button Button_Executar;
        internal System.Windows.Forms.Button Button_ExecutarAssincrono;
        internal System.Windows.Forms.Button Button_Limpar;
    }
}

