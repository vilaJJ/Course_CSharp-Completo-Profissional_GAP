using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormSecundaria : Form
    {
        public string Mensagem { get; set; }

        public FormSecundaria()
        {
            InitializeComponent();
        }

        public FormSecundaria(string Mensagem)
        {
            InitializeComponent();

            this.Mensagem = Mensagem;
        }

        private void FormSecundaria_Load(object sender, EventArgs e)
        {
            textBox_Mensagem.Text = Mensagem;
        }

        private void button_TelaPrincipal_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormPrincipal()));
            t.Start();
        }

        private void button_Retorno_Click(object sender, EventArgs e)
        {
            if (textBox_Mensagem.Text.Trim() == "" || textBox_Mensagem.Text == null)
            {
                Mensagem = null;
            }
            else
            {
                Mensagem = textBox_Mensagem.Text;
            }

            Close();
        }

        private void button_Fechar_Click(object sender, EventArgs e)
        {
            Mensagem = null;
            Close();
        }
    }
}
