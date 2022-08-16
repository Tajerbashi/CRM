using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BEE;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class ActivityBLL
    {
        ActivityDAL DAL = new ActivityDAL();
        public bool Create(Activity activity, Customer c, User u, ActivityCategory ac)
        {
            return DAL.Create(activity, c, u, ac);
        }
        public DataTable ReadAll()
        {
            return DAL.ReadAll();
        }
        public DataTable ReadSearch(String s)
        {
            return DAL.ReadSearch(s);
        }
        public Activity ReadByID(int id)
        {
            return DAL.ReadByID(id);
        }
        public bool Update(Activity activity, int id)
        {
            return DAL.Update(activity, id);
        }
        public void Delete(int id)
        {
            DAL.Delete(id);
        }
       
    }
}
