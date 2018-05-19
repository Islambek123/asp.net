﻿using Roflan.Entities;
using Roflan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Roflan.Controllers
{
    public class AuthorizeController : Controller
    {
        // GET: Autorize
        private static EFContext _context;

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (_context = new EFContext())
                {
                    //якщо юзер null -> створить його
                    if (_context.User.SingleOrDefault(t => t.FirstName == model.FirstName
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
                        //user.Gender = model.Gender;

                        _context.User.Add(user);
                    }
                    _context.SaveChanges();
                }

                return View(model);
                //return RedirectToAction("profile", "person", new { personID = Person.personID });
            }
            return View();
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