using Roflan.Entities;
using Roflan.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roflan.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class GeneralController : Controller
    {
        private static EFContext _context;
        private static List<UserRoles> list;

        public ActionResult List()
        {
            return RedirectToAction("List", "General");
        }
        [HttpGet]
        public ActionResult List(RegisterViewModel model)
        {
            List<RegisterViewModel> models = new List<RegisterViewModel>();

            foreach (var item in list)
            {
                model.Email = item.Users.Email;
                model.FirstName = item.Users.FirstName;
                model.LastName = item.Users.LastName;
                model.Password = item.Users.Password;
                models.Add(model);
            }

            return View(models);
        }
        public GeneralController()
        {
            if (_context == null)
            {
                using (_context = new EFContext())
                {
                    list = _context.UserRoles.ToList();
                }
            }
            
        }
    }
}