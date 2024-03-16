using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Imprimir
{
    public partial class FormPrincipal : Form
    {
        private int pontoX, pontoY, largura, altura, numLinhas, paginaAtual, totalPaginas;

        public FormPrincipal()
        {
            InitializeComponent();

            paginaAtual =
            totalPaginas = 
            0;
        }

        private void Button_VisualizarPadrao_Click(object sender, EventArgs e)
        {
            DefinirTamanho();
            PrintPreviewDialog_Impressao.Document = PrintDocument_Impressao;
            PrintPreviewDialog_Impressao.ShowDialog();
        }

        private void Button_Imprimir_Click(object sender, EventArgs e)
        {
            DefinirTamanho();

            PrintDialog_ConfiguracaoImpressao.Document = PrintDocument_Impressao;

            if (PrintDialog_ConfiguracaoImpressao.ShowDialog() == DialogResult.OK)
            {
                DefinirTamanho();

                PrintDocument_Impressao.PrinterSettings = PrintDialog_ConfiguracaoImpressao.PrinterSettings;
                PrintDocument_Impressao.Print();
            }            
        }

        private void PrintDocument_Impressao_PrintPage(object sender, PrintPageEventArgs e)
        {
            #region Parte 1
            /*
             
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

            */
            #endregion

            #region Parte 2
            /*
            var areaImpressao = PrintDocument_Impressao.DefaultPageSettings.Bounds;

            var pontoX = areaImpressao.X;
            var pontoY = areaImpressao.Y;
            var largura = areaImpressao.Width;
            var altura = areaImpressao.Height;

            var textoPagina = "Título da Página";
            var letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            var pincelTitulo = new SolidBrush(Color.Purple);
            var canetaTitulo = new Pen(Color.Blue, 2);
            var areaTextoTitulo = new Rectangle(pontoX + 50, pontoY + 100, largura - 100, 100);
            var formatoTitulo = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            e.Graphics.DrawString(textoPagina, letraTitulo, pincelTitulo, areaTextoTitulo, formatoTitulo);
            e.Graphics.DrawRectangle(canetaTitulo, areaTextoTitulo);

            var texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit,";
            var letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            var pincel = new SolidBrush(Color.Black);
            // var caneta = new Pen(Color.Red, 2);
            var areaTexto = new Rectangle(pontoX + 50, pontoY + 200, largura - 100, altura - 400);

            e.Graphics.DrawString(texto, letra, pincel, areaTexto);
            // e.Graphics.DrawRectangle(caneta, areaTexto);
            */
            #endregion

            #region Parte 3

            var listaTexto = new List<string>
            {
                "01. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "02. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "03. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "04. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "05. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "06. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "07. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "08. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "09. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "10. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "11. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "12. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "13. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "14. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "15. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "16. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "17. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "18. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "19. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "20. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "21. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "22. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "23. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "24. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "25. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "26. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "27. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "28. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "29. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "30. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "31. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "32. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "33. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "34. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "35. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "36. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "37. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "38. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "39. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "40. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "41. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "42. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "43. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "44. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "45. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "46. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "47. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "48. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "49. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "50. Lorem ipsum dolor sit amet, consectetur adipiscing elit."
            };

            var tituloPagina = "Título da Página";
            var letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            var pincelTitulo = new SolidBrush(Color.Purple);
            var areaTextoTitulo = new Rectangle(pontoX, pontoY, largura - 100, 100);
            var formatoTitulo = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            var pincel = new SolidBrush(Color.Black);

            while (numLinhas < listaTexto.Count)
            {
                if (numLinhas is 0)
                {
                    e.Graphics.DrawString(tituloPagina, letraTitulo, pincelTitulo, areaTextoTitulo, formatoTitulo);
                    pontoY += 150;
                }

                var areaTexto = new Point(pontoX, pontoY);

                e.Graphics.DrawString(listaTexto[numLinhas], letra, pincel, areaTexto);
                pontoY += 30;
                numLinhas++;

                if (pontoY >= altura - 50)
                {
                    // Mudar de página
                    pontoY = 50;
                    e.HasMorePages = true;
                    totalPaginas++;
                    break;
                }
            }

            #endregion
        }

        private void Button_Anterior_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 0)
            {
                PrintPreviewControl_Documento.StartPage = --paginaAtual;
            }
        }

        private void Button_Proximo_Click(object sender, EventArgs e)
        {
            if (paginaAtual < totalPaginas)
            {
                PrintPreviewControl_Documento.StartPage = ++paginaAtual;
            }
        }

        private void Button_Visualizar_Click(object sender, EventArgs e)
        {
            DefinirTamanho();
            PrintPreviewControl_Documento.Document = PrintDocument_Impressao;
        }

        private void DefinirTamanho()
        {
            var areaImpressao = PrintDocument_Impressao.DefaultPageSettings.Bounds;

            pontoX = 50;
            pontoY = 50;
            largura = areaImpressao.Width;
            altura = areaImpressao.Height;
            numLinhas = 0;
        }
    }
}
