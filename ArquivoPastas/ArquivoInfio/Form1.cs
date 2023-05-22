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

namespace ArquivoInfio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            listBox_Dados.Items.Clear();
            FileInfo fileInfo = new FileInfo(@"C:\Users\NSYS-DEV-05\Desktop\Estudos\C# estudo.txt");

            if (fileInfo.Exists)
            {
                listBox_Dados.Items.Add($"Nome completo: {fileInfo.FullName}");
                listBox_Dados.Items.Add($"Nome: {fileInfo.Name}");
                listBox_Dados.Items.Add($"Diretório completo: {fileInfo.DirectoryName}");
                listBox_Dados.Items.Add($"Diretório: {fileInfo.Directory}");
                listBox_Dados.Items.Add($"Extensão: {fileInfo.Extension}");
                listBox_Dados.Items.Add($"Data de criação: {fileInfo.CreationTime}");
                listBox_Dados.Items.Add($"Data de alteração: {fileInfo.LastWriteTime}");
                listBox_Dados.Items.Add($"Tamanho: {fileInfo.Length} bytes");

                Utilitarios.Alertas.MensagemInformacao($"Arquivo lido com sucesso.");
            }
            else
            {
                Utilitarios.Alertas.MensagemInformacao($"O arquivo '{fileInfo.FullName}' não existe.");
            }
        }
    }
}
