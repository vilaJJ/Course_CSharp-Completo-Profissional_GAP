using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_SelecArch_Click(object sender, EventArgs e)
        {
            openFile.Filter = "JPG|*.jpg|PNG|*.png|JPG e PNG|*.jpg;*png|Todos os arquivos|*.*";
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                label1.Text = $"Caminho do arquivo: {openFile.FileName}";

                foreach (string item in openFile.FileNames)
                {
                    lista_Arquivos.Items.Add(item);
                }

                Utilitarios.Alertas.MensagemInformacao("Arquivo selecionado com sucesso.");
            }
            else
            {
                label1.Text = "Caminho do arquivo: não selecionado.";
                Utilitarios.Alertas.MensagemInformacao("Nenhum arquivo selecionado.");
            }
        }
    }
}
