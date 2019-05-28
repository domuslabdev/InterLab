using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo.Entity;

namespace BusinessLogic.Process
{
    public enum stato { acq = 1, inelab, elab, inval, val, approvato };
    public static class getLotto
    {

        public static void UpLoadLotto()
        {
            using (var db = new BusinessLogic.Context.Context())
            {
                var nodi = db.SgateRequest.Where(x => x.LotId == 0).OrderBy(x => x.ReqDataDoc).ToList();
                //rilevo data piu vecchia
                if (nodi.Count() == 0)
                    return;
                var dt = nodi.First();
                var nodo = new CapLotti();
                nodo.DataAcquisizione = DateTime.Now;
                nodo.DataCarico = new DateTime(2018, 10, 06);
                nodo.DataScadenza = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(2);
                nodo.DataInvioEsiti = new DateTime(2018, 10, 06);
                nodo.RichiesteTotali = nodi.Count();
                nodo.RichiesteAutoVal = 0;
                nodo.RichiesteVal = 0;
                nodo.Status = (int)stato.acq;

                db.CapLots.Add(nodo);
                db.SaveChanges();

                var lottoid = db.CapLots.Where(x => x.LotId > 0).OrderByDescending(x => x.LotId).First();

                nodi.ForEach(h =>
                {
                    h.LotId = lottoid.LotId;
                    h.DataAcquisizione = DateTime.Now;
                //    db.SgateRequest.
                    db.SaveChanges();
                });

            }

        }
    }
}

