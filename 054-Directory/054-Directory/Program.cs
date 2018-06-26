﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Admin\Desktop"); //string verbatim

            Console.WriteLine("Nome completo: {0}", di.FullName);
            Console.WriteLine("Existe: {0}", di.Exists);
            Console.WriteLine("Nome: {0}", di.Name);
            Console.WriteLine("Parent: {0}", di.Parent.Name);
            Console.WriteLine("Root: {0}", di.Root);
            Console.WriteLine("Criado em: {0}", di.CreationTime);
            Console.WriteLine("Data do último acesso: {0}", di.LastAccessTime);
            Console.WriteLine("Data da última gravação: {0}", di.LastWriteTime);

            Console.WriteLine();

            DirectoryInfo novo = di.CreateSubdirectory("novo");

            foreach (var item in novo.GetFiles())
            {
                Console.WriteLine(item.Name);
            }

            novo.Delete(true);

            Console.WriteLine();

            Console.WriteLine("Existe o outro? {0}", Directory.Exists(@"C:\Users\Admin\Desktop\outro"));

            Directory.CreateDirectory(@"C:\Users\Admin\Desktop\outro");

            Console.WriteLine("Existe o outro? {0}", Directory.Exists(@"C:\Users\Admin\Desktop\outro"));

            Directory.Delete(@"C:\Users\Admin\Desktop\outro");

            Console.ReadKey();
        }
    }
}
