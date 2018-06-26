using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_ValueReference
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTRL+R, CTRL+M - extract method

            MostrarValueType();

            Console.WriteLine();

            MostrarReferenceType();

            Console.ReadKey();
        }

        private static void MostrarReferenceType()
        {
            ReferenceType.Pessoa rtp = new ReferenceType.Pessoa();
            rtp.nome = "ADAO";

            ReferenceType.Pessoa rtq = rtp;

            Console.WriteLine("{0} <--> {1}", rtp.nome, rtq.nome);

            rtq.nome = "EVA";

            Console.WriteLine("{0} <--> {1}", rtp.nome, rtq.nome);
        }

        private static void MostrarValueType()
        {
            ValueType.Pessoa vtp;
            vtp.nome = "ADAO";

            ValueType.Pessoa vtq = vtp;

            Console.WriteLine("{0} <--> {1}", vtp.nome, vtq.nome);

            vtq.nome = "EVA";

            Console.WriteLine("{0} <--> {1}", vtp.nome, vtq.nome);
        }
    }
}

#region Tipos
namespace ValueType
{
    struct Pessoa
    {
        internal String nome;
    }
}

namespace ReferenceType
{
    class Pessoa
    {
        internal String nome;
    }
}
#endregion

//CTRL+M, CTRL+O = COLLAPSE ALL REGIONS
//CTRL+M, CTRL+L = EXPAND ALL REGIONS
//CTRL+M, CTRL+M = EXPAND REGION
