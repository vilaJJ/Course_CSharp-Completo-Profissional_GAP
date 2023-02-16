using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Forma
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar...");
        }

        public virtual void Area() 
        {
            int area = Altura * Largura;
            Console.WriteLine("Área do Retângulo: " + area);
        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Círculo.");
        }

        public override void Area() 
        {
            double area = 3.14 * (Raio * Raio);
            Console.WriteLine("Área do Círculo = " + area);
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Retângulo.");
        }
        public override void Area()
        {
            base.Area();
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um Triângulo.");
        }
        public override void Area()
        {
            double area = (Altura * Largura) / 2;
            Console.WriteLine("Área do Triângulo: " + area);
        }
    }
}
