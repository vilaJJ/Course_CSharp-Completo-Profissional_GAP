namespace JoKenPo
{
    partial class JogoMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JogoMain));
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_voce = new System.Windows.Forms.Label();
            this.label_computador = new System.Windows.Forms.Label();
            this.label_vs = new System.Windows.Forms.Label();
            this.label_igual = new System.Windows.Forms.Label();
            this.label_resultado = new System.Windows.Forms.Label();
            this.button_tesoura = new System.Windows.Forms.Button();
            this.button_papel = new System.Windows.Forms.Button();
            this.button_pedra = new System.Windows.Forms.Button();
            this.pictureBox_resultado = new System.Windows.Forms.PictureBox();
            this.pictureBox_computador = new System.Windows.Forms.PictureBox();
            this.pictureBox_jogador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_computador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_jogador)).BeginInit();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            resources.ApplyResources(this.label_titulo, "label_titulo");
            this.label_titulo.Name = "label_titulo";
            // 
            // label_voce
            // 
            resources.ApplyResources(this.label_voce, "label_voce");
            this.label_voce.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_voce.Name = "label_voce";
            // 
            // label_computador
            // 
            resources.ApplyResources(this.label_computador, "label_computador");
            this.label_computador.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_computador.Name = "label_computador";
            // 
            // label_vs
            // 
            resources.ApplyResources(this.label_vs, "label_vs");
            this.label_vs.ForeColor = System.Drawing.Color.Red;
            this.label_vs.Name = "label_vs";
            // 
            // label_igual
            // 
            resources.ApplyResources(this.label_igual, "label_igual");
            this.label_igual.ForeColor = System.Drawing.Color.Red;
            this.label_igual.Name = "label_igual";
            // 
            // label_resultado
            // 
            resources.ApplyResources(this.label_resultado, "label_resultado");
            this.label_resultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_resultado.Name = "label_resultado";
            // 
            // button_tesoura
            // 
            resources.ApplyResources(this.button_tesoura, "button_tesoura");
            this.button_tesoura.BackgroundImage = global::JoKenPo.Properties.Resources.Tesoura;
            this.button_tesoura.Name = "button_tesoura";
            this.button_tesoura.UseVisualStyleBackColor = true;
            this.button_tesoura.Click += new System.EventHandler(this.button_tesoura_Click);
            // 
            // button_papel
            // 
            resources.ApplyResources(this.button_papel, "button_papel");
            this.button_papel.BackgroundImage = global::JoKenPo.Properties.Resources.Papel;
            this.button_papel.Name = "button_papel";
            this.button_papel.UseVisualStyleBackColor = true;
            this.button_papel.Click += new System.EventHandler(this.button_papel_Click);
            // 
            // button_pedra
            // 
            resources.ApplyResources(this.button_pedra, "button_pedra");
            this.button_pedra.BackgroundImage = global::JoKenPo.Properties.Resources.Pedra;
            this.button_pedra.Name = "button_pedra";
            this.button_pedra.UseVisualStyleBackColor = true;
            this.button_pedra.Click += new System.EventHandler(this.button_pedra_Click);
            // 
            // pictureBox_resultado
            // 
            resources.ApplyResources(this.pictureBox_resultado, "pictureBox_resultado");
            this.pictureBox_resultado.Name = "pictureBox_resultado";
            this.pictureBox_resultado.TabStop = false;
            // 
            // pictureBox_computador
            // 
            resources.ApplyResources(this.pictureBox_computador, "pictureBox_computador");
            this.pictureBox_computador.Name = "pictureBox_computador";
            this.pictureBox_computador.TabStop = false;
            // 
            // pictureBox_jogador
            // 
            resources.ApplyResources(this.pictureBox_jogador, "pictureBox_jogador");
            this.pictureBox_jogador.Name = "pictureBox_jogador";
            this.pictureBox_jogador.TabStop = false;
            // 
            // JogoMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_tesoura);
            this.Controls.Add(this.button_papel);
            this.Controls.Add(this.button_pedra);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.label_igual);
            this.Controls.Add(this.label_vs);
            this.Controls.Add(this.label_computador);
            this.Controls.Add(this.label_voce);
            this.Controls.Add(this.pictureBox_resultado);
            this.Controls.Add(this.pictureBox_computador);
            this.Controls.Add(this.pictureBox_jogador);
            this.Controls.Add(this.label_titulo);
            this.MaximizeBox = false;
            this.Name = "JogoMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_computador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_jogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.PictureBox pictureBox_jogador;
        private System.Windows.Forms.PictureBox pictureBox_computador;
        private System.Windows.Forms.PictureBox pictureBox_resultado;
        private System.Windows.Forms.Label label_voce;
        private System.Windows.Forms.Label label_computador;
        private System.Windows.Forms.Label label_vs;
        private System.Windows.Forms.Label label_igual;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button button_pedra;
        private System.Windows.Forms.Button button_papel;
        private System.Windows.Forms.Button button_tesoura;
    }
}

