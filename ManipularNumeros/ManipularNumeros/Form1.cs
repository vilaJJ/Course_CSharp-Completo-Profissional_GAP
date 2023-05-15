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

            #region ToString | Convert.ToString

            /*
            double num = 160.754;
            label_resultados.Text = num.ToString("#.00");
            */

            /*
            int valor = 2004;
            label_resultados.Text = valor.ToString("x"); // Retorna uma string, convertendo de DECIMAL para HEXADECIMAL, em minusculo.
            */

            /*
            int valor = 1945;
            label_resultados.Text = valor.ToString("X"); // Retorna uma string, convertendo de DECIMAL para HEXADECIMAL, em maisculo.
            */

            /*
            int valor = 1917;
            label_resultados.Text = valor.ToString("X4"); // Retorna uma string, convertendo de DECIMAL para HEXADECIMAL, com 4 digitos, em maisculo.
            */

            /*
            int valor = 0xB;
            label_resultados.Text = valor.ToString("D"); // Retorna uma string, convertendo de HEXADECIMAL para DECIMAL.
            */

            /*
            int valor = 0xBED;
            label_resultados.Text = valor.ToString("D5"); // Retorna uma string, convertendo de HEXADECIMAL para DECIMAL, com no minimo 5 digitos.
            */

            /*
            int valor = 1302;
            label_resultados.Text = valor.ToString("C"); // Retorna uma string, em formato monetário.
            */

            /*
            int valor = 164855;
            // label_resultados.Text = Convert.ToString(valor, 16); // Converte para Hexadecimal (base 16)
            //label_resultados.Text = Convert.ToString(valor, 8); // Convert para Octal (base 8)
            */
            #endregion

            #region Classe Math
            /*
            double pi = Math.PI;

            double cos45 = Math.Cos(45);
            double sen45 = Math.Sin(45);
            double tan45 = Math.Tan(45);

            double E = Math.E;

            double potencia = Math.Pow(5, 3); // 5 elevado a 3: 5 é a base, 3 é o expoente

            double raiz_quadrada = Math.Sqrt(49);

            double arredondar = Math.Round(1204.8); // Arredonda pro inteiro mais próximo

            double truncar = Math.Truncate(39.58); // Ignora os decimais

            double floor = Math.Floor(52.91); // Arredonda para baixo

            double ceiling = Math.Ceiling(21.04); // Arredonda para cima

            // label_resultados.Text = pi.ToString();
            // label_resultados.Text = Math.PI.ToString("#.00");
            // label_resultados.Text = potencia.ToString();
            // label_resultados.Text = raiz_quadrada.ToString();
            // label_resultados.Text = arredondar.ToString();
            // label_resultados.Text = truncar.ToString();
            // label_resultados.Text = floor.ToString();
            //label_resultados.Text = ceiling.ToString();
            */
            #endregion
        }
    }
}
