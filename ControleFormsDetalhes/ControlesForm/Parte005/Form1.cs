using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_Opcao1_CheckedChanged(object sender, EventArgs e)
        {
            ExibirNomeValorCheckBox(checkBox_Opcao1.Text, checkBox_Opcao1.Checked);
        }

        private void checkBox_Opcao2_CheckedChanged(object sender, EventArgs e)
        {
            ExibirNomeValorCheckBox(checkBox_Opcao2.Text, checkBox_Opcao2.Checked);
        }

        private void checkBox_Opcao3_CheckedChanged(object sender, EventArgs e)
        {
            ExibirNomeValorCheckBox(checkBox_Opcao3.Text, checkBox_Opcao3.Checked);
        }

        private void ExibirNomeValorCheckBox(string nome, bool valor)
        {
            MessageBox.Show(
                $"{nome} = {(valor ? "Verdadeiro" : "Falso")}", 
                "Informação do CheckBox", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button_Checados_Click(object sender, EventArgs e)
        {
            bool[] checados = 
            { 
                checkBox_Opcao1.Checked,
                checkBox_Opcao2.Checked,
                checkBox_Opcao3.Checked
            };

            ExibirChecados(checados);
        }

        private void ExibirChecados(bool[] checados)
        {
            string mensagem = "";

            int index = 1;
            foreach (bool item in checados)
            {
                mensagem += $"Opção {index} = {(item ? "Verdadeiro" : "Falso")}{(index != 3 ? "\n" : null)}";
                index++;
            }

            MessageBox.Show(
                mensagem,
                "Informação dos CheckBox's",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
