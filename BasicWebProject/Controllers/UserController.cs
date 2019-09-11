using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicWebProject.Models;

namespace BasicWebProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.Users.Add(user);
                dataContext.SaveChanges();
            }
            return View("Add");
        }
        public IActionResult List()
        {
            List<Models.User> UserList;
            using (DataContext dataContext = new DataContext())
            {
                UserList = dataContext.Users.Select(a => a).ToList();
            }
            return View(UserList);
        }
    }
}