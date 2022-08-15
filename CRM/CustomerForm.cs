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
    public partial class CustomerForm : Form
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

        public CustomerForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        CustomerBLL bll = new CustomerBLL();
        Functions Fun = new Functions();
        MSGClass MSG = new MSGClass();
        int ID = 0;
        bool sw = true;
        private void ShowDGV()
        {
            DGV.DataSource = null;
            DGV.DataSource = bll.ReadAll();
            DGV.Columns["آیدی"].Visible = false;
        }
        private void ClearTextBox()
        {
            NameTXT.Text = "";
            PhoneTXT.Text = "";
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ShowDGV();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            if (NameTXT.Text.Trim().Length==0)
            {
                MSG.ShowMSGBoxDialog("خطای فیلد خالی", "نام مشتری را وارد کنید", "", 3, 2);
            }
            else if (PhoneTXT.Text.Trim().Length==0)
            {
                MSG.ShowMSGBoxDialog("خطای فیلد خالی", "تلفن مشتری را وارد کنید", "", 3, 2);
            }
            else
            {
                if (sw)
                {
                    c.Name = NameTXT.Text;
                    c.Phone = Fun.ChangeToEnglishNumber(PhoneTXT.Text);
                    c.RegDate = DateTime.Now;
                    if (bll.Create(c))
                    {
                        MSG.ShowMSGBoxDialog("ثبت اطلاعات", "مشتری جدید با موفقیت ذخیره شد", "", 1, 2);
                        ClearTextBox();
                    }
                    else
                    {
                        MSG.ShowMSGBoxDialog("خطای در ثبت", "اطلاعات مشتری موجود است و ذخیره نشد", "", 3, 1);
                    }
                }
                else
                {
                    c.Name = NameTXT.Text;
                    c.Phone = Fun.ChangeToEnglishNumber(PhoneTXT.Text);
                    c.RegDate = DateTime.Now;
                    if (bll.Update(c, ID))
                    {
                        MSG.ShowMSGBoxDialog("ویرایش اطلاعات", "اطلاعات مشتری با موفقیت ویرایش شد", "", 1, 2);
                        SaveBtn.ButtonText = "ثبت اطلاعات";
                        ClearTextBox();
                        sw = true;
                    }
                    else
                    {
                        MSG.ShowMSGBoxDialog("خطا در ویرایش", "اطلاعات مشتری ویرایش نشد", "", 3, 1);
                    }
                }

            }

            ShowDGV();
        }

        private void PhoneTXT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PhoneTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            DGV.DataSource = null;
            DGV.DataSource = bll.ReadSearch(SearchTXT.Text);
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DGV.Rows[DGV.CurrentRow.Index].Cells["آیدی"].Value);
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameTXT.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["نام مشتری"].Value);
            PhoneTXT.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["شماره تماس"].Value);
            sw = false;
            SaveBtn.ButtonText = "ویرایش";
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MSG.ShowMSGBoxDialog("حذف اطلاعات", "آیا میخواهید اطلاعات مشتری مورد نظر حذف شود؟", "", 2,1);

            if (DialogResult.Yes == dr)
            {
                bll.Delete(ID);
            }
            ShowDGV();
        }
    }
}
