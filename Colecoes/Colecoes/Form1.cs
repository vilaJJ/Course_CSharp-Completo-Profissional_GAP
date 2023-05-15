using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Colecoes : Form
    {
        public Colecoes()
        {
            InitializeComponent();
        }

        private void button_List_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            // Exemplo de array
            string[] nomes1 = new string[3];
            nomes1[0] = "Juan";
            nomes1[1] = "Duda";
            nomes1[2] = "Yasmin";

            List<string> nomes2 = new List<string>();

            nomes2.AddRange(nomes1);
            nomes2.Add("Beatriz");
            nomes2.Add("Bárbara");

            //lista.Items.Add(nomes2[0]);
            //lista.Items.Add(nomes2[1]);

            //lista.Items.AddRange(nomes1);

            // MessageBox.Show(nomes2.Remove("Beatriz") ? "Beatriz foi removida" : "Beatriz não foi removida. Não existe na lista.");

            // MessageBox.Show(nomes2.Contains("Bárbara") ? "Bárbara está na lista." : "Bárbara não está na lista.");

            // nomes2.Sort(); // Organiza em ordem alfábetica

            // MessageBox.Show($"Yasmin está no indice: {nomes2.IndexOf("Yasmin")}."); // Retorna -1 quando não existe na lista.

            // nomes2.Insert(2, "João"); // Adiciona João no indice 2, e coloca os demais para trás.

            // nomes2.RemoveAt(4); // Remove o item no indice 4.

            // nomes2.Clear(); // Remove todos os elementos da lista

            // nomes2.Add("Juan"); // É possivel adicionar itens do mesmo nome (valor).

            foreach (string item in nomes2)
            {
                lista.Items.Add(item);
            }

            // MessageBox.Show($"A lista inserida possui {nomes2.Count} itens.");
        }

        private void button_HashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()  // Não comporta itens repetidos
            {
                "Carro", "Moto", "Avião", "Barco", "Bicicleta"
            };
            
            /*
            MessageBox.Show(veiculos.First());
            MessageBox.Show(veiculos.Last());
            */

            //MessageBox.Show(veiculos.ElementAt(3)); // Retorna o item do indice 3
                       
            /*
            if (!(veiculos.Add("Moto")))
            {
                MessageBox.Show("Não foi possivel adicionar. O item já existe na lista.");
            }

            MessageBox.Show($"O item 'Carro' {(veiculos.Contains("Carro") ? "existe" : "não existe")} na lista.");
            */

            /*
            if (veiculos.Remove("Moto"))
            {
                MessageBox.Show("'Moto' removido.");
            }
            */

            // int quantidadeItens = veiculos.Count;

            // veiculos.Clear(); // Limpa toda a HashSet

            foreach (string item in veiculos)
            {
                lista.Items.Add(item);
            }
        }

        private void button_Dictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 1379, "Juan" },
                { 5731, "Duda" },
                { 4826, "Bárbara" }
            };

            /*
            try
            {
                alunos.Add(1379, "João");
            }
            catch (Exception erro)
            {
                MessageBox.Show(string.Format("Não foi possivel adicionar. Motivo: {0}", erro.Message));
            }
            */

            foreach (KeyValuePair<int, string> item in alunos)
            {
                // lista.Items.Add(item); // Retorna chaves e valores, na mesma linha
                // lista.Items.Add(item.Key); // Retorna apenas as chaves
                // lista.Items.Add(item.Value); // Retorna apenas os valores

                lista.Items.Add($"{item.Key}: {item.Value}");
            }

            // int quantidade_alunos = alunos.Count;
            // MessageBox.Show($"Quantidade de alunos: {alunos.Count}.");

            // alunos.Remove(5731); // Remove o item da chave 5731

            // alunos.Clear(); // Irá limpar toda a coleção

            // KeyValuePair<int, string> primeiro = alunos.First(); // Retorna o primeiro item da coleção
            //MessageBox.Show($"Primeiro: {primeiro.Key} = {primeiro.Value}.");

            // KeyValuePair<int, string> ultimo = alunos.Last();
            // MessageBox.Show($"Último: {ultimo.Key} = {ultimo.Value}.");

            // alunos.ContainsKey(1379); // Irá retornar true se existir na lista uma chave igual a 1379.
            // alunos.ContainsValue("Juan"); // Irá retornar true se existir na lista um valor igual a "Juan".
        }

        private void button_SortedList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            SortedList<int, string> tabela_interclasse = new SortedList<int, string>()
            {
                { 2, "JIFTO Masc. (Reserva)" },
                { 3, "Desconhecidos (o resto)" },
                { 1, "Sin's (e o Victor)" }
            };

            tabela_interclasse.Add(4, "Torcida");
            tabela_interclasse.Add(0, "Arbitragem");

            tabela_interclasse.RemoveAt(4);
            tabela_interclasse.Remove(0);

            MessageBox.Show($"{tabela_interclasse.Count} times participaram dos Jogos Internos - Vôlei de Quadra.");

            // tabela.ContainsKey(3); // Irá retornar true se existir na lista uma chave igual a 3
            // tabela.ContainsValue("Aurora"); // Irá retornar true se existir na lista um valor igual a "Aurora".

            foreach (KeyValuePair<int, string> item in tabela_interclasse) // tabela_interclasse.Reverse()
            {
                lista.Items.Add($"{item.Key}° lugar: {item.Value}.");
            }
        }

        private void button_SortedDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            SortedDictionary<int, string> uniforme_time = new SortedDictionary<int, string>()
            {
                { 10, "Juan Felipe" },
                { 4, "Joeps" },
                { 11, "Jeff" },
                { 7, "João Arthur" }
            };

            uniforme_time.Add(1, "Vitor A. S.");
            uniforme_time.Add(3, "Ian Vitor");

            // uniforme_time.Remove(1);

            MessageBox.Show($"{uniforme_time.Count} jogadores.");

            // uniforme_time.Clear();
            
            // uniforme_time.ContainsKey(15);
            // uniforme_time.ContainsValue("João L.");
            MessageBox.Show(uniforme_time.ElementAt(0).ToString());

            foreach (KeyValuePair<int, string> item in uniforme_time) // uniforme_time.Reverse()
            {
                lista.Items.Add($"{item.Value} ({item.Key})");
            }
        }

        private void button_SortedSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            SortedSet<string> jogadores = new SortedSet<string>() // Semelhante ao HashSet, não pode repetir o valor
            {
                "Juan Felipe",
                "Joel",
                "Ian Vitor",
                "Ricardin",
                "Franklei",
                "João Lucas",
                "João Arthur",
                "Victor",
                "Paulo Berg",
                "Edu",
                "Jeff"
            };

            jogadores.Add("Vitor");
            jogadores.Remove("Franklei");

            // jogadores.ElementAt(1);
            // jogadores.First();
            // jogadores.Last();
            // jogadores.Count;
            // jogadores.Clear();

            foreach (string item in jogadores) // jogadores.Reverse()
            {
                lista.Items.Add(item);
            }
        }

        private void button_Queue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Juan Felipe Alves Flores");
            fila.Enqueue("Maria Eduarda Batista de Sousa");
            fila.Enqueue("Yasmin Garcia Borges");

            void preencher_lista()
            {
                lista.Items.Clear();
                foreach (string item in fila)
                {
                    lista.Items.Add(item);
                }
            }

            /*
            MessageBox.Show($"Há {fila.Count} pessoas na fila.");
            MessageBox.Show($"{fila.Peek()} é o primeiro da fila."); // Apenas busca o valor do primeiro da fila.
            */

            // fila.Clear();

            preencher_lista();

            //MessageBox.Show($"Primeiro da fila: {fila.First()}\nÚltimo da fila: {fila.Last()}");

            while (fila.Count > 0)
            {
                MessageBox.Show($"Há {fila.Count} pessoas na fila.");
                MessageBox.Show($"{fila.Dequeue()} era o primeiro da fila e foi atendido. Próximo."); // Remove o primeiro valor da fila.
                preencher_lista();
            }            
        }
        private void button_Stack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Stack<string> pilha = new Stack<string>();

            void preencher_lista()
            {
                lista.Items.Clear();
                foreach (string item in pilha)
                {
                    lista.Items.Add(item);
                }
            }           

            pilha.Push("Juan Felipe");
            pilha.Push("Yasmin Garcia");
            pilha.Push("Maria Eduarda");

            preencher_lista();            

            // MessageBox.Show($"{pilha.Peek()} está no topo da pilha.");

            while (pilha.Count > 0)
            {
                MessageBox.Show($"Existem {pilha.Count} elementos na pilha.");
                MessageBox.Show($"{pilha.Pop()} está no topo da pilha e foi removido.");
                preencher_lista();
            }

            preencher_lista();

            // pilha.Clear();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            if (!(lista.Items.Count == 0))
            {
                lista.Items.Clear();
                MessageBox.Show("Lista esvaziada.");
            }            
        }        
    }
}