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
            // Hide(); // Esconde a form principal

            FormSecundaria formSecundaria = new FormSecundaria();
            // formSecundaria.Mensagem = "Juan Felipe";
            // formSecundaria.Show();
            formSecundaria.ShowDialog();

            if (formSecundaria.Mensagem != null)
            {
                label_titulo.Text = formSecundaria.Mensagem;
            }

            //this.Show();
        }

        private void button_SegundaTela_Thread_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormSecundaria()));
            t.Start();
        }

        private void menu_Arquivo_Novo_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormPrincipal())).Start();
        }

        private void menu_Arquivo_Abrir_Click(object sender, EventArgs e)
        {
            Hide();

            FormSecundaria formSecundaria = new FormSecundaria();
            formSecundaria.ShowDialog();

            Show();
        }

        private void menu_Arquivo_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_Ajuda_Sobre_Desenvolvedor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Juan Felipe Alves Flores", "Desenvolvedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu_Ajuda_Sobre_Versao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão: 1.45.6 2H31", "Versão do Aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menu_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (menu_ComboBox.SelectedIndex)
            {
                case 0:     // English (US)
                    menu_Arquivo.Text = "File";
                    menu_Arquivo_Novo.Text = "New";
                    menu_Arquivo_Abrir.Text = "Open";
                    menu_Arquivo_Sair.Text = "Exit";

                    menu_Ajuda.Text = "Help";
                    menu_Ajuda_Sobre.Text = "About";
                    menu_Ajuda_Sobre_Desenvolvedor.Text = "Developer";
                    menu_Ajuda_Sobre_Versao.Text = "Version";                    
                    break;
                case 1:     // Portuguese (pt-BR)
                    menu_Arquivo.Text = "Arquivo";
                    menu_Arquivo_Novo.Text = "Novo";
                    menu_Arquivo_Abrir.Text = "Abrir";
                    menu_Arquivo_Sair.Text = "Sair";

                    menu_Ajuda.Text = "Ajuda";
                    menu_Ajuda_Sobre.Text = "Sobre";
                    menu_Ajuda_Sobre_Desenvolvedor.Text = "Desenvolvedor";
                    menu_Ajuda_Sobre_Versao.Text = "Versão";
                    break;
                default:
                    break;
            }
        }

        private void menu_Pesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                label_titulo.Text = menu_Pesquisar.Text;
                menu_Pesquisar.Text = null;
            }
        }
    }
}