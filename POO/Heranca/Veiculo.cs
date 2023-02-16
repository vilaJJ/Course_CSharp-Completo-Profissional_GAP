using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        public abstract void Acelerar();
        public abstract void Parar();
    }
}
