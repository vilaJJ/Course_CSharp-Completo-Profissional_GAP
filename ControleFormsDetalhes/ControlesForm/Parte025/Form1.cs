using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Pesquisar1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate($"https://{textBox_URL1.Text}/");
        }

        private void button_Pesquisar2_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate($"https://{textBox_URL2.Text}/");
        }
    }
}
