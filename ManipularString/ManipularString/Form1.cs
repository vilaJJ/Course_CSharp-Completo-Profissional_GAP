using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_executar_Click(object sender, EventArgs e)
        {
            #region Contains
            /*
            string texto = "Este tipo de variável é alfanúmerica.";
            if (texto.Contains("Tipo"))
            {
                label_texto.Text = "Contém.";
            }
            else
            {
                label_texto.Text = "Não contém.";
            }
            */
            #endregion

            #region ToString
            /*
            int num = 2004;
            label_texto.Text = num.ToString();            
            */
            #endregion

            #region ToUpper - ToLower
            /*
            string nome = "AaBbCcDdEeFf";
            
            string nomeMaiusculo = nome.ToUpper();
            string nomeMinusculo = nome.ToLower();

            label_texto.Text = nome.ToLower();
            */
            #endregion

            #region IndexOf - LastIndexOf
            /*
            string nome = "Juan Felipe";

            int indiceFirst = nome.IndexOf("e");                            // Primeira ocorrência
            indiceFirst = nome.IndexOf("e", 8);                             // Vai começar pelo indice 8 
            indiceFirst = nome.IndexOf("e", 8, 3);                          // Vai percorrer apenas 3 caracteres após o indice 8

            int indiceLast = nome.LastIndexOf("e");                         // Última ocorrência

            label_texto.Text = $"indiceFirst = {indiceFirst}\nindiceLast = {indiceLast}";
            */
            #endregion

            #region Insert - Replace
            /*
            string nome = "Juan Felipe";
            string nomeCompleto = nome.Insert(nome.Length *//*Retorna o tamanho da string (vulgo indice do último caractere*//*, " Alves Flores");

            nomeCompleto = nomeCompleto.Replace('a', '4');
            nomeCompleto = nomeCompleto.Replace("Felipe", "Pablo");

            label_texto.Text = nomeCompleto;
            */
            #endregion

            #region Length - Substring
            /*
            string nome = "Juan";
            int qntdCaracteresNome = nome.Length;

            for (int i = 0; i < qntdCaracteresNome; i++)
            {
                label_texto.Text += $"{nome[i]}\n";
            }

            string parte1 = nome.Substring(1); // Após o indice 1
            string parte2 = nome.Substring(1, 2); // Apenas dois caracteres após o indice 1

            label_texto.Text += $"Meu nome contém {qntdCaracteresNome} caracteres\n" +
                $"parte1 = {parte1}\n" +
                $"parte2 = {parte2}";
            */
            #endregion

            #region Split
            /*
            string[] separador = { " ", "_|_", "/", "+" };
            string nomes = "Juan_|_Madu_|_Bárbara_|_Yasmin_|_Karol";
            String[] nomesArray = nomes.Split(separador, StringSplitOptions.None);

            int i = 1;
            foreach (string item in nomesArray)
            {
                label_texto.Text += $"{i}: {item}\n";
                i++;
            }
            */
            #endregion

            #region StartsWith - EndsWith
            /*
            string nome = "Juan Felipe";

            string comeco = "B";
            string fim = "E";

            if (nome.StartsWith("B"))
            {
                label_texto.Text += $"Começa com '{comeco}'.\n";
            }
            else
            {
                label_texto.Text += $"Não Começa com '{comeco}'.\n";
            }

            if (nome.EndsWith(fim, StringComparison.OrdinalIgnoreCase)) // Ignora o case-sensitive 
            {
                label_texto.Text += $"Termina com '{fim}'.";
            }
            else
            {
                label_texto.Text += $"Não Termina com '{fim}'.";
            }
            */
            #endregion

            #region Trim - TrimStart - TrimEnd
            /*
            string mensagem1 = "          Olá, Juan   !!!";

            char[] caracteres = { ' ', '!' };

            label_texto.Text = ">" + mensagem1 + "<";
            label_texto.Text += "\n>" + mensagem1.Trim() + "<";
            label_texto.Text += "\n>" + mensagem1.Trim(caracteres) + "<";
            label_texto.Text += "\n";

            string mensagem2 = "     Olá, Bárbara    ";

            label_texto.Text += "\n>" + mensagem2 + "<";
            label_texto.Text += "\n>" + mensagem2.TrimStart() + "<";
            label_texto.Text += "\n>" + mensagem2.TrimEnd() + "<";
            // TrimStart e TriEnd tambem podem receber um array de char
            */
            #endregion

            #region CompareTo - Equals
            /*
            string nome1 = "Juan";
            string nome2 = "Felipe";

            if (nome1.Equals(nome2, StringComparison.OrdinalIgnoreCase)) // Ignora o case-sensitive
            {
                label_texto.Text = "É igual!";
            }
            else
            {
                label_texto.Text = "Não é igual!";
            }

            label_texto.Text += $"\n{nome1.CompareTo(nome2)}";
            // Retorno 1: A string nome2 vem antes de nome1.
            // Retorno 0: As strings nome1 e nome2 são iguais.
            // Retorno -1: A string nome1 vem depois de nome1.
            */
            #endregion

            #region Format
            /*
            double valor = 59.99;
            int idade = 18;

            string mensagem1 = string.Format(
                "O produto está custando {0:C2}.\nIdade mínima de consumo: {1} anos.",
                valor, idade);

            string mensagem2 = string.Format("Hoje é {0:d} e são {0:t}.", DateTime.Now);
            string mensagem3 = $"Hoje é {DateTime.Now:D} e são {DateTime.Now:T}.";

            label_texto.Text = $"{mensagem1}\n\n{mensagem2}\n{mensagem3}";
            */
            #endregion
        }
    }
}