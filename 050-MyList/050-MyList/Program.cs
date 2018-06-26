using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new MyList<String>();

            //lista.AddUnique("adao");
            //lista.AddUnique("adao");
            //lista.AddUnique("eva");

            lista.Add("adao");
            lista.Add("adao");
            lista.Add("eva");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    class MyList<T> : List<T>
    {
        //prefiro este:
        public new void Add(T t)
        {
            if (!this.Contains(t))
                base.Add(t);
        }
        
        //não gosto deste:
        public void AddUnique(T t)
        {
            if (!this.Contains(t))
                Add(t);
        }
    }
}
