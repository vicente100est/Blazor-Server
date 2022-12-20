using Inventary.DataAccess;
using Inventary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary.Business
{
    public class B_Product
    {
        public List<ProductEntity> ProductLst()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }

        public void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }

        public void DeleteProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Remove(oProduct);
                db.SaveChanges();
            }
        }
    }
}
