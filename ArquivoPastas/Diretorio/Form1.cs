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

namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Directory.Exists();
        // Directory.CreateDirectory();
        // Directory.Delete();
        // Directory.Move();
        // Directory.GetDirectories();
        // Directory.GetFiles();
        // Directory.GetDirectoryRoot();
        // Directory.GetLogicalDrives();
        // Directory.GetParent();
        // Directory.GetCurrentDirectory();
        private void button_Executar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            string path = @"C:\Users\NSYS-DEV-05\Desktop\Estudos\CSharp-Projetos";

            bool res = Directory.Exists(path);

            // Utilitarios.Alertas.MensagemInformacao($"A pasta {(res ? null : "não ")}existe.");

            /*
            if (!res)
            {
                Directory.CreateDirectory(path);
            }
            */

            /*
            if (res)
            {
                Directory.Delete(path);
            }
            */
            /*
            if (res)
            {
                Directory.Move(path, @"C:\Users\NSYS-DEV-05\Desktop\EstudoMovido");
            }
            */

            // lista.Items.AddRange(Directory.GetDirectories(path));
            // lista.Items.AddRange(Directory.GetFiles(path));
            // lista.Items.Add(Directory.GetDirectoryRoot(path));
            // lista.Items.AddRange(Directory.GetLogicalDrives());

            /*
            DirectoryInfo infoPath = Directory.GetParent(path);

            if (infoPath.Exists)
            {
                lista.Items.Add($"Nome: {infoPath.Name}");
                lista.Items.Add($"Nome completo: {infoPath.FullName}");
                lista.Items.Add($"Parente: {infoPath.Parent}");
                lista.Items.Add($"Raiz: {infoPath.Root}");
                lista.Items.Add($"Data de criação: {infoPath.CreationTime}");
            }
            else
            {
                Utilitarios.Alertas.MensagemInformacao("Não existe.");
            }
            */

            string execPath = Directory.GetCurrentDirectory();
            Utilitarios.Alertas.MensagemInformacao($"Programa sendo executado em: '{execPath}'.");
        }
    }
}
