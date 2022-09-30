using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Identity : IdentityUser
    {
        public string Name { get; set; }
        public bool isActive { get; set; }
    }
}
