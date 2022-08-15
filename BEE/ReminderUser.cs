using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class ReminderUser
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Reminder Reminder { get; set; }
    }
}
