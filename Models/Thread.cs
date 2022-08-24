using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication4.Models
{
    public partial class Thread
    {
        public Thread()
        {
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string ReceiverEmail { get; set; }

        public virtual User EmailNavigation { get; set; }
        public virtual User ReceiverEmailNavigation { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
