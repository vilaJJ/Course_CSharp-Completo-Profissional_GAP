using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Adicionar_Click()
        {
            button_Adicionar_Click(null, null);
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            string nome = textBox_Nome.Text.Trim();
            if (nome != "")
            {
                lista.Items.Add(nome);
                Atualizar_QntdItems();
                Mensagem_Informacao("Item Adicionado.");
                textBox_Nome.Text = null;
            }
        }

        private void textBox_Nome_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return) { button_Adicionar_Click(); }
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            if (lista.Items.Count != 0)
            {
                lista.Items.Clear();
                Atualizar_QntdItems();
                Mensagem_Informacao("Limpeza na lista realizada.");
            }
        }

        private void button_RemoverItem_Click(object sender, EventArgs e)
        {
            object item = lista.SelectedItem;
            Atualizar_QntdItems();
            lista.Items.Remove(item);
            Mensagem_Informacao($"Item '{item}' Removido.");
        }

        private void button_RemoverIndice_Click(object sender, EventArgs e)
        {
            int index = lista.SelectedIndex;
            Atualizar_QntdItems();
            lista.Items.RemoveAt(index);
            Mensagem_Informacao($"Item no índice '{index}' Removido.");
        }

        private void Mensagem_Informacao(string mensagem)
        {
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome;
            try
            {
                nome = lista.SelectedItem.ToString();
                textBox_Nome.Text = nome;
                return;
            }
            catch
            {
                textBox_Nome.Text = null;
                return;
            }
                       
            
        }

        private void Atualizar_QntdItems()
        {
            label_QntdItems.Text = $"Quantidade de Itens: {lista.Items.Count}";
        }
    }
}
