using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEE;

namespace BLL
{
    public class DashBourdBLL
    {
        DashBourdDAL DAL = new DashBourdDAL();
        public String UserReminderCount(User user)
        {
           return DAL.UserReminderCount(user);
        }
        public String CustomerCounts()
        {
            return DAL.CustomerCounts();
        }
        public String SellCount()
        {
            return DAL.SellCount();
        }
        public List<Reminder> GetUserReminders(User user)
        {
            return DAL.GetUserReminders(user).ToList();
        }
    }
}
