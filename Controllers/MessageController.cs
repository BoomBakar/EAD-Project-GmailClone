using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Models.Interface;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication4.Controllers
{
    public class MessageController : Controller
    {
        IThreadRepo TR;
        public MessageController(IThreadRepo irep)
        {
            TR = irep;
        }
        public ViewResult Inbox(User u,String SenderEmail)
        {
            AllEmails a = new AllEmails();
            if(SenderEmail!=null)
            {
                User u2 = new User();
                u2.Email = SenderEmail;
                a.curUser = u2;
            }
            else 
            {
                a.curUser = u;
            }
            
            
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
        public IActionResult CreateReply(int threadId,String SenderEmail,String RecieverEmail,String msg)
        {
            Message m = new Message();
            m.ThreadId = threadId;
            m.SenderEmail = SenderEmail;
            m.ReceiverEmail = RecieverEmail;
            m.Msg = msg;

            TR.AddMessage(m);
            return Json("success");
        }
        public PartialViewResult LiveTagSearch(string search)
        {
            var res = TR.search(search);


            // Pass the List of results to a Partial View 
            return PartialView(res);
        }
    }
}
