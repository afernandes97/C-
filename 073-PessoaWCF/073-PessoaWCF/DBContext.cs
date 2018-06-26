using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _073_PessoaWCF
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base("Data Source=srvka.database.windows.net;Initial Catalog=dbKa;User Id=usuario;Password=Pa55w.rd1234;")
        {
        }

        public DbSet<Pessoa> PessoaSet { get; set; }
    }
}