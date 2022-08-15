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
    public class ReminderDAL
    {
        DB_Class DB = new DB_Class();

        public bool Create(Reminder reminder,User u)
        {
            reminder.Users = DB.users.Find(u.ID);
            DB.reminders.Add(reminder);
            DB.SaveChanges();
            return true;
        }
        public DataTable Read()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRMDB;Integrated Security=true");
            SqlCommand com = new SqlCommand("dbo.ReadReminder");
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;

            var sqladapter = new SqlDataAdapter();
            sqladapter.SelectCommand = com;
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public Reminder ReadByID(int ID)
        {
            Reminder reminder = DB.reminders.Find(ID);
            return reminder;
        }
        public DataTable ReadSearch(string s)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRMDB;Integrated Security=true");
            SqlCommand com = new SqlCommand("dbo.SearchReminder");
            com.Parameters.AddWithValue("@SEARCH", s);
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;

            var sqladapter = new SqlDataAdapter();
            sqladapter.SelectCommand = com;
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public bool Update(Reminder reminder,int ID)
        {
            var q = DB.reminders.Where(c => c.ID == ID).SingleOrDefault();
            if (q != null)
            {
                q.ReminderDate = reminder.ReminderDate;
                q.ReminderInfo = reminder.ReminderInfo;
                q.Title= reminder.Title;
                DB.SaveChanges();
                return true;
            }   
            return false;
        }
        
        public void Delete(int ID)
        {
            var q = DB.reminders.Where(c => c.ID == ID).SingleOrDefault();
            q.DeleteStatus = true;
            DB.SaveChanges();
        }
        public void IsDone(int ID)
        {
            var q = DB.reminders.Where(c => c.ID == ID).SingleOrDefault();
            q.IsDone = true;
            DB.SaveChanges();
        }
    }
}
