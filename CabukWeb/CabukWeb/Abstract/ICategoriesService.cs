using CabukWeb.Models;

namespace CabukWeb.Abstract
{
    public interface ICategoriesService
    {
        void CategoriesAdd(Categories categories);
        void CategoriesDelete(Categories categories);

        void CategoriesUpdate(Categories categories);

        List<Categories> GetList();

        Categories GetCategoriesById(int id);
    }
}
