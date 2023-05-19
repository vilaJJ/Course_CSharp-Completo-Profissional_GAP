namespace Parte025
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.browser1 = new System.Windows.Forms.TabPage();
            this.browser2 = new System.Windows.Forms.TabPage();
            this.textBox_URL1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button_Pesquisar1 = new System.Windows.Forms.Button();
            this.textBox_URL2 = new System.Windows.Forms.TextBox();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.button_Pesquisar2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.browser1.SuspendLayout();
            this.browser2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.browser1);
            this.tabControl.Controls.Add(this.browser2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // browser1
            // 
            this.browser1.Controls.Add(this.button_Pesquisar1);
            this.browser1.Controls.Add(this.webBrowser1);
            this.browser1.Controls.Add(this.textBox_URL1);
            this.browser1.Location = new System.Drawing.Point(4, 22);
            this.browser1.Name = "browser1";
            this.browser1.Padding = new System.Windows.Forms.Padding(3);
            this.browser1.Size = new System.Drawing.Size(792, 424);
            this.browser1.TabIndex = 0;
            this.browser1.Text = "Browser 1";
            this.browser1.UseVisualStyleBackColor = true;
            // 
            // browser2
            // 
            this.browser2.Controls.Add(this.button_Pesquisar2);
            this.browser2.Controls.Add(this.webBrowser2);
            this.browser2.Controls.Add(this.textBox_URL2);
            this.browser2.Location = new System.Drawing.Point(4, 22);
            this.browser2.Name = "browser2";
            this.browser2.Padding = new System.Windows.Forms.Padding(3);
            this.browser2.Size = new System.Drawing.Size(792, 424);
            this.browser2.TabIndex = 1;
            this.browser2.Text = "Browser 2";
            this.browser2.UseVisualStyleBackColor = true;
            // 
            // textBox_URL1
            // 
            this.textBox_URL1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_URL1.Location = new System.Drawing.Point(3, 3);
            this.textBox_URL1.Name = "textBox_URL1";
            this.textBox_URL1.Size = new System.Drawing.Size(786, 20);
            this.textBox_URL1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 23);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(786, 398);
            this.webBrowser1.TabIndex = 1;
            // 
            // button_Pesquisar1
            // 
            this.button_Pesquisar1.Location = new System.Drawing.Point(717, 0);
            this.button_Pesquisar1.Name = "button_Pesquisar1";
            this.button_Pesquisar1.Size = new System.Drawing.Size(75, 23);
            this.button_Pesquisar1.TabIndex = 2;
            this.button_Pesquisar1.Text = "Pesquisar";
            this.button_Pesquisar1.UseVisualStyleBackColor = true;
            this.button_Pesquisar1.Click += new System.EventHandler(this.button_Pesquisar1_Click);
            // 
            // textBox_URL2
            // 
            this.textBox_URL2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_URL2.Location = new System.Drawing.Point(3, 3);
            this.textBox_URL2.Name = "textBox_URL2";
            this.textBox_URL2.Size = new System.Drawing.Size(786, 20);
            this.textBox_URL2.TabIndex = 0;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 23);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(786, 398);
            this.webBrowser2.TabIndex = 1;
            // 
            // button_Pesquisar2
            // 
            this.button_Pesquisar2.Location = new System.Drawing.Point(717, 0);
            this.button_Pesquisar2.Name = "button_Pesquisar2";
            this.button_Pesquisar2.Size = new System.Drawing.Size(75, 23);
            this.button_Pesquisar2.TabIndex = 2;
            this.button_Pesquisar2.Text = "Pesquisar";
            this.button_Pesquisar2.UseVisualStyleBackColor = true;
            this.button_Pesquisar2.Click += new System.EventHandler(this.button_Pesquisar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.browser1.ResumeLayout(false);
            this.browser1.PerformLayout();
            this.browser2.ResumeLayout(false);
            this.browser2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage browser1;
        private System.Windows.Forms.TabPage browser2;
        private System.Windows.Forms.Button button_Pesquisar1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox_URL1;
        private System.Windows.Forms.Button button_Pesquisar2;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.TextBox textBox_URL2;
    }
}

