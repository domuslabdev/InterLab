using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repo.Entity
{
  [Table("Caplotti")]
    public class CapLotti
    {
        [Key]
        public int LotId { get; set; }

        public string Desc { get; set; }

        public DateTime? DataAcquisizione { get; set; }

        public DateTime? DataCarico { get; set; }

        public DateTime? DataScadenza { get; set; }

        public int RichiesteTotali { get; set; }

        public int RichiesteAutoVal { get; set; }

        public int RichiesteVal { get; set; }

        public DateTime? DataInvioEsiti { get; set; }

        public DateTime? FDataRiscontroEsiti { get; set; }

        public DateTime? DataConfermaSgate { get; set; }

        public int Status { get; set; }

    }
}

