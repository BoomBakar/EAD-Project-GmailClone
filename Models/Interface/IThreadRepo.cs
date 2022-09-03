using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models.Interface
{
    public interface IThreadRepo
    {
        public Thread getThreadInfo(int id);
        public bool AddThread(Thread t, Message m);
        public AllEmails getAllThreads(User u);
        public AllEmails getAllSentThreads(User u);
        public AllEmails getAllMessages(AllEmails b);
        public List<Message> getAllMessages(Thread t);
        public AllEmails getAllSentEmails(AllEmails a);
        public AllEmails GetallEmails(AllEmails a);
        public void AddMessage(Message m);
    }
}
