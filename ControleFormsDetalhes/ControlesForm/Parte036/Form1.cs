using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Imprimir_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() != DialogResult.Cancel)
            {
                printDocument.Print();
            }            
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txt = richTextBox.Text;
            Font fonte = new Font("Arial", 12, FontStyle.Regular);
            Brush pincel = new SolidBrush(Color.Black);
            PointF pointF = new PointF(20, 20);

            e.Graphics.DrawString(txt, fonte, pincel, pointF);
        }

        private void button_CfgPage_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            pageSetupDialog.PageSettings = new System.Drawing.Printing.PageSettings();

            if (pageSetupDialog.ShowDialog() != DialogResult.Cancel)
            {
                printDocument.Print();
            }
        }
    }
}