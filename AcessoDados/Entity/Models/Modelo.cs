using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcessoDados.Entity.Models
{

    [Table("Modelo")]
    public class Modelo
    {
        [Key]
        public long Id { get; set; }
        public string Descricao { get; set; }
                      
    }
      
}
