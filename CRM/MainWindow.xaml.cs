using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.Windows.Media.Effects;
using System.Data.SqlClient;
using System.Data;
using BEE;
using BLL;

namespace CRM
{
    /// <summary>
    /// Interaction logic for m.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public User UserAdmin = new User();
        UserBLL userBLL = new UserBLL();
        MSGClass MSG = new MSGClass();
        public void OpenWindow(Form F)
        {
            Window g = this.FindName("Main") as Window;
            BlurBitmapEffect blurBitmapEffect = new BlurBitmapEffect();
            blurBitmapEffect.Radius = 20;

            g.BitmapEffect = blurBitmapEffect;
            F.ShowDialog();
            blurBitmapEffect.Radius = 0;
            g.BitmapEffect = blurBitmapEffect;
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (userBLL.Access(UserAdmin, "بخش فاکتور ها", 1))
            {
                InvoiceForm f = new InvoiceForm();
                OpenWindow(f);
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (userBLL.Access(UserAdmin, "بخش مشتریان", 1))
            {
                CustomerForm f = new CustomerForm();
                OpenWindow(f);
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی","شما اجازه ورود به این بخش نرم افزار ندارید","",3,2);
            }
        }

        private void TextBlock_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            if (userBLL.Access(UserAdmin, "بخش کالا ها", 1))
            {
                ProductForm f = new ProductForm();
                OpenWindow(f);
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
        }

        private void TextBlock_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            if (userBLL.Access(UserAdmin, "بخش فعالیت ها", 1))
            {
                ActivityForm f = new ActivityForm();
                OpenWindow(f);
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
        }

        private void TextBlock_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            if (userBLL.Access(UserAdmin, "بخش یاد آورها", 1))
            {
                ReminderForm f = new ReminderForm();
                OpenWindow(f);
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
        }

        private void TextBlock_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            if (userBLL.Access(UserAdmin, "پنل پیامکی", 1))
            {
                SMSForm f = new SMSForm();
                OpenWindow(f);
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
        }

        private void TextBlock_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            if (userBLL.Access(UserAdmin, "بخش کاربران", 1))
            {
                UserForm f = new UserForm();
                OpenWindow(f);
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
        }

        private void TextBlock_MouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            if (userBLL.Access(UserAdmin, "بخش تنظیمات", 1))
            {
                SettingForm f = new SettingForm();
                OpenWindow(f);
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
            //بخش گزارشات
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            LoginForm f = new LoginForm();
            OpenWindow(f);
        }

    }
}
