using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_Titulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao C#!\nVocê clicou na Label.", "Evento de Click do Label", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label_Titulo_MouseEnter(object sender, EventArgs e)
        {
            label_Titulo.ForeColor = Color.FromArgb(255, 192, 255);
        }

        private void label_Titulo_MouseLeave(object sender, EventArgs e)
        {
            label_Titulo.ForeColor = Color.White;
        }
    }
}
