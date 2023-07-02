using CabukWeb.Abstract;
using CabukWeb.EntityFramework;
using CabukWeb.Models;
using CabukWeb.Repositories;
using CabukWeb.Repository;

namespace CabukWeb.Concrete
{
    public class CategoriesManager : ICategoriesService
    {
        ICategoriesDal _categoriesDal;

        public CategoriesManager(ICategoriesDal categoriesDal)
        {
            _categoriesDal = categoriesDal;
        }

        public void CategoriesAdd(Categories categories)
        {
            _categoriesDal.Insert(categories);
        }

        public void CategoriesDelete(Categories categories)
        {
            _categoriesDal.Delete(categories);
        }

        public void CategoriesUpdate(Categories categories)
        {
           _categoriesDal.Update(categories);
        }

        public Categories GetCategoriesById(int id)
        {
            return _categoriesDal.GetById(id);
        }

        public List<Categories> GetList()
        {
           return _categoriesDal.GetListAll();
        }
    }
}
