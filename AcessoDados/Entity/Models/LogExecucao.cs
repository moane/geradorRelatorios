using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcessoDados.Entity.Models
{

    [Table("LogExecucao")]
    public class LogExecucao
    {
        [Key]
        public long Id { get; set; }
        public DateTime DataHora { get; set; }
        public string NomeRelatorio { get; set; }
        public string Consulta { get; set; }
              
    }
      
}
