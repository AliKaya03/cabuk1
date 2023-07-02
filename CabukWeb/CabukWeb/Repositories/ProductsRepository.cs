using CabukWeb.Abstract;
using CabukWeb.Models;

namespace CabukWeb.Repositories
{
    public class ProductsRepository : IGenericDal<Products>
    {
        Context c = new Context();
        public void Delete(Products t)
        {
            
            c.Remove(t);
            c.SaveChanges();
        }

        public Products GetById(int id)
        {
            return c.Products.Find(id);
        }

        public List<Products> GetListAll()
        {
           
            return c.Products.ToList();
        }

        public void Insert(Products t)
        {
           
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Products t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
