using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class UserGroup
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public List<UserAccessRole> UserAccessRoles { get; set; } = new List<UserAccessRole>();
    }
}
