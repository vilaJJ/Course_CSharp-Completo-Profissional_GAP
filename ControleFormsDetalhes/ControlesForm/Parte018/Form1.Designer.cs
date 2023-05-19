namespace Parte018
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
            this.components = new System.ComponentModel.Container();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.label_Titulo = new System.Windows.Forms.Label();
            this.button_Exec = new System.Windows.Forms.Button();
            this.button_Apagar = new System.Windows.Forms.Button();
            this.toolTip_Warning = new System.Windows.Forms.ToolTip(this.components);
            this.button_Consultar = new System.Windows.Forms.Button();
            this.toolTip_Error = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // toolTip_Info
            // 
            this.toolTip_Info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_Info.ToolTipTitle = "Informação: ";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(12, 9);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(98, 13);
            this.label_Titulo.TabIndex = 0;
            this.label_Titulo.Text = "Formulário Principal";
            this.toolTip_Info.SetToolTip(this.label_Titulo, "Este é o título do formulário");
            // 
            // button_Exec
            // 
            this.button_Exec.Location = new System.Drawing.Point(237, 106);
            this.button_Exec.Name = "button_Exec";
            this.button_Exec.Size = new System.Drawing.Size(75, 23);
            this.button_Exec.TabIndex = 1;
            this.button_Exec.Text = "Executar";
            this.toolTip_Info.SetToolTip(this.button_Exec, "Este botão irá executar uma ação, ao ser pressionado");
            this.button_Exec.UseVisualStyleBackColor = true;
            // 
            // button_Apagar
            // 
            this.button_Apagar.Location = new System.Drawing.Point(15, 106);
            this.button_Apagar.Name = "button_Apagar";
            this.button_Apagar.Size = new System.Drawing.Size(75, 23);
            this.button_Apagar.TabIndex = 2;
            this.button_Apagar.Text = "Apagar";
            this.toolTip_Warning.SetToolTip(this.button_Apagar, "Essa ação irá apagar seus arquivos.");
            this.button_Apagar.UseVisualStyleBackColor = true;
            // 
            // toolTip_Warning
            // 
            this.toolTip_Warning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip_Warning.ToolTipTitle = "Alerta:";
            // 
            // button_Consultar
            // 
            this.button_Consultar.Location = new System.Drawing.Point(237, 9);
            this.button_Consultar.Name = "button_Consultar";
            this.button_Consultar.Size = new System.Drawing.Size(75, 23);
            this.button_Consultar.TabIndex = 3;
            this.button_Consultar.Text = "Consultar";
            this.toolTip_Error.SetToolTip(this.button_Consultar, "Funcionalidade indisponível.");
            this.button_Consultar.UseVisualStyleBackColor = true;
            // 
            // toolTip_Error
            // 
            this.toolTip_Error.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip_Error.ToolTipTitle = "Erro:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 141);
            this.Controls.Add(this.button_Consultar);
            this.Controls.Add(this.button_Apagar);
            this.Controls.Add(this.button_Exec);
            this.Controls.Add(this.label_Titulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 180);
            this.MinimumSize = new System.Drawing.Size(340, 180);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Button button_Exec;
        private System.Windows.Forms.Button button_Apagar;
        private System.Windows.Forms.ToolTip toolTip_Warning;
        private System.Windows.Forms.Button button_Consultar;
        private System.Windows.Forms.ToolTip toolTip_Error;
    }
}

