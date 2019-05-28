using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repo.Entity
{
    [Table("COM_ANAGRAFICA_TERZI")]
    public class ComAnagrafica
    {
            [Key]
            public String codCliente { get; set; }

            public String codClienteIntegra { get; set; }

            public String ragioneSocialeCliente { get; set; }

            public String partitaIva { get; set; }

            public String codiceFiscale { get; set; }
            public String Comune { get; set; }
            public String Strada { get; set; }
            public String NumeroCivico { get; set; }

            public String CAP { get; set; }
            public String Provincia { get; set; }
            public String Nazione { get; set; }
            public String Email { get; set; }

            public String Telefono { get; set; }
            public String Fax { get; set; }
            public DateTime? DataInserimento { get; set; }
            public DateTime? DataNascita { get; set; }

        }

    }
