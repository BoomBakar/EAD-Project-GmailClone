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
        ThreadRepository TR;
        public MessageController()
        {
            TR = new ThreadRepository();
        }
        public IActionResult Compose(User u)
        {
            return View(u);
        }
        public IActionResult CreateThread(String To,String Subject,String Body,String SenderEmail)
        {
            Thread t = new Thread();
            t.Subject = Subject;
            t.Email = SenderEmail;

            Message m = new Message();
            m.SenderEmail = SenderEmail;
            m.ReceiverEmail = To;
            m.Msg = Body;
            TR.AddThread(t, m);
            return Json("success");
        }
    }
}
