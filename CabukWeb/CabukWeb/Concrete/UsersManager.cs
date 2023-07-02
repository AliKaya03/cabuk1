using CabukWeb.Abstract;
using CabukWeb.EntityFramework;
using CabukWeb.Models;

namespace CabukWeb.Concrete
{
    public class UsersManager : IUsersService
    {

        IUsersDal _usersDal;
        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public List<Users> GetList()
        {
            return _usersDal.GetListAll();
        }

        public Users GetUsersById(int id)
        {
            return _usersDal.GetById(id);
        }

        public void UsersAdd(Users users)
        {
            _usersDal.Insert(users);
        }

        public void UsersDelete(Users users)
        {
            _usersDal.Delete(users);
        }

        public void UsersUpdate(Users users)
        {
            _usersDal.Update(users);
        }
    }
}
