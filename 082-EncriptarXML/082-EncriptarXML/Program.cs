using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _082_EncriptarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomeArquivo = "dados.txt";


            String xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" +
                "<tabela><linha>" +
                "<cod></cod><nome></nome><sexo></sexo>" +
                "</linha></tabela>";

            var ds = new DataSet();

            ds.ReadXml(new StringReader(xml));

            DataRow dr = ds.Tables[0].Rows[0];

            dr["cod"] = 1;
            dr["nome"] = "ADÃO";
            dr["sexo"] = 'M';

            dr = ds.Tables[0].NewRow();

            dr["cod"] = 2;
            dr["nome"] = "EVA";
            dr["sexo"] = 'F';

            ds.Tables[0].Rows.Add(dr);
            ds.WriteEncryptedXml(nomeArquivo);
            Process.Start(nomeArquivo);

            //criando OUTRO DataSet

            ds = new DataSet();
            ds.ReadEncryptedXml(nomeArquivo);
            Console.WriteLine(ds.GetXml());
            Console.ReadKey();
        }
    }



    class Criptografia
    {

        //chaves da criptografia
        private static byte[] key;
        private static byte[] iv;

        static Criptografia()
        {
            key = Encoding.UTF8.GetBytes("Qu@lqu3r fr@s3 com 32 caractere$");

            iv = Encoding.UTF8.GetBytes("E e$$a t3m 16!!!");
        }



        public static String Encriptar(String mensagem)
        {

            String retorno = String.Empty;
            try
            {
                var rm = new RijndaelManaged();

                rm.Key = key;
                rm.IV = iv;


                var ms = new MemoryStream();

                var cs = new CryptoStream(ms,
                    rm.CreateEncryptor(rm.Key, rm.IV),
                    CryptoStreamMode.Write);


                cs.Write(Encoding.Default.GetBytes(mensagem),
                    0,
                    mensagem.Length);



                cs.FlushFinalBlock();

                retorno = Convert.ToBase64String(ms.ToArray());
                ms.Close();
                cs.Close();

            }

            catch { }
            return retorno;
        }



        public static String Decriptar(String mensagem)
        {

            var retorno = String.Empty;
            try
            {
                var rm = new RijndaelManaged();
                rm.Key = key;
                rm.IV = iv;

                byte[] cifrada = Convert.FromBase64String(mensagem);

                var ms = new MemoryStream(cifrada);



                var cs = new CryptoStream(ms,
                    rm.CreateDecryptor(rm.Key, rm.IV),
                    CryptoStreamMode.Read);
                

                byte[] decriptada = new byte[cifrada.Length];                

                int qtd = cs.Read(decriptada, 0, decriptada.Length);
                
                retorno = Encoding.Default.GetString(decriptada,
                    0,
                    qtd);

                ms.Close();
                cs.Close();

            }
            catch { }
            return retorno;
        }

    }

    static class DataSetExtensions
    {

        public static void ReadEncryptedXml(this DataSet ds, String nomeArquivo)
        {
            var sr = new StreamReader(nomeArquivo, Encoding.UTF8);

            var xml = Criptografia.Decriptar(sr.ReadToEnd());
            sr.Close();
            ds.ReadXml(new StringReader(xml));

        }

        public static void WriteEncryptedXml(this DataSet ds,

            String nomeArquivo)
        {

            var sw = new StreamWriter(nomeArquivo,
                false,
                Encoding.UTF8);

            sw.WriteLine(Criptografia.Encriptar(ds.GetXml()));
            sw.Close();

        }

    }

}