using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEE;

namespace BLL
{
    public class PROCDURE_BLL
    {
        PROCDURE_DAL DAL = new PROCDURE_DAL();
        public void Procedure()
        {
            DAL.Procedure();
        }
    }
}
