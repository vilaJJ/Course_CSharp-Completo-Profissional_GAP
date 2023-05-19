using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Img1_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = Image.FromFile("Assets/Imagem1.jpg");
        }

        private void button_Img2_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = Image.FromFile("Assets/Imagem2.png");
        }

        private void button_Img3_Click(object sender, EventArgs e)
        {
            pictureBox.BackgroundImage = Image.FromFile("Assets/Imagem3.jpg");
        }
    }
}
