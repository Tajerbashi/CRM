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
    public class ActivityDAL
    {
        DB_Class DB = new DB_Class();
        public bool Create(Activity activity,Customer c,User u, ActivityCategory ac)
        {
            try
            {
                activity.customer = DB.customers.Find(c.ID);
                activity.user = DB.users.Find(u.ID);
                activity.ActivityCategory = DB.activityCategories.Find(ac.ID);

                DB.activities.Add(activity);
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
            SqlCommand com = new SqlCommand("dbo.ReadActivity");
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
            SqlCommand com = new SqlCommand("dbo.SearchActivity");
            com.Parameters.AddWithValue("@Search", s);
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;

            var sqladapter = new SqlDataAdapter();
            sqladapter.SelectCommand = com;
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public Activity ReadByID(int id)
        {
            return DB.activities.Where(c => c.ID == id).FirstOrDefault();
        }
        public bool Update(Activity activity, int id)
        {
            var q = DB.activities.Where(c => c.ID == id).FirstOrDefault();
            if (q != null)
            {
                q.Title = activity.Title;
                q.Info = activity.Info;
                DB.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            var q = DB.activities.Where(c => c.ID == id).FirstOrDefault();
            q.DeleteStatus = true;
            DB.SaveChanges();
        }
        public void ChangeStatus(int id)
        {
            var q = DB.activities.Where(c => c.ID == id).FirstOrDefault();
            if (q.ReminderClock)
            {
                q.ReminderClock = false;
            }
            else
            {
                q.ReminderClock = true;
            }
            q.DeleteStatus = true;
            DB.SaveChanges();
        }

    }
}
