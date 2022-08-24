using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class ThreadRepository
    {
        MailContext db;
        public ThreadRepository()
        {
            db = new MailContext();
        }

        public bool AddThread(Thread t,Message m)
        {
            m.DateAndTime = Convert.ToString(DateTime.Now);
            db.Threads.Add(t);
            db.SaveChanges();
            m.ThreadId = t.Id;
            db.Messages.Add(m);
            db.SaveChanges();
            return true;
        }
        public List<Thread> getAllThreads(User u)
        {
            return db.Threads.Where(x => x.ReceiverEmail == u.Email).ToList();
        }
        public List<Message> getAllMessages(List<Thread> b)
        {
            List<Message> m = new List<Message>();
            foreach(Thread c in b)
            {
                Message temp = new Message();
                temp=db.Messages.Where(x => x.ThreadId == c.Id).FirstOrDefault();
                m.Add(temp);
            }
            return m;
        }
        public AllEmails GetallEmails(AllEmails a)
        {
            a.SeparateThread = getAllThreads(a.curUser);
            a.LatestMessage = getAllMessages(a.SeparateThread);
            return a;
        }
    }
}
