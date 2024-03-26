using CriptografiaMD5.Classes;
using System;
using System.Windows.Forms;

namespace CriptografiaMD5.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextBox_Saida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.C))
            {
                return;
            }

            e.SuppressKeyPress = true;
        }

        private void Button_Criptografar_Click(object sender, EventArgs e)
        {
            string saida;

            using (var criptografarMD5 = new CriptografarMD5())
            {
                saida = criptografarMD5.Criptografar(Entrada);                
            }

            DefinirSaida(saida);
        }

        private void Button_Comparar_Click(object sender, EventArgs e)
        {
            DefinirSaida();

            var senha = "4CBE7168720199598C409C4DD7905DBF"; // BabiJuan
            bool saoIguais;

            using (var criptografarMD5 = new CriptografarMD5())
            {
                saoIguais = criptografarMD5.Comparar(Entrada, senha);                
            }

            ApresentarResultadoLogin(saoIguais);
        }

        private string Entrada => TextBox_Entrada.Text;

        private void DefinirSaida(string value = "")
        {
            TextBox_Saida.Text = value;
        }

        private void ApresentarResultadoLogin(bool value)
        {
            var mensagem = value ? "Autenticado com sucesso." : "Senha inválida!";
            var titulo = "Autenticação";
            var botoes = MessageBoxButtons.OK;
            var icone = value ? MessageBoxIcon.Information : MessageBoxIcon.Error;

            MessageBox.Show(mensagem, titulo, botoes, icone);
        }
    }
}
