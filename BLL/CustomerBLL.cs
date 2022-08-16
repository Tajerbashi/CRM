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
    public class CustomerBLL
    {
        CustomerDAL dal = new CustomerDAL();

        public bool Create(Customer customer)
        {
            //  check customer is Not in DB
            if (!dal.ReadForCreate(customer))
            {
                dal.Create(customer);
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
        public Customer ReadByPhone(String Phone)
        {
            return dal.ReadByPhone(Phone);

        }
        public bool Update(Customer customer, int id)
        {
            return dal.Update(customer, id);
        }
        public void Delete(int id)
        {
            dal.Delete(id);
        }
        public List<string> ReadCustomerByPhone()
        {
            return (dal.ReadCustomerByPhone()).ToList();
        }
    }
}
