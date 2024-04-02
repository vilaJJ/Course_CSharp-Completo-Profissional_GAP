namespace Graficos.Formularios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Label_Grafico = new System.Windows.Forms.Label();
            this.Label_ValorX = new System.Windows.Forms.Label();
            this.Label_ValorY = new System.Windows.Forms.Label();
            this.TextBox_ValorY = new System.Windows.Forms.TextBox();
            this.TextBox_ValorX = new System.Windows.Forms.TextBox();
            this.Button_InserirValoresGrafico = new System.Windows.Forms.Button();
            this.Chart_Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_InserirValoresAleatorios = new System.Windows.Forms.Button();
            this.DataGridView_Historico = new System.Windows.Forms.DataGridView();
            this.DataGridView_Historico_EixoX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView_Historico_EixoY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_LimparGrafico = new System.Windows.Forms.Button();
            this.ComboBox_TipoGrafico = new System.Windows.Forms.ComboBox();
            this.CheckBox_Grafico3D = new System.Windows.Forms.CheckBox();
            this.ComboBox_PaletaCorGrafico = new System.Windows.Forms.ComboBox();
            this.Timer_InsercaoAleatoria = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Historico)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Grafico
            // 
            this.Label_Grafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label_Grafico.Location = new System.Drawing.Point(12, 9);
            this.Label_Grafico.Name = "Label_Grafico";
            this.Label_Grafico.Size = new System.Drawing.Size(208, 28);
            this.Label_Grafico.TabIndex = 0;
            this.Label_Grafico.Text = "Gráfico";
            this.Label_Grafico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_ValorX
            // 
            this.Label_ValorX.AutoSize = true;
            this.Label_ValorX.Location = new System.Drawing.Point(12, 46);
            this.Label_ValorX.Name = "Label_ValorX";
            this.Label_ValorX.Size = new System.Drawing.Size(56, 13);
            this.Label_ValorX.TabIndex = 1;
            this.Label_ValorX.Text = "Valor de &X";
            // 
            // Label_ValorY
            // 
            this.Label_ValorY.AutoSize = true;
            this.Label_ValorY.Location = new System.Drawing.Point(117, 46);
            this.Label_ValorY.Name = "Label_ValorY";
            this.Label_ValorY.Size = new System.Drawing.Size(56, 13);
            this.Label_ValorY.TabIndex = 3;
            this.Label_ValorY.Text = "Valor de &Y";
            // 
            // TextBox_ValorY
            // 
            this.TextBox_ValorY.Location = new System.Drawing.Point(120, 62);
            this.TextBox_ValorY.Name = "TextBox_ValorY";
            this.TextBox_ValorY.Size = new System.Drawing.Size(100, 20);
            this.TextBox_ValorY.TabIndex = 4;
            this.TextBox_ValorY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ValorY_KeyPress);
            // 
            // TextBox_ValorX
            // 
            this.TextBox_ValorX.Location = new System.Drawing.Point(15, 62);
            this.TextBox_ValorX.Name = "TextBox_ValorX";
            this.TextBox_ValorX.Size = new System.Drawing.Size(99, 20);
            this.TextBox_ValorX.TabIndex = 2;
            this.TextBox_ValorX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ValorX_KeyPress);
            // 
            // Button_InserirValoresGrafico
            // 
            this.Button_InserirValoresGrafico.Location = new System.Drawing.Point(15, 88);
            this.Button_InserirValoresGrafico.Name = "Button_InserirValoresGrafico";
            this.Button_InserirValoresGrafico.Size = new System.Drawing.Size(205, 23);
            this.Button_InserirValoresGrafico.TabIndex = 5;
            this.Button_InserirValoresGrafico.Text = "&Inserir Valores no Gráfico";
            this.Button_InserirValoresGrafico.UseVisualStyleBackColor = true;
            this.Button_InserirValoresGrafico.Click += new System.EventHandler(this.Button_InserirValoresGrafico_Click);
            // 
            // Chart_Grafico
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart_Grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart_Grafico.Legends.Add(legend2);
            this.Chart_Grafico.Location = new System.Drawing.Point(226, 12);
            this.Chart_Grafico.Name = "Chart_Grafico";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "X vs Y";
            this.Chart_Grafico.Series.Add(series2);
            this.Chart_Grafico.Size = new System.Drawing.Size(346, 308);
            this.Chart_Grafico.TabIndex = 12;
            this.Chart_Grafico.Text = "Gráfico";
            // 
            // Button_InserirValoresAleatorios
            // 
            this.Button_InserirValoresAleatorios.Location = new System.Drawing.Point(425, 326);
            this.Button_InserirValoresAleatorios.Name = "Button_InserirValoresAleatorios";
            this.Button_InserirValoresAleatorios.Size = new System.Drawing.Size(147, 23);
            this.Button_InserirValoresAleatorios.TabIndex = 11;
            this.Button_InserirValoresAleatorios.Text = "Inserir Valores &Aleatórios";
            this.Button_InserirValoresAleatorios.UseVisualStyleBackColor = true;
            this.Button_InserirValoresAleatorios.Click += new System.EventHandler(this.Button_InserirValoresAleatorios_Click);
            // 
            // DataGridView_Historico
            // 
            this.DataGridView_Historico.AllowUserToAddRows = false;
            this.DataGridView_Historico.AllowUserToDeleteRows = false;
            this.DataGridView_Historico.AllowUserToResizeColumns = false;
            this.DataGridView_Historico.AllowUserToResizeRows = false;
            this.DataGridView_Historico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Historico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridView_Historico_EixoX,
            this.DataGridView_Historico_EixoY});
            this.DataGridView_Historico.Location = new System.Drawing.Point(15, 117);
            this.DataGridView_Historico.MultiSelect = false;
            this.DataGridView_Historico.Name = "DataGridView_Historico";
            this.DataGridView_Historico.ReadOnly = true;
            this.DataGridView_Historico.RowHeadersVisible = false;
            this.DataGridView_Historico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Historico.ShowCellErrors = false;
            this.DataGridView_Historico.ShowCellToolTips = false;
            this.DataGridView_Historico.ShowEditingIcon = false;
            this.DataGridView_Historico.ShowRowErrors = false;
            this.DataGridView_Historico.Size = new System.Drawing.Size(205, 174);
            this.DataGridView_Historico.TabIndex = 6;
            this.DataGridView_Historico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Historico_CellClick);
            this.DataGridView_Historico.SelectionChanged += new System.EventHandler(this.DataGridView_Historico_SelectionChanged);
            // 
            // DataGridView_Historico_EixoX
            // 
            this.DataGridView_Historico_EixoX.HeaderText = "Eixo X";
            this.DataGridView_Historico_EixoX.Name = "DataGridView_Historico_EixoX";
            this.DataGridView_Historico_EixoX.ReadOnly = true;
            // 
            // DataGridView_Historico_EixoY
            // 
            this.DataGridView_Historico_EixoY.HeaderText = "Eixo Y";
            this.DataGridView_Historico_EixoY.Name = "DataGridView_Historico_EixoY";
            this.DataGridView_Historico_EixoY.ReadOnly = true;
            // 
            // Button_LimparGrafico
            // 
            this.Button_LimparGrafico.Location = new System.Drawing.Point(15, 297);
            this.Button_LimparGrafico.Name = "Button_LimparGrafico";
            this.Button_LimparGrafico.Size = new System.Drawing.Size(205, 23);
            this.Button_LimparGrafico.TabIndex = 7;
            this.Button_LimparGrafico.Text = "&Limpar Gráfico";
            this.Button_LimparGrafico.UseVisualStyleBackColor = true;
            this.Button_LimparGrafico.Click += new System.EventHandler(this.Button_LimparGrafico_Click);
            // 
            // ComboBox_TipoGrafico
            // 
            this.ComboBox_TipoGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_TipoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ComboBox_TipoGrafico.FormattingEnabled = true;
            this.ComboBox_TipoGrafico.Location = new System.Drawing.Point(15, 326);
            this.ComboBox_TipoGrafico.Name = "ComboBox_TipoGrafico";
            this.ComboBox_TipoGrafico.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_TipoGrafico.TabIndex = 8;
            this.ComboBox_TipoGrafico.SelectedIndexChanged += new System.EventHandler(this.ComboBox_TipoGrafico_SelectedIndexChanged);
            // 
            // CheckBox_Grafico3D
            // 
            this.CheckBox_Grafico3D.AutoSize = true;
            this.CheckBox_Grafico3D.Location = new System.Drawing.Point(343, 330);
            this.CheckBox_Grafico3D.Name = "CheckBox_Grafico3D";
            this.CheckBox_Grafico3D.Size = new System.Drawing.Size(77, 17);
            this.CheckBox_Grafico3D.TabIndex = 10;
            this.CheckBox_Grafico3D.Text = "Gráfico 3&D";
            this.CheckBox_Grafico3D.UseVisualStyleBackColor = true;
            this.CheckBox_Grafico3D.CheckedChanged += new System.EventHandler(this.CheckBox_Grafico3D_CheckedChanged);
            // 
            // ComboBox_PaletaCorGrafico
            // 
            this.ComboBox_PaletaCorGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PaletaCorGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ComboBox_PaletaCorGrafico.FormattingEnabled = true;
            this.ComboBox_PaletaCorGrafico.Location = new System.Drawing.Point(179, 326);
            this.ComboBox_PaletaCorGrafico.Name = "ComboBox_PaletaCorGrafico";
            this.ComboBox_PaletaCorGrafico.Size = new System.Drawing.Size(158, 23);
            this.ComboBox_PaletaCorGrafico.TabIndex = 9;
            this.ComboBox_PaletaCorGrafico.SelectedIndexChanged += new System.EventHandler(this.ComboBox_PaletaCorGrafico_SelectedIndexChanged);
            // 
            // Timer_InsercaoAleatoria
            // 
            this.Timer_InsercaoAleatoria.Interval = 500;
            this.Timer_InsercaoAleatoria.Tick += new System.EventHandler(this.Timer_InsercaoAleatoria_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.ComboBox_PaletaCorGrafico);
            this.Controls.Add(this.CheckBox_Grafico3D);
            this.Controls.Add(this.ComboBox_TipoGrafico);
            this.Controls.Add(this.Button_LimparGrafico);
            this.Controls.Add(this.DataGridView_Historico);
            this.Controls.Add(this.Button_InserirValoresAleatorios);
            this.Controls.Add(this.Chart_Grafico);
            this.Controls.Add(this.Button_InserirValoresGrafico);
            this.Controls.Add(this.TextBox_ValorX);
            this.Controls.Add(this.TextBox_ValorY);
            this.Controls.Add(this.Label_ValorY);
            this.Controls.Add(this.Label_ValorX);
            this.Controls.Add(this.Label_Grafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficos";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Historico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label_Grafico;
        internal System.Windows.Forms.Label Label_ValorX;
        internal System.Windows.Forms.Label Label_ValorY;
        internal System.Windows.Forms.TextBox TextBox_ValorY;
        internal System.Windows.Forms.TextBox TextBox_ValorX;
        internal System.Windows.Forms.Button Button_InserirValoresGrafico;
        internal System.Windows.Forms.Button Button_InserirValoresAleatorios;
        internal System.Windows.Forms.DataVisualization.Charting.Chart Chart_Grafico;
        internal System.Windows.Forms.DataGridView DataGridView_Historico;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridView_Historico_EixoX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridView_Historico_EixoY;
        internal System.Windows.Forms.Button Button_LimparGrafico;
        internal System.Windows.Forms.ComboBox ComboBox_TipoGrafico;
        internal System.Windows.Forms.CheckBox CheckBox_Grafico3D;
        internal System.Windows.Forms.ComboBox ComboBox_PaletaCorGrafico;
        internal System.Windows.Forms.Timer Timer_InsercaoAleatoria;
    }
}

