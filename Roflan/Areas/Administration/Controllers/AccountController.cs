using Roflan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roflan.Areas.Administration.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        // GET: Administration/Account
        [HttpGet]
        public ActionResult Overview()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Overview(RegisterViewModel model)
        {
            return View(model);
        }
    }
}