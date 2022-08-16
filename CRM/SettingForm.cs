using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BEE;
using static HandyControl.Tools.Interop.InteropValues;
using System.Windows.Interop;

namespace CRM
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        int ID = 0;
        bool SW = true;

        ActivityCategoryBLL bll = new ActivityCategoryBLL();
        MSGClass MSG = new MSGClass();
        public void ShowDGV()
        {
            DGV.DataSource = null;
            DGV.DataSource = bll.ReadAll();
            DGV.Columns["آیدی"].Visible = false;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ActivityCategory Ac = new ActivityCategory();
            Ac.CategoryName = NameAcTxt.Text;
            if (SW)
            {
                if (bll.Create(Ac))
                {
                    MSG.ShowMSGBoxDialog("ثبت اطلاعات", "اطلاعات جدید ذخیره شد", "", 1, 2);
                    NameAcTxt.Text = "";
                }
                else
                {
                    MSG.ShowMSGBoxDialog("خطا در ثبت اطلاعات", "اطلاعات ذخیره نشد", "", 2, 1);
                }
            }
            else
            {
                if (bll.Update(Ac,ID))
                {
                    MSG.ShowMSGBoxDialog("ویرایش اطلاعات", "قعالیت ویرایش شد", "", 1, 2);
                    SW = true;
                    NameAcTxt.Text = "";

                }
                else
                {
                    MSG.ShowMSGBoxDialog("خطا در ویرایش اطلاعات", "فعالیت ویرایش نشد", "", 2, 1);
                }
            }
            ShowDGV();

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

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameAcTxt.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["نام فعالیت"].Value);
            SW = false;
            SaveBtn.ButtonText = "ویرایش";
            ShowDGV();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MSG.ShowMSGBoxDialog("حذف اطلاعات", "آیا میخواهید اطلاعات مشتری مورد نظر حذف شود؟", "", 2, 1);

            if (DialogResult.Yes == dr)
            {
                bll.Delete(ID);
            }
            ShowDGV();
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            ShowDGV();
        }
    }
}
