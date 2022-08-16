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
    public class ActivityCategoryDAL
    {
        DB_Class DB = new DB_Class();

        public bool Create(ActivityCategory ActCat)
        {
            try
            {
                DB.activityCategories.Add(ActCat);
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
            string cmd = "SELECT ID AS آیدی, CategoryName AS [نام فعالیت] FROM dbo.ActivityCategories WHERE (DeleteStatus = 0)";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRMDB;Integrated Security=true");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commondbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);

            return ds.Tables[0];
        }

        public bool Delete(int id)
        {
            var q = DB.activityCategories.Where(c => c.ID == id).FirstOrDefault();
            q.DeleteStatus = true;
            DB.SaveChanges();
            return true;
        }

        public ActivityCategory GetActivityCategory(int ID)
        {
            return DB.activityCategories.Where(c => c.ID==ID).FirstOrDefault();
        }
        public bool Update(ActivityCategory AcCa,int id)
        {
            var q = DB.activityCategories.Where(c => c.ID == id).FirstOrDefault();
            q.CategoryName=AcCa.CategoryName;
            DB.SaveChanges();
            return true;
        }

        public List<string> ReadActivityByName()
        {
            return (DB.activityCategories.Select(i => i.CategoryName).ToList());
        }
        public ActivityCategory ReadByName(String name)
        {
            return DB.activityCategories.Where(c => c.CategoryName.Equals(name)).FirstOrDefault();
        }

    }

}
