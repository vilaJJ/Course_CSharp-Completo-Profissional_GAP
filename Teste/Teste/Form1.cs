using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Text = "Juan Felipe Alves Flores";

            this.Size = new Size(720, 480);

            this.ControlBox = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Clicando no Botão";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Carregando a Form";
        }

        private void MeuMetodo(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            btn_exe.Size = new Size(3100, 200);
        }

        private void btn_exe_MouseEnter(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Mouse dentro do botão";
        }

        private void btn_exe_MouseLeave(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Mouse fora do botão";
        }
    }
}
