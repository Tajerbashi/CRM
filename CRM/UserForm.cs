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
        int ID=0;
        bool SW = true;
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
                        MessageBox.Show("با موفقیت ثبت شد");
                        ClearAllText(this);
                        ShowDGV();
                    }
                    else
                    {
                        MessageBox.Show("ثبت نشد");
                    }
                }
                else
                {
                    u.Picture=SavePic(UserNameTXT.Text);
                    if (bll.Update(u, ID))
                    {
                        MessageBox.Show("با موفقیت ویرایش شد");
                        SW = true;
                        ClearAllText(this);
                        ShowDGV();
                        SaveBtn.ButtonText = "ثبت اطلاعات";
                    }
                    else
                    {
                        MessageBox.Show("ثبت نشد");
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
    }
}
