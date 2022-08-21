using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEE;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class ReportationBLL
    {
        ReportationDAL DAL = new ReportationDAL();
        public List<Customer> CustomerReportaionInvoices()
        {
            return DAL.CustomerReportaionInvoices();
        }
        public List<User> UserActivities()
        {
            return DAL.UserActivities();
        }
        public List<Product> ProductStock()
        {
            return DAL.ProductStock();
        }
    }
}
