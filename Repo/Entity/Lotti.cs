using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repo.Entity
{
    [Table("Lotti")]
    public class Lotti
    {
        [Key]
        [Column(Order = 1)]
        public int LotId { get; set; }

        [Required]
        [MaxLength(128)]
        public string Desc { get; set; }

        [Required]
        public int Status { get; set; }

        public string Esito { get; set; }

        [Required]
        public int Dim { get; set; }

        [Required]
        public DateTime DataCarico { get; set; }

    }
}
