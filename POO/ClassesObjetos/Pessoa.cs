using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Pessoa
    {
        // Atributos (ou Campos)
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        // Métodos simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, meu nome é " + nome + " " + sobrenome + "!");
        }
    }
}
