using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BEE;
using System.Windows.Interop;

namespace CRM
{
    public partial class LoginForm : Form
    {

        #region CodeRound
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        UserBLL userBLL = new UserBLL();
        List<String> users= new List<String>();

        Timer T1 = new Timer();
        Timer T2 = new Timer();

        MSGClass MSG = new MSGClass();

        public void LoginPanel()
        {
            RegisterUC registerUC = new RegisterUC();
            if (MainPanel.Controls.Count>0)
            {
                MainPanel.Controls[0].Dispose();
            }
            if (userBLL.IsAdmin())
            {
                registerUC.LoginPanelE.Visible = true;
                registerUC.LicPanel.Visible = false;
                registerUC.AdduserPanel.Visible = false;
            }
            MainPanel.Controls.Add(registerUC);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LodingLBL.Visible = true;
            T1.Enabled = true;
            T1.Interval = 15;
            T1.Tick += Timer_Tick1;
            T1.Start();
            LoginPanel();
            this.Controls["MainPanel"].Location = new Point(411, 830);
        }

        private void Timer_Tick1(object sender,EventArgs e)
        {
            if (progressBarX1.Value>=100)
            {
                T1.Stop();
                ExitBtn.Visible = true;
                progressBarX1.Visible = false;
                WelcomeLBL.Visible = true;
                LodingLBL.Visible=false;

                T2.Enabled = true;
                T2.Interval = 1;
                T2.Tick += Timer_Tick2;
                T2.Start();
            }
            else if(progressBarX1.Value==45)
            {
                users = userBLL.ReadUserbyUserName();
                progressBarX1.Value++;
            }
            else
            {
                progressBarX1.Value++;
            }
        }
        int y = 390;
        int y2 = 830;
        private void Timer_Tick2(object sender, EventArgs e)
        {
            if (WelcomeLBL.Location.Y >= 45)
            {
                MainPanel.Visible = true;
                y = y - 15;
                y2 = y2 - 32;
                WelcomeLBL.Location = new Point(397, y);
                this.Controls["MainPanel"].Location = new Point(411, y2);
            }
            else
            {
                T2.Stop();
            }
        }
        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
