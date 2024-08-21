namespace EditorTexto.Formularios.SobrePrograma
{
    partial class FormSobrePrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobrePrograma));
            Button_Sair = new Button();
            Label_Email = new Label();
            Label_DataVersao = new Label();
            Label_Versao = new Label();
            PictureBox_Icone = new PictureBox();
            Label_TituloApp = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Icone).BeginInit();
            SuspendLayout();
            // 
            // Button_Sair
            // 
            Button_Sair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button_Sair.Location = new Point(247, 151);
            Button_Sair.Name = "Button_Sair";
            Button_Sair.Size = new Size(75, 23);
            Button_Sair.TabIndex = 4;
            Button_Sair.Text = "&Sair";
            Button_Sair.UseVisualStyleBackColor = true;
            // 
            // Label_Email
            // 
            Label_Email.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label_Email.AutoSize = true;
            Label_Email.Location = new Point(12, 155);
            Label_Email.Name = "Label_Email";
            Label_Email.Size = new Size(226, 15);
            Label_Email.TabIndex = 3;
            Label_Email.Text = "Email: juan.felipe.alves.flores@gmail.com";
            // 
            // Label_DataVersao
            // 
            Label_DataVersao.Location = new Point(172, 123);
            Label_DataVersao.Name = "Label_DataVersao";
            Label_DataVersao.RightToLeft = RightToLeft.No;
            Label_DataVersao.Size = new Size(150, 15);
            Label_DataVersao.TabIndex = 2;
            Label_DataVersao.Text = "Data da Versão";
            Label_DataVersao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label_Versao
            // 
            Label_Versao.Location = new Point(12, 123);
            Label_Versao.Name = "Label_Versao";
            Label_Versao.Size = new Size(150, 15);
            Label_Versao.TabIndex = 1;
            Label_Versao.Text = "Versão";
            Label_Versao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PictureBox_Icone
            // 
            PictureBox_Icone.Image = Properties.Resources.text_editor;
            PictureBox_Icone.InitialImage = null;
            PictureBox_Icone.Location = new Point(12, 12);
            PictureBox_Icone.Name = "PictureBox_Icone";
            PictureBox_Icone.Size = new Size(310, 75);
            PictureBox_Icone.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox_Icone.TabIndex = 4;
            PictureBox_Icone.TabStop = false;
            // 
            // Label_TituloApp
            // 
            Label_TituloApp.AutoSize = true;
            Label_TituloApp.Font = new Font("Segoe UI", 14F);
            Label_TituloApp.Location = new Point(101, 94);
            Label_TituloApp.Name = "Label_TituloApp";
            Label_TituloApp.Size = new Size(137, 25);
            Label_TituloApp.TabIndex = 0;
            Label_TituloApp.Text = "Editor de Texto";
            // 
            // FormSobrePrograma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = Button_Sair;
            ClientSize = new Size(334, 186);
            Controls.Add(Label_TituloApp);
            Controls.Add(PictureBox_Icone);
            Controls.Add(Label_Versao);
            Controls.Add(Label_DataVersao);
            Controls.Add(Label_Email);
            Controls.Add(Button_Sair);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(350, 225);
            MinimizeBox = false;
            MinimumSize = new Size(350, 225);
            Name = "FormSobrePrograma";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editor de Texto - Sobre";
            Load += FormSobrePrograma_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox_Icone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Button Button_Sair;
        internal Label Label_Email;
        internal Label Label_DataVersao;
        internal Label Label_Versao;
        internal PictureBox PictureBox_Icone;
        internal Label Label_TituloApp;
    }
}