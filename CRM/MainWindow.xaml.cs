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
            InvoiceForm f = new InvoiceForm();
            OpenWindow(f);
        }

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            CustomerForm f = new CustomerForm();
            OpenWindow(f);
        }

        private void TextBlock_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            ProductForm f = new ProductForm();
            OpenWindow(f);
        }

        private void TextBlock_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            ActivityForm f = new ActivityForm();
            OpenWindow(f);
        }

        private void TextBlock_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            ReminderForm f = new ReminderForm();
            OpenWindow(f);
        }

        private void TextBlock_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            SMSForm f = new SMSForm();
            OpenWindow(f);
        }

        private void TextBlock_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            UserForm f = new UserForm();
            OpenWindow(f);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
