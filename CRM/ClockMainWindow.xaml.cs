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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using BEE;
using BLL;

namespace CRM
{
    /// <summary>
    /// Interaction logic for ClockMainWindow.xaml
    /// </summary>
    public partial class ClockMainWindow : UserControl
    {
        public ClockMainWindow()
        {
            InitializeComponent();
            DispatcherTimer Timer=new DispatcherTimer();
            Timer.Interval = TimeSpan.FromMilliseconds(500);
            Timer.Tick +=new EventHandler(Timer_Tick);
            Timer.Start();
        }
        
        private void Timer_Tick(object sender,EventArgs e)
        {

            clockTime.Text = (DateTime.Now).ToString();
            //clockTime.Text = Functions.ConvertToPersian(DateTime.Now).ToString();
        }
    }
}
