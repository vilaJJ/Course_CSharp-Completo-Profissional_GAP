namespace Parte032
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
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.label_Progresso = new System.Windows.Forms.Label();
            this.button_Iniciar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // label_Progresso
            // 
            this.label_Progresso.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Progresso.Location = new System.Drawing.Point(0, 0);
            this.label_Progresso.Name = "label_Progresso";
            this.label_Progresso.Size = new System.Drawing.Size(224, 28);
            this.label_Progresso.TabIndex = 0;
            this.label_Progresso.Text = "Progresso";
            this.label_Progresso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Iniciar
            // 
            this.button_Iniciar.Location = new System.Drawing.Point(19, 31);
            this.button_Iniciar.Name = "button_Iniciar";
            this.button_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.button_Iniciar.TabIndex = 1;
            this.button_Iniciar.Text = "Iniciar";
            this.button_Iniciar.UseVisualStyleBackColor = true;
            this.button_Iniciar.Click += new System.EventHandler(this.button_Iniciar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(137, 31);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 2;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 62);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(224, 19);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 81);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Iniciar);
            this.Controls.Add(this.label_Progresso);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 120);
            this.MinimumSize = new System.Drawing.Size(240, 120);
            this.Name = "Form1";
            this.Text = "Progresso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label label_Progresso;
        private System.Windows.Forms.Button button_Iniciar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

