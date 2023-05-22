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

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            // File.Exists();
            // File.Delete();
            // File.Create();
            // File.Move();
            // File.Copy();
            // File.WriteAllText();
            // File.ReadAllText();

            string pasta = @"C:\Users\NSYS-DEV-05\Desktop\Estudos";
            string arquivo = @"C# estudo.txt";

            string caminho = Path.Combine(pasta, arquivo);

            /*
            if (File.Exists(caminho))
            {
                Utilitarios.Alertas.MensagemInformacao("O arquivo existe.");
            }
            else
            {
                Utilitarios.Alertas.MensagemInformacao("O arquivo não existe.");
            }
            */

            // File.Delete(caminho);

            /*
            if (File.Exists(caminho))
            {
                Utilitarios.Alertas.MensagemInformacao("O arquivo já existe no caminho especificado.");
            }
            else
            {
                File.Create(caminho).Close();
                Utilitarios.Alertas.MensagemInformacao("O arquivo foi criado.");                
            }
            */

            /*
            try
            {
                File.Copy(caminho, Path.Combine(pasta, "arquivo_copiado.txt"), true);
                Utilitarios.Alertas.MensagemInformacao("O arquivo foi copiado.");
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
            */

            /*
            try
            {
                File.Move(caminho, Path.Combine(Path.Combine(pasta, "Destino"), "Movido.txt"));
                Utilitarios.Alertas.MensagemInformacao("O arquivo foi movido.");
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
            */

            /*
            try
            {
                File.WriteAllText(caminho, "Teste de escrita de arquivo.", Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
            */
            try
            {                
                label_Resultado.Text = File.ReadAllText(caminho, Encoding.UTF8);
                File.SetCreationTime(caminho, DateTime.Now);
                Utilitarios.Alertas.MensagemInformacao($"O arquivo foi criado em: {File.GetCreationTime(caminho).ToString("dd/MM/yyyy HH:mm:ss")}");
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }

            // label_Resultado.Text = caminho;
        }
    }
}
