using SistemaLogin.Classes;
using SistemaLogin.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            while (CadastroUsuarios.UsuarioLogado == null)
            {
                login.ShowDialog();

                if (FormLogin.Cancelado)
                {
                    Application.Exit();
                    return;
                }
            }

            WindowState = FormWindowState.Normal;
            label_bemvindo.Text = $"Seja bem vindo(a),\n{CadastroUsuarios.UsuarioLogado.Nome}.";
        }

        private void label_bemvindo_Click(object sender, EventArgs e)
        {

        }
    }
}
