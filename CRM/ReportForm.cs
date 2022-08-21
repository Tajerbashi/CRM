using Stimulsoft.Report;
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
using System.Windows.Forms.DataVisualization.Charting;
using static HandyControl.Tools.Interop.InteropValues;

namespace CRM
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        StiReport sti = new StiReport();
        UserBLL userBLL = new UserBLL();
        ReportationBLL reportationBLL = new ReportationBLL();   
        MSGClass MSG = new MSGClass();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void PrintReport1_Click(object sender, EventArgs e)
        {
            if (R1.Checked)
            {
                sti.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\CustomerReports.mrt");
                sti.Render();
                sti.Show();
            }
            else if (R2.Checked)
            {
                sti.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ActivityReports.mrt");
                sti.Render();
                sti.Show();
            }
            else if (R3.Checked)
            {
                sti.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\InvoiceWeekReports.mrt");
                sti.Render();
                sti.Show();
            }
            else if(R4.Checked)
            {
                sti.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\InvoiceMonthReports.mrt");
                sti.Render();
                sti.Show();
            }
            else if (R5.Checked)
            {
                sti.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\InvoiceYearReports.mrt");
                sti.Render();
                sti.Show();
            }
            else
            {
                MSG.ShowMSGBoxDialog("خطای کاربری","گزینه ای برای چاپ گزارش انتخاب نشده است","",3,1);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowReport_Click(object sender, EventArgs e)
        {
            

            chart1.Series["Series1"].Points.Clear();
            if (RR1.Checked)
            {
                List<string> listName = new List<string>();
                List<string> listNumber = new List<string>();
                foreach (var item in reportationBLL.CustomerReportaionInvoices())
                {
                    double Sum = 0;
                    foreach (var q in item.inVoices)
                    {
                        if (q.RegDate.Date >= DateStart.Value.Date && q.RegDate.Date <= DateEnd.Value.Date)
                        {
                            if (item.ID==q.customer.ID)
                            {
                                Sum += q.inVoicePrice;
                            }
                        }
                    }
                    chart1.Series["Series1"].Points.AddXY(item.Name, Sum);
                }
            }
            else if (RR2.Checked)
            {
                List<string> listName = new List<string>();
                List<string> listNumber = new List<string>();
                foreach (var item in reportationBLL.UserActivities())
                {
                    double Sum = 0;
                    foreach (var q in item.Activities)
                    {
                        if (q.RegDate.Date >= DateStart.Value.Date && q.RegDate.Date <= DateEnd.Value.Date)
                        {
                            if (item.ID == q.user.ID)
                            {
                                Sum++;
                            }
                        }
                    }
                    chart1.Series["Series1"].Points.AddXY(item.Name, Sum);
                }
            }
            else if (RR3.Checked)
            {
                List<string> listName = new List<string>();
                List<string> listNumber = new List<string>();
                foreach (var item in userBLL.ReadUserInvoiceReport())
                {
                    int x = 0;
                    foreach (var q in item.InVoices)
                    {
                        if (q.RegDate.Date >= DateStart.Value.Date && q.RegDate.Date <= DateEnd.Value.Date)
                        {
                            x++;
                        }
                    }
                    chart1.Series["Series1"].Points.AddXY(item.Name, x);
                }
            }
            else if (RR4.Checked)
            {
                List<string> listName = new List<string>();
                List<string> listNumber = new List<string>();

                foreach (var item in reportationBLL.ProductStock())
                {
                    listName.Add(item.Name);
                    listNumber.Add((item.Stock).ToString());                    
                }
                for (int i=0;i<listName.Count;i++)
                {
                    chart1.Series["Series1"].Points.AddXY(listName[i], listNumber[i]);
                }
            }
            else
            {
                MSG.ShowMSGBoxDialog("خطای کاربری", "هنوز هیچ گزینه ای انتخاب نشده است", "", 3, 2);
            }
        }

        private void PrintReport2_Click(object sender, EventArgs e)
        {
            if (RR1.Checked)
            {
                List<Customer> ListName = new List<Customer>();
                foreach (var item in reportationBLL.CustomerReportaionInvoices())
                {
                    if (item.RegDate.Date >= DateStart.Value.Date && item.RegDate.Date <= DateEnd.Value.Date)
                    {
                        ListName.Add(item);
                    }
                }
                StiReport sti = new StiReport();
                sti.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\CustomerReports2.mrt");
                sti.RegBusinessObject("Customer", ListName);
                sti.Render();
                sti.Show();
            }
            else if (RR2.Checked)
            {
                StiReport sti = new StiReport();

                sti.Dictionary.DataStore.Clear();
                sti.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ActivityReports2.mrt");

                sti["@Start"] = DateStart.Value;
                sti["@End"] = DateEnd.Value;

                //sti.Dictionary.Variables["Start"].Value = (DateStart.Value.Date);

                sti.Render();
                sti.Show();
            }
            else if (RR3.Checked)
            {
                StiReport sti = new StiReport();

                sti.Dictionary.DataStore.Clear();
                sti.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\UserInvoicePriceReports.mrt");

                sti["@Start"] = DateStart.Value;
                sti["@End"] = DateEnd.Value;

                //sti.Dictionary.Variables["Start"].Value = (DateStart.Value.Date);

                sti.Render();
                sti.Show();
            }
            else if (RR4.Checked)
            {
                sti.Load(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\ReadStockReports.mrt");
                sti.Render();
                sti.Show();
            }
            else
            {
                MSG.ShowMSGBoxDialog("خطای کاربری", "هنوز هیچ گزینه ای انتخاب نشده است", "", 3, 2);
            }
        }
        int i = 0;
        private void GraphLine_Click(object sender, EventArgs e)
        {
            if (i==1)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
            else if(i==2)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            }
            else if(i==3)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            }else
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                i = 0;
            }
            i++;
        }

        private void GraphColumn_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            else if (i == 2)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            }
            else if (i == 3)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            }
            else
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
                i = 0;
            }
            i++;
        }

        private void GraphPoint_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            }
            else if (i == 2)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.PointAndFigure;
            }
            else if (i == 3)
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            }
            else
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                i = 0;
            }
            i++;
        }
    }
}
