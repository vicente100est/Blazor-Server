using Inventary.DataAccess;
using Inventary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary.Business
{
    public class B_Storage
    {
        public List<StorageEntity> StorageLst()
        {
            using (var db = new InventaryContext())
            {
                return db.Storage.ToList();
            }
        }

        public void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Add(oStorage);
                db.SaveChanges();
            }
        }

        public void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Update(oStorage);
                db.SaveChanges();
            }
        }

        public void DeleteStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Remove(oStorage);
                db.SaveChanges();
            }
        }
    }
}
