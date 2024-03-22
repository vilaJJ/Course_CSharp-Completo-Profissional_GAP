namespace HelloWorldApp
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
            this.Button_PressioneAqui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_PressioneAqui
            // 
            this.Button_PressioneAqui.Location = new System.Drawing.Point(88, 19);
            this.Button_PressioneAqui.Name = "Button_PressioneAqui";
            this.Button_PressioneAqui.Size = new System.Drawing.Size(108, 23);
            this.Button_PressioneAqui.TabIndex = 0;
            this.Button_PressioneAqui.Text = "&Pressione Aqui!";
            this.Button_PressioneAqui.UseVisualStyleBackColor = true;
            this.Button_PressioneAqui.Click += new System.EventHandler(this.Button_PressioneAqui_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.Button_PressioneAqui);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 100);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 100);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World!";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button_PressioneAqui;
    }
}

