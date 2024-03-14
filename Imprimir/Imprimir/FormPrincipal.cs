using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Imprimir
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Button_Imprimir_Click(object sender, EventArgs e)
        {
            PrintDocument_Impressao.Print();
        }

        private void PrintDocument_Impressao_PrintPage(object sender, PrintPageEventArgs e)
        {
            #region Parte 1

            var dados = "Trabalhando com impressão em C# (CS | CSharp).";
            var fonte = new Font("Arial", 16, FontStyle.Regular, GraphicsUnit.Point);
            var pincel = new SolidBrush(Color.Black);
            var pontoInicial = new Point(100, 50);

            // Desenhar o documento para ser impresso
            e.Graphics.DrawString(
                dados,
                fonte,
                pincel,
                pontoInicial
                );

            e.Graphics.DrawString(
                "Juan Felipe Alves Flores",
                new Font("Arial", 12, FontStyle.Italic, GraphicsUnit.Point),
                Brushes.Red,
                new Point(100, 200)
                );

            e.Graphics.FillRectangle(
                Brushes.Purple,
                new Rectangle(100, 300, 100, 150) 
                );

            #endregion
        }
    }
}
