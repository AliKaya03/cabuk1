using CabukWeb.Abstract;
using CabukWeb.EntityFramework;
using CabukWeb.Models;

namespace CabukWeb.Concrete
{
    public class ProductsManager : IProductsService
    {
        IProductsDal _productsDal;

        public ProductsManager(IProductsDal productsDal)
        {
            _productsDal = productsDal;
        }

        public List<Products> GetList()
        {
            return _productsDal.GetListAll();
        }

        public Products GetProductsById(int id)
        {
            return _productsDal.GetById(id);
        }

        public void ProductsAdd(Products products)
        {
            _productsDal.Insert(products);
        }

        public void ProductsDelete(Products products)
        {
            _productsDal.Delete(products);
        }

        public void ProductsUpdate(Products products)
        {
            _productsDal.Update(products);
        }
    }
}
