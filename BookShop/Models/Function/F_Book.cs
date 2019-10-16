using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using BookShop.Models.Entities;
using BookShop;
namespace BookShop.Models.Function
{
    public class F_Book
    {
        private MyDBContent context;

        public F_Book()
        {
            context = new MyDBContent();
        }

        public IQueryable<Book> DSSach
        {
            get { return context.Books; }
        }
        public List<Book> getAll()
        {
            List<Book> ans = context.Books.ToList();
            return ans;
        }
        public Book FindEntity(long ma)
        {
            Book dbE = context.Books.Find(ma);
            return dbE;
        }
        


        public long? Insert(Book model)
        {
            Book temp = context.Books.Find(model.ID);
            if (temp == null)
            {
                return null;
            }
            else
            {
                context.Books.Add(model);
                context.SaveChanges();
                return model.ID;
            }
        }

        public long? Update(Book model)
        {
            Book temp = context.Books.Find(model.ID);
            if (temp == null)
            {
                return null;
            }
            else
            {
                temp = model;
                context.SaveChanges();
                return model.ID;
            }
        }
        public long? Delete(Book model)
        {
            Book temp = context.Books.Find(model.ID);
            if (temp == null)
            {
                return null;
            } 
            else
            {
                context.Books.Remove(model);
                context.SaveChanges();
                return model.ID;
            }
        }

    }
}