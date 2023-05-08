using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button_executar_Click(object sender, EventArgs e)
        {
            #region TryParse
            /*
            int num1;
            bool res = int.TryParse("2004", out num1);

            if (res)
            {
                label_resultados.Text = $"{num1}";
            }
            else
            {
                label_resultados.Text = "Erro na conversão.";
            }
            */
            #endregion
        }
    }
}
