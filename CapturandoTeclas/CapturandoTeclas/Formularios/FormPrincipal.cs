using System;
using System.Windows.Forms;

namespace CapturandoTeclas.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Button_TeclaX_Click(object sender, EventArgs e)
        {
            ExibirNoLabel("Tecla 'X' pressionada.");
        }

        private void Button_TeclaEnter_Click(object sender, EventArgs e)
        {
            ExibirNoLabel("Tecla 'Enter' pressionada.");
        }

        private void FormPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar is (char)49)
            {
                ExibirNoLabel("Tecla '1' pressionada.");
            }
        }

        private void Button_TeclaX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar is (char)8)
            {
                Button_TeclaX.PerformClick();
                Label_Resultado.Text += "\nCom KeyPress";
            }            
        }

        private void ExibirNoLabel(string mensagem)
        {
            Label_Resultado.Text = mensagem;
        }
    }
}
