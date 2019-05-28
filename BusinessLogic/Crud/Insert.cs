using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Context;
using Repo.Entity;

namespace BusinessLogic.Crud
{
  public  class Insert
    {
        public static void InsertLotti(Lotti lotto)
        {
            using (var db = new BusinessLogic.Context.Context())
            {
                lotto.DataCarico = DateTime.Today;
                db.lotti.Add(lotto);
                db.SaveChanges();
            }
        }

        public static void InsertCapReqs(List<CapReq> reqs)
        {
            var i = 3;
            using (var db = new BusinessLogic.Context.Context())
            {
                reqs.ForEach(x =>
              {
                  var anag = new ComAnagrafica();
                  anag.CAP = "20029";
                  anag.codCliente = "009876"+i++;
                  anag.Comune = "milano";
                  //   db.CapRequest.Add(x);
                  db.Anagrafica.Add(anag);
                  db.SaveChanges();
              });
            }
        }

    }
}
