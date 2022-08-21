using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;

namespace DAL
{
    public class ReportationDAL
    {
        DB_Class DB=new DB_Class();
        public List<Customer> CustomerReportaionInvoices()
        {
            return DB.customers.Include("InVoices").Where(c => c.DeleteStatus==false).ToList();
        }
        public List<User> UserActivities()
        {
            return DB.users.Include("Activities").Where(c => c.DeleteStatus == false).ToList();
        }
        public List<Product> ProductStock()
        {
            return DB.products.Where(c => c.DeleteStatus == false).ToList();
        }
    }
}
