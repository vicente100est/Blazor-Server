using Inventary.DataAccess;
using Inventary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary.Business
{
    public class B_InOut
    {
        public List<InOutEntity> InOutLst()
        {
            using (var db = new InventaryContext())
            {
                return db.InOut.ToList();
            }
        }

        public void CreateInOut(InOutEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Add(oInOut);
                db.SaveChanges();
            }
        }

        public void UpdateInOut(InOutEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Update(oInOut);
                db.SaveChanges();
            }
        }

        public void DeleteInOut(InOutEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Remove(oInOut);
                db.SaveChanges();
            }
        }
    }
}
