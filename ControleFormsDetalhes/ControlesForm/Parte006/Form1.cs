using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkedListBox_Opcoes.Items.Add("Maria Eduarda", true);
            checkedListBox_Opcoes.Items.Add("Yasmin Garcia", false);
            checkedListBox_Opcoes.Items.Add("Bárbara Ohana", true);
            checkedListBox_Opcoes.Items.Add("Juan Felipe", false);

            // MensagemInformacao($"{checkedListBox_Opcoes.Items.Count} itens adicionado.");
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            // checkedListBox_Opcoes.Items.Clear();

            /*
            checkedListBox_Opcoes.Items.AddRange(new object[]
            {
                "João Arthur", "João Lucas"
            });
            */

            // MessageBox.Show($"{(checkedListBox_Opcoes.Items.Contains("Bárbara Ohana") ? "Contém" : "Não Contém")}");

            // checkedListBox_Opcoes.Items.Remove("Juan Felipe");
            // checkedListBox_Opcoes.Items.RemoveAt(2);

            //checkedListBox_Opcoes.Items.Insert(2, "Jefferson Ribeiro");

            /*
            string itensMarcados = "";
            var itens = checkedListBox_Opcoes.CheckedItems;
            foreach (var item in itens)
            {
                itensMarcados += $"\n{item}";
            }
            MensagemInformacao($"Itens checados:\n{itensMarcados}");
            */

            var itemSelecionado = checkedListBox_Opcoes.SelectedItem;           
            MensagemInformacao($"Itens selecionado: {(itemSelecionado == null ? "Nenhum" : itemSelecionado)}.");
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

        private void checkedListBox_Opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label.Text = checkedListBox_Opcoes.SelectedItem.ToString();
            }
            catch 
            {
                label.Text = "Selecione um item válido.";
            }
        }
    }
}
