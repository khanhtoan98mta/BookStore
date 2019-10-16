using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShop.Models.Entities;
using BookShop;
namespace BookShop.Models.Function
{
    public class F_Category
    {
        private MyDBContent content;

        public List<Category> getAll()
        {
            List<Category> ans = content.Categories.ToList();
            return ans;
        }

        public F_Category()
        {
            content = new MyDBContent();
        }

        public IQueryable<Category> DSDM
        {
            get { return content.Categories; }
        }

        public Category FindEntity(long ma)
        {
            Category dbE = content.Categories.Find(ma);
            return dbE;
        }

        public long? Insert(Category model)
        {
            Category temp = content.Categories.Find(model.ID);
            if (temp == null)
            {
                return null;
            }
            else
            {
                content.Categories.Add(model);
                content.SaveChanges();
                return model.ID;
            }
        }

        public long? Update(Category model)
        {
            Category temp = content.Categories.Find(model.ID);
            if (temp == null)
            {
                return null;
            }
            else
            {
                temp = model;
                content.SaveChanges();
                return model.ID;
            }
        }
        public long? Delete(Category model)
        {
            Category temp = content.Categories.Find(model.ID);
            if (temp == null)
            {
                return null; 
            }
            else
            {
                content.Categories.Remove(model) ;
                content.SaveChanges();
                return model.ID;
            }
        }

        




    }
}