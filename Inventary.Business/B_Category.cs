using Inventary.DataAccess;
using Inventary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary.Business
{
    public class B_Category
    {

        public List<CategoryEntity> CategoryLst()
        {
            using (var db = new InventaryContext())
            {
                return db.Category.ToList();
            }
        }

        public void CreateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Category.Add(oCategory);
                db.SaveChanges();
            }
        }

        public void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Category.Update(oCategory);
                db.SaveChanges();
            }
        }

        public void DeleteCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Category.Remove(oCategory);
                db.SaveChanges();
            }
        }
    }
}
