using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte027
{
    public partial class Form1 : Form
    {
        string txt;
        bool isRecortar;
        public Form1()
        {
            InitializeComponent();
        }

        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt = textBox1.Text;
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt = textBox1.Text;
            textBox1.Text = null;
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text += txt ?? null;
        }

        private void contextMenuStrip_Final_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show($"{txt != null || txt != ""}");
            colarToolStripMenuItem.Enabled = txt != null || txt != "";
        }
    }
}
