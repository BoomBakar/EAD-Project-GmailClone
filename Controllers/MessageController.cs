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

        public ViewResult Sent(String SenderEmail)
        {
            AllEmails a = new AllEmails();
            User u = new User();
            u.Email = SenderEmail;
            a.curUser = u;

            a = TR.getAllSentEmails(a);
            return View(a);
        }
        public ViewResult MailDetail(MessageThread MessageThreadValue,String CurUserEmail)
        {
            MailDetailMessages m = new MailDetailMessages();
            m.Thrd = new Thread();
            m.Thrd.Id = MessageThreadValue.thrd.Id;
            User U = new User();
            U.Email = CurUserEmail;
            m.curUser = U;
            m.allMessages= TR.getAllMessages(m.Thrd);
            m.Thrd = TR.getThreadInfo(m.Thrd.Id);
            return View(m);
        }
        public IActionResult Compose(String SenderEmail)
        {
            User u = new User();
            u.Email = SenderEmail;
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
