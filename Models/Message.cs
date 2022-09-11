using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication4.Models
{
    public partial class Message : Entity
    {
        public int Id { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverEmail { get; set; }
        public string Msg { get; set; }
        public string DateAndTime { get; set; }
        public int ThreadId { get; set; }
        public new string CreatedByUser { get; set; }
        public new DateTimeOffset CreatedDate { get; set; }
        public new string ModifiedByUser { get; set; }
        public new DateTimeOffset ModifiedDate { get; set; }
        public virtual User ReceiverEmailNavigation { get; set; }
        public virtual User SenderEmailNavigation { get; set; }
        public virtual Thread Thread { get; set; }
    }
}
