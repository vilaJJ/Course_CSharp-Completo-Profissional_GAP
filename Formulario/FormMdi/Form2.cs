using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMdi
{
    public partial class Form2 : Form
    {
        public Form2(Form parent)
        {
            InitializeComponent();

            MdiParent = parent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(MdiParent);
            f3.Show();
            Close();
        }
    }
}
