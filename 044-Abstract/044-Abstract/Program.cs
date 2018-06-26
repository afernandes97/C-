using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new Quadrado { X = 2 };
            q.Imprimir();

            Circulo c = new Circulo { X = 1 };
            c.Imprimir();

            Triangulo t = new Triangulo { X = 1};
            t.Imprimir();

            Pentagono p = new Pentagono { X = 1 };
            p.Imprimir();

            Figura f; //polimorfismo
            f = new Triangulo { X = 1 };
            f.Imprimir();

            f = new Pentagono{ X = 1 };
            f.Imprimir();



            Console.ReadKey();
        }
    }

    //abstract indica que a class não pode ser instanciada
    abstract class Figura
    {
        public double X { get; set; }

        //abstract indica que o método não tem implementação
        //e DEVE SER implementado em classes derivadas
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        public void Imprimir()
        {
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("medida...: {0}", X);
            Console.WriteLine("área.....: {0}", CalcularArea());
            Console.WriteLine("perímetro: {0}", CalcularPerimetro());
            Console.WriteLine();
        }
    }

    class Triangulo : Figura
    {
        public override double CalcularArea()
        {
            double sp = CalcularPerimetro() / 2;
            return Math.Sqrt(sp * Math.Pow((sp - X), 3));
        }

        public override double CalcularPerimetro()
        {
            return 3 * X;
        }
    }

    class Pentagono : Figura 
    {
        public override double CalcularArea()
        {
            return 1.72 * X;
        }

        public override double CalcularPerimetro()
        {
            return 5 * X;
        }
    }

    interface IFigura
    {
        double X { get; set; }
        double CalcularArea();
        double CalcularPerimetro();
        void Imprimir();
    }

    class Quadrado : IFigura
    {
        public double X { get; set; }

        public double CalcularArea()
        {
            return Math.Pow(X, 2);
        }

        public double CalcularPerimetro()
        {
            return 4 * X;
        }

        public void Imprimir()
        {
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("medida...: {0}", X);
            Console.WriteLine("área.....: {0}", CalcularArea());
            Console.WriteLine("perímetro: {0}", CalcularPerimetro());
            Console.WriteLine();
        }
    }

    class Circulo : IFigura
    {
        public double X { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(X, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * X;
        }

        public void Imprimir()
        {
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("medida...: {0}", X);
            Console.WriteLine("área.....: {0}", CalcularArea());
            Console.WriteLine("perímetro: {0}", CalcularPerimetro());
            Console.WriteLine();
        }
    }
}
