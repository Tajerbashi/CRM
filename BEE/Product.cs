using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class Product
    {
        public Product()
        {
            DeleteStatus = false;
            RegDate = DateTime.Now;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime RegDate { get; set; }
        public int Stock { get; set; }
        public bool DeleteStatus { get; set; }
        public List<InVoice> InVoices { get; set; }=new List<InVoice>();
    }
}
