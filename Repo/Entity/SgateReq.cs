using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repo.Entity
{
    [Table("SgateRichieste")]
   public class SgateReq

    {
        [Key]
        [Column(Order = 1)]
        public int SgateId { get; set; }

        public int LotId { get; set; }

        public int ProtDomanda { get; set; }

        public int ProtRichiesta { get; set; }

        public string TipoDomanda { get; set; }

        public string ReqNome { get; set; }

        public string ReqCognome { get; set; }

        public string ReqCf { get; set; }

        public string ReqTipoDoc { get; set; }

        public string ReqNumeroDoc { get; set; }

        public DateTime? ReqDataDoc { get; set; }

        public string ReqEnteRilsascioDoc { get; set; }

        public string ReqIstatComune { get; set; }

        public string ReqEnteAreaCir { get; set; }

        public string ReqCivico { get; set; }

        public string ReqEdificio { get; set; }

        public string ReqScala { get; set; }

        public string ReqInterno { get; set; }

        public string ReqCap { get; set; }

        public string CodUtenteInd { get; set; }

        public string IndNome { get; set; }

        public string IndCognome { get; set; }

        public string IndCf { get; set; }

        public string IndTipoDoc { get; set; }

        public string IndNumeroDoc { get; set; }

        public DateTime? IndDataDoc { get; set; }

        public string IndEnteRilDoc { get; set; }

        public string IndIstatComune { get; set; }

        public string IndAreaCirc { get; set; }

        public string IndCivico { get; set; }

        public string IndEdificio { get; set; }

        public string IndScala { get; set; }

        public string IndInterno { get; set; }

        public string IndCap { get; set; }

        public string CodUtenteCentr { get; set; }

        public string CentrIban { get; set; }

        public string CentrDenCondominio { get; set; }

        public string CentrEdificioPlurifam { get; set; }

        public string CentrIstatComune { get; set; }

        public string CentrAreaCircolazione { get; set; }

        public string CentrCivico { get; set; }

        public string CentrEdificio { get; set; }

        public string CentrScala { get; set; }

        public string CentrInterno { get; set; }

        public string CentrCap { get; set; }

        public string CentrIstatComune2 { get; set; }

        public string CentrAreaCir2 { get; set; }

        public string CentrCivico2 { get; set; }

        public string CentrEdificio2 { get; set; }

        public string CentrScala2 { get; set; }

        public string CentrInterno2 { get; set; }

        public string CentrCap2 { get; set; }

        public string CentrIstatComune3 { get; set; }

        public string CentrAreaCirc3 { get; set; }

        public string CentrCivico3 { get; set; }

        public string CentrEdificio3 { get; set; }

        public string CentrScalae3 { get; set; }

        public string CentrInterno3 { get; set; }

        public string CentrCap3 { get; set; }

        public string CompFamigliaAnag { get; set; }

        public DateTime? DataDisponibilita { get; set; }

        public DateTime? DataAmmissione { get; set; }

        public DateTime? DataPresentazione { get; set; }

        public DateTime? DataInizioAgev { get; set; }

        public DateTime? DataFineAgev { get; set; }

        public bool Allineamento { get; set; }

        public bool FruizioneCont { get; set; }

        public DateTime? DataAcquisizione { get; set; }

        public DateTime? DataPresaIncarico { get; set; }

        public bool Forzato { get; set; }

        public string EsitoD { get; set; }

        public DateTime? DataInvioEsitoD { get; set; }

        public string EsitoS { get; set; }

        public int CodErroreS { get; set; }

        public string DettaglioErrores { get; set; }

        public DateTime? DataChiusuras { get; set; }

    }
}
