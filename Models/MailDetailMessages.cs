using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class MailDetailMessages
    {
        public MailDetailMessages()
        {
            allMessages = new List<Message>();
        }
        public Thread Thrd { get; set; }
        public User curUser { get; set; }
        public List<Message> allMessages { get; set; }
    }
}
