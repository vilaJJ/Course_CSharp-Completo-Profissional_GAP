using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte037
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txt = txtPrint.Text;
            Font font = new Font("Arial", 48, FontStyle.Regular);
            Brush brush = Brushes.Black;
            PointF pointF = new PointF(50, 50);

            e.Graphics.DrawString(txt, font, brush, pointF);
        }

        private void button_Imprimir_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void button_Visualizar_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocument;
        }
    }
}
