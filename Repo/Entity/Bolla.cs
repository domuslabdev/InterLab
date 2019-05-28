using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Repo.Entity
{
    [Table("bolla")]
    public class Bolla
    {
        [Key]
        public int id { get; set; }
        public int num { get; set; }
        public string  fornitore { get; set; }
    }
}
