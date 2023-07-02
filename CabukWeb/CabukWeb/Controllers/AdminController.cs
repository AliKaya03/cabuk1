using CabukWeb.Concrete;
using CabukWeb.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using CabukWeb.Models;

namespace CabukWeb.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        UsersManager um = new UsersManager(new EfUsersRepository());
        public IActionResult Users()
        {
            var values=um.GetList();
            return View(values);
        }
        
        ProductsManager pm=new ProductsManager(new EfProductsRepository());

        public IActionResult Urunler()
        {
            var values=pm.GetList();
            return View(values);
        }
        CategoriesManager cm=new CategoriesManager(new EfCategoriesRepository());
        public IActionResult Kategoriler()
        {
            var values=cm.GetList();
            return View(values);
        }
        public IActionResult Order() 
        { 
            return View();
        }

        [HttpGet]
        public IActionResult YeniUrunler()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniUrunler(Products p)
        {
            Context c = new Context();
            c.Products.Add(p);
            c.SaveChanges();
            return RedirectToAction("Urunler");
        }

        [HttpGet]
        public IActionResult YeniKategoriler()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniKategoriler(Categories k)
        {
            Context c = new Context();
            c.Categories.Add(k);
            c.SaveChanges();
            return RedirectToAction("Kategoriler");
        }

        public IActionResult UrunSil(int id)
        {
            Context c=new Context();
            var urun = c.Products.Find(id);
            c.Products.Remove(urun);
            c.SaveChanges();
            return RedirectToAction("Urunler");
        }
        public IActionResult KategoriSil(int id)
        {
            Context c = new Context();
            var cat = c.Categories.Find(id);
            c.Categories.Remove(cat);
            c.SaveChanges();
            return RedirectToAction("Kategoriler");
        }

       public IActionResult KullanıcıSil(int id)
        {
            Context c =new Context();
            var user = c.Users.Find(id);
            c.Users.Remove(user);
            c.SaveChanges();
            return RedirectToAction("Users");
        }
    }
}
