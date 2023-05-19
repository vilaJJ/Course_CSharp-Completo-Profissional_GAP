using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SemProcessoRodando_Text();
        }

        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            if (bgWorker.IsBusy)
            {
                Utilitarios.Alertas.MensagemInformacao("O processo já foi iniciado.");
            }
            else
            {
                button_Iniciar.Enabled = false;
                button_Cancelar.Enabled = true;
                bgWorker.RunWorkerAsync();
            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            if (bgWorker.WorkerSupportsCancellation)
            {
                
                if (bgWorker.IsBusy)
                {
                    bgWorker.CancelAsync();
                }
                else
                {
                    Utilitarios.Alertas.MensagemInformacao("Não há processos rodando.");
                }
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(500);
                    bgWorker.ReportProgress(i * 10);
                }
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label_Progresso.Text = $"Progresso: {e.ProgressPercentage}%";
            progressBar.Value = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Utilitarios.Alertas.MensagemInformacao("O processo foi cancelado.");
            }
            else if (e.Error != null)
            {
                Utilitarios.Alertas.MensagemInformacao($"Ocorreu um erro no processo.\nMotivo: {e.Error.Message}");
            }
            else
            {
                Utilitarios.Alertas.MensagemInformacao("Processo concluído com sucesso.");
            }

            SemProcessoRodando_Text();
        }

        private void SemProcessoRodando_Text()
        {
            label_Progresso.Text = "Sem processos rodando.";
            progressBar.Value = 0;
            button_Iniciar.Enabled = true;
            button_Cancelar.Enabled = false;
        }        
    }
}