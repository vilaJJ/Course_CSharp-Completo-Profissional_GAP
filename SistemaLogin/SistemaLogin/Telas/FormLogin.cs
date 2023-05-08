using SistemaLogin.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin.Telas
{
    public partial class FormLogin : Form
    {
        public static bool Cancelado = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Cancelado = true;
            Close();
        }

        private void button_acessar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario()
            {
                Nome = textBox_usuario.Text,
                Senha = textBox_senha.Text
            };

            if (CadastroUsuarios.Login(u))
            {
                MessageBox.Show("Login autorizado", "Acesso autorizado", MessageBoxButtons.OK);

                Close();
            }
            else
            {
                MessageBox.Show("Login não autorizado. Tente novamente.", "Acesso autorizado", MessageBoxButtons.OK);

                textBox_usuario.Text = null;
                textBox_senha.Text = null;

                textBox_usuario.Focus();
            }
        }
    }
}
