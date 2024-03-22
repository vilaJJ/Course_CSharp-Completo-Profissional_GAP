using System;
using System.Windows.Forms;

namespace HelloWorldApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Button_PressioneAqui_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Hello, World!",
                "Mensagem",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
