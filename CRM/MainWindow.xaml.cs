using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CRM
{
    /// <summary>
    /// Interaction logic for m.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer Timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            Timer.Start();
            Timer.Interval = TimeSpan.FromMilliseconds(100);
            Timer.Tick += new EventHandler(Timer_Tick);
        }
        private void Timer_Tick(object sender,EventArgs e)
        {
            ClockLBL.Content = DateTime.Now.ToString();
        }

    }
}
