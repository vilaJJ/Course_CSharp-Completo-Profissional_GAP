namespace Parte004
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
            this.lista = new System.Windows.Forms.ListBox();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.button_RemoverItem = new System.Windows.Forms.Button();
            this.button_RemoverIndice = new System.Windows.Forms.Button();
            this.label_QntdItems = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.lista.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.ForeColor = System.Drawing.Color.Magenta;
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 24;
            this.lista.Location = new System.Drawing.Point(0, 0);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(453, 450);
            this.lista.Sorted = true;
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(640, 38);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(148, 24);
            this.button_Adicionar.TabIndex = 1;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(468, 12);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(320, 20);
            this.textBox_Nome.TabIndex = 2;
            this.textBox_Nome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Nome_KeyUp);
            // 
            // button_Limpar
            // 
            this.button_Limpar.Location = new System.Drawing.Point(640, 126);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(148, 23);
            this.button_Limpar.TabIndex = 3;
            this.button_Limpar.Text = "Limpar Tudo";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // button_RemoverItem
            // 
            this.button_RemoverItem.Location = new System.Drawing.Point(640, 68);
            this.button_RemoverItem.Name = "button_RemoverItem";
            this.button_RemoverItem.Size = new System.Drawing.Size(148, 23);
            this.button_RemoverItem.TabIndex = 4;
            this.button_RemoverItem.Text = "Remover Item";
            this.button_RemoverItem.UseVisualStyleBackColor = true;
            this.button_RemoverItem.Click += new System.EventHandler(this.button_RemoverItem_Click);
            // 
            // button_RemoverIndice
            // 
            this.button_RemoverIndice.Location = new System.Drawing.Point(640, 97);
            this.button_RemoverIndice.Name = "button_RemoverIndice";
            this.button_RemoverIndice.Size = new System.Drawing.Size(148, 23);
            this.button_RemoverIndice.TabIndex = 5;
            this.button_RemoverIndice.Text = "Remover Item pelo Índice";
            this.button_RemoverIndice.UseVisualStyleBackColor = true;
            this.button_RemoverIndice.Click += new System.EventHandler(this.button_RemoverIndice_Click);
            // 
            // label_QntdItems
            // 
            this.label_QntdItems.AutoSize = true;
            this.label_QntdItems.Location = new System.Drawing.Point(460, 425);
            this.label_QntdItems.Name = "label_QntdItems";
            this.label_QntdItems.Size = new System.Drawing.Size(115, 13);
            this.label_QntdItems.TabIndex = 6;
            this.label_QntdItems.Text = "Quantidade de Itens: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_QntdItems);
            this.Controls.Add(this.button_RemoverIndice);
            this.Controls.Add(this.button_RemoverItem);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.Button button_RemoverItem;
        private System.Windows.Forms.Button button_RemoverIndice;
        private System.Windows.Forms.Label label_QntdItems;
    }
}

