using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_SaveArch_Click(object sender, EventArgs e)
        {
            saveFile.Filter = "Texto|*.txt|PDF|*.pdf|Documento Word|*.docx";

            if (saveFile.ShowDialog() != DialogResult.Cancel)
            {                
                label1.Text = $"Arquivo salvo: {saveFile.FileName}";
                Utilitarios.Alertas.MensagemInformacao("Arquivo salvo com sucesso.");
            }
            else
            {                
                label1.Text = "Arquivo salvo: Nenhum arquivo salvo.";
                Utilitarios.Alertas.MensagemInformacao("Nenhum arquivo salvo.");
            }
        }
    }
}
