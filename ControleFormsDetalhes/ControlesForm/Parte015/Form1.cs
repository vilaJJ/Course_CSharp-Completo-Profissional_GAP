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

namespace Parte015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            #region Parte 1
            /*            
            Task parte1 = Task.Factory.StartNew(new Action(() =>
            {
                Thread.Sleep(2000);
                progresso.Invoke(new Action(() => { progresso.Value = 25; }));
            }));

            Task parte2 = parte1.ContinueWith(t => 
            {
                Thread.Sleep(4000);
                progresso.Invoke(new Action(() => { progresso.Value = 50; }));
            });

            Task parte3 = parte2.ContinueWith(t =>
            {
                Thread.Sleep(3000);
                progresso.Invoke(new Action(() => { progresso.Value = 75; }));
            });

            Task parte4 = parte3.ContinueWith(t =>
            {
                Thread.Sleep(2500);
                progresso.Invoke(new Action(() => { progresso.Value = 100; }));
            });
            */
            #endregion

            progresso.Value = 0;

            List<Task> tarefas = new List<Task>();                        
           
            tarefas.Add(new Task(new Action(new Action(() =>
            {
                Thread.Sleep(1456);
                progresso.Invoke(new Action(() => progresso.PerformStep()));
            }))));

            tarefas.Add(new Task(new Action(new Action(() =>
            {
                Thread.Sleep(2314);
                progresso.Invoke(new Action(() => progresso.PerformStep()));
            }))));

            tarefas.Add(new Task(new Action(new Action(() =>
            {
                Thread.Sleep(4123);
                progresso.Invoke(new Action(() => progresso.PerformStep()));
            }))));

            progresso.Maximum = tarefas.Count;
            progresso.Step = 1;

            foreach (Task tarefa in tarefas)
            {
                tarefa.Start();
            }
        }
    }
}
