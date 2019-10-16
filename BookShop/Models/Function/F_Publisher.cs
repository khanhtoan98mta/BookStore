using BookShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Models.Function
{
    public class F_Publisher
    {
        private MyDBContent content;

        public List<Publisher> getAll()
        {
            List<Publisher> ans = content.Publishers.ToList();
            return ans;
        }

        public F_Publisher()
        {
            content = new MyDBContent();
        }

        public IQueryable<Publisher> DSDM
        {
            get { return content.Publishers; }
        }

        public Publisher FindEntity(long ma)
        {
            Publisher dbE = content.Publishers.Find(ma);
            return dbE;
        }

        public long? Insert(Publisher model)
        {
            Publisher temp = content.Publishers.Find(model.ID);
            if (temp == null)
            {
                return null;
            }
            else
            {
                content.Publishers.Add(model);
                content.SaveChanges();
                return model.ID;
            }
        }

        public long? Update(Publisher model)
        {
            Publisher temp = content.Publishers.Find(model.ID);
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
        public long? Delete(Publisher model)
        {
            Publisher temp = content.Publishers.Find(model.ID);
            if (temp == null)
            {
                return null;
            }
            else
            {
                content.Publishers.Remove(model);
                content.SaveChanges();
                return model.ID;
            }
        }






    }
}