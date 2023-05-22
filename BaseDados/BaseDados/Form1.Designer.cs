namespace BaseDados
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
            this.label_Resultado = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Nome = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.button_Conectar = new System.Windows.Forms.Button();
            this.button_CriarTabela = new System.Windows.Forms.Button();
            this.button_Inserir = new System.Windows.Forms.Button();
            this.button_Procurar = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_Excluir = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusBancoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusNomeConexao = new System.Windows.Forms.ToolStripLabel();
            this.statusBancoResLabel = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Resultado
            // 
            this.label_Resultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.Location = new System.Drawing.Point(0, 0);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Resultado.Size = new System.Drawing.Size(784, 132);
            this.label_Resultado.TabIndex = 0;
            this.label_Resultado.Text = "Manipulação de Bases de Dados";
            this.label_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lista
            // 
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.email});
            this.lista.Location = new System.Drawing.Point(12, 200);
            this.lista.MultiSelect = false;
            this.lista.Name = "lista";
            this.lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lista.Size = new System.Drawing.Size(587, 336);
            this.lista.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(12, 138);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(35, 13);
            this.label_Nome.TabIndex = 2;
            this.label_Nome.Text = "Nome";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(12, 164);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 3;
            this.label_Email.Text = "Email";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(53, 135);
            this.textBox_Nome.MaxLength = 50;
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(546, 20);
            this.textBox_Nome.TabIndex = 4;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(53, 161);
            this.textBox_Email.MaxLength = 50;
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(546, 20);
            this.textBox_Email.TabIndex = 5;
            // 
            // button_Conectar
            // 
            this.button_Conectar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Conectar.Location = new System.Drawing.Point(605, 200);
            this.button_Conectar.Name = "button_Conectar";
            this.button_Conectar.Size = new System.Drawing.Size(167, 51);
            this.button_Conectar.TabIndex = 6;
            this.button_Conectar.Text = "Conectar";
            this.button_Conectar.UseVisualStyleBackColor = true;
            this.button_Conectar.Click += new System.EventHandler(this.button_Conectar_Click);
            // 
            // button_CriarTabela
            // 
            this.button_CriarTabela.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CriarTabela.Location = new System.Drawing.Point(605, 257);
            this.button_CriarTabela.Name = "button_CriarTabela";
            this.button_CriarTabela.Size = new System.Drawing.Size(167, 51);
            this.button_CriarTabela.TabIndex = 7;
            this.button_CriarTabela.Text = "Criar Tabela";
            this.button_CriarTabela.UseVisualStyleBackColor = true;
            this.button_CriarTabela.Click += new System.EventHandler(this.button_CriarTabela_Click);
            // 
            // button_Inserir
            // 
            this.button_Inserir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inserir.Location = new System.Drawing.Point(605, 314);
            this.button_Inserir.Name = "button_Inserir";
            this.button_Inserir.Size = new System.Drawing.Size(167, 51);
            this.button_Inserir.TabIndex = 8;
            this.button_Inserir.Text = "Inserir";
            this.button_Inserir.UseVisualStyleBackColor = true;
            // 
            // button_Procurar
            // 
            this.button_Procurar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Procurar.Location = new System.Drawing.Point(605, 371);
            this.button_Procurar.Name = "button_Procurar";
            this.button_Procurar.Size = new System.Drawing.Size(167, 51);
            this.button_Procurar.TabIndex = 9;
            this.button_Procurar.Text = "Procurar";
            this.button_Procurar.UseVisualStyleBackColor = true;
            // 
            // button_Editar
            // 
            this.button_Editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Editar.Location = new System.Drawing.Point(605, 428);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(167, 51);
            this.button_Editar.TabIndex = 10;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            // 
            // button_Excluir
            // 
            this.button_Excluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Excluir.Location = new System.Drawing.Point(605, 485);
            this.button_Excluir.Name = "button_Excluir";
            this.button_Excluir.Size = new System.Drawing.Size(167, 51);
            this.button_Excluir.TabIndex = 11;
            this.button_Excluir.Text = "Excluir";
            this.button_Excluir.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBancoLabel,
            this.statusNomeConexao,
            this.statusBancoResLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 536);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusBancoLabel
            // 
            this.statusBancoLabel.AutoSize = false;
            this.statusBancoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusBancoLabel.Name = "statusBancoLabel";
            this.statusBancoLabel.Size = new System.Drawing.Size(156, 20);
            this.statusBancoLabel.Text = "Status do Banco de Dados: ";
            this.statusBancoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusNomeConexao
            // 
            this.statusNomeConexao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusNomeConexao.AutoSize = false;
            this.statusNomeConexao.Name = "statusNomeConexao";
            this.statusNomeConexao.Size = new System.Drawing.Size(200, 22);
            this.statusNomeConexao.Text = "Sem conexão";
            this.statusNomeConexao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusBancoResLabel
            // 
            this.statusBancoResLabel.AutoSize = false;
            this.statusBancoResLabel.Name = "statusBancoResLabel";
            this.statusBancoResLabel.Size = new System.Drawing.Size(300, 20);
            this.statusBancoResLabel.Text = "Desconectado";
            this.statusBancoResLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button_Excluir);
            this.Controls.Add(this.button_Editar);
            this.Controls.Add(this.button_Procurar);
            this.Controls.Add(this.button_Inserir);
            this.Controls.Add(this.button_CriarTabela);
            this.Controls.Add(this.button_Conectar);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Nome);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Nome);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label_Resultado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Dados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Button button_Conectar;
        private System.Windows.Forms.Button button_CriarTabela;
        private System.Windows.Forms.Button button_Inserir;
        private System.Windows.Forms.Button button_Procurar;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_Excluir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBancoLabel;
        private System.Windows.Forms.ToolStripLabel statusBancoResLabel;
        private System.Windows.Forms.ToolStripLabel statusNomeConexao;
    }
}

