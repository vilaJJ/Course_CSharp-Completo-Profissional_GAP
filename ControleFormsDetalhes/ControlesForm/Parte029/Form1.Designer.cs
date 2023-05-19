namespace Parte029
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgresso = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Progresso100 = new System.Windows.Forms.ToolStripMenuItem();
            this.Progresso75 = new System.Windows.Forms.ToolStripMenuItem();
            this.Progresso50 = new System.Windows.Forms.ToolStripMenuItem();
            this.Progresso25 = new System.Windows.Forms.ToolStripMenuItem();
            this.Progresso0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.opçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.toolStripProgresso,
            this.toolStripDropDownButton1,
            this.toolStripSplitButton1});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "Status";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatus.Text = "Status";
            this.toolStripStatus.ToolTipText = "Resolução da janela";
            // 
            // toolStripProgresso
            // 
            this.toolStripProgresso.Name = "toolStripProgresso";
            this.toolStripProgresso.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgresso.ToolTipText = "Barra de Progresso";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progresso100,
            this.Progresso75,
            this.Progresso50,
            this.Progresso25,
            this.Progresso0});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ToolTipText = "Alterar Barra de Progresso";
            // 
            // Progresso100
            // 
            this.Progresso100.Name = "Progresso100";
            this.Progresso100.Size = new System.Drawing.Size(180, 22);
            this.Progresso100.Text = "100%";
            this.Progresso100.ToolTipText = "Alterar para 100%";
            this.Progresso100.Click += new System.EventHandler(this.Progresso100_Click);
            // 
            // Progresso75
            // 
            this.Progresso75.Name = "Progresso75";
            this.Progresso75.Size = new System.Drawing.Size(180, 22);
            this.Progresso75.Text = "75%";
            this.Progresso75.ToolTipText = "Alterar para 75%";
            this.Progresso75.Click += new System.EventHandler(this.Progresso75_Click);
            // 
            // Progresso50
            // 
            this.Progresso50.Name = "Progresso50";
            this.Progresso50.Size = new System.Drawing.Size(180, 22);
            this.Progresso50.Text = "50%";
            this.Progresso50.ToolTipText = "Alterar para 50%";
            this.Progresso50.Click += new System.EventHandler(this.Progresso50_Click);
            // 
            // Progresso25
            // 
            this.Progresso25.Name = "Progresso25";
            this.Progresso25.Size = new System.Drawing.Size(180, 22);
            this.Progresso25.Text = "25%";
            this.Progresso25.ToolTipText = "Alterar para 25%";
            this.Progresso25.Click += new System.EventHandler(this.Progresso25_Click);
            // 
            // Progresso0
            // 
            this.Progresso0.Name = "Progresso0";
            this.Progresso0.Size = new System.Drawing.Size(180, 22);
            this.Progresso0.Text = "0%";
            this.Progresso0.ToolTipText = "Alterar para 0%";
            this.Progresso0.Click += new System.EventHandler(this.Progresso0_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçãoToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // opçãoToolStripMenuItem
            // 
            this.opçãoToolStripMenuItem.Name = "opçãoToolStripMenuItem";
            this.opçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opçãoToolStripMenuItem.Text = "Opção";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgresso;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem Progresso100;
        private System.Windows.Forms.ToolStripMenuItem Progresso75;
        private System.Windows.Forms.ToolStripMenuItem Progresso50;
        private System.Windows.Forms.ToolStripMenuItem Progresso25;
        private System.Windows.Forms.ToolStripMenuItem Progresso0;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem opçãoToolStripMenuItem;
    }
}

