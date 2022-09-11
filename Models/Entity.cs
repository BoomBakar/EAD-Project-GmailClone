using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Entity
    {
        public string CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedByUser { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
