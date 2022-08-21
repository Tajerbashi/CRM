using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEE;


namespace DAL
{
    public class PROCDURE_DAL
    {
        public void Procedure()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CRMDB;Integrated Security=true");
            SqlCommand Com = new SqlCommand();
            Com.Connection = con;

            string ReadActivityRead = "Create PROCEDURE [dbo].[ReadActivity] AS BEGIN SELECT dbo.Activities.ID AS آیدی, dbo.Activities.Title AS [موضوع فعالیت], dbo.ActivityCategories.CategoryName AS [دسته بندی], dbo.Customers.Name AS [نام مشتری], dbo.Users.Name AS [نام کاربر], dbo.Activities.ReminderDate AS [تاریخ ثبت] FROM dbo.Activities INNER JOIN dbo.ActivityCategories ON dbo.Activities.ActivityCategory_ID = dbo.ActivityCategories.ID INNER JOIN dbo.Customers ON dbo.Activities.customer_ID = dbo.Customers.ID INNER JOIN dbo.Users ON dbo.Activities.user_ID = dbo.Users.ID WHERE (dbo.Activities.DeleteStatus = 0) END";
            string ReadInvoice = "CREATE PROCEDURE[dbo].[ReadInvoice] AS BEGIN SELECT dbo.InVoices.ID AS آیدی, dbo.Users.Name AS[نام کاربر], dbo.InVoices.InvoiceNumber AS[شماره فاکتور], dbo.InVoices.RegDate AS[تاریخ ثبت], dbo.Customers.Name AS[نام مشتری], dbo.Customers.Phone AS[شماره تماس], dbo.InVoices.CheckOutDate AS[تاریخ فاکتور], dbo.InVoices.inVoicePrice AS[جمع فاکتور], dbo.InVoices.IsCheckout AS وضعیت FROM dbo.InVoices INNER JOIN dbo.Users ON dbo.InVoices.user_ID = dbo.Users.ID INNER JOIN dbo.Customers ON dbo.InVoices.customer_ID = dbo.Customers.ID WHERE(dbo.InVoices.DeleteStatus = 0) END";
            string ReadReminders = "CREATE PROCEDURE[dbo].[ReadReminders] AS BEGIN SELECT dbo.Reminders.ID AS آیدی, dbo.Users.UserName AS[نام کاربری], dbo.Users.Name AS[نام کامل], dbo.Reminders.Title AS[عنوان یادآور], dbo.Reminders.ReminderInfo AS[توضیحات یادآور], dbo.Reminders.ReminderDate AS[تاریخ یادآور], dbo.Reminders.IsDone AS وضعیت FROM dbo.Reminders INNER JOIN dbo.Users ON dbo.Reminders.Users_ID = dbo.Users.ID WHERE(dbo.Reminders.DeleteStatus = 0) AND(dbo.Users.DeleteStatus = 0) END";
            string ReadUserGroup = "CREATE PROCEDURE [dbo].[ReadUserGroup] AS BEGIN SELECT TOP (100) PERCENT dbo.UserGroups.ID AS آیدی, dbo.UserGroups.Title AS عنوان, dbo.UserAccessRoles.Section AS بخش, dbo.UserAccessRoles.CanCreate AS [اضافه کردن], dbo.UserAccessRoles.CanEnter AS [وارد شدن],  dbo.UserAccessRoles.CanDelete AS [حذف کردن], dbo.UserAccessRoles.CanUpdate AS [ویرایش کردن] FROM dbo.UserGroups INNER JOIN dbo.UserAccessRoles ON dbo.UserGroups.ID = dbo.UserAccessRoles.UserGroup_ID ORDER BY عنوان END ";


            string SearchActivity = "CREATE PROCEDURE[dbo].[SearchActivity] @SEARCH nvarchar(max) AS BEGIN SELECT dbo.Activities.ID AS آیدی, dbo.Activities.Title AS عنوان, dbo.Activities.ReminderDate AS[تاریخ  یادآوری], dbo.Activities.ReminderClock AS یادآوری, dbo.ActivityCategories.CategoryName AS[نوع فعالیت], dbo.Customers.Name AS[نام مشتری], dbo.Users.Name AS[نام کاربر] FROM dbo.Activities INNER JOIN dbo.ActivityCategories ON dbo.Activities.ActivityCategory_ID = dbo.ActivityCategories.ID INNER JOIN dbo.Customers ON dbo.Activities.customer_ID = dbo.Customers.ID INNER JOIN dbo.Users ON dbo.Activities.user_ID = dbo.Users.ID WHERE(dbo.Activities.DeleteStatus = 0) AND((dbo.Activities.Title like '%' + @SEARCH + '%') OR(dbo.Customers.Name like '%' + @SEARCH + '%') OR(dbo.Users.Name like '%' + @SEARCH + '%') OR(dbo.ActivityCategories.CategoryName like '%' + @SEARCH + '%'))END";
            string SearchCustomer = "CREATE PROCEDURE [dbo].[SearchCustomer]\t@Search nvarchar(max) AS BEGIN SELECT Name AS [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ ثبت] FROM dbo.Customers WHERE (DeleteStatus = 0) AND (Name like '%'+@Search+'%') OR (Phone like '%'+@Search+'%') END";
            string SearchInvoice = "CREATE PROCEDURE [dbo].[SearchInvoice] @SEARCH nvarchar(max) AS BEGIN SELECT dbo.InVoices.ID AS آیدی, dbo.Users.Name AS [نام کاربر], dbo.InVoices.InvoiceNumber AS [شماره فاکتور], dbo.InVoices.RegDate AS [تاریخ ثبت], dbo.Customers.Name AS [نام مشتری], dbo.Customers.Phone AS [شماره تماس],  dbo.InVoices.CheckOutDate AS [تاریخ فاکتور], dbo.InVoices.inVoicePrice AS [جمع فاکتور], dbo.InVoices.IsCheckout AS وضعیت FROM dbo.InVoices INNER JOIN  dbo.Users ON dbo.InVoices.user_ID = dbo.Users.ID INNER JOIN dbo.Customers ON dbo.InVoices.customer_ID = dbo.Customers.ID WHERE (dbo.InVoices.DeleteStatus = 0) AND  (dbo.Users.Name like '%'+@SEARCH+'%') OR (dbo.InVoices.InvoiceNumber like '%'+@SEARCH+'%') OR (dbo.InVoices.RegDate like '%'+@SEARCH+'%') OR (dbo.Customers.Name like '%'+@SEARCH+'%') OR  (dbo.Customers.Phone like '%'+@SEARCH+'%') OR  (dbo.InVoices.CheckOutDate like '%'+@SEARCH+'%') END";
            string SearchProduct = "CREATE PROCEDURE [dbo].[SearchProduct] @Search nvarchar(max) AS BEGIN SELECT Name AS [نام محصول], Price AS [قیمت محصول], Stock AS موجودی FROM dbo.Products WHERE (Name like '%'+@Search+'%') AND (DeleteStatus = 0) OR (Stock like '%'+@Search+'%') END";
            string SearchReminder = "CREATE PROCEDURE  [dbo].[SearchReminder] @SEARCH Nvarchar(max) AS BEGIN SELECT dbo.Reminders.ID AS [آیدی], dbo.Users.UserName AS [نام کاربری], dbo.Users.Name AS [نام کامل], dbo.Reminders.Title AS [عنوان یادآور], dbo.Reminders.ReminderInfo AS [توضیحات یادآور], dbo.Reminders.ReminderDate AS [تاریخ یادآور],  dbo.Reminders.IsDone AS وضعیت FROM dbo.Reminders INNER JOIN  dbo.Users ON dbo.Reminders.Users_ID = dbo.Users.ID WHERE ((dbo.Users.DeleteStatus = 0) AND (dbo.Reminders.DeleteStatus = 0)) AND  (  (dbo.Users.Name like '%'+@SEARCH+'%') OR (dbo.Reminders.Title like '%'+@SEARCH+'%') OR (dbo.Reminders.ReminderDate like '%'+@SEARCH+'%') OR (dbo.Reminders.IsDone like '%'+@SEARCH+'%')  ) END";

            String CustomerReports = "CREATE PROCEDURE CustomerReports AS BEGIN SELECT Name AS [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ ثبت سیستم] FROM dbo.Customers WHERE (DeleteStatus = 0) END";
            String ActivityReports = "CREATE PROCEDURE ActivityReports AS BEGIN SELECT dbo.Users.Name AS [نام کاربر], dbo.Activities.Title AS عنوان, dbo.ActivityCategories.CategoryName AS فعالیت, dbo.Activities.Info AS توضیحات, dbo.Activities.RegDate AS [تاریخ ثبت], dbo.Activities.ReminderDate AS [تاریخ یادآور] FROM dbo.Users INNER JOIN  dbo.Activities ON dbo.Users.ID = dbo.Activities.user_ID INNER JOIN  dbo.ActivityCategories ON dbo.Activities.ActivityCategory_ID = dbo.ActivityCategories.ID WHERE (dbo.Users.DeleteStatus = 0) GROUP BY dbo.Users.Name, dbo.Activities.Title, dbo.ActivityCategories.CategoryName, dbo.Activities.Info, dbo.Activities.RegDate, dbo.Activities.ReminderDate END";
            String InvoiceMonthReports = "Create PROCEDURE InvoiceMonthReports AS BEGIN DECLARE @StartOfCurrentMonth Datetime Set @StartOfCurrentMonth = DATEADD(MONTH,DATEDIFF(MONTH,0,CURRENT_TIMESTAMP),0) SELECT dbo.Users.Name AS [نام فروشنده], dbo.InVoices.InvoiceNumber AS [شماره فاکتور], dbo.Customers.Name AS [نام مشتری], dbo.Customers.Phone AS [تلفن مشتری], dbo.InVoices.inVoicePrice AS [قیمت فاکتور], dbo.InVoices.RegDate AS [تاریخ ثبت] FROM dbo.Users INNER JOIN  dbo.InVoices ON dbo.Users.ID = dbo.InVoices.user_ID INNER JOIN  dbo.Customers ON dbo.InVoices.customer_ID = dbo.Customers.ID WHERE (dbo.InVoices.DeleteStatus = 0) AND (dbo.InVoices.RegDate >=DATEADD(month, DATEDIFF(month, 0, @StartOfCurrentMonth), 0)) END";
            String InvoiceWeekReports = "CREATE PROCEDURE InvoiceWeekReports AS BEGIN DECLARE @FirstCurrentDay Datetime Set @FirstCurrentDay = DATEADD(wk, 0, DATEADD(DAY, 1-DATEPART(WEEKDAY, GETDATE()+1), DATEDIFF(dd, 0, GETDATE()))) DECLARE @FirstpreviousDay Datetime Set @FirstpreviousDay =DATEADD(wk, -1, DATEADD(DAY, 1-DATEPART(WEEKDAY, GETDATE()+1), DATEDIFF(dd, 0, GETDATE()))) SELECT dbo.Users.Name AS [نام فروشنده], dbo.InVoices.InvoiceNumber AS [شماره فاکتور], dbo.Customers.Name AS [نام مشتری], dbo.Customers.Phone AS [تلفن مشتری], dbo.InVoices.inVoicePrice AS [قیمت فاکتور], dbo.InVoices.RegDate AS [تاریخ ثبت] FROM dbo.Users INNER JOIN  dbo.InVoices ON dbo.Users.ID = dbo.InVoices.user_ID INNER JOIN  dbo.Customers ON dbo.InVoices.customer_ID = dbo.Customers.ID WHERE (dbo.InVoices.DeleteStatus = 0) AND (dbo.InVoices.RegDate between @FirstpreviousDay AND @FirstCurrentDay) END";
            String InvoiceYearReports = "CREATE PROCEDURE InvoiceYearReports AS BEGIN DECLARE @FIRST DATE set @FIRST=DATEADD(yy, DATEDIFF(yy, 0, GETDATE())-1, 0) DECLARE @END DATE set @END=DATEADD(yy, DATEDIFF(yy, 0, GETDATE()), 0) SELECT dbo.Users.Name AS [نام فروشنده], dbo.InVoices.InvoiceNumber AS [شماره فاکتور], dbo.Customers.Name AS [نام مشتری], dbo.Customers.Phone AS [تلفن مشتری], dbo.InVoices.inVoicePrice AS [قیمت فاکتور],  dbo.InVoices.RegDate AS [تاریخ ثبت] FROM dbo.Users INNER JOIN  dbo.InVoices ON dbo.Users.ID = dbo.InVoices.user_ID INNER JOIN  dbo.Customers ON dbo.InVoices.customer_ID = dbo.Customers.ID WHERE (dbo.InVoices.DeleteStatus = 0) AND (dbo.InVoices.RegDate BETWEEN @FIRST AND @END ) END";

            //String CustomerReport = "CREATE PROCEDURE CustomerReports AS BEGIN SELECT Name AS [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ ثبت سیستم] FROM dbo.Customers WHERE (DeleteStatus = 0) END GO";
            //String CustomerReport = "CREATE PROCEDURE CustomerReports AS BEGIN SELECT Name AS [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ ثبت سیستم] FROM dbo.Customers WHERE (DeleteStatus = 0) END GO";
            //String CustomerReport = "CREATE PROCEDURE CustomerReports AS BEGIN SELECT Name AS [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ ثبت سیستم] FROM dbo.Customers WHERE (DeleteStatus = 0) END GO";
            //String CustomerReport = "CREATE PROCEDURE CustomerReports AS BEGIN SELECT Name AS [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ ثبت سیستم] FROM dbo.Customers WHERE (DeleteStatus = 0) END GO";

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            Com.CommandText = ReadActivityRead;
            Com.ExecuteNonQuery();
            Com.CommandText = ReadInvoice;
            Com.ExecuteNonQuery();
            Com.CommandText = ReadReminders;
            Com.ExecuteNonQuery();
            Com.CommandText = ReadUserGroup;
            Com.ExecuteNonQuery();
            Com.CommandText = SearchActivity;
            Com.ExecuteNonQuery();
            Com.CommandText = SearchCustomer;
            Com.ExecuteNonQuery();
            Com.CommandText = SearchInvoice;
            Com.ExecuteNonQuery();
            Com.CommandText = SearchProduct;
            Com.ExecuteNonQuery();
            Com.CommandText = SearchReminder;
            Com.ExecuteNonQuery();
            Com.CommandText = CustomerReports;
            Com.ExecuteNonQuery();
            Com.CommandText = ActivityReports;
            Com.ExecuteNonQuery();
            Com.CommandText = InvoiceMonthReports;
            Com.ExecuteNonQuery();
            Com.CommandText = InvoiceWeekReports;
            Com.ExecuteNonQuery();
            Com.CommandText = InvoiceYearReports;
            Com.ExecuteNonQuery();
            con.Close();
        }
    }
}
