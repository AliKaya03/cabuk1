using CabukWeb.Abstract;
using CabukWeb.Models;
using CabukWeb.Repositories;

namespace CabukWeb.EntityFramework
{
    public class EfUsersRepository: GenericRepository<Users>,IUsersDal
    {
    }
}
