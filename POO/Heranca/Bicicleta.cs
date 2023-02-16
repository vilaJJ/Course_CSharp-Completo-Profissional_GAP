using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    // sealed faz com que a classe não pode ser herdada.
    internal sealed class Bicicleta : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a Bicicleta.");
        }
        public override void Parar()
        {
            Console.WriteLine("Parou a Bicicleta.");
        }
        public void Pedalar()
        {
            Console.WriteLine("Pedalou");
        }
    }
}
