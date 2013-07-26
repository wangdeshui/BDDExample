using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BDD.Web.Controllers
{
    public class AccountController : Controller
    {

        [HttpGet]
        public ActionResult Register()
        {
            return View("Register");
        }


        [HttpPost]
        public RedirectToRouteResult Register(string email, string password)
        {
            TempData["Success"] = "Thank you for registering";
            return RedirectToAction("Register");
        }

    }
}
