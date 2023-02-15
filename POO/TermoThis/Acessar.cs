using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Acessar
    {
        string senha = "123123";

        public bool Login(string senha)
        {
            return this.senha == senha;
        }
    }
}
