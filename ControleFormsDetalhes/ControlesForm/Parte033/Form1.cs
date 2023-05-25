using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Parar.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            label_Titulo.Text = r.Next().ToString();
        }

        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            label_Titulo.Text = "Timer Iniciado";
            AlterarEstadoBotoes(true);
            timer.Start();
        }

        private void button_Parar_Click(object sender, EventArgs e)
        {
            timer.Stop();
            AlterarEstadoBotoes(false);
            label_Titulo.Text = "Timer Parado";
        }

        private void AlterarEstadoBotoes(bool timerIniciado)
        {
            button_Iniciar.Enabled = !timerIniciado;
            button_Parar.Enabled = timerIniciado;
        }
    }
}
