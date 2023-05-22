using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LerEscrever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_WriteTxt_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\NSYS-DEV-05\Desktop\File.txt";
            StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8);

            try
            {
                // writer.WriteLine(textBox_Conteudo.Text);

                writer.Write(textBox_Conteudo.Text);

                Utilitarios.Dispose.StreamWriter(writer);

                Utilitarios.Alertas.MensagemInformacao("Arquivo escrito.");
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }            
        }
    }
}
