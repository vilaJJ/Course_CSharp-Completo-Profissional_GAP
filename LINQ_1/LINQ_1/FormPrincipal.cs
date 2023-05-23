using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class FormPrincipal : Form
    {
        List<string> lista_nomes;
        List<int> lista_numeros;
        Dictionary<string, double> lista_produtos;
        Dictionary<string, string> lista_cidades;

        public FormPrincipal()
        {
            #region Lista de nomes
            lista_nomes = new List<string>();
            lista_nomes.Add("Juan Felipe Alves Flores");
            lista_nomes.Add("Maria Eduarda Batista de Sousa");
            lista_nomes.Add("Bárbara Ohana dos Santos");
            lista_nomes.Add("Yasmin Garcia Borges");
            lista_nomes.Add("João Arthur Borges Rodrigues");
            lista_nomes.Add("Jefferson Ribeiro Vasconcelos Carvalho");
            #endregion

            #region Lista de números
            lista_numeros = new List<int>();            
            lista_numeros.Add(7);
            lista_numeros.Add(10);
            lista_numeros.Add(21);
            lista_numeros.Add(5);
            lista_numeros.Add(1);
            lista_numeros.Add(13);
            #endregion

            #region Lista de produtos
            lista_produtos = new Dictionary<string, double>();
            lista_produtos.Add("Apple Iphone 7s Plus", 1899.99);
            lista_produtos.Add("Cabo USB-C 3.1", 79.99);
            lista_produtos.Add("Monitor Dell 24' H2419U", 1399.99);
            lista_produtos.Add("Xiaomi Poco X3 Pro", 2189.99);
            lista_produtos.Add("Mac Mini Mid 11'", 1779.99);
            lista_produtos.Add("Logitech C270 Pro", 249.99);
            #endregion

            #region Lista de cidades
            lista_cidades = new Dictionary<string, string>();
            lista_cidades.Add("Montreal", "Canada");
            lista_cidades.Add("Araguaina", "Brazil");
            lista_cidades.Add("Seoul", "South Korea");
            lista_cidades.Add("Rio de Janeiro", "Brazil");
            lista_cidades.Add("Busan", "South Korea");
            lista_cidades.Add("Vancouver", "Canada");
            #endregion

            InitializeComponent();
        }

        private void button_Executar_Click()
        {
            button_Executar_Click(null, null);
        }
        private void button_Executar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            // Obter a fonte dos dados
            // Criar a consulta
            // Executar a consulta

            /*
            IEnumerable<int> res1 = 
                from num in lista_numeros
                where num % 2 == 0
                select num;

            foreach (int item in res1)
            {
                lista.Items.Add(item);
            }
            */

            IEnumerable<string> res2 =
                from nome in lista_nomes
                where nome.StartsWith(textBox_comando.Text)
                select nome;
            lista.Items.AddRange(res2.ToArray());
        }

        private void textBox_comando_TextChanged(object sender, EventArgs e)
        {
            // button_Executar_Click();
        }

        private void button_Where_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            // Operador de Filtragem, a cláusula where

            IEnumerable<string> res1 =
                from nome in lista_nomes
                where nome.ToLower().Contains(textBox_comando.Text.ToLower())
                select nome;
            lista.Items.AddRange(res1.ToArray());
        }

        private void button_OrderBy_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            // Operador de ordenação

            /*
            IEnumerable<int> res1 =
                from num in lista_numeros
                orderby num ascending // descending
                where num > 0
                select num;

            foreach (int item in res1)
            {
                lista.Items.Add(item);
            }
            */

            /*
            IEnumerable<string> res2 =
                from nome in lista_nomes
                orderby nome ascending // descending
                select nome;
            lista.Items.AddRange(res2.ToArray());
            */

            IEnumerable<KeyValuePair<string, double>> res3 =
                from produto in lista_produtos
                orderby produto.Key ascending // descending
                select produto;
            foreach (KeyValuePair<string, double> item in res3)
            {
                lista.Items.Add($"{item.Key} (R$ {item.Value.ToString("000,000.00").TrimStart('0', '.')})");
            }
        }

        private void button_GroupBy_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            textBox_comando.Clear();
            // Operadores de agrupamento

            IEnumerable<IGrouping<string, KeyValuePair<string, string>>> res1 =
                from cidade in lista_cidades
                group cidade by cidade.Value;
            foreach (IGrouping<string, KeyValuePair<string, string>> grupo in res1)
            {
                lista.Items.Add(grupo.Key);
                foreach (var estado in grupo)
                {
                    lista.Items.Add($"\t-> {estado.Key}");
                }
            }
        }

        private void button_Agregacao_Click(object sender, EventArgs e)
        {
            string txtbox = textBox_comando.Text;
            lista.Items.Clear();
            textBox_comando.Clear();

            // Operadores de Agregação
            
            // Count
            int cont1 = lista_nomes.Count();
            int cont2 = (from nome in lista_nomes where nome.StartsWith(txtbox) select nome).Count();

            lista.Items.Add($"{cont1} nomes.");
            lista.Items.Add($"{cont2} nomes começados com '{txtbox}'.");

            // Average
            double media1 = lista_numeros.Average();
            lista.Items.Add($"Média em 'lista_numeros': {media1}");

            double media2 = (from num in lista_numeros where num < 10 select num).Average();
            lista.Items.Add($"Média em 'lista_numeros' < 10: {media2}");

            // Sum
            int soma1 = lista_numeros.Sum();
            lista.Items.Add($"Soma em 'lista_numeros': {soma1}.");

            int soma2 = (from num in lista_numeros where num < 10 select num).Sum();
            lista.Items.Add($"Soma em 'lista_numeros' < 10: {soma2}.");

            // Max
            int max1 = lista_numeros.Max();
            lista.Items.Add($"Maior número: {max1}.");

            int max2 = (from num in lista_numeros where num % 2 == 0 select num).Max();
            lista.Items.Add($"Maior número par: {max2}.");

            // Min
            int min1 = lista_numeros.Min();
            lista.Items.Add($"Menor número: {min1}.");

            int min2 = (from num in lista_numeros where num % 2 == 0 select num).Min();
            lista.Items.Add($"Menor número par: {min2}.");

            // LongCount
            long contagem1 = lista_numeros.LongCount();
            long contagem2 = (from num in lista_numeros where num % 2 == 0 select num).LongCount();

            // Agregate
            string maiorNome1 = lista_nomes.Aggregate(lista_nomes[0], (maior, proximo) =>
            {
                return (maior.Length > proximo.Length)
                ? maior
                : proximo;
            });
            string maiorNome2 = (from nome in lista_nomes select nome).Aggregate(lista_nomes[0], (maior, proximo) =>
            {
                return (maior.Length > proximo.Length)
                ? maior
                : proximo;
            });

            lista.Items.Add($"Maior nome: '{maiorNome2}'.");
        }

        private void button_OpElementos_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            // Operados de Elemento

            /* Se não tiver elementos na lista, irá retornar erro se usar o .First();
             * Usar o .FirstOrDefault() para contornar
            int primeiro1 = lista_numeros.First();
            int primeiro2 = (from num in lista_numeros where num % 2 == 0 select num).First();
            */ 
            int primeiro1 = lista_numeros.FirstOrDefault();
            int primeiro2 = (from num in lista_numeros where num % 2 == 0 select num).FirstOrDefault();

            lista.Items.Add($"Primeiro 'lista_numeros': {primeiro1}.");
            lista.Items.Add($"Primeiro par 'lista_numeros': {primeiro2}.");

            /* Se não tiver elementos na lista, irá retornar erro se usar o .ElementAt(x);
             * Usar o .ElementAtOrDefault(x) para contornar
            int elemento1 = lista_numeros.ElementAt(3);
            int elemento2 = (from num in lista_numeros where num % 2 == 0 select num).ElementAt(3);
            */
            int elemento1 = lista_numeros.ElementAtOrDefault(3);
            int elemento2 = (from num in lista_numeros where num % 2 == 0 select num).ElementAtOrDefault(3);

            lista.Items.Add($"Elemento id. 3 'lista_numeros': {elemento1}.");
            lista.Items.Add($"Último id. 3 entre pares 'lista_numeros': {elemento2}.");

            /* Se não tiver elementos na lista, irá retornar erro se usar o .Last();
             * Usar o .LastOrDefault() para contornar
            int ultimo1 = lista_numeros.Last();
            int ultimo2 = (from num in lista_numeros where num % 2 == 0 select num).Last();
            */
            int ultimo1 = lista_numeros.LastOrDefault();
            int ultimo2 = (from num in lista_numeros where num % 2 == 0 select num).LastOrDefault();

            lista.Items.Add($"Último 'lista_numeros': {ultimo1}.");
            lista.Items.Add($"Último par 'lista_numeros': {ultimo2}.");
        }

        private void button_LINQLambda_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            // LINQ com Métodos Lambda
            /*
            var cons1 = (from nome in lista_nomes select nome);     // Comum
            var cons2 = lista_nomes.Select(nome => nome);
            lista.Items.AddRange(cons2.ToArray());
            */

            /*
            var cons3 = (from nome in lista_nomes where nome.StartsWith(textBox_comando.Text) select nome);
            var cons4 = lista_nomes.Where(nome => nome.StartsWith(textBox_comando.Text));
            lista.Items.AddRange(cons4.ToArray());
            */

            /*
            var cons5 = (from nome in lista_nomes orderby nome ascending select nome);
            var cons6 = lista_nomes.OrderBy(nome => nome);
            var cons7 = lista_nomes.OrderByDescending(nome => nome);
            lista.Items.AddRange(cons7.ToArray());
            */

            var cons8 = (from cidade in lista_cidades group cidade by cidade.Value);
            var cons9 = lista_cidades.GroupBy(estado => estado.Value);

            foreach (var grupo in cons9)
            {
                lista.Items.Add(grupo.Key);
                foreach (var estado in grupo)
                {
                    lista.Items.Add($"\t{estado.Key}");
                }
            }
        }
    }
}