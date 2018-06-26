using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _084_Event_produtop
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Produto
            {
                Codigo = 1,
                Nome = "André",
                EstoqueMinimo = 10,
                Estoque = 20
            };
            //p.EventoEstoque += new DelegateEstoque(TratarEstoque);
            p.EventoEstoque += TratarEstoque;

            p.Estoque = 1;
           
            Console.ReadKey();
        }

        private static void TratarEstoque(Produto p)
        {
            Console.WriteLine("Estoque ({0}) do produto {1}, esta abaixo do minimo do recomendado({2})",p.Estoque, p.Nome ,p.EstoqueMinimo);
        }

        delegate void DelegateEstoque(Produto p);

        class Produto
        {
            //event
            //metodo associado - delegateestoque
            public event DelegateEstoque EventoEstoque;

            public int Codigo { get; set; }
            public String Nome { get; set; }
            public int EstoqueMinimo { get; set; }

            private int estoque;


            public int Estoque {
                get { return estoque;  }
                set { 
                    estoque = value;
                    if (EventoEstoque != null && estoque < EstoqueMinimo)
                    {
                        EventoEstoque(this);
                    }
                  }
            }
        }

    }
}
