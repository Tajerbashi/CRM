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

        public bool Create(User user,String NameUG)
        {
            UserGroup user1=DB.userGroups.Where( c=> c.Title==NameUG).FirstOrDefault();
            user.UserGroup=user1;
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
        public User ReadByUserName(String user)
        {
            return DB.users.Where(c => c.UserName == user).FirstOrDefault();
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
        public bool Delete(int id)
        {
            try
            {
                if (id>0)
                {
                    var q = DB.users.Where(c => c.ID == id).FirstOrDefault();
                    q.DeleteStatus = true;
                    DB.SaveChanges();
                    return true;
                }
                return false;
            }
            catch 
            {
                return false;
            }

        }
        public List<string> ReadUserbyName()
        {
            return (DB.users.Select(i => i.Name).ToList());
        }
        public List<string> ReadUserbyUserName()
        {
            return (DB.users.Select(i => i.UserName).ToList());
        }
        public bool IsAdmin()
        {
            return DB.users.Count() > 0;
        }
        public User IsLogin(String username,String pass)
        {
            return DB.users.Include("UserGroup").Where(c => c.UserName ==username && c.Password==pass && c.Status && !c.DeleteStatus).FirstOrDefault();
        }

        public bool Access(User user,String S,int a)
        {
            //  1 Can Enter            //  2 Can Create            //  3 Can Update            //  4 Can Delete
            UserGroup ug = DB.userGroups.Include("UserAccessRoles").Where(i => i.ID == user.UserGroup.ID).FirstOrDefault();
            UserAccessRole uar=ug.UserAccessRoles.Where(z => z.Section==S).FirstOrDefault();
            switch (a)
            {
                case 1:
                    {
                        return uar.CanEnter; 
                    }
                case 2:
                    {
                        return uar.CanCreate;
                    }
                case 3:
                    {
                        return uar.CanUpdate;
                    }
                case 4:
                    {
                        return uar.CanDelete;
                    }
            }
            return false;
        }

        public List<User> ReadUserInvoiceReport()
        {
            return DB.users.Include("InVoices").Where(i => i.DeleteStatus == false).ToList();
        }
    }
}
