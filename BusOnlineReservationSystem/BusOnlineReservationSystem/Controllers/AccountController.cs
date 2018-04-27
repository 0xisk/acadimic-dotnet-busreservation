using BusOnlineReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusOnlineReservationSystem.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            using (BusOnlineReservationSystemContext db = new BusOnlineReservationSystemContext())
            {
                return View(db.Users.ToList());
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User account)
        {
            if (ModelState.IsValid)
            {
                using (BusOnlineReservationSystemContext db = new BusOnlineReservationSystemContext())
                {
                    db.Users.Add(account);
                    db.SaveChanges();
                }

                ModelState.Clear();
                ViewBag.Message = account.name + " Successfully Registered";
            }
            return View();
        }

        //login

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User users)
        {
            using (BusOnlineReservationSystemContext db = new BusOnlineReservationSystemContext())
            {
                var usr = db.Users.Single(u => u.email == users.email && u.password == users.password);
                if (usr != null)
                {
                    Session["id"] = users.id.ToString();
                    Session["email"] = users.email.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Email Or Password Is Wrong");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }


    }
}