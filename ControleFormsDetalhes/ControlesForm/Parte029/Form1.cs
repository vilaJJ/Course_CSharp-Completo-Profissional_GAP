using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte029
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Resize();

            toolStripProgresso.Value = 75;
        }

        private void Form1_Resize()
        {
            Form1_Resize(null, null);
            return;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            toolStripStatus.Text = $"{Size.Width} x {Size.Height}";
        }


        private void AlterarProgresso(int value)
        {
            toolStripProgresso.Value = value;
        }

        private void Progresso0_Click(object sender, EventArgs e)
        {
            AlterarProgresso(0);
        }

        private void Progresso25_Click(object sender, EventArgs e)
        {
            AlterarProgresso(25);
        }

        private void Progresso50_Click(object sender, EventArgs e)
        {
            AlterarProgresso(50);
        }

        private void Progresso75_Click(object sender, EventArgs e)
        {
            AlterarProgresso(75);
        }

        private void Progresso100_Click(object sender, EventArgs e)
        {
            AlterarProgresso(100);
        }
    }
}
