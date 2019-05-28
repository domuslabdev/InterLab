using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Repo.Entity
{

    [Table("CapRichieste")]
    public class CapReq
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        public int lotId { get; set; }

        public string ProtRichiesta { get; set; }

        public string TipoRichiesta { get; set; }

        public int TipoUtente { get; set; }

        public DateTime DataPresentazione { get; set; }

        public DateTime DataScadenzaInvioEsiti { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string Denominazione { get; set; }

        public string Cf { get; set; }

        public string Integra { get; set; }

        public string IndFornitua { get; set; }

        public int NumFamAnagrafica { get; set; }

        public string Uso { get; set; }

        public int StatoUtenza { get; set; }

        public string EsitoAutoVal { get; set; }

        public string EsitoManVal { get; set; }

        public int Processato { get; set; }

        public int ReqInterno { get; set; }

        public Double ImportoBi { get; set; }

        public Double ImportoIntegrativo { get; set; }

        public string Esito { get; set; }

        public string codCliente { get; set; }

        public string codClienteNew { get; set; }

        public int codClienteSuspect { get; set; }
    }
}
