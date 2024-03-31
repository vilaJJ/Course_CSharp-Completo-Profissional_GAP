using ProgramacaoAssincrona.Classes;
using System;
using System.Windows.Forms;

namespace ProgramacaoAssincrona.Formularios
{
    internal partial class FormPrincipal : Form
    {
        private static ListBox Resultado;

        internal FormPrincipal()
        {
            InitializeComponent();

            Resultado = ListBox_Resultado;
        }

        internal static void InserirResultado(string mensagem)
        {
            Resultado.Items.Add(mensagem);

            Resultado.SelectedIndex = Resultado.Items.Count - 1;
        }

        private void Button_Executar_Click(object sender, EventArgs e)
        {
            InserirResultado("Evento do botão 'Executar' foi iniciado.");

            using (var exemplo = new Exemplo())
            {
                exemplo.TaskLongaDuracao();
            }

            InserirResultado("Evento do botão 'Executar' foi finalizado.");
        }

        private async void Button_ExecutarAssincrono_Click(object sender, EventArgs e)
        {
            InserirResultado("Evento do botão 'Executar Assíncrono' foi iniciado.");

            using (var exemploAssincrono = new ExemploAssincrono())
            {
                await exemploAssincrono.TaskLongaDuracao();
            }

            InserirResultado("Evento do botão 'Executar Assíncrono' foi finalizado.");
        }

        private void Button_Limpar_Click(object sender, EventArgs e)
        {
            ListBox_Resultado.Items.Clear();
        }
    }
}
