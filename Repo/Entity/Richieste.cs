using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Repo.Entity
{
    [Table("Richieste")]
   public class Richieste
    {
        [Key]
        [Column(Order = 1)]
        public int LotId { get; set; }

        [Required]
        [MaxLength(128)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(128)]
        public string Cognome{ get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public string Esito { get; set; }

        [Required]
        public bool Tipo { get; set; }

    }
}
