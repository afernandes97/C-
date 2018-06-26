using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordenada c;
            c.x = 10;
            c.y = 5;

            Console.WriteLine("o ponto é ({0}, {1})", c.x, c.y);

            Console.ReadKey();
        }
    }

    struct Coordenada //type 
    {
        internal int x; //member: field 
        internal int y;
    }

    /*
     * PARA MEMBROS!!!
     * 
     * private (default) - visibilidade somente no próprio tipo
     * internal - acesso somente no próprio assembly
     * protected - dentro do mesmo namespace ou em tipos derivados
     * protected internal - acessos do protected + internal
     * public - qualquer tipo de qualquer assembly pode acessar
     * 
     */
}
