using Roflan.Entities;
using Roflan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roflan.Controllers
{
    [Authorize]
    public class SettingsController : Controller
    {
        private static EFContext context;
        private User user;

        public SettingsController()
        {
            context = new EFContext();
        }
        // GET: Settings
        [HttpGet]
        public ActionResult Profile()
        {
            RegisterViewModel model = new RegisterViewModel();
            user = context.User.SingleOrDefault(u => u.Email == User.Identity.Name);
            model.Email = user.Email;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.Password = user.Password;

            return View(model);
        }
        [HttpPost]
        
        public ActionResult Edit(EditModel model)
        {
            if (ModelState.IsValid)
            {
                user = context.User.SingleOrDefault(u => u.Email == User.Identity.Name);
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                //user.Password = model.Password;
                context.SaveChanges();

                return RedirectToAction("Profile");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}