using Microsoft.AspNetCore.Http;
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
                    string data = String.Empty;
                    if (HttpContext.Request.Cookies.ContainsKey("User"))
                    {
                        string firstVisitedDateTime = HttpContext.Request.Cookies["User"];
                        data = "Already Exists " + firstVisitedDateTime;

                    }
                    else
                    {
                        CookieOptions option = new CookieOptions();
                        option.Expires = System.DateTime.Now.AddDays(365);
                        HttpContext.Response.Cookies.Append("User", u.Email, option);
                    }
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
        
       
    }
}
