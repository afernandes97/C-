using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o sexo: [M]asculino ou [F]eminino ");

            String sexo = Console.ReadLine().ToUpper();

            Sexo s = sexo == "M" 
                ? Sexo.Masculino
                : Sexo.Feminino;

            switch (s)
            {
                case Sexo.Masculino:
                    Console.WriteLine("Homem");
                    break;
                case Sexo.Feminino:
                    Console.WriteLine("Mulher");
                    break;
            }

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Indica o sexo da pessoa
    /// </summary>
    enum Sexo
    {
        /// <summary>
        /// usar quando for homem
        /// </summary>
        Masculino,
        /// <summary>
        /// usar quando for mulher
        /// </summary>
        Feminino
    }
}
