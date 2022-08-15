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
    public class ProductBLL
    {
        ProductDAL dal = new ProductDAL();

        public bool Create(Product product)
        {
            //  check customer is Not in DB
            if (!dal.ReadForCreate(product))
            {
                dal.Create(product);
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
        public bool Update(Product product, int id)
        {
            return dal.Update(product, id);
        }
        public void Delete(int id)
        {
            dal.Delete(id);
        }
    }
}
