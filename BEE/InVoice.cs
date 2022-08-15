using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class InVoice
    {
        public InVoice()
        {
            DeleteStatus = false;
        }
        public int ID { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool IsCheckout { get; set; } = false;
        public Customer customer { get; set; }
        public User user { get; set; }
        public List<Product> products { get; set; } = new List<Product>();
        public bool DeleteStatus { get; set; } = false;

    }
}
