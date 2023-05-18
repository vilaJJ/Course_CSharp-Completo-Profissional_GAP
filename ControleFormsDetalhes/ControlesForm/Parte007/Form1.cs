using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("Maria Eduarda");

            comboBox.Items.AddRange(new object[]
            {
                "Yasmin Garcia", "Bárbara Ohana", "Juan Felipe"
            });
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            // MensagemInformacao($"Quantidade de Itens: {comboBox.Items.Count}.");

            /*
            object item = comboBox.SelectedItem;
            int indice = comboBox.SelectedIndex;

            if (indice != -1) MensagemInformacao($"{indice}. {item}.");
            */

            // comboBox.Items.Clear();

            // comboBox.Items.Remove("Juan Felipe");
            // comboBox.Items.RemoveAt(1);

            // comboBox.Items.Insert(1, "Jefferson Ribeiro");

            // MensagemInformacao($"Indíce de 'Maria Eduarda': {comboBox.Items.IndexOf("Maria Eduarda")}");
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

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { MensagemInformacao(comboBox.SelectedItem.ToString()); } catch { }
        }
    }
}