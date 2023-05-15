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
    }
}
