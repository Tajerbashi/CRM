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
using BLL;
using BEE;
using System.Globalization;
using System.Windows.Interop;

namespace CRM
{
    public partial class ProductForm : Form
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
        
        public ProductForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        ProductBLL bll = new ProductBLL();
        Functions Fun = new Functions();
        MSGClass MSG = new MSGClass();
        bool sw = true;
        int ID = 0;
        public void ShowDGV()
        {
            DGV.DataSource = null;
            DGV.DataSource = bll.ReadAll();
            DGV.Columns["آیدی"].Visible = false;
        }
        private void ClearTextBox()
        {
            ProductTXT.Text = "";
            PriceTXT.Text = "";
            StockTXT.Text = "";
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ShowDGV();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            if (ProductTXT.Text.Trim().Length==0)
            {
                MSG.ShowMSGBoxDialog("خطای فیلد خالی", "نام محصول را وارد کنید", "", 3, 2);
                ProductTXT.Focus();
            }
            else if (PriceTXT.Text.Trim().Length == 0)
            {
                MSG.ShowMSGBoxDialog("خطای فیلد خالی", "قیمت محصول را وارد کنید", "", 3, 2);
                PriceTXT.Focus();

            }
            else if (StockTXT.Text.Trim().Length == 0)
            {
                MSG.ShowMSGBoxDialog("خطای فیلد خالی", "تعداد موجودی را وارد کنید", "", 3, 2);
                StockTXT.Focus();

            }
            else
            {
                product.Name = ProductTXT.Text;
                product.Price = Convert.ToDouble(Fun.ChangeToEnglishNumber(PriceTXT.Text));
                product.Stock = Convert.ToInt32(Fun.ChangeToEnglishNumber(StockTXT.Text));
                if (sw)
                {
                    if (bll.Create(product))
                    {
                        MSG.ShowMSGBoxDialog("ثبت اطلاعات", "محصول جدیدی ذخیره شد", "", 1, 2);
                        ClearTextBox();
                    }
                    else
                    {
                        MSG.ShowMSGBoxDialog("خطای ثبت", "اطلاعات محصول ذخیره نشد", "", 2, 1);
                    }
                }
                else
                {
                    if (bll.Update(product, ID))
                    {
                        MSG.ShowMSGBoxDialog("ویرایش اطلاعات", "اطلاعات محصول ویرایش شد", "", 1, 2);
                        sw = true;
                        ClearTextBox();
                        SaveBTN.ButtonText = "ثبت اطلاعات";
                    }
                    else
                    {
                        MSG.ShowMSGBoxDialog("خطای ویرایش", "اطلاعات محصول ویرایش نشد", "", 2, 1);
                    }
                }
                ShowDGV();
            }



        }

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sw = false;
            ProductTXT.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["نام محصول"].Value);
            PriceTXT.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["قیمت محصول"].Value);
            StockTXT.Text = Convert.ToString(DGV.Rows[DGV.CurrentRow.Index].Cells["موجودی"].Value);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MSG.ShowMSGBoxDialog("هشدار حذف اطلاعات","آیا میخواهید اطلاعات مورد نظر حذف شود؟","",2,1);
            if (Dr==DialogResult.Yes)
            {
                bll.Delete(ID);
                ShowDGV();
            }
        }

        private void PriceTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    NumberFormatInfo nfi = new NumberFormatInfo();
                    nfi.NumberDecimalDigits = 0;
                    ProductTXT.Text = Int64.Parse(ProductTXT.Text, NumberStyles.AllowThousands).ToString("N", nfi);
                    ProductTXT.Select(ProductTXT.Text.Length, 0);
                }
                catch
                {

                }
            }
            catch
            {
                
            }
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

        private void PriceTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            DGV.DataSource = null;
            DGV.DataSource = bll.ReadSearch(SearchTXT.Text);
        }
    }
}
