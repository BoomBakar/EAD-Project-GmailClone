using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Models.Interface;

namespace WebApplication4.Controllers
{
    public class AdminController : Controller
    {
        IUserRepo userRep;
        public AdminController(IUserRepo usrR)
        {
            userRep = usrR;
        }
        [HttpGet]   //Sign in page for get request
        public ViewResult SignIn()
        {

            User u = new User();
            u.Password = "";
            u.Email = "";
            return View("SignIn", u);
        }
        [HttpPost]  //Sign in page for post request
        public IActionResult SignIn(User u)
        {
            ViewBag.verify = false;

            if (userRep.verifyUser(u))
            {
                ViewBag.verify = true;
                List<User> list = new List<User>();
                list = userRep.GetAllUsers();
                return View("UserList", list);     // go to inbox if user entered right credentials
            }
            else
            {
                ViewBag.verify = false;
                return View("SignIn", u);              // else go back to sign in and show wrong credentials 
            }
        }
        [HttpGet]
        public IActionResult UserList()
        {            
            return View();
        }
        [HttpPost]
        public ViewResult UserList(String Name,String Password, String Email)
        {
            User u = new User();
            u.Name = Name;
            u.Email = Email;
            u.Password = Password;
            userRep.delUser(u);
            List<User> list = new List<User>();
            list = userRep.GetAllUsers();
            return View(list);
        }
        public IActionResult Main()
        {
            return View();
        }
    }
}
