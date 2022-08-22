using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
namespace WebApplication4.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Compose(User u)
        {
            return View(u);
        }
    }
}
