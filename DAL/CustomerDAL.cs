using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BEE;
using System.Data;
namespace DAL
{
    public class CustomerDAL
    {
        DB_Class DB = new DB_Class();
        public bool Create(Customer customer)
        {
            try
            {
                DB.customers.Add(customer);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable ReadAll()
        {
            string cmd = "SELECT ID AS آیدی, Name AS [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ ثبت] FROM dbo.Customers WHERE (DeleteStatus = 0)";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRMDB;Integrated Security=true");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commondbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable ReadSearch(String s)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRMDB;Integrated Security=true");
            SqlCommand com = new SqlCommand("dbo.SearchCustomer");
            com.Parameters.AddWithValue("@search",s);
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;

            var sqladapter = new SqlDataAdapter();
            sqladapter.SelectCommand = com;
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public Customer ReadByID(int id)
        {
            return DB.customers.Where(c => c.ID==id).FirstOrDefault();
        }
        public bool Update(Customer customer,int id)
        {
            var q = DB.customers.Where(c => c.ID == id).FirstOrDefault();
            if (q != null)
            {
                q.Name=customer.Name;
                q.Phone=customer.Phone;
                DB.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            var q=DB.customers.Where(c => c.ID == id).FirstOrDefault();
            q.DeleteStatus = true;
            DB.SaveChanges();
        }
        public bool ReadForCreate(Customer customer)
        {
            var q = DB.customers.Where(c => c.Name == customer.Name && c.Phone == customer.Phone).FirstOrDefault();
            if (q != null)
            {
                return true;
            }
            return false;
        }
    }
}
