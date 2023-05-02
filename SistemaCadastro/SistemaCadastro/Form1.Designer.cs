namespace SistemaCadastro
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_dataNasc = new System.Windows.Forms.Label();
            this.lbl_estadoCivil = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txtBox_nome = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dataNasc = new System.Windows.Forms.DateTimePicker();
            this.comboBox_estadoCivil = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_casaPropria = new System.Windows.Forms.CheckBox();
            this.checkBox_veiculoProprio = new System.Windows.Forms.CheckBox();
            this.groupBox_sexo = new System.Windows.Forms.GroupBox();
            this.radioButton_sexo_masc = new System.Windows.Forms.RadioButton();
            this.radioButton_sexo_fem = new System.Windows.Forms.RadioButton();
            this.radioButton_sexo_outro = new System.Windows.Forms.RadioButton();
            this.listBox_resultados = new System.Windows.Forms.ListBox();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.groupBox_sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(12, 33);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(51, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_dataNasc
            // 
            this.lbl_dataNasc.AutoSize = true;
            this.lbl_dataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataNasc.Location = new System.Drawing.Point(12, 65);
            this.lbl_dataNasc.Name = "lbl_dataNasc";
            this.lbl_dataNasc.Size = new System.Drawing.Size(154, 20);
            this.lbl_dataNasc.TabIndex = 1;
            this.lbl_dataNasc.Text = "Data de Nascimento";
            // 
            // lbl_estadoCivil
            // 
            this.lbl_estadoCivil.AutoSize = true;
            this.lbl_estadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoCivil.Location = new System.Drawing.Point(12, 97);
            this.lbl_estadoCivil.Name = "lbl_estadoCivil";
            this.lbl_estadoCivil.Size = new System.Drawing.Size(91, 20);
            this.lbl_estadoCivil.TabIndex = 2;
            this.lbl_estadoCivil.Text = "Estado Cívil";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(12, 129);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(71, 20);
            this.lbl_telefone.TabIndex = 3;
            this.lbl_telefone.Text = "Telefone";
            // 
            // txtBox_nome
            // 
            this.txtBox_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_nome.Location = new System.Drawing.Point(172, 27);
            this.txtBox_nome.Name = "txtBox_nome";
            this.txtBox_nome.Size = new System.Drawing.Size(750, 26);
            this.txtBox_nome.TabIndex = 4;
            // 
            // dateTimePicker_dataNasc
            // 
            this.dateTimePicker_dataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_dataNasc.Location = new System.Drawing.Point(172, 59);
            this.dateTimePicker_dataNasc.Name = "dateTimePicker_dataNasc";
            this.dateTimePicker_dataNasc.Size = new System.Drawing.Size(750, 26);
            this.dateTimePicker_dataNasc.TabIndex = 5;
            // 
            // comboBox_estadoCivil
            // 
            this.comboBox_estadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_estadoCivil.FormattingEnabled = true;
            this.comboBox_estadoCivil.Location = new System.Drawing.Point(172, 94);
            this.comboBox_estadoCivil.Name = "comboBox_estadoCivil";
            this.comboBox_estadoCivil.Size = new System.Drawing.Size(750, 28);
            this.comboBox_estadoCivil.TabIndex = 6;
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(172, 129);
            this.maskedTextBox_telefone.Mask = "(00) 00000-0000";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(750, 26);
            this.maskedTextBox_telefone.TabIndex = 7;
            // 
            // checkBox_casaPropria
            // 
            this.checkBox_casaPropria.AutoSize = true;
            this.checkBox_casaPropria.Location = new System.Drawing.Point(172, 161);
            this.checkBox_casaPropria.Name = "checkBox_casaPropria";
            this.checkBox_casaPropria.Size = new System.Drawing.Size(128, 17);
            this.checkBox_casaPropria.TabIndex = 8;
            this.checkBox_casaPropria.Text = "Possuí Casa Própria?";
            this.checkBox_casaPropria.UseVisualStyleBackColor = true;
            // 
            // checkBox_veiculoProprio
            // 
            this.checkBox_veiculoProprio.AutoSize = true;
            this.checkBox_veiculoProprio.Location = new System.Drawing.Point(172, 184);
            this.checkBox_veiculoProprio.Name = "checkBox_veiculoProprio";
            this.checkBox_veiculoProprio.Size = new System.Drawing.Size(141, 17);
            this.checkBox_veiculoProprio.TabIndex = 9;
            this.checkBox_veiculoProprio.Text = "Possuí Veículo Próprio?";
            this.checkBox_veiculoProprio.UseVisualStyleBackColor = true;
            this.checkBox_veiculoProprio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox_sexo
            // 
            this.groupBox_sexo.Controls.Add(this.radioButton_sexo_outro);
            this.groupBox_sexo.Controls.Add(this.radioButton_sexo_fem);
            this.groupBox_sexo.Controls.Add(this.radioButton_sexo_masc);
            this.groupBox_sexo.Location = new System.Drawing.Point(172, 207);
            this.groupBox_sexo.Name = "groupBox_sexo";
            this.groupBox_sexo.Size = new System.Drawing.Size(289, 88);
            this.groupBox_sexo.TabIndex = 10;
            this.groupBox_sexo.TabStop = false;
            this.groupBox_sexo.Text = "Sexo";
            // 
            // radioButton_sexo_masc
            // 
            this.radioButton_sexo_masc.AutoSize = true;
            this.radioButton_sexo_masc.Checked = true;
            this.radioButton_sexo_masc.Location = new System.Drawing.Point(6, 19);
            this.radioButton_sexo_masc.Name = "radioButton_sexo_masc";
            this.radioButton_sexo_masc.Size = new System.Drawing.Size(73, 17);
            this.radioButton_sexo_masc.TabIndex = 0;
            this.radioButton_sexo_masc.TabStop = true;
            this.radioButton_sexo_masc.Text = "Masculino";
            this.radioButton_sexo_masc.UseVisualStyleBackColor = true;
            this.radioButton_sexo_masc.CheckedChanged += new System.EventHandler(this.radioButton_sexo_masc_CheckedChanged);
            // 
            // radioButton_sexo_fem
            // 
            this.radioButton_sexo_fem.AutoSize = true;
            this.radioButton_sexo_fem.Location = new System.Drawing.Point(6, 42);
            this.radioButton_sexo_fem.Name = "radioButton_sexo_fem";
            this.radioButton_sexo_fem.Size = new System.Drawing.Size(67, 17);
            this.radioButton_sexo_fem.TabIndex = 1;
            this.radioButton_sexo_fem.TabStop = true;
            this.radioButton_sexo_fem.Text = "Feminino";
            this.radioButton_sexo_fem.UseVisualStyleBackColor = true;
            // 
            // radioButton_sexo_outro
            // 
            this.radioButton_sexo_outro.AutoSize = true;
            this.radioButton_sexo_outro.Location = new System.Drawing.Point(6, 65);
            this.radioButton_sexo_outro.Name = "radioButton_sexo_outro";
            this.radioButton_sexo_outro.Size = new System.Drawing.Size(51, 17);
            this.radioButton_sexo_outro.TabIndex = 2;
            this.radioButton_sexo_outro.TabStop = true;
            this.radioButton_sexo_outro.Text = "Outro";
            this.radioButton_sexo_outro.UseVisualStyleBackColor = true;
            // 
            // listBox_resultados
            // 
            this.listBox_resultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_resultados.FormattingEnabled = true;
            this.listBox_resultados.ItemHeight = 20;
            this.listBox_resultados.Location = new System.Drawing.Point(9, 355);
            this.listBox_resultados.Name = "listBox_resultados";
            this.listBox_resultados.Size = new System.Drawing.Size(913, 144);
            this.listBox_resultados.TabIndex = 11;
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.AutoSize = true;
            this.button_cadastrar.Location = new System.Drawing.Point(710, 326);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(103, 23);
            this.button_cadastrar.TabIndex = 12;
            this.button_cadastrar.Text = "Cadastrar / Alterar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.AutoSize = true;
            this.button_excluir.Location = new System.Drawing.Point(819, 326);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(103, 23);
            this.button_excluir.TabIndex = 13;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.AutoSize = true;
            this.button_limpar.Location = new System.Drawing.Point(9, 326);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(103, 23);
            this.button_limpar.TabIndex = 14;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.listBox_resultados);
            this.Controls.Add(this.groupBox_sexo);
            this.Controls.Add(this.checkBox_veiculoProprio);
            this.Controls.Add(this.checkBox_casaPropria);
            this.Controls.Add(this.maskedTextBox_telefone);
            this.Controls.Add(this.comboBox_estadoCivil);
            this.Controls.Add(this.dateTimePicker_dataNasc);
            this.Controls.Add(this.txtBox_nome);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_estadoCivil);
            this.Controls.Add(this.lbl_dataNasc);
            this.Controls.Add(this.lbl_nome);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_sexo.ResumeLayout(false);
            this.groupBox_sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_dataNasc;
        private System.Windows.Forms.Label lbl_estadoCivil;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox txtBox_nome;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataNasc;
        private System.Windows.Forms.ComboBox comboBox_estadoCivil;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.CheckBox checkBox_casaPropria;
        private System.Windows.Forms.CheckBox checkBox_veiculoProprio;
        private System.Windows.Forms.GroupBox groupBox_sexo;
        private System.Windows.Forms.RadioButton radioButton_sexo_fem;
        private System.Windows.Forms.RadioButton radioButton_sexo_masc;
        private System.Windows.Forms.RadioButton radioButton_sexo_outro;
        private System.Windows.Forms.ListBox listBox_resultados;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_limpar;
    }
}

