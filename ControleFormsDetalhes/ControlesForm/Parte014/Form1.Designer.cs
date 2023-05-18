namespace Parte014
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
            this.button_HealthConnect = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_NTSColetor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_HealthConnect
            // 
            this.button_HealthConnect.Location = new System.Drawing.Point(633, 376);
            this.button_HealthConnect.Name = "button_HealthConnect";
            this.button_HealthConnect.Size = new System.Drawing.Size(155, 62);
            this.button_HealthConnect.TabIndex = 1;
            this.button_HealthConnect.Text = "HealthConnect";
            this.button_HealthConnect.UseVisualStyleBackColor = true;
            this.button_HealthConnect.Click += new System.EventHandler(this.button_Executar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(420, 420);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button_NTSColetor
            // 
            this.button_NTSColetor.Location = new System.Drawing.Point(633, 308);
            this.button_NTSColetor.Name = "button_NTSColetor";
            this.button_NTSColetor.Size = new System.Drawing.Size(155, 62);
            this.button_NTSColetor.TabIndex = 2;
            this.button_NTSColetor.Text = "Nortesys Scan Coletor";
            this.button_NTSColetor.UseVisualStyleBackColor = true;
            this.button_NTSColetor.Click += new System.EventHandler(this.button_NTSColetor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_NTSColetor);
            this.Controls.Add(this.button_HealthConnect);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_HealthConnect;
        private System.Windows.Forms.Button button_NTSColetor;
    }
}

