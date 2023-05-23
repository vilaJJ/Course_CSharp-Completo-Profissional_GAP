namespace LINQ_1
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
            this.lista = new System.Windows.Forms.ListBox();
            this.textBox_comando = new System.Windows.Forms.TextBox();
            this.button_Executar = new System.Windows.Forms.Button();
            this.button_Where = new System.Windows.Forms.Button();
            this.button_OrderBy = new System.Windows.Forms.Button();
            this.button_GroupBy = new System.Windows.Forms.Button();
            this.button_Agregacao = new System.Windows.Forms.Button();
            this.button_OpElementos = new System.Windows.Forms.Button();
            this.button_LINQLambda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Monocraft", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.HorizontalScrollbar = true;
            this.lista.ItemHeight = 28;
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.ScrollAlwaysVisible = true;
            this.lista.Size = new System.Drawing.Size(563, 508);
            this.lista.TabIndex = 0;
            // 
            // textBox_comando
            // 
            this.textBox_comando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_comando.Location = new System.Drawing.Point(581, 12);
            this.textBox_comando.Name = "textBox_comando";
            this.textBox_comando.Size = new System.Drawing.Size(191, 26);
            this.textBox_comando.TabIndex = 1;
            this.textBox_comando.TextChanged += new System.EventHandler(this.textBox_comando_TextChanged);
            // 
            // button_Executar
            // 
            this.button_Executar.Location = new System.Drawing.Point(581, 44);
            this.button_Executar.Name = "button_Executar";
            this.button_Executar.Size = new System.Drawing.Size(191, 44);
            this.button_Executar.TabIndex = 2;
            this.button_Executar.Text = "Executar";
            this.button_Executar.UseVisualStyleBackColor = true;
            this.button_Executar.Click += new System.EventHandler(this.button_Executar_Click);
            // 
            // button_Where
            // 
            this.button_Where.Location = new System.Drawing.Point(581, 94);
            this.button_Where.Name = "button_Where";
            this.button_Where.Size = new System.Drawing.Size(191, 44);
            this.button_Where.TabIndex = 3;
            this.button_Where.Text = "Where";
            this.button_Where.UseVisualStyleBackColor = true;
            this.button_Where.Click += new System.EventHandler(this.button_Where_Click);
            // 
            // button_OrderBy
            // 
            this.button_OrderBy.Location = new System.Drawing.Point(581, 144);
            this.button_OrderBy.Name = "button_OrderBy";
            this.button_OrderBy.Size = new System.Drawing.Size(191, 44);
            this.button_OrderBy.TabIndex = 4;
            this.button_OrderBy.Text = "Order by";
            this.button_OrderBy.UseVisualStyleBackColor = true;
            this.button_OrderBy.Click += new System.EventHandler(this.button_OrderBy_Click);
            // 
            // button_GroupBy
            // 
            this.button_GroupBy.Location = new System.Drawing.Point(581, 194);
            this.button_GroupBy.Name = "button_GroupBy";
            this.button_GroupBy.Size = new System.Drawing.Size(191, 44);
            this.button_GroupBy.TabIndex = 5;
            this.button_GroupBy.Text = "Group by";
            this.button_GroupBy.UseVisualStyleBackColor = true;
            this.button_GroupBy.Click += new System.EventHandler(this.button_GroupBy_Click);
            // 
            // button_Agregacao
            // 
            this.button_Agregacao.Location = new System.Drawing.Point(581, 244);
            this.button_Agregacao.Name = "button_Agregacao";
            this.button_Agregacao.Size = new System.Drawing.Size(191, 44);
            this.button_Agregacao.TabIndex = 6;
            this.button_Agregacao.Text = "Operadores de Agregação";
            this.button_Agregacao.UseVisualStyleBackColor = true;
            this.button_Agregacao.Click += new System.EventHandler(this.button_Agregacao_Click);
            // 
            // button_OpElementos
            // 
            this.button_OpElementos.Location = new System.Drawing.Point(581, 294);
            this.button_OpElementos.Name = "button_OpElementos";
            this.button_OpElementos.Size = new System.Drawing.Size(191, 44);
            this.button_OpElementos.TabIndex = 7;
            this.button_OpElementos.Text = "Operadores de Elemento";
            this.button_OpElementos.UseVisualStyleBackColor = true;
            this.button_OpElementos.Click += new System.EventHandler(this.button_OpElementos_Click);
            // 
            // button_LINQLambda
            // 
            this.button_LINQLambda.Location = new System.Drawing.Point(581, 344);
            this.button_LINQLambda.Name = "button_LINQLambda";
            this.button_LINQLambda.Size = new System.Drawing.Size(191, 44);
            this.button_LINQLambda.TabIndex = 8;
            this.button_LINQLambda.Text = "LINQ Lambda";
            this.button_LINQLambda.UseVisualStyleBackColor = true;
            this.button_LINQLambda.Click += new System.EventHandler(this.button_LINQLambda_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_LINQLambda);
            this.Controls.Add(this.button_OpElementos);
            this.Controls.Add(this.button_Agregacao);
            this.Controls.Add(this.button_GroupBy);
            this.Controls.Add(this.button_OrderBy);
            this.Controls.Add(this.button_Where);
            this.Controls.Add(this.button_Executar);
            this.Controls.Add(this.textBox_comando);
            this.Controls.Add(this.lista);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.Text = "LINQ - (Language Integrated Query)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox textBox_comando;
        private System.Windows.Forms.Button button_Executar;
        private System.Windows.Forms.Button button_Where;
        private System.Windows.Forms.Button button_OrderBy;
        private System.Windows.Forms.Button button_GroupBy;
        private System.Windows.Forms.Button button_Agregacao;
        private System.Windows.Forms.Button button_OpElementos;
        private System.Windows.Forms.Button button_LINQLambda;
    }
}

