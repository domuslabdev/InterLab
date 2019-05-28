using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Crud
{
    public static class Delete
    {
        public static void DelLot()
        {
            using (var db = new BusinessLogic.Context.Context())
            {
                var lot = db.lotti.FirstOrDefault(x => x.LotId == 4);
                db.lotti.Remove(lot);
                db.SaveChanges();
            }
        }
    }
}
