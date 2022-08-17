using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;

namespace DAL
{
    public class UserGroupDAL
    {
        DB_Class DB = new DB_Class();
        public bool Create(UserGroup userGroup)
        {
            DB.userGroups.Add(userGroup);
            return true;
        }
    }
}
