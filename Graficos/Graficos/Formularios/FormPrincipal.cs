using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos.Formularios
{
    public partial class FormPrincipal : Form
    {
        private readonly Dictionary<double, double> Valores;
        private double ContadorX;

        public FormPrincipal()
        {
            InitializeComponent();

            Valores = new Dictionary<double, double>();
            ContadorX = 0;
        }

        #region Form Events

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            TextBox_ValorX.Focus();

            PopularComboBox();
        }

        #endregion

        #region Button Events

        private void Button_InserirValoresGrafico_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas is false)
            {
                return;
            }

            InserirValores();
        }

        private void Button_LimparGrafico_Click(object sender, EventArgs e)
        {
            ContadorX = 0;

            Valores.Clear();
            LimparDados();
        }

        private void Button_InserirValoresAleatorios_Click(object sender, EventArgs e)
        {
            Timer_InsercaoAleatoria.Enabled = !Timer_InsercaoAleatoria.Enabled;

            Button_InserirValoresAleatorios.Text = Timer_InsercaoAleatoria.Enabled
                ? "Desativar Valores &Aleatorios" 
                : "Ativar Valores &Aleatórios";
        }

        #endregion

        #region DataGridView Events

        private void DataGridView_Historico_SelectionChanged(object sender, EventArgs e)
        {
            var indiceAtual = DataGridView_Historico.CurrentRow.Index;

            var chave = DataGridView_Historico.Rows[indiceAtual].Cells[0].Value.ToString();
            var valor = DataGridView_Historico.Rows[indiceAtual].Cells[1].Value.ToString();

            TextBox_ValorX.Text = chave;
            TextBox_ValorY.Text = valor;
        }

        private void DataGridView_Historico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridView_Historico_SelectionChanged(sender, e);
        }

        #endregion

        #region ComboBox Events

        private void ComboBox_TipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoGrafico = (SeriesChartType)ComboBox_TipoGrafico.SelectedItem;

            foreach (var serie in Chart_Grafico.Series)
            {
                serie.ChartType = tipoGrafico;
            }
        }

        private void ComboBox_PaletaCorGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            var paletaCor = (ChartColorPalette)ComboBox_PaletaCorGrafico.SelectedItem;

            foreach (var serie in Chart_Grafico.Series)
            {
                serie.Palette = paletaCor;
            }
        }

        #endregion

        #region Timer

        private void Timer_InsercaoAleatoria_Tick(object sender, EventArgs e)
        {
            foreach (var serie in Chart_Grafico.Series)
            {
                if (serie.Points.Count > 10)
                {
                    serie.Points.RemoveAt(0);
                    Chart_Grafico.Update();
                }
            }

            ContadorX++;
            var valorY = new Random(DateTime.Now.Millisecond).Next(1000);

            foreach (var serie in Chart_Grafico.Series)
            {
                serie.Points.AddXY(ContadorX, valorY);
            }
            DataGridView_Historico.Rows.Add(ContadorX, valorY);

            Valores.Add(ContadorX, valorY);

            SelecionarUltimaCelula();
        }

        #endregion

        #region CheckBox Events

        private void CheckBox_Grafico3D_CheckedChanged(object sender, EventArgs e)
        {
            var ativar3D = CheckBox_Grafico3D.Checked;

            foreach (var areas in Chart_Grafico.ChartAreas)
            {
                areas.Area3DStyle.Enable3D = ativar3D;
            }
        }

        #endregion

        #region Button Events

        private void TextBox_ValorX_KeyPress(object sender, KeyPressEventArgs e)
        {
            CancelarKeyPress((TextBox)sender, e);
        }

        private void TextBox_ValorY_KeyPress(object sender, KeyPressEventArgs e)
        {
            CancelarKeyPress((TextBox)sender, e);
        }

        #endregion

        #region Helpers

        private void PopularComboBox()
        {
            for (int indice = 0; indice < 35; indice++)
            {
                ComboBox_TipoGrafico.Items.Add((SeriesChartType)indice);
            }

            for (int indice = 0; indice < 13; indice++)
            {
                ComboBox_PaletaCorGrafico.Items.Add((ChartColorPalette)indice);
            }

            ComboBox_TipoGrafico.SelectedIndex = 4;
            ComboBox_PaletaCorGrafico.SelectedIndex = 12;
        }

        private void CancelarKeyPress(TextBox textBox, KeyPressEventArgs eventArgs)
        {
            var isNumero = char.IsNumber(eventArgs.KeyChar);
            var isBackspace = eventArgs.KeyChar is (char)8;
            var isEnter = eventArgs.KeyChar is (char)13;
            var isVirgula = eventArgs.KeyChar is (char)44;
            var naoPossuiVirgula = textBox.Text.Contains(',') is false;

            eventArgs.Handled = (isNumero || isBackspace || isEnter || (isVirgula && naoPossuiVirgula)) is false;
        }

        private bool ValidarEntradas
        {
            get
            {
                if (string.IsNullOrEmpty(TextBox_ValorX.Text.Trim()) || string.IsNullOrEmpty(TextBox_ValorY.Text.Trim()))
                {
                    MessageBox.Show(
                        "Os dois valores são obrigatórios.",
                        "Validação de dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );

                    return false;
                }

                return true;
            }            
        }

        private void InserirValores()
        {
            var chave = double.Parse(TextBox_ValorX.Text);
            var valor = double.Parse(TextBox_ValorY.Text);
            var contemChave = Valores.ContainsKey(chave);

            if (contemChave)
            {
                Valores[chave] = valor;
            }
            else
            {
                Valores.Add(chave, valor);
            }

            AtualizarVisualizacoes();
            SelecionarUltimaCelula();
        }

        private void AtualizarVisualizacoes()
        {
            LimparDados();

            #region Ordernar

            var valores = Valores.OrderBy(valor => valor.Key);

            #endregion

            #region Inserção

            foreach (var valor in valores)
            {
                DataGridView_Historico.Rows.Add(valor.Key, valor.Value);

                foreach (var serie in Chart_Grafico.Series)
                {
                    serie.Points.AddXY(valor.Key, valor.Value);
                }
            }

            Chart_Grafico.Update();
            LimparCampos();

            TextBox_ValorX.Focus();

            #endregion
        }

        private void LimparDados()
        {
            DataGridView_Historico.Rows.Clear();

            foreach (var serie in Chart_Grafico.Series)
            {
                serie.Points.Clear();
            }

            LimparCampos();
        }

        private void LimparCampos()
        {
            var campos = new List<TextBox>
            {
                TextBox_ValorX, TextBox_ValorY
            };

            foreach (var campo in campos)
            {
                campo.Clear();
            }
        }

        private void SelecionarUltimaCelula()
        {
            var qntdItems = DataGridView_Historico.Rows.Count - 1;

            DataGridView_Historico.CurrentCell = DataGridView_Historico.Rows[qntdItems].Cells[0];
        }

        #endregion
    }
}
