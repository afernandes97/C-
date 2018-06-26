using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_File
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Directory.GetFiles(@"C:\Users\Admin\Desktop"))
            {
                FileInfo fi = new FileInfo(item);

                Console.WriteLine("Nome completo: {0}", fi.FullName);
                Console.WriteLine("Nome: {0}", fi.Name);
                Console.WriteLine("Extensão: {0}", fi.Extension);
                Console.WriteLine("Diretório (pasta): {0}", fi.DirectoryName);
                Console.WriteLine("Tamanho: {0}", fi.Length);
                Console.WriteLine("Somente leitura? {0}", fi.IsReadOnly);
                Console.WriteLine("Criado em: {0}", fi.CreationTime);
                Console.WriteLine("Último acesso: {0}", fi.LastAccessTime);
                Console.WriteLine("Última gravação: {0}", fi.LastWriteTime);
                Console.WriteLine();
            }

            //File.Create(@"C:\Users\Admin\Desktop\arquivo.txt");

            File.Delete(@"C:\Users\Admin\Desktop\arquivo.txt");

            Console.ReadKey();
        }
    }
}
