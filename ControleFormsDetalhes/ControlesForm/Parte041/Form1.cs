using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_SelecFont_Click(object sender, EventArgs e)
        {
            Font oldFont = label1.Font;
            Color oldForeColor = label1.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                AlterarLabel();
                Utilitarios.Alertas.MensagemInformacao($"Fonte '{label1.Font.Name}' aplicada.");
            }
            else
            {
                AlterarLabel(oldFont, oldForeColor);
                Utilitarios.Alertas.MensagemInformacao("Fonte não alterada.");
            }
        }

        private void fontDialog_Apply(object sender, EventArgs e)
        {
            AlterarLabel();
        }

        private void AlterarLabel()
        {
            label1.Font = fontDialog.Font;
            label1.ForeColor = fontDialog.Color;
        }
        private void AlterarLabel(Font font, Color color)
        {
            label1.Font = font;
            label1.ForeColor = color;
        }
    }
}
