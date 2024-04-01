using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos.Formularios
{
    public partial class FormPrincipal : Form
    {
        private readonly Dictionary<double, double> Valores;

        public FormPrincipal()
        {
            InitializeComponent();

            Valores = new Dictionary<double, double>();
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

        }

        private void Button_LimparGrafico_Click(object sender, EventArgs e)
        {

        }

        private void Button_InserirValoresAleatorios_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region DataGridView Events

        private void DataGridView_Historico_SelectionChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region ComboBox Events

        private void ComboBox_TipoGráfico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_PaletaCorGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region CheckBox Events

        private void CheckBox_Grafico3D_CheckedChanged(object sender, EventArgs e)
        {

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
                ComboBox_TipoGráfico.Items.Add((SeriesChartType)indice);
            }

            for (int indice = 0; indice < 13; indice++)
            {
                ComboBox_PaletaCorGrafico.Items.Add((ChartColorPalette)indice);
            }

            ComboBox_TipoGráfico.SelectedIndex = 4;
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

        #endregion
    }
}
