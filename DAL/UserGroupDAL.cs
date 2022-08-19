using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;

namespace DAL
{
    public class UserGroupDAL
    {
        DB_Class DB = new DB_Class();
        public bool Create(UserGroup userGroup)
        {
            try
            {
                if (Readtitle(userGroup.Title))
                {
                    DB.userGroups.Add(userGroup);
                    DB.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }
        public bool Readtitle(String title)
        {
            var q = DB.userGroups.Where(c => c.Title == title).FirstOrDefault();
            if (q!=null)
            {
                return false;
            }
            return true;
        }
        public List<String> Readtitles()
        {
            return DB.userGroups.Select(c => c.Title).ToList();
        }
        public DataTable Read()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRMDB;Integrated Security=true");
            SqlCommand com = new SqlCommand("dbo.ReadUserGroup");
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;

            var sqladapter = new SqlDataAdapter();
            sqladapter.SelectCommand = com;
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
    }
}
