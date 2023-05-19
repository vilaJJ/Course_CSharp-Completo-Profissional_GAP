namespace Parte33
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_Titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Iniciar = new System.Windows.Forms.Button();
            this.button_Parar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_Titulo
            // 
            this.label_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Titulo.Location = new System.Drawing.Point(0, 0);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(284, 212);
            this.label_Titulo.TabIndex = 0;
            this.label_Titulo.Text = "Timer Parado";
            this.label_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_Iniciar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Parar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 215);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 46);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button_Iniciar
            // 
            this.button_Iniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Iniciar.Location = new System.Drawing.Point(3, 3);
            this.button_Iniciar.Name = "button_Iniciar";
            this.button_Iniciar.Size = new System.Drawing.Size(136, 40);
            this.button_Iniciar.TabIndex = 0;
            this.button_Iniciar.Text = "Iniciar";
            this.button_Iniciar.UseVisualStyleBackColor = true;
            this.button_Iniciar.Click += new System.EventHandler(this.button_Iniciar_Click);
            // 
            // button_Parar
            // 
            this.button_Parar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Parar.Location = new System.Drawing.Point(145, 3);
            this.button_Parar.Name = "button_Parar";
            this.button_Parar.Size = new System.Drawing.Size(136, 40);
            this.button_Parar.TabIndex = 1;
            this.button_Parar.Text = "Parar";
            this.button_Parar.UseVisualStyleBackColor = true;
            this.button_Parar.Click += new System.EventHandler(this.button_Parar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_Titulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_Iniciar;
        private System.Windows.Forms.Button button_Parar;
    }
}

