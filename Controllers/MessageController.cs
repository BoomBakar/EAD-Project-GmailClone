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
        public ViewResult Inbox(User u)
        {
            AllEmails a = new AllEmails();
            a.curUser = u;

            a=TR.GetallEmails(a);
            return View(a);
        }

        public ViewResult Sent(User u)
        {
            AllEmails a = new AllEmails();
            a.curUser = u;

            a = TR.GetallEmails(a);
            return View(a);
        }
        public ViewResult MailDetail()
        {
            return View();
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
            t.ReceiverEmail = To;
            Message m = new Message();
            m.SenderEmail = SenderEmail;
            m.ReceiverEmail = To;
            m.Msg = Body;
            TR.AddThread(t, m);
            return Json("success");
        }
    }
}
