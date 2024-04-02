namespace CapturandoTeclas.Formularios
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
            this.Button_TeclaX = new System.Windows.Forms.Button();
            this.Button_TeclaEnter = new System.Windows.Forms.Button();
            this.Label_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_TeclaX
            // 
            this.Button_TeclaX.Location = new System.Drawing.Point(12, 289);
            this.Button_TeclaX.Name = "Button_TeclaX";
            this.Button_TeclaX.Size = new System.Drawing.Size(150, 60);
            this.Button_TeclaX.TabIndex = 0;
            this.Button_TeclaX.Text = "Tecla &X";
            this.Button_TeclaX.UseVisualStyleBackColor = true;
            this.Button_TeclaX.Click += new System.EventHandler(this.Button_TeclaX_Click);
            this.Button_TeclaX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Button_TeclaX_KeyPress);
            // 
            // Button_TeclaEnter
            // 
            this.Button_TeclaEnter.Location = new System.Drawing.Point(422, 289);
            this.Button_TeclaEnter.Name = "Button_TeclaEnter";
            this.Button_TeclaEnter.Size = new System.Drawing.Size(150, 60);
            this.Button_TeclaEnter.TabIndex = 1;
            this.Button_TeclaEnter.Text = "Tecla &Enter";
            this.Button_TeclaEnter.UseVisualStyleBackColor = true;
            this.Button_TeclaEnter.Click += new System.EventHandler(this.Button_TeclaEnter_Click);
            // 
            // Label_Resultado
            // 
            this.Label_Resultado.Font = new System.Drawing.Font("Arial", 14F);
            this.Label_Resultado.Location = new System.Drawing.Point(12, 9);
            this.Label_Resultado.Name = "Label_Resultado";
            this.Label_Resultado.Size = new System.Drawing.Size(560, 277);
            this.Label_Resultado.TabIndex = 2;
            this.Label_Resultado.Text = "Digite uma tecla...";
            this.Label_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Label_Resultado);
            this.Controls.Add(this.Button_TeclaEnter);
            this.Controls.Add(this.Button_TeclaX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturando Teclas";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPrincipal_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button_TeclaX;
        internal System.Windows.Forms.Button Button_TeclaEnter;
        internal System.Windows.Forms.Label Label_Resultado;
    }
}

