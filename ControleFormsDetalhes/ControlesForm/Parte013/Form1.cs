using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if((numericUpDown.Value % 2) == 0)
            {
                label_Valor.Text = "Número Par";
            }
            else
            {
                label_Valor.Text = "Número Impar";
            }
        }
    }
}
