using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication4.Models
{
    public partial class Thread : Entity
    {
        public Thread()
        {
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string ReceiverEmail { get; set; }
        public new string CreatedByUser { get; set; }
        public new DateTimeOffset CreatedDate { get; set; }
        public new string ModifiedByUser { get; set; }
        public new DateTimeOffset ModifiedDate { get; set; }
        public virtual User EmailNavigation { get; set; }
        public virtual User ReceiverEmailNavigation { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
