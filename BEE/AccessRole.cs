using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class AccessRole
    {
        public AccessRole()
        {
            CanCreate = false;
            CanDelete = false;
            CanEdition = false;
            CanUpdate = false;
        }
        public int ID { get; set; }
        public String Section { get; set; }
        public bool CanEdition { get; set; }
        public bool CanCreate { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public UserGroup UserGroup { get; set; }
    }
}
