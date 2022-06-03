using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICategoryBs
    {
        List<Category> GetAll();
        Category GetById(int id);
        bool Insert(Category obj);
        bool Update(Category obj);
        bool Delete(int id);
    }
    public class CategoryBs : ICategoryBs
    {
        private CategoryDb objDb;
        public CategoryBs()
        {
            objDb = new CategoryDb();
        }
        public bool Delete(int id)
        {
            return objDb.Delete(id);
        }

        public List<Category> GetAll()
        {
            return objDb.GetAll();
        }

        public Category GetById(int id)
        {
            return objDb.GetById(id);
        }

        public bool Insert(Category obj)
        {
            return objDb.Insert(obj);
        }

        public bool Update(Category obj)
        {
            return objDb.Update(obj);
        }
    }
}
