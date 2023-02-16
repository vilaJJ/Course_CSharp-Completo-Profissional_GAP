using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Carro : Veiculo
    {
        public int VelocidadeMaxima { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o Carro");
        }
        public override void Parar()
        {
            Console.WriteLine("Parou o Carro");
        }

        public void LigarMotor()
        {
            Console.WriteLine("Motor ligado.");
        }
    }
}
