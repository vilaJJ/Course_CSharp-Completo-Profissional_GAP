using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            label_QntdCarac.Text = $"Quantidade de caracteres: {richTextBox.TextLength}";
        }

        private void button_ZoomPlus_Click(object sender, EventArgs e)
        {
            if (richTextBox.ZoomFactor < 5) richTextBox.ZoomFactor++;
            AlterarTextoZoom();
        }

        private void button_ZoomSubt_Click(object sender, EventArgs e)
        {
            if (richTextBox.ZoomFactor > 1) richTextBox.ZoomFactor--;
            AlterarTextoZoom();
        }

        private void AlterarTextoZoom()
        {
            label_zoom.Text = $"Zoom: {richTextBox.ZoomFactor.ToString("0")}x";
        }
    }
}
