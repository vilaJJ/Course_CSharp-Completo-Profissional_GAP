using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            comboBox_estadoCivil.Items.Add("Casado(a)");
            comboBox_estadoCivil.Items.Add("Solteiro(a)");
            comboBox_estadoCivil.Items.Add("Víuvo(a)");
            comboBox_estadoCivil.Items.Add("Divorciado(a)");

            comboBox_estadoCivil.SelectedIndex = 0; // Selecionar item selecionado por padrão
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_sexo_masc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            int id = -1;

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == txtBox_nome.Text)
                {
                    id = pessoas.IndexOf(pessoa);
                }
            }

            if(txtBox_nome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome!");
                txtBox_nome.Focus();
                return;
            }
            if (maskedTextBox_telefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo Telefone!");
                maskedTextBox_telefone.Focus();
                return;
            }

            char sexo;

            if (radioButton_sexo_masc.Checked)
            {
                sexo = 'M';
            }
            else if (radioButton_sexo_fem.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa p = new Pessoa();
            p.Nome = txtBox_nome.Text;
            p.DataNascimento = dateTimePicker_dataNasc.Text;
            p.EstadoCivil = comboBox_estadoCivil.SelectedItem.ToString();
            p.Telefone = maskedTextBox_telefone.Text;
            p.CasaPropria = checkBox_casaPropria.Checked;
            p.Veiculo = checkBox_veiculoProprio.Checked;
            p.Sexo = sexo;

            if(id < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[id] = p;
            }

            button_limpar_Click(button_limpar, EventArgs.Empty);

            Listar();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            int id = listBox_resultados.SelectedIndex;

            if(id == -1)
            {
                MessageBox.Show("Escolha uma Pessoa para ser excluída!");
            }
            else
            {
                MessageBox.Show(pessoas[id].Nome + " foi excluído!");
                pessoas.RemoveAt(id);
                Listar();
            }
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            txtBox_nome.Text = "";
            dateTimePicker_dataNasc.Text = "";
            comboBox_estadoCivil.SelectedIndex = 0;
            maskedTextBox_telefone.Text = "";
            checkBox_casaPropria.Checked = false;
            checkBox_veiculoProprio.Checked = false;
            radioButton_sexo_masc.Checked = true;
            radioButton_sexo_fem.Checked = false;
            radioButton_sexo_outro.Checked = false;

            txtBox_nome.Focus();
        }

        private void Listar()
        {
            listBox_resultados.Items.Clear();

            foreach (Pessoa p in pessoas)
            {
                listBox_resultados.Items.Add(p.Nome);
            }
        }

        private void listBox_resultados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = listBox_resultados.SelectedIndex;
            Pessoa p = pessoas[id];

            txtBox_nome.Text = p.Nome;
            dateTimePicker_dataNasc.Text = p.DataNascimento;
            comboBox_estadoCivil.SelectedItem = p.EstadoCivil;
            maskedTextBox_telefone.Text = p.Telefone;
            checkBox_casaPropria.Checked = p.CasaPropria;
            checkBox_veiculoProprio.Checked = p.Veiculo;

            switch (p.Sexo)
            {
                case 'M':
                    radioButton_sexo_masc.Checked = true;
                    break;
                case 'F':
                    radioButton_sexo_fem.Checked = true;
                    break;
                default:
                    radioButton_sexo_outro.Checked = true;
                    break;
            }
        }
    }
}