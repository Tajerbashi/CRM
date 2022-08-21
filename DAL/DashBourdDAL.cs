using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;

namespace DAL
{
    public class DashBourdDAL
    {
        DB_Class DB = new DB_Class();
        
        public String UserReminderCount(User user)
        {
            try
            {
                var q = DB.users.Include("Reminder").Where(i => i.ID == user.ID).FirstOrDefault();
                return q.Reminder.Where(c => c.ReminderDate == DateTime.Now.Date).Count().ToString();
            }
            catch 
            {
                return " ";
            }
        }
        public String CustomerCounts()
        {
            return DB.customers.Count().ToString();
        }
        public String SellCount()
        {
            int Sum = 0;
            foreach (var i in DB.inVoices)
            {
                if (i.RegDate.ToString("yyyy/MM/dd")==DateTime.Now.ToString("yyyy/MM/dd")) Sum++;
            }
            return Sum.ToString();
        }
        public List<Reminder> GetUserReminders(User user)
        {
            return DB.reminders.Include("Users").Where(i => i.Users.ID == user.ID).ToList();
        }
    }
}
