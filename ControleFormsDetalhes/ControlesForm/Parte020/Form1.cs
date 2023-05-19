using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Navegar_Click()
        {
            button_Navegar_Click(null, null);
        }
        private void button_Navegar_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate($"http://{textBox_url.Text}");
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void button_Avancar_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();            
        }

        private void textBox_url_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) button_Navegar_Click();
        }
    }
}
