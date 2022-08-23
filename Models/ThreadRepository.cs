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
            return true;
        }
    }
}
