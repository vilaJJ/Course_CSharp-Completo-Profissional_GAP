using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // pictureBox.BackgroundImage = Image.FromFile("Assets/healthconnect.png");
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            // pictureBox.Image = Image.FromFile("Assets/old_nts-coletor.png");
            pictureBox.BackgroundImage = Image.FromFile("Assets/healthconnect.png");
        }

        private void button_NTSColetor_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = Image.FromFile("Assets/old_nts-coletor.png");
        }
    }
}
