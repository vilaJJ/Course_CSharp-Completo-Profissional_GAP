using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MensagemInformacao(string mensagem)
        {
            MessageBox.Show(
                mensagem,
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            MensagemInformacao($"Dia Selecionado: {dateTimePicker.Value.ToString("dd/MM/yyyy")}.");
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            DateTime atual = DateTime.Now;
            dateTimePicker.Value = atual;
        }
    }
}
