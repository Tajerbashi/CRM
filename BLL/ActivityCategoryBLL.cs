using BEE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ActivityCategoryBLL
    {
        ActivityCategoryDAL dal = new ActivityCategoryDAL();
        public bool Create(ActivityCategory ActCat)
        {
            return dal.Create(ActCat);
        }

        public DataTable ReadAll()
        {
            return dal.ReadAll();
        }

        public void Delete(int id)
        {
            dal.Delete(id);
        }

        public ActivityCategory GetActivityCategory(int ID)
        {
            return dal.GetActivityCategory(ID);
        }
        public bool Update(ActivityCategory AcCa, int id)
        {
            return dal.Update(AcCa,id);
        }
        public List<string> ReadActivityByName()
        {
            return (dal.ReadActivityByName()).ToList();
        }
        public ActivityCategory ReadByName(String name)
        {
            return dal.ReadByName(name);
        }
    }
}
