using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class Activity
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String Info { get; set; }
        public DateTime RegDate { get; set; }
        public Customer customer { get; set; }
        public User user { get; set; }
        public ActivityCategory ActivityCategory { get; set; }
    }
}
