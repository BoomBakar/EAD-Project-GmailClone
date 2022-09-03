using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models.Interface;

namespace WebApplication4.Models
{
    public class ThreadRepository : IThreadRepo
    {
        MailContext db;
        public ThreadRepository()
        {
            db = new MailContext();
        }
        public Thread getThreadInfo(int id)
        {
            return db.Threads.Where(x => x.Id == id).FirstOrDefault();
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
        public AllEmails getAllThreads(User u)
        {
            List<Thread> th= db.Threads.Where(x => x.ReceiverEmail == u.Email).ToList();
            AllEmails al = new AllEmails();
            al.curUser = u;
            foreach (Thread t in th)
            {

                MessageThread mt = new MessageThread();
                mt.thrd = t;
                al.MsgThread.Add(mt);
            }
            return al;
        }
        public AllEmails getAllSentThreads(User u)
        {
            List<Thread> th= db.Threads.Where(x => x.Email == u.Email).ToList();
            AllEmails al = new AllEmails();
            al.curUser = u;
            foreach(Thread t in th)
            {

                MessageThread mt = new MessageThread();
                mt.thrd = t;
                al.MsgThread.Add(mt);
            }
            return al;
        }
        public AllEmails getAllMessages(AllEmails b)
        {
           
            foreach(MessageThread c in b.MsgThread)
            {
                Message temp = new Message();
                temp=db.Messages.Where(x => x.ThreadId == c.thrd.Id).FirstOrDefault();
                c.msg = temp;
            }
            return b;
        }
        public void AddMessage(Message m)
        {
            db.Messages.Add(m);
            m.DateAndTime = DateTime.Now.ToString();
            db.SaveChanges();
        }
        public List<Message> getAllMessages(Thread t)
        {
            List<Message> M = db.Messages.Where(x => x.ThreadId == t.Id).ToList();
            return M;

        }
        public AllEmails getAllSentEmails(AllEmails a)
        {
            a= getAllSentThreads(a.curUser);
            a = getAllMessages(a);
            return a;
        }
        public AllEmails GetallEmails(AllEmails a)
        {
            a = getAllThreads(a.curUser);
            a = getAllMessages(a);
            return a;
        }
    }
}
