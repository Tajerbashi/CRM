using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class Customer
    {
        public Customer()
        {
            DeleteStatus = false;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime RegDate { get; set; }
        public List<InVoice> inVoices { get; set; } = new List<InVoice>();
        public List<Activity> Activities { get; set; } = new List<Activity>();
        public bool DeleteStatus { get; set; } = false;

    }
}
