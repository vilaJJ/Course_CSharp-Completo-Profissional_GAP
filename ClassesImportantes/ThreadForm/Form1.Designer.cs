namespace ThreadForm
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
            this.label_resultado = new System.Windows.Forms.Label();
            this.button_principal = new System.Windows.Forms.Button();
            this.button_contador = new System.Windows.Forms.Button();
            this.label_resultado2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_resultado
            // 
            this.label_resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.Location = new System.Drawing.Point(3, 0);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(386, 194);
            this.label_resultado.TabIndex = 0;
            this.label_resultado.Text = "Resultado 1";
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_principal
            // 
            this.button_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_principal.Location = new System.Drawing.Point(74, 221);
            this.button_principal.Name = "button_principal";
            this.button_principal.Size = new System.Drawing.Size(192, 105);
            this.button_principal.TabIndex = 1;
            this.button_principal.Text = "Principal";
            this.button_principal.UseVisualStyleBackColor = true;
            this.button_principal.Click += new System.EventHandler(this.button_principal_Click);
            // 
            // button_contador
            // 
            this.button_contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_contador.Location = new System.Drawing.Point(518, 221);
            this.button_contador.Name = "button_contador";
            this.button_contador.Size = new System.Drawing.Size(192, 105);
            this.button_contador.TabIndex = 2;
            this.button_contador.Text = "Horário";
            this.button_contador.UseVisualStyleBackColor = true;
            this.button_contador.Click += new System.EventHandler(this.button_contador_Click);
            // 
            // label_resultado2
            // 
            this.label_resultado2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_resultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado2.Location = new System.Drawing.Point(395, 0);
            this.label_resultado2.Name = "label_resultado2";
            this.label_resultado2.Size = new System.Drawing.Size(386, 194);
            this.label_resultado2.TabIndex = 3;
            this.label_resultado2.Text = "Resultado 2";
            this.label_resultado2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_resultado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_resultado2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 194);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_contador);
            this.Controls.Add(this.button_principal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button button_principal;
        private System.Windows.Forms.Button button_contador;
        private System.Windows.Forms.Label label_resultado2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

