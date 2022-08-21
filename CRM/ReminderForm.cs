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
using static HandyControl.Tools.Interop.InteropValues;

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
        MSGClass MSG = new MSGClass();
        User UserAdmin = new User();
        UserBLL UserBLL = new UserBLL();
        User USER = new User();
        MainWindow mainWindow = new MainWindow();

        private void NewReminder()
        {
            UsernameTXT.Enabled = true;
            UsernameTXT.Text = "";

            SaveUserBtn.Enabled = true;

            titleeTXT.Enabled = true;
            titleeTXT.Text = "";

            InfoTxt.Enabled = true;
            InfoTxt.Text = "";

        }

        public void ShowDGV()
        {
            DGV.DataSource = null;
            DGV.DataSource = bll.Read();
            DGV.Columns["آیدی"].Visible = false;
            int count = DGV.RowCount;
            label6.Text = count.ToString();
            NewReminder();
        }
        public void DGVSearch()
        {
            DGV.DataSource = null;
            DGV.DataSource = bll.ReadSearch(SearchTXT.Text);
            DGV.Columns["آیدی"].Visible = false;
        }
        private void ReminderForm_Load(object sender, EventArgs e)
        {
            mainWindow = (MainWindow)System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            UserAdmin = mainWindow.UserAdmin;

            AutoCompleteStringCollection names=new AutoCompleteStringCollection();
            foreach( var i in UserBLL.ReadUserbyUserName())
            {
                names.Add(i);
            }
            UsernameTXT.AutoCompleteCustomSource = names;
            ShowDGV();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (UserBLL.Access(UserAdmin, "بخش یاد آورها", 2))
            {
                #region Code
                Reminder Rem = new Reminder();
                Rem.Title = titleeTXT.Text;
                Rem.ReminderInfo = InfoTxt.Text;
                Rem.ReminderDate = dateTXt.Value;
                Rem.RegDate = DateTime.Now;
                if (!UsernameTXT.Enabled)
                {
                    if (SW)
                    {
                        if (bll.Create(Rem, USER))
                        {
                            MSG.ShowMSGBoxDialog("ثبت یادآور", "یاد آور جدیدی ذخیره شد", "", 1, 2);
                            ShowDGV();

                        }
                        else
                        {
                            MSG.ShowMSGBoxDialog("خطا در ثبت", "یاد آور ذخیره نشد", "", 3, 1);
                        }
                    }
                    else
                    {
                        if (bll.Update(Rem, ID))
                        {
                            MSG.ShowMSGBoxDialog("ویرایش یادآور", "یاد آور با موفقیت ویرایش شد", "", 1, 2);
                            SaveBtn.ButtonText = "ثبت اطلاعات";

                            SW = true;
                            ShowDGV();

                        }
                        else
                        {
                            MSG.ShowMSGBoxDialog("خطا در ویرایش", "یاد آور ویرایش نشد", "", 3, 1);
                        }
                    }
                }
                else
                {
                    MSG.ShowMSGBoxDialog("تایید ادمین", "کلید تایید ادمین فشرده نشده است", "", 3, 1);
                }
                #endregion

            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
        }

        private void SaveUserBtn_Click(object sender, EventArgs e)
        {
            USER = UserBLL.ReadByUserName(UsernameTXT.Text);
            if (USER != null)
            {
                UsernameTXT.Enabled = false;
            }
            else
            {
                MSG.ShowMSGBoxDialog("خطای کاربری", "ادمین انتخاب نشد و اطلاعات اشتباه وارد شده است", "", 3, 2);
            }
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            DGVSearch();
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserBLL.Access(UserAdmin, "بخش یاد آورها", 3))
            {
                if (ID != 0)
                {
                    SW = false;
                    SaveBtn.ButtonText = "ویرایش اطلاعات";
                    titleeTXT.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["عنوان یادآور"].Value);
                    InfoTxt.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["توضیحات یادآور"].Value);
                    dateTXt.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["تاریخ یادآور"].Value);
                }
                else
                {
                    MSG.ShowMSGBoxDialog("اشتباه کاربری", "هنوز ردیف مورد نظر را کلیک نکرده اید!", "", 3, 2);
                }
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
        }

        private void تغییروضعیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserBLL.Access(UserAdmin, "بخش یاد آورها", 3))
            {
                if (ID != 0)
                {
                    bll.IsDone(ID);
                    ShowDGV();
                }
                else
                {
                    MSG.ShowMSGBoxDialog("اشتباه کاربری", "هنوز ردیف مورد نظر را کلیک نکرده اید!", "", 3, 2);
                }
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (UserBLL.Access(UserAdmin, "بخش یاد آورها", 4))
            {
                if (ID != 0)
                {
                    DialogResult dr = MSG.ShowMSGBoxDialog("حذف اطلاعات", "آیا میخواهید اطلاعات مورد نظر را حذف کنید؟", "", 2, 1);
                    if (dr == DialogResult.Yes)
                    {
                        bll.Delete(ID);
                        ShowDGV();
                    }
                }
                else
                {
                    MSG.ShowMSGBoxDialog("اشتباه کاربری", "هنوز ردیف مورد نظر را کلیک نکرده اید!", "", 3, 2);
                }
            }
            else
            {
                MSG.ShowMSGBoxDialog("محدودیت دسترسی", "شما اجازه ورود به این بخش نرم افزار ندارید", "", 3, 2);
            }
        }

        private void DGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DGV.Rows[DGV.CurrentRow.Index].Cells["آیدی"].Value);
        }

        private void DGV_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
    }
}
