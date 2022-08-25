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
            MsgThread = new List<MessageThread>();
        }
        public List<MessageThread> MsgThread { get; set; }

        public User curUser { get; set; }
    }
}
