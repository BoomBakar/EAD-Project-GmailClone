using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models.Interface
{
    public interface IUserRepo
    {
        public bool addUser(User u);
        public bool verifyUser(User u);
        public bool uniqueEmail(User us);
    }
}
