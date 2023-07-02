using CabukWeb.Abstract;
using CabukWeb.Models;

namespace CabukWeb.Repositories
{
    public class UsersRepository : IGenericDal<Users>
    {
        Context c = new Context();
        public void Delete(Users t)
        {
            
            c.Remove(t);
            c.SaveChanges();
        }

        public Users GetById(int id)
        {
            
            return c.Users.Find(id);
        }

        public List<Users> GetListAll()
        {
           
            return c.Users.ToList();
        }

        public void Insert(Users t)
        {
           
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(Users t)
        {
            
            c.Update(t);
            c.SaveChanges();
        }
    }
}
