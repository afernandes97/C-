using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _080_criptografiaSimetrica
{
    class Program
    {
        static void Main(string[] args)
        {
            var rm = new RijndaelManaged();

            GravarChaves(rm, "Chaves.txt");

            GravarArquivo(rm, "Arquivo.txt", "Criptografado.txt");

            Process.Start("Chaves.txt");
            Process.Start("Arquivo.txt");
            Process.Start("Criptografado.txt");
        }

        private static void GravarArquivo(RijndaelManaged rm, String nomeArquivo, String nomeArquivoDestino)
        {
            var fs = new FileStream(nomeArquivoDestino,
                FileMode.Create,
                FileAccess.Write);

            var cs = new CryptoStream(fs,
                rm.CreateEncryptor(rm.Key, rm.IV),
                CryptoStreamMode.Write);

            var sw = new StreamWriter(cs);

            var sr = new StreamReader(nomeArquivo);

            sw.WriteLine(sr.ReadToEnd());

            sr.Close();

            sw.Close();
        }

        private static void GravarChaves(RijndaelManaged rm, String nomeArquivoDestino)
        {
            var sw = new StreamWriter(nomeArquivoDestino, false, Encoding.UTF8);

            sw.WriteLine(MontarString(rm.Key));
            sw.WriteLine(MontarString(rm.IV));

            sw.Close();
        }

        private static String MontarString(byte[] array)
        {
            var sb = new StringBuilder();

            foreach (var item in array)
                {
                    sb.Append(String.Format("{0} ", item));
                }

                return sb.ToString();
         }
    }
    
}
