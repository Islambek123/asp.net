using Roflan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roflan.Areas.Administration.Controllers
{
    public class GeneralController : Controller
    {
        [Authorize]
        [HttpGet]
        public ActionResult List()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult List(RegisterViewModel model)
        {
            
            return View(model);
        }
    }
}
