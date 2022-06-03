using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICategoryDb
    {
        List<Category> GetAll();
        Category GetById(int id);
        bool Insert(Category obj);
        bool Update(Category obj);
        bool Delete(int id);
    }
    public class CategoryDb : ICategoryDb
    {
        private DbFirstEntities1 context;
        public CategoryDb()
        {
            context = new DbFirstEntities1();
        }

        public bool Delete(int id)
        {
            var obj = context.Categories.Find(id);
            context.Categories.Remove(obj);
            context.SaveChanges();
            return true;
        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return context.Categories.Find(id);
        }

        public bool Insert(Category obj)
        {
            context.Categories.Add(obj);
            context.SaveChanges();
            return true;
        }

        public bool Update(Category obj)
        {
            context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return true;
        }
    }
}
