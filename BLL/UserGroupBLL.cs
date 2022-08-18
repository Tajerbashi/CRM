using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;
using DAL;

namespace BLL
{
    public class UserGroupBLL
    {
        UserGroupDAL DAL = new UserGroupDAL();
        public bool Create(UserGroup userGroup)
        {
            return DAL.Create(userGroup);
        }
    }
}
