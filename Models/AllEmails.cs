using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class AllEmails
    {
        public  AllEmails()
        {
            LatestMessage = new List<Message>();
            SeparateThread = new List<Thread>();
        }
        public List<Message> LatestMessage { get; set; }
        public List<Thread> SeparateThread { get; set; }

        public User curUser { get; set; }
    }
}
