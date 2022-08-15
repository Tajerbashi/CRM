using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEE;
using System.Data;

namespace BLL
{
    public class ReminderBLL
    {
        ReminderDAL DAL = new ReminderDAL();
        public bool Create(Reminder reminder,User u)
        {
            return DAL.Create(reminder,u);
        }
        public DataTable Read()
        {
            return (DAL.Read());
        }
        public Reminder ReadByID(int ID)
        {
            return ReadByID(ID);
        }
        public DataTable ReadSearch(string s)
        {
            return (DAL.ReadSearch(s));
        }

        public bool Update(Reminder reminder, int ID)
        {
            return DAL.Update(reminder,ID);
        }

        public void Delete(int ID)
        {
            DAL.Delete(ID);
        }
        public void IsDone(int ID)
        {
            DAL.IsDone(ID);
        }
    }
}
