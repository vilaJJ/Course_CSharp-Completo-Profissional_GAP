namespace Formulario
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.button_TelaSecundaria = new System.Windows.Forms.Button();
            this.button_SegundaTela_Thread = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menu_Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Arquivo_Novo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Arquivo_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Arquivo_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Ajuda_Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Ajuda_Sobre_Desenvolvedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Ajuda_Sobre_Versao = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.menu_Pesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_titulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(0, 27);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(784, 180);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Principal";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_TelaSecundaria
            // 
            this.button_TelaSecundaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TelaSecundaria.Location = new System.Drawing.Point(12, 467);
            this.button_TelaSecundaria.Name = "button_TelaSecundaria";
            this.button_TelaSecundaria.Size = new System.Drawing.Size(244, 82);
            this.button_TelaSecundaria.TabIndex = 1;
            this.button_TelaSecundaria.Text = "Segunda Tela";
            this.button_TelaSecundaria.UseVisualStyleBackColor = true;
            this.button_TelaSecundaria.Click += new System.EventHandler(this.button_TelaSecundaria_Click);
            // 
            // button_SegundaTela_Thread
            // 
            this.button_SegundaTela_Thread.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SegundaTela_Thread.Location = new System.Drawing.Point(262, 467);
            this.button_SegundaTela_Thread.Name = "button_SegundaTela_Thread";
            this.button_SegundaTela_Thread.Size = new System.Drawing.Size(244, 82);
            this.button_SegundaTela_Thread.TabIndex = 2;
            this.button_SegundaTela_Thread.Text = "Segunda Tela\r\n(Thread)\r\n";
            this.button_SegundaTela_Thread.UseVisualStyleBackColor = true;
            this.button_SegundaTela_Thread.Click += new System.EventHandler(this.button_SegundaTela_Thread_Click);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Arquivo,
            this.menu_Ajuda,
            this.menu_ComboBox,
            this.menu_Pesquisar});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 27);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // menu_Arquivo
            // 
            this.menu_Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Arquivo_Novo,
            this.menu_Arquivo_Abrir,
            this.toolStripSeparator1,
            this.menu_Arquivo_Sair});
            this.menu_Arquivo.Name = "menu_Arquivo";
            this.menu_Arquivo.Size = new System.Drawing.Size(61, 23);
            this.menu_Arquivo.Text = "Arquivo";
            // 
            // menu_Arquivo_Novo
            // 
            this.menu_Arquivo_Novo.Image = global::Formulario.Properties.Resources.novo;
            this.menu_Arquivo_Novo.Name = "menu_Arquivo_Novo";
            this.menu_Arquivo_Novo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_Arquivo_Novo.Size = new System.Drawing.Size(180, 22);
            this.menu_Arquivo_Novo.Text = "Novo";
            this.menu_Arquivo_Novo.Click += new System.EventHandler(this.menu_Arquivo_Novo_Click);
            // 
            // menu_Arquivo_Abrir
            // 
            this.menu_Arquivo_Abrir.Enabled = false;
            this.menu_Arquivo_Abrir.Image = global::Formulario.Properties.Resources.abrir;
            this.menu_Arquivo_Abrir.Name = "menu_Arquivo_Abrir";
            this.menu_Arquivo_Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menu_Arquivo_Abrir.Size = new System.Drawing.Size(180, 22);
            this.menu_Arquivo_Abrir.Text = "Abrir";
            this.menu_Arquivo_Abrir.Click += new System.EventHandler(this.menu_Arquivo_Abrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menu_Arquivo_Sair
            // 
            this.menu_Arquivo_Sair.Image = global::Formulario.Properties.Resources.sair;
            this.menu_Arquivo_Sair.Name = "menu_Arquivo_Sair";
            this.menu_Arquivo_Sair.ShortcutKeyDisplayString = "";
            this.menu_Arquivo_Sair.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.menu_Arquivo_Sair.Size = new System.Drawing.Size(180, 22);
            this.menu_Arquivo_Sair.Text = "Sair";
            this.menu_Arquivo_Sair.Click += new System.EventHandler(this.menu_Arquivo_Sair_Click);
            // 
            // menu_Ajuda
            // 
            this.menu_Ajuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Ajuda_Sobre});
            this.menu_Ajuda.Name = "menu_Ajuda";
            this.menu_Ajuda.Size = new System.Drawing.Size(50, 23);
            this.menu_Ajuda.Text = "Ajuda";
            // 
            // menu_Ajuda_Sobre
            // 
            this.menu_Ajuda_Sobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Ajuda_Sobre_Desenvolvedor,
            this.menu_Ajuda_Sobre_Versao});
            this.menu_Ajuda_Sobre.Name = "menu_Ajuda_Sobre";
            this.menu_Ajuda_Sobre.Size = new System.Drawing.Size(180, 22);
            this.menu_Ajuda_Sobre.Text = "Sobre";
            // 
            // menu_Ajuda_Sobre_Desenvolvedor
            // 
            this.menu_Ajuda_Sobre_Desenvolvedor.Name = "menu_Ajuda_Sobre_Desenvolvedor";
            this.menu_Ajuda_Sobre_Desenvolvedor.Size = new System.Drawing.Size(180, 22);
            this.menu_Ajuda_Sobre_Desenvolvedor.Text = "Desenvolvedor";
            this.menu_Ajuda_Sobre_Desenvolvedor.Click += new System.EventHandler(this.menu_Ajuda_Sobre_Desenvolvedor_Click);
            // 
            // menu_Ajuda_Sobre_Versao
            // 
            this.menu_Ajuda_Sobre_Versao.Name = "menu_Ajuda_Sobre_Versao";
            this.menu_Ajuda_Sobre_Versao.Size = new System.Drawing.Size(180, 22);
            this.menu_Ajuda_Sobre_Versao.Text = "Versão";
            this.menu_Ajuda_Sobre_Versao.Click += new System.EventHandler(this.menu_Ajuda_Sobre_Versao_Click);
            // 
            // menu_ComboBox
            // 
            this.menu_ComboBox.Items.AddRange(new object[] {
            "English (en-US)",
            "Portuguese (pt-BR)"});
            this.menu_ComboBox.Name = "menu_ComboBox";
            this.menu_ComboBox.Size = new System.Drawing.Size(121, 23);
            this.menu_ComboBox.SelectedIndexChanged += new System.EventHandler(this.menu_ComboBox_SelectedIndexChanged);
            // 
            // menu_Pesquisar
            // 
            this.menu_Pesquisar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menu_Pesquisar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu_Pesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu_Pesquisar.Name = "menu_Pesquisar";
            this.menu_Pesquisar.Size = new System.Drawing.Size(200, 23);
            this.menu_Pesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.menu_Pesquisar_KeyUp);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_SegundaTela_Thread);
            this.Controls.Add(this.button_TelaSecundaria);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button button_TelaSecundaria;
        private System.Windows.Forms.Button button_SegundaTela_Thread;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menu_Arquivo;
        private System.Windows.Forms.ToolStripMenuItem menu_Arquivo_Novo;
        private System.Windows.Forms.ToolStripMenuItem menu_Arquivo_Abrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_Arquivo_Sair;
        private System.Windows.Forms.ToolStripMenuItem menu_Ajuda;
        private System.Windows.Forms.ToolStripMenuItem menu_Ajuda_Sobre;
        private System.Windows.Forms.ToolStripMenuItem menu_Ajuda_Sobre_Desenvolvedor;
        private System.Windows.Forms.ToolStripMenuItem menu_Ajuda_Sobre_Versao;
        private System.Windows.Forms.ToolStripComboBox menu_ComboBox;
        private System.Windows.Forms.ToolStripTextBox menu_Pesquisar;
    }
}

