using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class Activity
    {
        public Activity()
        {
            RegDate = DateTime.Now;
            DeleteStatus = false;
            ReminderClock = false;
        }

        public int ID { get; set; }
        public String Title { get; set; }
        public String Info { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime ReminderDate { get; set; }
        public bool DeleteStatus { get; set; }
        public bool ReminderClock { get; set; }

        public Customer customer { get; set; }
        public User user { get; set; }
        public ActivityCategory ActivityCategory { get; set; }
    }
}
