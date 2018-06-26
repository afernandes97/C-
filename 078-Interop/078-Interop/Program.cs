using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//abreviacao moie
using MOIE = Microsoft.Office.Interop.Excel;

namespace _078_Interop
{
    class Program
    {
        //adicionar a reference Microsoft.Office.Interop.Excel
        static void Main(string[] args)
        {
            var lista = new List<Livro>();

            lista.Add(new Livro { Codigo = 1, Titulo = "TESTE 1" });
            lista.Add(new Livro { Codigo = 2, Titulo = "TESTE 2" });
            lista.Add(new Livro { Codigo = 3, Titulo = "TESTE 3" });
            lista.Add(new Livro { Codigo = 4, Titulo = "TESTE 4" });
            lista.Add(new Livro { Codigo = 8, Titulo = "TESTE 5" });

            MOIE._Application excel = new MOIE.Application();

            excel.Workbooks.Add();

            MOIE._Worksheet planilha = excel.ActiveSheet;

            int linha = 1;

            planilha.Cells[linha, "A"] = "Código";
            planilha.Cells[linha, "B"] = "Titulo";

            foreach (var item in lista)
            {
                planilha.Cells[++linha, "A"] = item.Codigo;
                planilha.Cells[linha, "B"] = item.Titulo;
            }

            planilha.Range["A1"].AutoFormat(MOIE.XlRangeAutoFormat.xlRangeAutoFormatClassic3);

            String nomeArquivo = Path.Combine(Environment.CurrentDirectory, "planilha.xlsx");

            planilha.SaveAs(nomeArquivo);

            excel.Quit();

            Process.Start(nomeArquivo);
        }
    }

    class Livro
    {
        public int Codigo { get; set; }
        public String Titulo { get; set; }
    }
}
