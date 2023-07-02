using CabukWeb.Concrete;
using CabukWeb.EntityFramework;
using CabukWeb.Models;
using CabukWeb.ValidationRules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CabukWeb.Controllers
{
   
    public class RegisterController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        UsersManager um = new UsersManager(new EfUsersRepository());

      

        [HttpPost]
        public IActionResult Register(Users u)
        {
            UserValidator vr= new UserValidator();
            ValidationResult results=vr.Validate(u);
            if (results.IsValid)
            {
				u.IsActive = true;
				u.CreatedDate = DateTime.Now;
				um.UsersAdd(u);
				return RedirectToAction("Index", "Home");
			}
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }


        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
       
       

	}
}
