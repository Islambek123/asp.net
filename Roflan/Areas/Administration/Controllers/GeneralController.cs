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
    [Authorize]
    public class GeneralController : Controller
    {
        private static EFContext _context;
        private static List<UserRoles> list;
        //[HttpGet]
        //public ActionResult List()
        //{
        //    return View();
        //}
        [HttpPost]
        public ActionResult List(RegisterViewModel model)
        {
            foreach (var item in list)
            {
                model.Email = item.Users.Email;
            }
            return View(model);
        }
        public GeneralController()
        {
            using (_context = new EFContext())
            {
                list = _context.UserRoles.ToList();
            }
        }
    }
}
