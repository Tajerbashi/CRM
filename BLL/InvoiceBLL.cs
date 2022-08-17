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
    public class InvoiceBLL
    {
        InvoiceDAL dal = new InvoiceDAL();

        public bool Create(InVoice inVoice, Customer c, User u, List<Product> p)
        {
            return dal.Create(inVoice, c, u, p);
        }
        public DataTable ReadAll()
        {
            return dal.ReadAll();
        }
        public DataTable ReadSearch(String s)
        {
            return dal.ReadSearch(s);
        }
        public InVoice ReadByID(int id)
        {
            return dal.ReadByID(id);
        }
        public bool Update(InVoice inVoice, int id)
        {
            return dal.Update(inVoice, id);
        }
        public void Delete(int id)
        {
            dal.Delete(id);
        }
        public bool ReadForCreate(InVoice inVoice)
        {
            return dal.ReadForCreate(inVoice);
        }

        public int lastFactorNumber()
        {
            return dal.lastFactorNumber();
        }

        public void ChangeCheckIsDone(int ID)
        {
            dal.ChangeCheckIsDone(ID);
        }


    }
}
