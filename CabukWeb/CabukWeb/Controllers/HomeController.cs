using CabukWeb.Concrete;
using CabukWeb.EntityFramework;
using CabukWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CabukWeb.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        ProductsManager p = new ProductsManager(new EfProductsRepository());
        public IActionResult Index()
        {
            var values = p.GetList();
            return View(values);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        ProductsManager p2 = new ProductsManager(new EfProductsRepository());
        public IActionResult Menu()
        {
            var values = p2.GetList();
            return View(values);
        }

        public IActionResult Giris()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Kayit() 
        {
            return View();
        }
            
        UsersManager um = new UsersManager(new EfUsersRepository());

        [HttpPost]
        public IActionResult Kayit(Users u)
        {
            u.IsActive = true;
            u.CreatedDate = DateTime.Now;
            um.UsersAdd(u);
            return RedirectToAction("Index");
        }

        public IActionResult UrunAnaSayfa()
        {
            return View();
        }
    }

    
}