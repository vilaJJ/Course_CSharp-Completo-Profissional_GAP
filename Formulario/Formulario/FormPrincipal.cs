using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button_TelaSecundaria_Click(object sender, EventArgs e)
        {
            Hide(); // Esconde a form principal

            FormSecundaria formSecundaria = new FormSecundaria();

            // formSecundaria.Show();
            formSecundaria.ShowDialog();

            this.Show();
        }

        private void button_SegundaTela_Thread_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormSecundaria()));
            t.Start();
        }
    }
}