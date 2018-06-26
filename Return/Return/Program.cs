using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctrl + r, ctrl+m - refatorar, extrair metodo
            //MostrarDobrar();
            //MostrarDobrarComRetorno();
            //MostrarAlterarReferenceType();

            //DobrarRef();

            Console.ReadKey();
        }

        private static void DobrarRef()
        {
            int x = 10;
            Console.WriteLine("antes de dobrar: {0}", x);

            DobrarRef(ref x); //passa referencia do value type para o method

            Console.WriteLine("Depois de dobrar: {0}", x);
        }

        private static void DobrarRef(ref int x) //passar valor por referencia
        {
            x *= 2;
            Console.WriteLine("Dentro metodo: {0}", x);
        }

        private static void MostrarAlterarReferenceType()
        {
            var p = new Pessoa { nome = "Andre" };

            Console.WriteLine("antes: {0}", p.nome);

            Alterar(p);

            Console.WriteLine("Depois: {0}", p.nome);
        }

        private static void Alterar(Pessoa p)
        {
            p.nome = "******" + p.nome + "******";
            Console.WriteLine("Dentro: {0}", p.nome);
        }

        private static void MostrarDobrarComRetorno()
        {
            int x = 10;
            Console.WriteLine("antes de dobrar: {0}", x);

            x = DobrarComRetorno(x);

            Console.WriteLine("Depois de dobrar: {0}", x);
        }

        private static void MostrarDobrar()
        {
            int x = 10;
            Console.WriteLine("antes de dobrar: {0}", x);

            Dobrar(x);

            Console.WriteLine("Depois de dobrar: {0}", x);
        }

        static void Dobrar(int x)
        {
            x *= 2;
            Console.WriteLine("Dobrar: {0}", x);
        }

        static int DobrarComRetorno(int x)
        {
            x *= 2;
            Console.WriteLine("Dobrar: {0}", x);
            
            return x;
        }


    }

    class Pessoa
    {
        internal String nome;
    }
}
