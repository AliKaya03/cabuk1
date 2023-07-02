using CabukWeb.Models;

namespace CabukWeb.Abstract
{
    public interface IUsersService
    {
        void UsersAdd(Users users);
        void UsersDelete(Users users);

        void UsersUpdate(Users users);

        List<Users> GetList();

        Users GetUsersById(int id);
    }
}
