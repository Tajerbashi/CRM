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
using Stimulsoft.Report;

namespace CRM
{
    public partial class InvoiceForm : Form
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
        public InvoiceForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        MSGClass MSG = new MSGClass();
        InvoiceBLL BLL = new InvoiceBLL();

        CustomerBLL customerBLL = new CustomerBLL();
        UserBLL UserBLL = new UserBLL();
        ProductBLL ProductBLL = new ProductBLL();

        Customer C = new Customer();
        User U = new User();

        int IDDGV1 = 0;
        int IDDGV2 = 0;

        public List<Product> ProductsList = new List<Product>();
        
        public void ShowDGV()
        {
            DGV2.DataSource = null;
            DGV2.DataSource = BLL.ReadAll();
            DGV2.Columns["آیدی"].Visible = false;
        }
        public void DGVSearch()
        {
            DGV2.DataSource = null;
            DGV2.DataSource = BLL.ReadSearch(SearchTXT.Text);
            DGV2.Columns["آیدی"].Visible = false;
        }
        public void DGV1Setting()
        {
            DGV1.DataSource = null;
            DGV1.DataSource = ProductsList.Distinct().ToList();

            DGV1.Columns["ID"].Visible = false;
            DGV1.Columns["Stock"].Visible = false;
            DGV1.Columns["DeleteStatus"].Visible = false;
            DGV1.Columns["RegDate"].Visible = false;

            DGV1.Columns["Name"].HeaderText = "نام محصول";
            DGV1.Columns["Price"].HeaderText = "قیمت محصول";

            Double S = 0;
            foreach (var i in ProductsList)
            {
                S += i.Price;
            }
            TotalPriceLBL.Text=S.ToString("N0");
            S = S - Convert.ToDouble(PercentTXT.Text);
            TotalBuyPrice.Text = S.ToString("N0");
        }
        public void ResultLBL()
        {
            double D = 0;
            foreach (var i in ProductsList)
            {
                D += i.Price;
            }
            TotalPriceLBL.Text = D.ToString("N0");
            TotalBuyPrice.Text = (Convert.ToDouble(TotalPriceLBL.Text) - Convert.ToDouble(PercentTXT.Text)).ToString("N0");
        }
        public void AddProduct()
        {
            bool SWW = false;
            Product P = new Product();
            P = ProductBLL.ReadProductByName(ProductsNameTXT.Text);
            foreach (var i in ProductsList)
            {
                if (i.Name==P.Name)
                {
                    SWW = true;
                    break;
                }
            }

            if (!SWW)
            {
                ProductsList.Add(P);
                String S = P.Name + " به ارزش " + P.Price.ToString("N0") + " تومان ";
                ListBoxNames.Items.Add(S);
            }
            
            DGV1Setting();
        }
        public void RemoveProduct()
        {
            ListBoxNames.Items.RemoveAt(IDDGV1);
            ProductsList.RemoveAt(IDDGV1);
            DGV1Setting();
        }
        //  ================================================================================================================
        //  ================================================================================================================
        //  ================================================================================================================
        //  ================================================================================================================
        private void xuiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            LastFacLBL.Text = Convert.ToString(BLL.lastFactorNumber());
            DateLBL.Text = DateTime.Now.ToString("yyyy/MM/dd");
            AutoCompleteStringCollection CustomersNames = new AutoCompleteStringCollection();
            AutoCompleteStringCollection ProductNames = new AutoCompleteStringCollection();
            AutoCompleteStringCollection UsersName = new AutoCompleteStringCollection();

            foreach (var i in customerBLL.ReadCustomerByPhone())
            {
                CustomersNames.Add(i);
            }
            foreach (var i in ProductBLL.ReadAllProductByName())
            {
                ProductNames.Add(i);
            }
            foreach (var i in UserBLL.ReadUserbyUserName())
            {
                UsersName.Add(i);
            }

            CustomerPhoneTXT.AutoCompleteCustomSource = CustomersNames;
            ProductsNameTXT.AutoCompleteCustomSource = ProductNames;
            UserNameTXT.AutoCompleteCustomSource = UsersName;
            ShowDGV();
        }
        
        private void SaveBtn0_Click(object sender, EventArgs e)
        {
            try
            {
                U = UserBLL.ReadByUserName(UserNameTXT.Text);
                UserNameTXT.Text = U.Name;
                UserNameTXT.Enabled = false;
                SaveBtn0.Enabled = false;
            }
            catch 
            {
            }
        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            C = customerBLL.ReadByPhone(CustomerPhoneTXT.Text);
            NameLBL.Text = C.Name;
            PhoneLBL.Text = C.Phone; ;
            CustomerPhoneTXT.Enabled = false;
        }

        private void PercentTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TotalBuyPrice.Text = (Convert.ToDouble(TotalPriceLBL.Text) - Convert.ToDouble(PercentTXT.Text)).ToString("N0");
            }
            catch
            {
                PercentTXT.Text = "0";
            }
        }

        private void DGV1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void AddBtn1_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDDGV1 = DGV1.CurrentRow.Index;
        }

        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDDGV2 = Convert.ToInt32(DGV2.Rows[DGV2.CurrentRow.Index].Cells["آیدی"].Value);
        }

        private void SavePrintBtn_Click(object sender, EventArgs e)
        {
            InVoice inVoice = new InVoice();
            inVoice.RegDate = DateTime.Now;
            inVoice.InvoiceNumber = int.Parse(LastFacLBL.Text);
            inVoice.inVoicePrice = Convert.ToDouble(TotalBuyPrice.Text);
            if (IsCheck.Checked)
            {
                inVoice.IsCheckout = true;
                inVoice.CheckOutDate= DateTime.Now;
            }
            else
            {
                inVoice.IsCheckout = false;
            }
            if (BLL.Create(inVoice,C,U,ProductsList))
            {
                DialogResult DR= MSG.ShowMSGBoxDialog("ثبت اطلاعات","فاکتور با موفقیت ذخیره شد\nآیا میخواهید فاکتور چاپ شود?","",2,2);
                if (DR==DialogResult.Yes)
                {
                    StiReport sti = new StiReport();
                    sti.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Report.mrt");
                    sti.Dictionary.Variables["InvoiceNumber"].Value=LastFacLBL.Text;
                    sti.Dictionary.Variables["Date"].Value=DateLBL.Text;
                    sti.Dictionary.Variables["UserName"].Value=UserNameTXT.Text;
                    sti.Dictionary.Variables["CustomerName"].Value=NameLBL.Text;
                    sti.Dictionary.Variables["CustomerPhone"].Value=PhoneLBL.Text;
                    sti.RegBusinessObject("Product",ProductsList);
                    sti.Render();
                    sti.Show();
                }
            }
            else
            {
                MSG.ShowMSGBoxDialog("خطای ثبت اطلاعات", "فاکتور ذخیره نشد", "", 3, 1);
            }
            ShowDGV();
            LastFacLBL.Text = Convert.ToString(BLL.lastFactorNumber());
        }

        private void DGV2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveProduct();
        }

        private void SearchTXT_TextChanged(object sender, EventArgs e)
        {
            DGVSearch();
        }

        private void پرداختشدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  DGV2
            DialogResult DR = MSG.ShowMSGBoxDialog("تغییر وضعیت","آیا میخواهید تایید پرداخت را فعال کنید؟","",2,2);
            if (DR==DialogResult.Yes)
            {
                BLL.ChangeCheckIsDone(IDDGV2);
                ShowDGV();
            }
        }
        private void حذفToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //  DGV2
            DialogResult DR = MSG.ShowMSGBoxDialog("حذف اطلاعات", "آیا میخواهید فاکتور مورد نظر را حذف کنید؟", "", 2, 1);
            if (DR == DialogResult.Yes)
            {
                BLL.Delete(IDDGV2);
                ShowDGV();
            }
        }
    }
}
