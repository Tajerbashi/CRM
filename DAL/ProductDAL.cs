using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProductDAL
    {
        DB_Class DB = new DB_Class();
        public bool Create(Product product)
        {
            try
            {
                DB.products.Add(product);
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
            string cmd = "SELECT ID AS آیدی, Name AS [نام محصول], Price AS [قیمت محصول], Stock AS موجودی FROM dbo.Products WHERE (DeleteStatus = 0)";
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
            SqlCommand com = new SqlCommand("dbo.SearchProduct");
            com.Parameters.AddWithValue("@Search", s);
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;

            var sqladapter = new SqlDataAdapter();
            sqladapter.SelectCommand = com;
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public Product ReadByID(int id)
        {
            return DB.products.Where(c => c.ID == id).FirstOrDefault();
        }
        public bool Update(Product product, int id)
        {
            var q = DB.products.Where(c => c.ID == id).FirstOrDefault();
            if (q != null)
            {
                q.Name = product.Name;
                q.Price = product.Price;
                q.Stock = product.Stock;
                DB.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            var q = DB.products.Where(c => c.ID == id).FirstOrDefault();
            q.DeleteStatus = true;
            DB.SaveChanges();
        }
        public bool ReadForCreate(Product product)
        {
            var q = DB.customers.Where(c => c.Name == product.Name).FirstOrDefault();
            if (q != null)
            {
                return true;
            }
            return false;
        }
    
    }
}
