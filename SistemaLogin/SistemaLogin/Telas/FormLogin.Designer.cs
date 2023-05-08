namespace SistemaLogin.Telas
{
    partial class FormLogin
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
            this.groupBox_usuario = new System.Windows.Forms.GroupBox();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.groupBox_senha = new System.Windows.Forms.GroupBox();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_acessar = new System.Windows.Forms.Button();
            this.groupBox_usuario.SuspendLayout();
            this.groupBox_senha.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_usuario
            // 
            this.groupBox_usuario.Controls.Add(this.textBox_usuario);
            this.groupBox_usuario.Location = new System.Drawing.Point(12, 55);
            this.groupBox_usuario.Name = "groupBox_usuario";
            this.groupBox_usuario.Size = new System.Drawing.Size(360, 43);
            this.groupBox_usuario.TabIndex = 0;
            this.groupBox_usuario.TabStop = false;
            this.groupBox_usuario.Text = "Usuário";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_usuario.Location = new System.Drawing.Point(3, 16);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(354, 20);
            this.textBox_usuario.TabIndex = 0;
            // 
            // groupBox_senha
            // 
            this.groupBox_senha.Controls.Add(this.textBox_senha);
            this.groupBox_senha.Location = new System.Drawing.Point(12, 104);
            this.groupBox_senha.Name = "groupBox_senha";
            this.groupBox_senha.Size = new System.Drawing.Size(360, 43);
            this.groupBox_senha.TabIndex = 1;
            this.groupBox_senha.TabStop = false;
            this.groupBox_senha.Text = "Senha";
            // 
            // textBox_senha
            // 
            this.textBox_senha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_senha.Location = new System.Drawing.Point(3, 16);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = '*';
            this.textBox_senha.Size = new System.Drawing.Size(354, 20);
            this.textBox_senha.TabIndex = 0;
            this.textBox_senha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(297, 249);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 4;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_acessar
            // 
            this.button_acessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_acessar.Location = new System.Drawing.Point(101, 169);
            this.button_acessar.Name = "button_acessar";
            this.button_acessar.Size = new System.Drawing.Size(182, 48);
            this.button_acessar.TabIndex = 3;
            this.button_acessar.Text = "Acessar";
            this.button_acessar.UseVisualStyleBackColor = true;
            this.button_acessar.Click += new System.EventHandler(this.button_acessar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 284);
            this.ControlBox = false;
            this.Controls.Add(this.button_acessar);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_senha);
            this.Controls.Add(this.groupBox_usuario);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 16);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox_usuario.ResumeLayout(false);
            this.groupBox_usuario.PerformLayout();
            this.groupBox_senha.ResumeLayout(false);
            this.groupBox_senha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_usuario;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.GroupBox groupBox_senha;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_acessar;
    }
}