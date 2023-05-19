using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            string nomeCurso;
            bool cursoDefinido = true;

            if (curso_TADS.Checked)
            {
                nomeCurso = curso_TADS.Text;
            }
            else if (curso_GPI.Checked)
            {
                nomeCurso = curso_GPI.Text;
            }
            else if (curso_Biotec.Checked)
            {
                nomeCurso = curso_Biotec.Text;
            }
            else if (curso_Info.Checked)
            {
                nomeCurso = curso_Info.Text;
            }
            else
            {
                cursoDefinido = false;
                nomeCurso = "Não foi possível definir o seu curso.";
            }

            Utilitarios.Alertas.MensagemInformacao(cursoDefinido ? $"Seu curso é: {nomeCurso}." : nomeCurso);
        }

        private void curso_TADS_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged();
        }

        private void curso_GPI_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged();
        }

        private void curso_Biotec_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged();
        }

        private void curso_Info_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged();
        }

        private void CheckedChanged()
        {
            if (curso_TADS.Checked)
            {
                Text = curso_TADS.Text;
            }
            else if (curso_GPI.Checked)
            {
                Text = curso_GPI.Text;
            }
            else if (curso_Biotec.Checked)
            {
                Text = curso_Biotec.Text;
            }
            else if (curso_Info.Checked)
            {
                Text = curso_Info.Text;
            }
            else
            {
                Text = "Cursos do IFTO";
            }
        }
    }
}
