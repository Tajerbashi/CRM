using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEE;
using System.Web;

namespace DAL
{
    public class UserDAL
    {

        DB_Class DB=new DB_Class();

        public bool Create(User user)
        {
            var q = DB.users.Where(u => u.Name == user.Name && u.UserName == user.UserName);
            if (q.Count()==0)
            {
                DB.users.Add(user);
                DB.SaveChanges();
                return true;
            }
            return false;
        }
        public DataTable ReadAll()
        {
            string cmd = "SELECT ID AS آیدی, Name AS [نام کامل], UserName AS [نام کاربری], Password AS [رمز کاربری] FROM dbo.Users WHERE (DeleteStatus = 0)";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRMDB;Integrated Security=true");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commondbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);

            return ds.Tables[0];
        }
        
        public User ReadByID(int id)
        {
            return DB.users.Where(c => c.ID == id).FirstOrDefault();
        }
        public User ReadByName(String Name)
        {
            return DB.users.Where(c => c.Name == Name).FirstOrDefault();
        }
        public bool Update(User user, int id)
        {
            var q = DB.users.Where(c => c.ID == id).FirstOrDefault();
            if (q != null)
            {
                q.Name = user.Name;
                q.UserName=user.UserName;
                q.Password = user.Password;
                q.Picture = user.Picture;
                DB.SaveChanges();
                return true;
            }
            return false;
        }
        public void Delete(int id)
        {
            var q = DB.users.Where(c => c.ID == id).FirstOrDefault();
            q.DeleteStatus = true;
            DB.SaveChanges();
        }
        public List<string> ReadUserName()
        {
            return (DB.users.Select( i => i.Name).ToList());
        } 
    }
}
