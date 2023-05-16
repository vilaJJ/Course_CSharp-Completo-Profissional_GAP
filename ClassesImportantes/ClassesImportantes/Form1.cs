using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class ClassesImportantes : Form
    {
        public ClassesImportantes()
        {
            InitializeComponent();
        }

        private void button_MessageBox_Click(object sender, EventArgs e)
        {
            // Existem diversas assinaturas

            // MessageBox.Show("Olá, mundo!"); // Apenas exibe uma mensagem
            // MessageBox.Show("Corpo da Mensagem", "Título da janela"); // Exibe a mensagem e o título da janela

            // Retorna o valor do botão pressionado na janela
            /*
            DialogResult res = MessageBox.Show("Corpo da Mensagem", "Título da janela", MessageBoxButtons.YesNoCancel); // Exibe a mensagem, o título da janela e um conjunto de botões personalizado

            label_resultado.Text = "Clicou em ";
            if(res == DialogResult.Yes)
            {
                label_resultado.Text += "Sim.";
            }
            else if(res == DialogResult.No)
            {
                label_resultado.Text += "Não.";
            }
            else
            {
                label_resultado.Text += "Cancelar.";
            }
            */

            // Adiciona um ícone na janela (inclusive efeitos sonoros, dependendo o tipo (por exemplo: beep de erro)).
            /*
            MessageBox.Show(
                "Corpo da Mensagem", 
                "Título da janela", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning
            );
            */

            // Marca um botão especifico.
            MessageBox.Show(
                "Corpo da Mensagem", 
                "Título da janela", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Error, 
                MessageBoxDefaultButton.Button2
            );
        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            // Random r = new Random();
            Random r = new Random(DateTime.Now.Millisecond); // Gera números aleatórios a partir de uma SEED

            r.Next();
            r.Next(150);
            r.Next(0, 100);

            int valor = r.Next(20, 200);
            double valor2 = r.NextDouble() * 100; // Gera valores entre 0 e 1

            label_resultado.Text = $"Número aleatorio: {valor2}";
        }

        private void button_TimeSpan_Click(object sender, EventArgs e)
        {
            // Formata tempo (horário e dia)
            /*
            label_resultado.Text = TimeSpan.FromMilliseconds(5000).ToString();
            label_resultado.Text = TimeSpan.FromSeconds(5000).ToString();            
            label_resultado.Text = TimeSpan.FromMinutes(5000).ToString();
            label_resultado.Text = TimeSpan.FromHours(5000).ToString();
            label_resultado.Text = TimeSpan.FromDays(5000).ToString();
            */

            // label_resultado.Text = TimeSpan.TicksPerMinute.ToString();

            // Calcular diferença de tempo
            TimeSpan inicio = new TimeSpan(8, 24, 41);
            TimeSpan fim = new TimeSpan(18, 16, 59);

            // TimeSpan intervalo = fim - inicio;
            // TimeSpan soma = inicio.Add(fim);
            TimeSpan intervalo = fim.Subtract(inicio);

            // label_resultado.Text = intervalo.TotalHours.ToString(); // Retorna a hora total
            label_resultado.Text = $"Você trabalhou por {intervalo.Hours} horas, {intervalo.Minutes} minutos e {intervalo.Seconds} segundos.";
        }

        private void button_DateTime_Click(object sender, EventArgs e)
        {
            // label_resultado.Text = DateTime.Now.ToString();                      // Data e Hora
            // label_resultado.Text = DateTime.Today.ToString();                    // Apenas a Data
            // label_resultado.Text = DateTime.DaysInMonth(2023, 5).ToString();     // Quantidade de dias de um mês de um determinado ano
            // label_resultado.Text = DateTime.IsLeapYear(2023).ToString();         // Verifica se determinado ano é bissexto
            // label_resultado.Text = DateTime.Now.ToLongDateString();              // Formato em extenso da data
            // label_resultado.Text = DateTime.Now.ToShortDateString();             // Formato curto para data
            // label_resultado.Text = DateTime.Now.ToLongTimeString();              // Formato longo para horário (com segundos)
            // label_resultado.Text = DateTime.Now.ToShortTimeString();             // Formato curto para horario (sem segundos)
            // label_resultado.Text = DateTime.Now.ToUniversalTime().ToString();    // Formato universal para data e horário
            // label_resultado.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // Personalizar formato do DateTime

            DateTime data = new DateTime(2004, 05, 23, 17, 40, 52); // Data: 23/05/2004 | Horário: 17:40:52

            // Operações com TimeSpan
            // data.Add(new TimeSpan(3, 5, 12));                                    // Adiciona uma data
            // data.Subtract(new TimeSpan(3, 5, 12));                               // Subtrai uma data

            // Adiciona anos (existem outros métodos que adicionam outras escalas de tempo
            // data.AddYears(24);

            label_resultado.Text = $"{data.ToString($"dd/MM/yyyy\nHH:mm:ss")}\n{data.DayOfYear}\n{data.DayOfWeek}";
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            Color vermelho = Color.Red;
            Color verde = Color.Green;
            Color azul = Color.Blue;
            Color ciano = Color.Cyan;

            Color corARGB1 = Color.FromArgb(135, ciano);
            Color corARGB2 = Color.FromArgb(255, 100, 50, 135); // Com controle de transparência (primeiro parâmetro)
            Color corARGB3 = Color.FromArgb(100, 50, 135);      // Sem controle de transparência

            Color cor1 = Color.FromKnownColor(KnownColor.Aquamarine);
            Color cor2 = Color.FromName("Aquamarine");            

            label_resultado.BackColor = cor2;
            label_resultado.ForeColor = corARGB3;

            Color cor3 = label_resultado.BackColor;
            button_Color.BackColor = cor3;
        }

        private void button_Font_Click(object sender, EventArgs e)
        {
            Font fonte1 = new Font(
                "Helvetica, Arial", 
                32, 
                FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, 
                GraphicsUnit.Pixel
            );

            Font fonte2 = new Font(
                FontFamily.GenericSerif,
                36,
                FontStyle.Underline,
                GraphicsUnit.Pixel
            );

            label_resultado.Text = "Alterando propriedade da fonte";
            label_resultado.Font = fonte1;
        }

        private void button_Environment_Click(object sender, EventArgs e)
        {
            string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Environment.CurrentDirectory = "C:\\";
            string dirAtual = Environment.CurrentDirectory;

            //label_resultado.Text = dirAtual + Environment.NewLine + myDocuments;

            /*
            string envPath = Environment.GetEnvironmentVariable("PATH");
            label_resultado.Text = envPath;
            */

            /*
            string[] discosLocais = Environment.GetLogicalDrives();
            label_resultado.Text = null;
            foreach (string item in discosLocais)
            {
                label_resultado.Text += $"\n{item}";
            }
            */

            string usuario = Environment.UserName;
            string dominio = Environment.UserDomainName;
            int nCPU = Environment.ProcessorCount;

            label_resultado.Text = $"Usuário atual: {usuario}\nDomínio: {dominio}\nNúmero de Processadores: {nCPU}";
        }

        private void button_Application_Click(object sender, EventArgs e)
        {
            // Application.Exit(); // Finaliza os processos, e fecha o programa.

            /*
            string pathExe = Application.ExecutablePath;
            string pastaExe = Application.StartupPath;

            label_resultado.Text = pastaExe;
            */

            Application.Restart(); // Reinicia o programa
        }
    }
}