using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Teste
    {
        private string nome;
        public string sobrenome;

        private void Metodo1()
        {

        }
        public void Executar()
        {

        }
    }
    
    class Humano
    {
        // Fica acessível apenas para a própria classe e os herdeiros.
        protected string nome;

        // Fica acessível apenas na classe criada.
        private string sobrenome;

        // Pode ser usada apenas dentro da aplicação (assembly).
        internal int idade;
    }
    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "Abacate";
        }
    }
}
