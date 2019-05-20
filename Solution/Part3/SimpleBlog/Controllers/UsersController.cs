using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            /*UsersModel user = new UsersModel();
            int age = 10 / user.age;*/
            return View();
        }

        public ActionResult ListUsers() {

            List<UsersModel> users = new List<UsersModel>();
            users.Add(new UsersModel("Tom", "Jerky", 22, false));
            users.Add(new UsersModel("Mickle", "Jerky", 25, false));
            users.Add(new UsersModel("John", "Marley", 31, true));
            users.Add(new UsersModel("Alex", "Jerky", 12, false));

            return View(users);
        }
    }
}