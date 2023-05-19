namespace Parte024
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_Img1 = new System.Windows.Forms.Button();
            this.button_Img2 = new System.Windows.Forms.Button();
            this.button_Img3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel1.Controls.Add(this.button_Img3);
            this.splitContainer.Panel1.Controls.Add(this.button_Img2);
            this.splitContainer.Panel1.Controls.Add(this.button_Img1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(594, 448);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button_Img1
            // 
            this.button_Img1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Img1.Location = new System.Drawing.Point(0, 0);
            this.button_Img1.Name = "button_Img1";
            this.button_Img1.Size = new System.Drawing.Size(198, 41);
            this.button_Img1.TabIndex = 0;
            this.button_Img1.Text = "Imagem 1";
            this.button_Img1.UseVisualStyleBackColor = true;
            this.button_Img1.Click += new System.EventHandler(this.button_Img1_Click);
            // 
            // button_Img2
            // 
            this.button_Img2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Img2.Location = new System.Drawing.Point(0, 41);
            this.button_Img2.Name = "button_Img2";
            this.button_Img2.Size = new System.Drawing.Size(198, 41);
            this.button_Img2.TabIndex = 1;
            this.button_Img2.Text = "Imagem 2";
            this.button_Img2.UseVisualStyleBackColor = true;
            this.button_Img2.Click += new System.EventHandler(this.button_Img2_Click);
            // 
            // button_Img3
            // 
            this.button_Img3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Img3.Location = new System.Drawing.Point(0, 82);
            this.button_Img3.Name = "button_Img3";
            this.button_Img3.Size = new System.Drawing.Size(198, 41);
            this.button_Img3.TabIndex = 2;
            this.button_Img3.Text = "Imagem 3";
            this.button_Img3.UseVisualStyleBackColor = true;
            this.button_Img3.Click += new System.EventHandler(this.button_Img3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button button_Img3;
        private System.Windows.Forms.Button button_Img2;
        private System.Windows.Forms.Button button_Img1;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

