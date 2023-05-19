namespace Parte040
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
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.button_openFolderBrowser = new System.Windows.Forms.Button();
            this.label_path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Escolha uma pasta";
            // 
            // button_openFolderBrowser
            // 
            this.button_openFolderBrowser.Location = new System.Drawing.Point(12, 254);
            this.button_openFolderBrowser.Name = "button_openFolderBrowser";
            this.button_openFolderBrowser.Size = new System.Drawing.Size(760, 95);
            this.button_openFolderBrowser.TabIndex = 0;
            this.button_openFolderBrowser.Text = "Selecione uma pasta";
            this.button_openFolderBrowser.UseVisualStyleBackColor = true;
            this.button_openFolderBrowser.Click += new System.EventHandler(this.button_openFolderBrowser_Click);
            // 
            // label_path
            // 
            this.label_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_path.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_path.Location = new System.Drawing.Point(0, 0);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(784, 251);
            this.label_path.TabIndex = 1;
            this.label_path.Text = "Caminho selecionado: nenhum.";
            this.label_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.button_openFolderBrowser);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button button_openFolderBrowser;
        private System.Windows.Forms.Label label_path;
    }
}

