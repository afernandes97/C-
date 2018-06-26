using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _081_decriptacaoSimetrica
{
    class Program
    {
        static void Main(string[] args)
        {

            var rm = new RijndaelManaged();

            byte[] k = new byte[rm.Key.Length];
            byte[] iv = new byte[rm.IV.Length];

            LerChave(k, iv, "Chaves.txt");

            LerArquivo(rm, k, iv);

            Process.Start("Criptografado.txt");
            Process.Start("Decriptado.txt");
        }

        private static void LerArquivo(RijndaelManaged rm, byte[] k, byte[] iv)
        {
            var fs = new FileStream("Criptografado.txt",
                FileMode.Open,
                FileAccess.Read);

            var cs = new CryptoStream(fs,
                rm.CreateDecryptor(k, iv),
                CryptoStreamMode.Read);

            var sr = new StreamReader(cs);
            var sw = new StreamWriter("Decriptado.txt");

            sw.WriteLine(sr.ReadToEnd());

            sr.Close();
            sw.Close();
        }

        private static void LerChave(byte[] k, byte[] iv, String nomeArquivo)
        {
            var sr = new StreamReader(nomeArquivo, Encoding.UTF8);

            String[] keys = sr.ReadLine().Trim().Split(' ');
            String[] ivs = sr.ReadLine().Trim().Split(' ');

            sr.Close();

            for (int i = 0; i < k.Length; i++)
            {
                k[i] = Convert.ToByte(keys[i]);
            }

            for (int i = 0; i < iv.Length; i++)
            {
                iv[i] = Convert.ToByte(iv[i]);
            }
        }
    }
}
