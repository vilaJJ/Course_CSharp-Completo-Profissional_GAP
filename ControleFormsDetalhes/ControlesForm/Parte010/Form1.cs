using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Inserindo uma linha
            /*
            ListViewItem item1 = new ListViewItem("1");
            item1.SubItems.Add("Juan Felipe Alves Flores");
            item1.SubItems.Add("juan.alves@nortesys.com.br");
            item1.SubItems.Add("(63) 99117-5470");
            */
            ListViewItem item1 = new ListViewItem(new string[]
            {
                "1",
                "Juan Felipe Alves Flores",
                "juan.alves@nortesys.com.br",
                "(63) 99117-5470"
            });
            

            // Inserindo uma linha
            ListViewItem item2 = new ListViewItem(new string[]
            {
                "2",
                "Hugo Christian",
                "hugo@nortesys.com.br",
                "(63) 99305-2220"
            });

            // Inserindo uma linha
            ListViewItem item3 = new ListViewItem(new string[]
            {
                "3",
                "Maikon Wingler",
                "maikon.wingler@nortesys.com.br",
                "(63) 99284-6721"
            });

            lista.Items.Add(item1);
            lista.Items.AddRange(new ListViewItem[] { item2, item3 });
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            // LimparLista();
            // try { ApagarItem(lista.SelectedItems[0]); } catch { }
            try { ApagarItemPeloIndice(lista.SelectedIndices[0]); } catch { }
        }

        private void LimparLista()
        {
            if(lista.Items.Count != 0)
            {
                lista.Items.Clear();
                Utilitarios.Alertas.MensagemInformacao("Os dados da lista foram limpados.");
            }            
        }
        private void ApagarItem(ListViewItem item)
        {
            try { lista.Items.Remove(item); } catch { return; }
            Utilitarios.Alertas.MensagemInformacao("Item removido.");
        }
        private void ApagarItemPeloIndice(int indice)
        {
            try { lista.Items.RemoveAt(indice); } catch { return; }
            Utilitarios.Alertas.MensagemInformacao("Item removido.");
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Utilitarios.Alertas.MensagemInformacao($"Usuário n.{lista.SelectedItems[0].Text} foi selecionado.");
        }
    }
}
