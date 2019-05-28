using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repo.Entity
{
    [Table("prodotto")]
    public class Prodotto
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
    }
}
