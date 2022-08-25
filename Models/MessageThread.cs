using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class MessageThread
    {
        public Message msg { get; set; }
        public Thread thrd { get; set; }
    }
}
