using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressoesLambda.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0039:Use local function", Justification = "Aprendizado!")]
        private void Button_Executar_Click(object sender, EventArgs e)
        {
            #region Sem bloco

            Func<int, int> quadrado = value => value * value;

            ApresentarMensagem(
                string.Format(
                    "O resultado é: {0}",
                    quadrado(12)
                    )
                );

            #endregion

            #region Expressões

            Expression<Func<int, int>> somar = value => value + value;

            ApresentarMensagem(
                string.Format(
                    "A expressão de soma é: {0}",
                    somar.ToString()
                    )
                );

            #endregion

            #region LINQ com Lambda

            var numeros = new List<int> { 3, 23, 6, 2023, 17 };
            var numerosAoQuadrado = numeros.Select(num => num * num);
            var numerosApresentar = string.Join("\n> ", numerosAoQuadrado);

            ApresentarMensagem(
                string.Format(
                    "Números ao quadrado: \n\n> {0}",
                    numerosApresentar
                    )
                );

            #endregion

            #region Com bloco

            Action<string> apresentar = nome =>
            {
                var apresentacao = string.Format("Olá, {0}.", nome);
                ApresentarMensagem(apresentacao);
            };

            apresentar("Bárbara Ohana");

            #endregion

            #region Sem parâmetro de entrada.

            Action acaoSemEntrada = () => ApresentarMensagem("Wish you were here");
            acaoSemEntrada();

            #endregion

            #region Diversos parâmetros de entrada

            Func<string, string, string> juntarNomes = (nome, sobrenome) => string.Format("{0} {1}", nome, sobrenome);
            var nomeJunto = juntarNomes("Bárbara Ohana", "Santos Silva Flores");
            ApresentarMensagem(nomeJunto);

            #endregion
        }

        private void ApresentarMensagem(string mensagem)
        {
            MessageBox.Show(
                mensagem,
                "Execução da expressão Lambda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
