using CabukWeb.Abstract;
using CabukWeb.Models;

namespace CabukWeb.Repository
{
    public class CategoriesRepository : IGenericDal<Categories>
    {
        Context c =new Context();
        public void Delete(Categories t)
        {
            
            c.Remove(t);
            c.SaveChanges();
        }

        public Categories GetById(int id)
        {
            
            return c.Categories.Find(id);
        }

        public List<Categories> GetListAll()
        {
            
            return c.Categories.ToList();
        }

        public void Insert(Categories t)
        {
            
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Categories t)
        {
            
            c.Update(t);
            c.SaveChanges();
        }
    }
}

