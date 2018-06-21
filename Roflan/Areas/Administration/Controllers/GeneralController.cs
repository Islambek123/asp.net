using Roflan.Areas.Administration.Models;
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
        private static EFContext context;

        [HttpGet]
        public ActionResult List(int page = 1)
        {
            RegisterListViewModel registerList = new RegisterListViewModel();
            registerList.RegisterList = new List<RegisterViewModel>();
            registerList.PageInfo = new PageInfo();
            int pageSize = 20; // количество объектов на страницу
            foreach (var user in context
                .UserRoles
                .OrderBy(u => u.UserId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize).ToList())
            {
                RegisterViewModel model =
                    new RegisterViewModel();
                model.UserId = user.UserId;
                model.Email = user.Users.Email;
                model.FirstName = user.Users.FirstName;
                model.LastName = user.Users.LastName;
                model.Password = user.Users.Password;
                model.RoleName = user.Roles.Name;
                registerList.RegisterList.Add(model);
            }
            //int countRow = _context.UserRoles.Count();
            //ViewBag.CountUsers = countRow;

            IEnumerable<RegisterViewModel> items = registerList.RegisterList;
            PageInfo pageInfo = new PageInfo
            {
                PageNumber = page,
                PageSize = pageSize,
                TotalItems = context.UserRoles.Count()
            };
            registerList.PageInfo = pageInfo;

            return View(registerList);
        }
        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    var delelCategory = _context
        //        .User
        //        .Select(c => new User
        //        {
        //            Id = c.Id
        //        })
        //        .SingleOrDefault(c => c.Id == id);
        //    return View(delelCategory);
        //}
        [HttpPost]
        public ActionResult Delete(int[] userId)
        {
            for (int i = 0; i < userId.Length; i++)
            {
                int curr = userId[i];
                User user = context.User.SingleOrDefault(c => c.Id == curr);

                if (user.Email != User.Identity.Name)
                {
                    context.User.Remove(user);
                    context.SaveChanges();
                }
            }

            return View();

        }
        public GeneralController()
        {
            context = new EFContext();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            UserRoles user = context.UserRoles.FirstOrDefault(u => u.Users.Id == id);

            RegisterViewModel model = new RegisterViewModel()
            {
                Email = user.Users.Email,
                FirstName = user.Users.FirstName,
                LastName = user.Users.LastName,
                Password = user.Users.Password,
                RoleName = user.Roles.Name
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }

    }
}