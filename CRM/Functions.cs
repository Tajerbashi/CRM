using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Windows.Controls.Primitives;
using TextBoxBase = System.Windows.Forms.TextBoxBase;
using Control = System.Windows.Controls.Control;

//"#,0"
namespace CRM
{
    public class Functions
    {
        public string GetPersianDate(DateTime date)
        {
            System.Globalization.PersianCalendar jc = new System.Globalization.PersianCalendar();
            int hr = int.Parse(jc.GetHour(date).ToString()) > 12 ? int.Parse(jc.GetHour(date).ToString()) - 12 : int.Parse(jc.GetHour(date).ToString());
            return string.Format("{0:0000}/{1:00}/{2:00}  {3:00}:{4:00}:{5:00}  ", jc.GetYear(date), jc.GetMonth(date), jc.GetDayOfMonth(date), hr, jc.GetMinute(date), jc.GetSecond(date));
        }
        public String CLOCK()
        {
            string ToDayShamsiDate = GetPersianDate(DateTime.Now);

            return ToDayShamsiDate;
        }

        public String ChangeToEnglishNumber(String input)
        {
            String EnglishNumbers = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    EnglishNumbers += char.GetNumericValue(input, i);
                }
                else
                {
                    EnglishNumbers += input[i].ToString();
                }
            }
            return EnglishNumbers;
        }
        public String ChangeToPersionNumber(String englishNumber)
        {
            String Result = "";
            foreach (char ch in englishNumber)
            {
                Result += (char)(1776 + char.GetNumericValue(ch));
            }
            return Result;
        }
        public String toArabicNumber(String input)
        {
            var arabic = new String[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };
            for (int j = 0; j < arabic.Length; j++)
            {
                input = input.Replace(j.ToString(), arabic[j]);
            }
            return input;
        }

    }
}
