using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcessoDados.Entity.Models
{

    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        public long Id { get; set; }
        public string Ano { get; set; }

        public Modelo Modelo { get; set; }

        public string Descricao { get; set; }
    }
      
}
