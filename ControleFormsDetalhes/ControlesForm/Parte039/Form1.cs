using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Cor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = label_Cor.BackColor;

            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                label_Cor.BackColor = colorDialog1.Color;
            }
        }
    }
}
