using Inventary.DataAccess;
using Inventary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary.Business
{
    public class B_Warehouse
    {
        public List<WarehouseEntity> WhLst()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouse.ToList();
            }
        }

        public void CreateWh(WarehouseEntity oWh)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouse.Add(oWh);
                db.SaveChanges();
            }
        }

        public void UpdateWh(WarehouseEntity oWh)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouse.Update(oWh);
                db.SaveChanges();
            }
        }

        public void DeleteWh(WarehouseEntity oWh)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouse.Remove(oWh);
                db.SaveChanges();
            }
        }
    }
}
