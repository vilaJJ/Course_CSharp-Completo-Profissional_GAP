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

namespace DirInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            string separador = "----------------------------------------------------------------------------------------------------";

            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\NSYS-DEV-05\Desktop\Estudos\CSharp-Projetos");

            if (dirInfo.Exists)
            {
                lista.Items.Add($"Endereço completo: {dirInfo.FullName}");
                lista.Items.Add($"Nome: {dirInfo.Name}");
                lista.Items.Add($"Parente: {dirInfo.Parent}");
                lista.Items.Add($"Raiz: {dirInfo.Root}");
                lista.Items.Add($"Data de criação: {dirInfo.CreationTime}");

                DirectoryInfo[] dirInfos = dirInfo.GetDirectories();

                lista.Items.AddRange(new string[] { separador, "Pastas no diretório:" });
                foreach (DirectoryInfo item in dirInfos)
                {
                    lista.Items.Add(item.Name);
                }

                FileInfo[] fileInfos = dirInfo.GetFiles();
                lista.Items.AddRange(new string[] { separador, "Arquivos no diretório:" });
                foreach (FileInfo item in fileInfos)
                {
                    lista.Items.Add(item.Name);
                }
            }
            else
            {
                Utilitarios.Alertas.MensagemInformacao("O diretório especificado não existe.");
            }            
        }
    }
}
