using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Model;

namespace BusinessLogic.Crud
{
   public class Get
    {
        public  static List<MLotti> getLotti()
        {
            using (var db=new BusinessLogic.Context.Context())
            {
                var lotti = (from l in db.CapLots
                             select new MLotti
                             {
                                 LotId = l.LotId,
                                 Desc = l.Desc,
                                 DataAcquisizione = l.DataAcquisizione,
                                 Status = l.Status,
                                 RichiesteTotali= l.RichiesteTotali,
                                 DataCarico = l.DataCarico,
                                 DataInvioEsiti=l.DataInvioEsiti
                             }).ToList();
                return lotti;
            }
        }

        public static List<MSgateReqs> getSgateReqs(int lotid)
        {
            using (var db = new BusinessLogic.Context.Context())
            {
                var sgateReqs = (from s in db.SgateRequest where s.LotId== lotid
                                 select new MSgateReqs 
                                 {
                                     CentrCap=s.CentrCap,
                                     CentrIban=s.CentrIban,
                                     DataFineAgev=s.DataFineAgev,
                                     CodUtenteCentr=s.CodUtenteCentr,
                                     CodUtenteInd=s.CodUtenteInd,
                                     DataAcquisizione=s.DataAcquisizione,
                                     EsitoD=s.EsitoD,
                                     EsitoS=s.EsitoS,
                                     IndAreaCirc=s.IndAreaCirc,
                                     IndCivico=s.IndCivico,
                                     IndCognome=s.IndCognome,
                                     IndNome=s.IndNome,
                                     IndIstatComune=s.IndIstatComune,
                                     ProtDomanda=s.ProtDomanda,
                                     ProtRichiesta=s.ProtRichiesta,
                                     IndCap=s.IndCap,
                                     CentrCivico=s.CentrCivico,
                                     LotId=s.LotId,
                                     ReqCognome=s.ReqCognome,
                                     ReqCap=s.ReqCap,
                                     ReqIstatComune=s.ReqIstatComune
                                 }).ToList();
                return sgateReqs;
            }
        }

      public static  List<Anagrafica>  getAnagrafica()
        {

            using (var db=new BusinessLogic.Context.Context())
            {
               var  ana=(from res in db.Anagrafica
                         select new Anagrafica{
                             CAP=res.CAP,
                             codClienteIntegra=res.codCliente,
                             Comune=res.Comune
                }).ToList();
                return ana;

            }
        }
    }
}
