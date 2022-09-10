using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Models.Interface;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        IUserRepo userRep;
        public HomeController(IUserRepo usrR)
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
            u.isActive = userRep.isBlocked(u);
            if (!u.isActive)
            {
                ViewBag.verify = true;
                return View("SignIn", u);
            }
            else if (userRep.verifyUser(u))
            {
                ViewBag.verify = true;
                return RedirectToAction("Inbox","Message", u);     // go to inbox if user entered right credentials
            }        
            else
            {
                ViewBag.verify = false;
                return View("SignIn", u);              // else go back to sign in and show wrong credentials 
            }

        }
        public PartialViewResult Reply()
        {
            return PartialView("Reply");
        }
        //[HttpPost]
        //public JsonResult ValidateUser(string userid, string password)
        //{
        //    User u = new User();
        //    u.Name = userid;
        //    u.Password = password;

        //    if (UserRepo.verifyUser(u))
        //        return Json(new { Success = true }, System.Web.Mvc.JsonRequestBehavior.AllowGet);
        //    else
        //        return Json(new { Success = false }, System.Web.Mvc.JsonRequestBehavior.AllowGet);
        //}

        [HttpGet]   //Sign up for get request
        public ViewResult SignUp()
        {
            ViewBag.unique = true;
            return View();
        }
        [HttpPost]  //Sign up for post request
        public ViewResult SignUp(User u)
        {
            ViewBag.unique = true;

            if (ModelState.IsValid)
            {
                if (userRep.addUser(u)) 
                {
                    ViewBag.unique = true;
                    ViewBag.verify = true;
                    return View("SignIn", u);   //add user if all model validations are fine
                }
                else
                {
                    ViewBag.unique = false;
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        public ViewResult UserList()    //Showing all users in a table as per the assignment
        {
            List<User> list = new List<User>();
            //list = UserRepo.datareaderToList();

            return View();
        }
        //public ViewResult Inbox()
        //{
        //    return View();
        //}
       
        //public ViewResult Sent()
        //{
        //    return View();
        //}
        //public ViewResult MailDetail()
        //{
        //    return View();
        //}

    }
}
