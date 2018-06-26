using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = new List<Produto>
            {
                new Produto{Id=1, Nome="MARTELO", Preco=10},
                new Produto{Id=2, Nome="MACHADO", Preco=20},
                new Produto{Id=3, Nome="SERROTE", Preco=30},
            };

            var produtosCaros = produtos
                .Where(p => p.Preco >= 15)
                .Select(p => new { Codigo = p.Id, p.Nome, Agora = DateTime.Now });

            foreach (var item in produtosCaros)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public decimal Preco { get; set; }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}", Id, Nome, Preco);
        }
    }
}
