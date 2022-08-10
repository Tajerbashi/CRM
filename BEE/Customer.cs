using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime RegDate { get; set; }
        public List<InVoice> inVoices { get; set; }
        public List<Activity> Activities { get; set; } = new List<Activity>();


    }
}
