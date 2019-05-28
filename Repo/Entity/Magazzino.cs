using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repo.Entity
{
    [Table("magazzino")]
    public class Magazzino
    {
        [Key]
        public int id { get; set; }
        public int quantita { get; set; }
    }
}
