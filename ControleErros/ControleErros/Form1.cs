using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleErros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            int[] num = { 10, 20, 30, 40, 50 };
            string res = "";            

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    res += $"{num[i]} ";
                }

                label_Resultado.Text = res.TrimEnd();
            }
            catch (Exception ex)
            {
                label_Resultado.Text = $"Ocorreu um erro. Motivo: {ex.Message}";
            }
            finally
            {
                MessageBox.Show("Operação finalizada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
