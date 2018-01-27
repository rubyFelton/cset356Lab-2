using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cset356Lab2.Data;
using cset356Lab2.Data.Entities;

namespace cset356Lab2.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult List()
        {
            var users = InMemoryDatabase.Users;

            return View(users);
        }

        [HttpPost]
        public ActionResult Create(Users user)
        {
            user.Id = InMemoryDatabase.NextId();
            InMemoryDatabase.Users.Add(user);

            return RedirectToAction("List");
        }
    }
}