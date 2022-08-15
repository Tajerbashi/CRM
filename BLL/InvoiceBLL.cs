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

        public bool Create(InVoice invoice)
        {
            //  check customer is Not in DB
            if (!dal.ReadForCreate(invoice))
            {
                dal.Create(invoice);
                return true;
            }
            return false;
        }
        public DataTable ReadSearch(String word)
        {
            return dal.ReadSearch(word);
        }

        public DataTable ReadAll()
        {
            return dal.ReadAll();
        }
        public bool Update(InVoice invoice, int id)
        {
            return dal.Update(invoice, id);
        }
        public void Delete(int id)
        {
            dal.Delete(id);
        }

    }
}
