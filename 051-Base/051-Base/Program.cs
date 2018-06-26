using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyException();
                //throw new MyException("mensagem de erro do programa");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }

    class MyException : Exception
    {
        public MyException(String msg)
            : base(msg)
        {
        }

        public MyException()
            : this("sem mensagem")
        {

        }
    }
}
