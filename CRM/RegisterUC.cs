using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxLearn.License;
using BLL;
using BEE;
using DevComponents.DotNetBar;
using System.Windows.Controls;
using System.Runtime.InteropServices;
using Image = System.Drawing.Image;
using System.IO;
using HandyControl.Controls;

namespace CRM
{
    public partial class RegisterUC : System.Windows.Forms.UserControl
    {

        public RegisterUC()
        {
            InitializeComponent();
        }
        UserBLL UserBLL = new UserBLL();
        UserGroupBLL UserGroupBLL = new UserGroupBLL();
        MSGClass MSG = new MSGClass();
        OpenFileDialog ofd = new OpenFileDialog();
        UserGroup Ug = new UserGroup();
        PROCDURE_BLL ProBL = new PROCDURE_BLL();
        Image pic;

        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();

        int x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0;

        bool SW = false;

        public void LunchSQLProcdure()
        {
            ProBL.Procedure();
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            //  License
            if (LicPanel.Location.Y<1000)
            {
                y1 = y1 + 15;
                LicPanel.Location = new Point(x1, y1);
            }
            else
            {
                timer1.Stop();
                AdduserPanel.Visible = true;
            }

        }
        private void Timer_Tick1_1(object sender, EventArgs e)
        {
            //  License
            if (progressBarX1.Value>=100 && SW)
            {
                SW = false;
                timer1.Stop();
                SHOWMSG();
            }
            else
            {
                progressBarX1.Value++;
            }

        }
        private void Switch1()
        {
            progressBarX1.Visible = true;
            SW = true;
            progressBarX1.Value = 0;
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += Timer_Tick1_1;
            timer1.Start();
        }
        private void Switch1_1()
        {
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += Timer_Tick1;
            timer1.Start();
        }

        private void Timer_Tick2(object sender, EventArgs e)
        {
            //  Register
            if (AdduserPanel.Location.Y < 1000)
            {
                y2 = y2 + 15;
                AdduserPanel.Location = new Point(x2, y2);
            }
            else
            {
                timer2.Stop();
                LoginPanelE.Visible = true;
            }
        }
        private void Switch2()
        {
            timer2.Enabled = true;
            timer2.Interval = 15;
            timer2.Tick += Timer_Tick2;
            timer2.Start();
        }
     
        private string SavePic(String Name)
        {
            // محل که نرم افزار از آنجا اجرا میشود در متغییر ذخیره میکند
            String path = Path.GetDirectoryName(Application.ExecutablePath) + @"\Pictures\";
            // این شرط چک میکند اگر موجود نبود بساز
            if (!Directory.Exists(path))
            {
                // این دستور دایرکتوری فولدر عکس هارا در فولدر برنامه میسازد
                Directory.CreateDirectory(path);
            }
            // نام که تابع ورودی میگیرد را با وازه کاربر و پسوند عکس در متغییر رشته ذخیره میکند
            string PicName = Name + ".JPG";

            try
            {
                //  در داخل ترای کش ما عکس که فایل دیالوگ برمیگرداند نامش را ذخیره میکند
                String PicPath = ofd.FileName;
                //  توسط تابع کپی ما عکس که از فایل دیالوگ گرفتیم را در آدرس پث که اول گرفتیم به اضافه نامی که در نظر گرفتیم ذخیره میکنیم
                if (!Directory.Exists(path + PicName))
                {
                    File.Copy(PicPath, path + PicName, true);
                }
            }
            catch (Exception ex)
            {
                MSG.ShowMSGBoxDialog("خطای ثبت تصویر", "تصویر برای کاربر مورد نظر ذخیره نشده است", ex.Message, 3, 1);
            }
            //  این قسمت ما آدرس و نام تصویر که داریم را برمیگردانیم
            return (path + PicName);
        }
        
        public UserAccessRole FillAccessRole(String Section, bool CanEnter, bool CanAdd, bool CanEdit, bool CanDel)
        {
            UserAccessRole role = new UserAccessRole();
            role.Section = Section;
            role.CanEnter = CanEnter;
            role.CanCreate = CanAdd;
            role.CanUpdate = CanEdit;
            role.CanDelete = CanDel;
            return role;
        }
        private void CreateAdminUserGroup()
        {
            Ug.Title = "مدیریت";
            Ug.UserAccessRoles.Add(FillAccessRole("بخش مشتریان", true, true, true, true));
            Ug.UserAccessRoles.Add(FillAccessRole("بخش کالاها", true, true, true, true));
            Ug.UserAccessRoles.Add(FillAccessRole("بخش فاکتور ها", true, true, true, true));
            Ug.UserAccessRoles.Add(FillAccessRole("بخش فعالیت ها", true, true, true, true));
            Ug.UserAccessRoles.Add(FillAccessRole("بخش یادآور ها", true, true, true, true));
            Ug.UserAccessRoles.Add(FillAccessRole("بخش کاربران", true, true, true, true));
            Ug.UserAccessRoles.Add(FillAccessRole("پنل پیامکی", true, true, true, true));
            Ug.UserAccessRoles.Add(FillAccessRole("بخش گزارشات", true, true, true, true));
            Ug.UserAccessRoles.Add(FillAccessRole("بخش تنظیمات", true, true, true, true));
            UserGroupBLL.Create(Ug);

        }

        private void RegisterUC_Load(object sender, EventArgs e)
        {
            HashCodeTXT.Text = ComputerInfo.GetComputerId();
            progressBarX1.Visible = false;
            LicPanel.Visible = true;
        }

        private void CopyBTN_Click(object sender, EventArgs e)
        {
            if (HashCodeTXT.Text != String.Empty)
            {
                Clipboard.SetText(HashCodeTXT.Text);
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            //  ACtiv
            User user = new User();
            user.UserName = UsernameTXT.Text;
            user.Password = PassTXTEnter.Text;
            if (UserBLL.IsLogin(user))
            {
                user = UserBLL.ReadByUserName(user.UserName);
                MainWindow mainWindow = (MainWindow)System.Windows.Application.Current.MainWindow;
                mainWindow.UserAdmin = user;
                mainWindow.USERINFO.Content = user.Name;
                ((LoginForm)Application.OpenForms["LoginForm"]).Close();
            }
            else
            {
                MSG.ShowMSGBoxDialog("خطا در ورود","نام یا رمز کاربری اشتباه است","",3,2);
            }
            LunchSQLProcdure();
        }

        private void ActiveBtnj_Click(object sender, EventArgs e)
        {
            Switch1();
        }
        public void SHOWMSG()
        {
            KeyManager km = new KeyManager(HashCodeTXT.Text);
            String productKey = LicenseTXT.Text.ToString();
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "Personal accounting";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }
                    km.SaveSuretyFile(String.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    MSG.ShowMSGBoxDialog("فعال سازی", "برنامه با موفقیت فعال سازی شد", "", 1, 2);
                    progressBarX1.Visible = false;
                    ActiveBtn.Visible = true;
                }
            }
            else
            {
                MSG.ShowMSGBoxDialog("خطا در فعال سازی", "کد فعال سازی نا معتبر است", "", 3, 1);
                progressBarX1.Visible = false;

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = NameTXT.Text;
            user.UserName = UserTXT.Text;
            user.Picture = SavePic(UserTXT.Text);

            if (PassTXT.Text == RePasTXT.Text)
            {
                user.Password = PassTXT.Text;
                CreateAdminUserGroup();

                if (UserBLL.Create(user, "مدیریت"))
                {
                    MSG.ShowMSGBoxDialog("ثبت اطلاعات", "ثبت اطلاعات با موفقیت ذخیره شد", "", 1, 2);
                    //LunchSQLProcdure();
                    Switch2();
                }
                else
                {
                    MSG.ShowMSGBoxDialog("خطای در ثبت", "ثبت اطلاعات ناموفق بود", "", 3, 2);
                }
            }
            else
            {
                MSG.ShowMSGBoxDialog("خطای رمز", "رمز همخوانی ندارید و دوباره تلاش کنید", "", 3, 1);
            }
            
        }

        private void PicBtn_Click(object sender, EventArgs e)
        {

            ofd.Filter = "JPG(*.JPG)|*.JPG";
            ofd.Title = "تصویر کاربر را انتخاب کنید";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic = Image.FromFile(ofd.FileName);
            }
        }

        private void ActiveBtn_Click(object sender, EventArgs e)
        {
            Switch1_1();
        }

    }
}
