using CabukWeb.Models;

namespace CabukWeb.Abstract
{
    public interface IProductsService
    {
        void ProductsAdd(Products products);
        void ProductsDelete(Products products);

        void ProductsUpdate(Products products);

        List<Products> GetList();

        Products GetProductsById(int id);
    }
}
