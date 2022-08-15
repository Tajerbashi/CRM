using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BEE;
using BLL;

namespace CRM
{
    public partial class ReminderForm : Form
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

        public ReminderForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        int ID;
        bool SW = true;
        ReminderBLL bll=new ReminderBLL();
        UserBLL UBLL = new UserBLL();
        User U = new User();
        MSGClass MSG = new MSGClass();
        private void ReminderForm_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection names=new AutoCompleteStringCollection();
            foreach( var i in UBLL.ReadUserName())
            {
                names.Add(i);
            }
            UsernameTXT.AutoCompleteCustomSource = names;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DGV.Rows[DGV.CurrentRow.Index].Cells["آیدی"].Value);
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Reminder Rem = new Reminder();
            Rem.Title=titleeTXT.Text;
            Rem.ReminderInfo = InfoTxt.Text;
            Rem.ReminderDate = dateTXt.Value;
            Rem.RegDate = DateTime.Now;
            if (bll.Create(Rem,U))
            {
                MSG.ShowMSGBoxDialog("ثبت یادآور", "یاد آور جدیدی ذخیره شد", "", 1, 2);
            }
            else
            {
                MSG.ShowMSGBoxDialog("خطا در ثبت", "یاد آور ذخیره نشد", "", 3, 1);
            }
        }

        private void SaveUserBtn_Click(object sender, EventArgs e)
        {
            UsernameTXT.Enabled = false;
            U=UBLL.ReadByName(UsernameTXT.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
