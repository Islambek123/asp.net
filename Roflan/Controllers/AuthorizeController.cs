using Roflan.Entities;
using Roflan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;

namespace Roflan.Controllers
{
    public class AuthorizeController : Controller
    {
        // GET: Autorize
        private static EFContext context;

        
        public AuthorizeController()
        {
            context = new EFContext();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (context.UserRoles.SingleOrDefault(u => u.Users.Email == model.Email) != null)
            {
                ModelState.AddModelError("Email", "Такий користувач уже зареєстрований");
            }
            else if (ModelState.IsValid)
            {
                //якщо юзер null -> створить його
                if (context.User.SingleOrDefault(t => t.FirstName == model.FirstName
                && t.LastName == model.LastName
                && t.Email == model.Email) == null)
                {
                    var user = new User()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        Password = model.Password

                    };
                    //RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                    var userRole = new UserRoles()
                    {
                        Users = user,
                        Roles = context.Role.Where(x => x.Name == "User").SingleOrDefault()
                    };


                    context.UserRoles.Add(userRole);
                }
                context.SaveChanges();


                return RedirectToAction("Index", "Home");
                //return RedirectToAction("profile", "person", new { personID = Person.personID });
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid && Membership.ValidateUser(model.Email, model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.Email, false);
                //Roles.AddUserToRole(model.Email, "Admin");
                return RedirectToAction("Index", "Home");
            }
            //errorState
            ModelState.AddModelError("Password", "Wrong Data.");
            return View(model);
        }
        [HttpGet]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            //AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}