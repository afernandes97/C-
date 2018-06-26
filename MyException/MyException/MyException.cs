using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyException
{
    public class MyException : Exception
    {
        public MyException()//constructor
        {
            Logar();
        }

        private void Logar()
        {
            var arquivo = new StreamWriter("C:\\Users\\Admin\\Desktop\\teste\\log.txt", true, Encoding.Unicode);

            arquivo.WriteLine("Probrema no programa");
            arquivo.Close();
            arquivo.Dispose();//liberar recursos sistema operacional
        }
    } 
}
