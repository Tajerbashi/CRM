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
    public class InvoiceDAL
    {
        DB_Class DB = new DB_Class();
        public bool Create(InVoice inVoice,Customer c,User u,List<Product> p)
        {
            try
            {
                inVoice.customer = DB.customers.Find(c.ID);
                inVoice.user = DB.users.Find(u.ID);
                foreach (var i in p)
                {
                    inVoice.products.Add(DB.products.Find(i.ID));
                }
                DB.inVoices.Add(inVoice);
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
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRMDB;Integrated Security=true");
            SqlCommand com = new SqlCommand("dbo.ReadInvoice");
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;

            var sqladapter = new SqlDataAdapter();
            sqladapter.SelectCommand = com;
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable ReadSearch(String s)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRMDB;Integrated Security=true");
            SqlCommand com = new SqlCommand("dbo.SearchInvoice");
            com.Parameters.AddWithValue("@search", s);
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;

            var sqladapter = new SqlDataAdapter();
            sqladapter.SelectCommand = com;
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public InVoice ReadByID(int id)
        {
            return DB.inVoices.Where(c => c.ID == id).FirstOrDefault();
        }
        public bool Update(InVoice inVoice, int id)
        {
            var q = DB.inVoices.Where(c => c.ID == id).FirstOrDefault();
            if (q != null)
            {
                q.InvoiceNumber = inVoice.InvoiceNumber;
                q.CheckOutDate = inVoice.CheckOutDate;
                q.IsCheckout = inVoice.IsCheckout;
                DB.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            var q = DB.inVoices.Where(c => c.ID == id).FirstOrDefault();
            q.DeleteStatus = true;
            DB.SaveChanges();
        }
        public bool ReadForCreate(InVoice inVoice)
        {
            var q = DB.inVoices.Where(c => c.InvoiceNumber == inVoice.InvoiceNumber ).FirstOrDefault();
            if (q != null)
            {
                return true;
            }
            return false;
        }
        
        public int lastFactorNumber()
        {
            int q=DB.inVoices.Count();
            if (q>0)
            {
                var N = DB.inVoices.Select(c => c.InvoiceNumber).Max();
                return N + 1;
            }
            return 10001;
        }
        public void ChangeCheckIsDone(int ID)
        {
            var q = DB.inVoices.Where(c => c.ID == ID).FirstOrDefault();
            q.CheckOutDate = DateTime.Now;
            q.IsCheckout = true;
            DB.SaveChanges();
        }

    }
}
