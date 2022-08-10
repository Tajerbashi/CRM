using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEE;
using System.Globalization;

namespace BLL
{
    public class Functions
    {
        public static string ConvertToPersian(DateTime date)
        {
            PersianCalendar g = new PersianCalendar();
            String Shift = "0";
            if (g.GetHour(date) < 12)
            {
                Shift = "AM";
            }
            else
            {
                Shift = "PM";
            }

            return string.Format("{0}:{1}:{2} {3}", g.GetHour(date), g.GetMinute(date), g.GetSecond(date),Shift);
        }

        public static DateTime ConvertToMiladi(string date)
        {
            string[] d = new string[3];
            d = date.Split('/');
            PersianCalendar g = new PersianCalendar();
            return g.ToDateTime(int.Parse(d[0]), int.Parse(d[1]), int.Parse(d[2]), 8, 0, 0, 0);//1392/05/10
        }

        public static PersianCalendar converttopersian(DateTime date)
        {
            PersianCalendar g = new PersianCalendar();
            return g;
        }
    }
}
