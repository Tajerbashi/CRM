using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class ActivityCategory
    {
        public ActivityCategory()
        {
            DeleteStatus = false;
        }
        public int ID { get; set; }
        public String CategoryName { get; set; }
        public bool DeleteStatus { get; set; }
        public List<Activity> Activities { get; set; }=new List<Activity>();
    }
}
