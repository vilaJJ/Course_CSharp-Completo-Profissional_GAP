using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControle
{
    public partial class Form1 : Form
    {
        Label label1;
        Button button1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1 = new Label();
            label1.Location = new Point(100, 50);
            label1.AutoSize = false;
            label1.Size = new Size(500, 200);
            label1.BackColor = Color.LightCyan;
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Text = "Minha Label no Código Fonte";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Dock = DockStyle.Top;

            button1 = new Button();
            button1.Location = new Point(12, 412);
            button1.Size = new Size(100, 30);
            button1.Text = "Botão";
            button1.Font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            // button1.Click += new EventHandler(button1_Click);
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;


            Controls.Add(label1);
            Controls.Add(button1);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Passou o mouse no botão";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicou no botão";
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Clicou no botão";
        }
        */
    }
}