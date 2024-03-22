using DataHoraAtual.Services;
using System;
using System.Windows.Forms;

namespace ConsumirDLL
{
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Button_ExibirDataHoraAtual_Click(object sender, EventArgs e)
        {
            using (var service = new DataHoraAtualService())
            {
                var dataHoraAtual = service.ObterDataHoraAtual();

                MessageBox.Show(
                    dataHoraAtual,
                    "Data e Hora Atual",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }
    }
}
