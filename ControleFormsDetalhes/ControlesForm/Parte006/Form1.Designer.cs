namespace Parte006
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
            this.checkedListBox_Opcoes = new System.Windows.Forms.CheckedListBox();
            this.button_Executar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox_Opcoes
            // 
            this.checkedListBox_Opcoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_Opcoes.CheckOnClick = true;
            this.checkedListBox_Opcoes.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkedListBox_Opcoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkedListBox_Opcoes.FormattingEnabled = true;
            this.checkedListBox_Opcoes.Location = new System.Drawing.Point(207, 0);
            this.checkedListBox_Opcoes.Margin = new System.Windows.Forms.Padding(15);
            this.checkedListBox_Opcoes.Name = "checkedListBox_Opcoes";
            this.checkedListBox_Opcoes.Size = new System.Drawing.Size(593, 450);
            this.checkedListBox_Opcoes.Sorted = true;
            this.checkedListBox_Opcoes.TabIndex = 0;
            this.checkedListBox_Opcoes.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Opcoes_SelectedIndexChanged);
            // 
            // button_Executar
            // 
            this.button_Executar.Location = new System.Drawing.Point(12, 12);
            this.button_Executar.Name = "button_Executar";
            this.button_Executar.Size = new System.Drawing.Size(177, 35);
            this.button_Executar.TabIndex = 1;
            this.button_Executar.Text = "Executar";
            this.button_Executar.UseVisualStyleBackColor = true;
            this.button_Executar.Click += new System.EventHandler(this.button_Executar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 428);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_Executar);
            this.Controls.Add(this.checkedListBox_Opcoes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_Opcoes;
        private System.Windows.Forms.Button button_Executar;
        private System.Windows.Forms.Label label;
    }
}

