namespace Parte017
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label_QntdCarac = new System.Windows.Forms.Label();
            this.button_ZoomPlus = new System.Windows.Forms.Button();
            this.button_ZoomSubt = new System.Windows.Forms.Button();
            this.label_zoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.Linen;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Location = new System.Drawing.Point(12, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(776, 346);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // label_QntdCarac
            // 
            this.label_QntdCarac.AutoSize = true;
            this.label_QntdCarac.Location = new System.Drawing.Point(12, 361);
            this.label_QntdCarac.Name = "label_QntdCarac";
            this.label_QntdCarac.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_QntdCarac.Size = new System.Drawing.Size(142, 13);
            this.label_QntdCarac.TabIndex = 1;
            this.label_QntdCarac.Text = "Quantidade de caracteres: 0";
            this.label_QntdCarac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_ZoomPlus
            // 
            this.button_ZoomPlus.Location = new System.Drawing.Point(712, 361);
            this.button_ZoomPlus.Name = "button_ZoomPlus";
            this.button_ZoomPlus.Size = new System.Drawing.Size(75, 23);
            this.button_ZoomPlus.TabIndex = 2;
            this.button_ZoomPlus.Text = "Zoom +";
            this.button_ZoomPlus.UseVisualStyleBackColor = true;
            this.button_ZoomPlus.Click += new System.EventHandler(this.button_ZoomPlus_Click);
            // 
            // button_ZoomSubt
            // 
            this.button_ZoomSubt.Location = new System.Drawing.Point(712, 390);
            this.button_ZoomSubt.Name = "button_ZoomSubt";
            this.button_ZoomSubt.Size = new System.Drawing.Size(75, 23);
            this.button_ZoomSubt.TabIndex = 3;
            this.button_ZoomSubt.Text = "Zoom -";
            this.button_ZoomSubt.UseVisualStyleBackColor = true;
            this.button_ZoomSubt.Click += new System.EventHandler(this.button_ZoomSubt_Click);
            // 
            // label_zoom
            // 
            this.label_zoom.AutoSize = true;
            this.label_zoom.Location = new System.Drawing.Point(737, 428);
            this.label_zoom.Name = "label_zoom";
            this.label_zoom.Size = new System.Drawing.Size(51, 13);
            this.label_zoom.TabIndex = 4;
            this.label_zoom.Text = "Zoom: 1x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_zoom);
            this.Controls.Add(this.button_ZoomSubt);
            this.Controls.Add(this.button_ZoomPlus);
            this.Controls.Add(this.label_QntdCarac);
            this.Controls.Add(this.richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label_QntdCarac;
        private System.Windows.Forms.Button button_ZoomPlus;
        private System.Windows.Forms.Button button_ZoomSubt;
        private System.Windows.Forms.Label label_zoom;
    }
}

