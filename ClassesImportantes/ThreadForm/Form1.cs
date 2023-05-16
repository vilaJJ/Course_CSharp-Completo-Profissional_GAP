using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
        private delegate void AtualizarControle(Control controle, string propriedade, object valor);

        Thread t;

        public Form1()
        {
            InitializeComponent();

            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
        }

        private void button_principal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void button_contador_Click(object sender, EventArgs e)
        {
            if (!(t.IsAlive)) t.Start();  
        }

        private void Tarefa()
        {
            DefinirValorPropriedade(label_resultado2, "BackColor", Color.LightCyan);
            while (true)
            {                
                label_resultado.Invoke(new Action(() => label_resultado.Text = DateTime.Now.Second.ToString()));
                DefinirValorPropriedade(label_resultado2, "Text", DateTime.Now.ToString("HH:mm:ss"));
            }
        }

        private void DefinirValorPropriedade(Control controle, string propriedade, object valor)
        {
            if (controle.InvokeRequired)
            {
                AtualizarControle d = new AtualizarControle(DefinirValorPropriedade);
                controle.Invoke(d, new object[] { controle, propriedade, valor });
            }
            else
            {
                Type t = controle.GetType();
                PropertyInfo[] propriedades = t.GetProperties();

                foreach (PropertyInfo item in propriedades)
                {
                    if (item.Name.ToUpper() == propriedade.ToUpper())
                    {
                        item.SetValue(controle, valor, null);
                    }
                }
            }
        }
    }
}