using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _073_PessoaWCF
{
    [Table("PESSOA")]
    public class Pessoa
    {
        [Key]
        [Column("COD_PESSOA")]
        public int Id { get; set; }

        [Column("NOME_PESSOA")]
        [Required]
        public String Nome { get; set; }

        [Column("FUMANTE_PESSOA")]
        [Required]
        public bool Fumante { get; set; }
    }
}