using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BEE;
using BLL;
using System.Data.SqlClient;

namespace CRM
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        Image pic;
        UserBLL bll = new UserBLL();
        UserGroupBLL BLLG=new UserGroupBLL();
        int ID=0;
        bool SW = true;
        MSGClass MSG = new MSGClass();

        public UserAccessRole FillAccessRole(String Section,bool CanEnter,bool CanAdd,bool CanEdit,bool CanDel)
        {
            UserAccessRole role = new UserAccessRole();
            role.Section = Section;
            role.CanEnter = CanEnter;
            role.CanCreate = CanAdd;
            role.CanUpdate = CanEdit;
            role.CanDelete = CanDel;
            return role;
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
                if (!Directory.Exists(path+PicName))
                {
                    File.Copy(PicPath, path + PicName, true);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطای ثبت تصویر\n" + ex.Message);
            }
            //  این قسمت ما آدرس و نام تصویر که داریم را برمیگردانیم
            return (path + PicName);
        }
        public void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        public void ShowDGV()
        {
            DGV.DataSource = null;
            DGV.DataSource = bll.ReadAll();
            DGV.Columns["آیدی"].Visible = false;
            DGV.Columns["رمز کاربری"].Visible = false;
        }
        
        private void Pic_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG(*.JPG)|*.JPG";
            ofd.Title = "تصویر کاربر را انتخاب کنید";

            if (ofd.ShowDialog()==DialogResult.OK)
            {
                pic = Image.FromFile(ofd.FileName);
                Pic.Image = pic;
                Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            if (NameTXT.Text.Trim().Length==0)
            {
                MessageBox.Show("نام کامل را درج کنید","خطای درج اطلاعات",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (UserNameTXT.Text.Trim().Length == 0)
            {
                MessageBox.Show("نام کاربری را درج کنید", "خطای درج اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (PassTXT.Text.Trim().Length == 0)
            {
                MessageBox.Show("کلمه عبور را درج کنید", "خطای درج اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (RePassTXT.Text.Trim().Length == 0)
            {
                MessageBox.Show("تکرار کلمه عبور را درج کنید", "خطای درج اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                #region SaveCode
                u.Name = NameTXT.Text;
                u.UserName = UserNameTXT.Text;

                if (PassTXT.Text == RePassTXT.Text)
                {
                    u.Password = PassTXT.Text;
                }
                else
                {
                    MessageBox.Show("رمز و تکرار همخوانی ندارد");
                }

                if (SW)
                {
                    u.Picture = SavePic(UserNameTXT.Text);
                    u.RegDate = DateTime.Now;

                    if (bll.Create(u))
                    {
                        MSG.ShowMSGBoxDialog("ثبت اطلاعات","کاربر جدیدی ذخیره شد","",1,2);
                        ClearAllText(this);
                        ShowDGV();
                    }
                    else
                    {
                        MSG.ShowMSGBoxDialog("خطای در ثبت", "اطلاعات کاربر ذخیره نشد", "", 3, 1);
                    }
                }
                else
                {
                    u.Picture=SavePic(UserNameTXT.Text);
                    if (bll.Update(u, ID))
                    {
                        MSG.ShowMSGBoxDialog("ویرایش اطلاعات", "اطلاعات کاربر ویرایش شد", "", 1, 2);
                        SW = true;
                        ClearAllText(this);
                        ShowDGV();
                        SaveBtn.ButtonText = "ثبت اطلاعات";
                    }
                    else
                    {
                        MSG.ShowMSGBoxDialog("خطای در ویرایش", "اطلاعات کاربر ویرایش نشد", "", 3, 1);
                    }
                }
                #endregion

            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            ShowDGV();
        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SW = false;
            NameTXT.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["نام کامل"].Value);
            UserNameTXT.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["نام کاربری"].Value);
            SaveBtn.ButtonText = "ویرایش اطلاعات";
            User u=bll.ReadByID(ID);
            if (u.Picture != null)
            {
                Pic.Image = Image.FromFile(u.Picture);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.Delete(ID);
            ShowDGV();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DGV.Rows[DGV.CurrentRow.Index].Cells["آیدی"].Value);
            User u = bll.ReadByID(ID);
            if (u.Picture != null)
            {
                Pic.Image = Image.FromFile(u.Picture);
            }
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void UserNameTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void E0_CheckedChanged(object sender, EventArgs e)
        {
            if (E0.Checked)
            {
                E1.Checked = true;
                E2.Checked = true;
                E3.Checked = true;
                E4.Checked = true;
                E5.Checked = true;
                E6.Checked = true;
                E7.Checked = true;
                E8.Checked = true;
                E9.Checked = true;
            }
            else
            {
                E1.Checked = false;
                E2.Checked = false;
                E3.Checked = false;
                E4.Checked = false;
                E5.Checked = false;
                E6.Checked = false;
                E7.Checked = false;
                E8.Checked = false;
                E9.Checked = false;
            }
        }

        private void A0_CheckedChanged(object sender, EventArgs e)
        {
            if (A0.Checked)
            {
                A1.Checked = true;
                A2.Checked = true;
                A3.Checked = true;
                A4.Checked = true;
                A5.Checked = true;
                A6.Checked = true;
                A7.Checked = true;
                A8.Checked = true;
                A9.Checked = true;
            }
            else
            {
                A1.Checked = false;
                A2.Checked = false;
                A3.Checked = false;
                A4.Checked = false;
                A5.Checked = false;
                A6.Checked = false;
                A7.Checked = false;
                A8.Checked = false;
                A9.Checked = false;
            }
        }

        private void U0_CheckedChanged(object sender, EventArgs e)
        {
            if (U0.Checked)
            {
                U1.Checked = true;
                U2.Checked = true;
                U3.Checked = true;
                U4.Checked = true;
                U5.Checked = true;
                U6.Checked = true;
                U7.Checked = true;
                U8.Checked = true;
                U9.Checked = true;
            }
            else
            {
                U1.Checked = false;
                U2.Checked = false;
                U3.Checked = false;
                U4.Checked = false;
                U5.Checked = false;
                U6.Checked = false;
                U7.Checked = false;
                U8.Checked = false;
                U9.Checked = false;
            }

        }

        private void D0_CheckedChanged(object sender, EventArgs e)
        {
            if (D0.Checked)
            {
                D1.Checked = true;
                D2.Checked = true;
                D3.Checked = true;
                D4.Checked = true;
                D5.Checked = true;
                D6.Checked = true;
                D7.Checked = true;
                D8.Checked = true;
                D9.Checked = true;
            }
            else
            {
                D1.Checked = false;
                D2.Checked = false;
                D3.Checked = false;
                D4.Checked = false;
                D5.Checked = false;
                D6.Checked = false;
                D7.Checked = false;
                D8.Checked = false;
                D9.Checked = false;
            }
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            UserGroup Ug = new UserGroup();
            Ug.Title = GroupTXT.Text;
            Ug.UserAccessRoles.Add(FillAccessRole(L1.Text,E1.Checked,A1.Checked,U1.Checked,D1.Checked));
            Ug.UserAccessRoles.Add(FillAccessRole(L2.Text,E2.Checked,A2.Checked,U2.Checked,D2.Checked));
            Ug.UserAccessRoles.Add(FillAccessRole(L3.Text,E3.Checked,A3.Checked,U3.Checked,D3.Checked));
            Ug.UserAccessRoles.Add(FillAccessRole(L4.Text,E4.Checked,A4.Checked,U4.Checked,D4.Checked));
            Ug.UserAccessRoles.Add(FillAccessRole(L5.Text,E5.Checked,A5.Checked,U5.Checked,D5.Checked));
            Ug.UserAccessRoles.Add(FillAccessRole(L6.Text,E6.Checked,A6.Checked,U6.Checked,D6.Checked));
            Ug.UserAccessRoles.Add(FillAccessRole(L7.Text,E7.Checked,A7.Checked,U7.Checked,D7.Checked));
            Ug.UserAccessRoles.Add(FillAccessRole(L8.Text,E8.Checked,A8.Checked,U8.Checked,D8.Checked));
            Ug.UserAccessRoles.Add(FillAccessRole(L9.Text,E9.Checked,A9.Checked,U9.Checked,D9.Checked));
            if (BLLG.Create(Ug))
            {
                MSG.ShowMSGBoxDialog("ثبت اطلاعات", "گروه کاربری با موفقیت ذخیره شد", "", 1, 2);
            }
            else
            {
                MSG.ShowMSGBoxDialog("خطای در ثبت", "گروه کاربری ایجاد نشد", "", 3, 1);
            }
        }
    }
}
