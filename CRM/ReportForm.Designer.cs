namespace CRM
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.R5 = new System.Windows.Forms.RadioButton();
            this.R4 = new System.Windows.Forms.RadioButton();
            this.R3 = new System.Windows.Forms.RadioButton();
            this.R2 = new System.Windows.Forms.RadioButton();
            this.R1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PrintReport1 = new XanderUI.XUIButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DateEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.DateStart = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RR4 = new System.Windows.Forms.RadioButton();
            this.RR3 = new System.Windows.Forms.RadioButton();
            this.RR2 = new System.Windows.Forms.RadioButton();
            this.RR1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowReport = new XanderUI.XUIButton();
            this.PrintReport2 = new XanderUI.XUIButton();
            this.GraphPoint = new XanderUI.XUIButton();
            this.GraphColumn = new XanderUI.XUIButton();
            this.GraphLine = new XanderUI.XUIButton();
            this.Close = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.R5);
            this.groupBox1.Controls.Add(this.R4);
            this.groupBox1.Controls.Add(this.R3);
            this.groupBox1.Controls.Add(this.R2);
            this.groupBox1.Controls.Add(this.R1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PrintReport1);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(734, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش چاپی";
            // 
            // R5
            // 
            this.R5.AutoSize = true;
            this.R5.Location = new System.Drawing.Point(279, 198);
            this.R5.Name = "R5";
            this.R5.Size = new System.Drawing.Size(208, 34);
            this.R5.TabIndex = 4;
            this.R5.TabStop = true;
            this.R5.Text = "لیست فروش سال گذشته";
            this.R5.UseVisualStyleBackColor = true;
            // 
            // R4
            // 
            this.R4.AutoSize = true;
            this.R4.Location = new System.Drawing.Point(287, 164);
            this.R4.Name = "R4";
            this.R4.Size = new System.Drawing.Size(200, 34);
            this.R4.TabIndex = 3;
            this.R4.TabStop = true;
            this.R4.Text = "لیست فروش ماه گذشته";
            this.R4.UseVisualStyleBackColor = true;
            // 
            // R3
            // 
            this.R3.AutoSize = true;
            this.R3.Location = new System.Drawing.Point(273, 130);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(214, 34);
            this.R3.TabIndex = 2;
            this.R3.TabStop = true;
            this.R3.Text = "لیست فروش هفته گذشته";
            this.R3.UseVisualStyleBackColor = true;
            // 
            // R2
            // 
            this.R2.AutoSize = true;
            this.R2.Location = new System.Drawing.Point(210, 95);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(277, 34);
            this.R2.TabIndex = 1;
            this.R2.TabStop = true;
            this.R2.Text = "تمام فعالیت های ثبت شده کاربران";
            this.R2.UseVisualStyleBackColor = true;
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Location = new System.Drawing.Point(296, 63);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(191, 34);
            this.R1.TabIndex = 0;
            this.R1.TabStop = true;
            this.R1.Text = "مشتریان ثبت نام شده";
            this.R1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "گزارش مورد نظر خود را انتخاب نمایید :";
            // 
            // PrintReport1
            // 
            this.PrintReport1.BackgroundColor = System.Drawing.Color.Transparent;
            this.PrintReport1.ButtonImage = global::CRM.Properties.Resources.icons8_send_to_printer_96;
            this.PrintReport1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.PrintReport1.ButtonText = "چاپ گزارش";
            this.PrintReport1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PrintReport1.ClickTextColor = System.Drawing.Color.MidnightBlue;
            this.PrintReport1.CornerRadius = 5;
            this.PrintReport1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintReport1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.PrintReport1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.PrintReport1.HoverTextColor = System.Drawing.Color.Black;
            this.PrintReport1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.PrintReport1.Location = new System.Drawing.Point(6, 225);
            this.PrintReport1.Name = "PrintReport1";
            this.PrintReport1.Size = new System.Drawing.Size(155, 41);
            this.PrintReport1.TabIndex = 5;
            this.PrintReport1.TextColor = System.Drawing.Color.White;
            this.PrintReport1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.PrintReport1.Click += new System.EventHandler(this.PrintReport1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DateEnd);
            this.groupBox2.Controls.Add(this.DateStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.RR4);
            this.groupBox2.Controls.Add(this.RR3);
            this.groupBox2.Controls.Add(this.RR2);
            this.groupBox2.Controls.Add(this.RR1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ShowReport);
            this.groupBox2.Controls.Add(this.PrintReport2);
            this.groupBox2.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(734, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "گزارش بر اساس تاریخ";
            // 
            // DateEnd
            // 
            // 
            // 
            // 
            this.DateEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DateEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DateEnd.ButtonDropDown.Visible = true;
            this.DateEnd.ForeColor = System.Drawing.Color.Black;
            this.DateEnd.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.DateEnd.IsPopupCalendarOpen = false;
            this.DateEnd.Location = new System.Drawing.Point(22, 254);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DateEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateEnd.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DateEnd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DateEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DateEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DateEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DateEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateEnd.MonthCalendar.DisplayMonth = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.DateEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DateEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DateEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DateEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateEnd.MonthCalendar.TodayButtonVisible = true;
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(155, 36);
            this.DateEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DateEnd.TabIndex = 5;
            this.DateEnd.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            // 
            // DateStart
            // 
            // 
            // 
            // 
            this.DateStart.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DateStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DateStart.ButtonDropDown.Visible = true;
            this.DateStart.ForeColor = System.Drawing.Color.Black;
            this.DateStart.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.DateStart.IsPopupCalendarOpen = false;
            this.DateStart.Location = new System.Drawing.Point(251, 254);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DateStart.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateStart.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DateStart.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DateStart.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DateStart.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DateStart.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DateStart.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DateStart.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DateStart.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DateStart.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateStart.MonthCalendar.DisplayMonth = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.DateStart.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DateStart.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DateStart.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DateStart.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateStart.MonthCalendar.TodayButtonVisible = true;
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(155, 36);
            this.DateStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DateStart.TabIndex = 4;
            this.DateStart.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(183, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "تا تاریخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(412, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "از تاریخ";
            // 
            // RR4
            // 
            this.RR4.AutoSize = true;
            this.RR4.Location = new System.Drawing.Point(345, 185);
            this.RR4.Name = "RR4";
            this.RR4.Size = new System.Drawing.Size(142, 34);
            this.RR4.TabIndex = 3;
            this.RR4.TabStop = true;
            this.RR4.Text = "موجودی هر کالا";
            this.RR4.UseVisualStyleBackColor = true;
            // 
            // RR3
            // 
            this.RR3.AutoSize = true;
            this.RR3.Location = new System.Drawing.Point(355, 145);
            this.RR3.Name = "RR3";
            this.RR3.Size = new System.Drawing.Size(132, 34);
            this.RR3.TabIndex = 2;
            this.RR3.TabStop = true;
            this.RR3.Text = "فروش هر کاربر";
            this.RR3.UseVisualStyleBackColor = true;
            // 
            // RR2
            // 
            this.RR2.AutoSize = true;
            this.RR2.Location = new System.Drawing.Point(198, 105);
            this.RR2.Name = "RR2";
            this.RR2.Size = new System.Drawing.Size(289, 34);
            this.RR2.TabIndex = 1;
            this.RR2.TabStop = true;
            this.RR2.Text = "فعالیت های ثبت شده توسط کاربران";
            this.RR2.UseVisualStyleBackColor = true;
            // 
            // RR1
            // 
            this.RR1.AutoSize = true;
            this.RR1.Location = new System.Drawing.Point(296, 65);
            this.RR1.Name = "RR1";
            this.RR1.Size = new System.Drawing.Size(191, 34);
            this.RR1.TabIndex = 0;
            this.RR1.TabStop = true;
            this.RR1.Text = "مشتریان ثبت نام شده";
            this.RR1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "گزلرش و تاریخ مدنظر خودرا وارد کنید :";
            // 
            // ShowReport
            // 
            this.ShowReport.BackgroundColor = System.Drawing.Color.Transparent;
            this.ShowReport.ButtonImage = global::CRM.Properties.Resources.icons8_report_641;
            this.ShowReport.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.ShowReport.ButtonText = "نمایش نتیجه";
            this.ShowReport.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ShowReport.ClickTextColor = System.Drawing.Color.MidnightBlue;
            this.ShowReport.CornerRadius = 5;
            this.ShowReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowReport.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.ShowReport.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ShowReport.HoverTextColor = System.Drawing.Color.Black;
            this.ShowReport.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.ShowReport.Location = new System.Drawing.Point(167, 312);
            this.ShowReport.Name = "ShowReport";
            this.ShowReport.Size = new System.Drawing.Size(155, 41);
            this.ShowReport.TabIndex = 6;
            this.ShowReport.TextColor = System.Drawing.Color.White;
            this.ShowReport.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.ShowReport.Click += new System.EventHandler(this.ShowReport_Click);
            // 
            // PrintReport2
            // 
            this.PrintReport2.BackgroundColor = System.Drawing.Color.Transparent;
            this.PrintReport2.ButtonImage = global::CRM.Properties.Resources.icons8_send_to_printer_96;
            this.PrintReport2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.PrintReport2.ButtonText = "چاپ گزارش";
            this.PrintReport2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PrintReport2.ClickTextColor = System.Drawing.Color.MidnightBlue;
            this.PrintReport2.CornerRadius = 5;
            this.PrintReport2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintReport2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.PrintReport2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.PrintReport2.HoverTextColor = System.Drawing.Color.Black;
            this.PrintReport2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.PrintReport2.Location = new System.Drawing.Point(6, 312);
            this.PrintReport2.Name = "PrintReport2";
            this.PrintReport2.Size = new System.Drawing.Size(155, 41);
            this.PrintReport2.TabIndex = 7;
            this.PrintReport2.TextColor = System.Drawing.Color.White;
            this.PrintReport2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.PrintReport2.Click += new System.EventHandler(this.PrintReport2_Click);
            // 
            // GraphPoint
            // 
            this.GraphPoint.BackgroundColor = System.Drawing.Color.Transparent;
            this.GraphPoint.ButtonImage = global::CRM.Properties.Resources.icons8_graph_643;
            this.GraphPoint.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.GraphPoint.ButtonText = "نمودار نقطه ای";
            this.GraphPoint.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GraphPoint.ClickTextColor = System.Drawing.Color.MidnightBlue;
            this.GraphPoint.CornerRadius = 5;
            this.GraphPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GraphPoint.Font = new System.Drawing.Font("IRANSansWeb", 13F);
            this.GraphPoint.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.GraphPoint.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.GraphPoint.HoverTextColor = System.Drawing.Color.Black;
            this.GraphPoint.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.GraphPoint.Location = new System.Drawing.Point(80, 12);
            this.GraphPoint.Name = "GraphPoint";
            this.GraphPoint.Size = new System.Drawing.Size(155, 41);
            this.GraphPoint.TabIndex = 4;
            this.GraphPoint.TextColor = System.Drawing.Color.White;
            this.GraphPoint.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.GraphPoint.Click += new System.EventHandler(this.GraphPoint_Click);
            // 
            // GraphColumn
            // 
            this.GraphColumn.BackgroundColor = System.Drawing.Color.Transparent;
            this.GraphColumn.ButtonImage = global::CRM.Properties.Resources.icons8_graph_643;
            this.GraphColumn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.GraphColumn.ButtonText = "نمودار ستونی";
            this.GraphColumn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GraphColumn.ClickTextColor = System.Drawing.Color.MidnightBlue;
            this.GraphColumn.CornerRadius = 5;
            this.GraphColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GraphColumn.Font = new System.Drawing.Font("IRANSansWeb", 13F);
            this.GraphColumn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.GraphColumn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.GraphColumn.HoverTextColor = System.Drawing.Color.Black;
            this.GraphColumn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.GraphColumn.Location = new System.Drawing.Point(292, 12);
            this.GraphColumn.Name = "GraphColumn";
            this.GraphColumn.Size = new System.Drawing.Size(155, 41);
            this.GraphColumn.TabIndex = 3;
            this.GraphColumn.TextColor = System.Drawing.Color.White;
            this.GraphColumn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.GraphColumn.Click += new System.EventHandler(this.GraphColumn_Click);
            // 
            // GraphLine
            // 
            this.GraphLine.BackgroundColor = System.Drawing.Color.Transparent;
            this.GraphLine.ButtonImage = global::CRM.Properties.Resources.icons8_graph_643;
            this.GraphLine.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.GraphLine.ButtonText = "نمودار خطی";
            this.GraphLine.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GraphLine.ClickTextColor = System.Drawing.Color.MidnightBlue;
            this.GraphLine.CornerRadius = 5;
            this.GraphLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GraphLine.Font = new System.Drawing.Font("IRANSansWeb", 13F);
            this.GraphLine.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.GraphLine.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.GraphLine.HoverTextColor = System.Drawing.Color.Black;
            this.GraphLine.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.GraphLine.Location = new System.Drawing.Point(504, 12);
            this.GraphLine.Name = "GraphLine";
            this.GraphLine.Size = new System.Drawing.Size(155, 41);
            this.GraphLine.TabIndex = 2;
            this.GraphLine.TextColor = System.Drawing.Color.White;
            this.GraphLine.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.GraphLine.Click += new System.EventHandler(this.GraphLine_Click);
            // 
            // Close
            // 
            this.Close.BackgroundColor = System.Drawing.Color.Transparent;
            this.Close.ButtonImage = global::CRM.Properties.Resources.icons8_back_to_96;
            this.Close.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.Close.ButtonText = "برگشت به صفحه اصلی";
            this.Close.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.Close.ClickTextColor = System.Drawing.Color.Blue;
            this.Close.CornerRadius = 5;
            this.Close.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold);
            this.Close.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Close.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Close.HoverTextColor = System.Drawing.Color.Black;
            this.Close.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.Close.Location = new System.Drawing.Point(12, 608);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(216, 41);
            this.Close.TabIndex = 5;
            this.Close.TextColor = System.Drawing.Color.White;
            this.Close.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "نتیجه گزارش";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.Inclination = 10;
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.Perspective = 10;
            chartArea3.Area3DStyle.PointDepth = 50;
            chartArea3.Area3DStyle.PointGapDepth = 50;
            chartArea3.Area3DStyle.Rotation = -20;
            chartArea3.Area3DStyle.WallWidth = 15;
            chartArea3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            chartArea3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(12, 72);
            this.chart1.Name = "chart1";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Name = "Series1";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(716, 530);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1244, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraphPoint);
            this.Controls.Add(this.GraphColumn);
            this.Controls.Add(this.GraphLine);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private XanderUI.XUIButton PrintReport1;
        private System.Windows.Forms.GroupBox groupBox2;
        private XanderUI.XUIButton ShowReport;
        private XanderUI.XUIButton PrintReport2;
        private XanderUI.XUIButton GraphLine;
        private XanderUI.XUIButton GraphColumn;
        private XanderUI.XUIButton GraphPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton R5;
        private System.Windows.Forms.RadioButton R4;
        private System.Windows.Forms.RadioButton R3;
        private System.Windows.Forms.RadioButton R2;
        private System.Windows.Forms.RadioButton R1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RR4;
        private System.Windows.Forms.RadioButton RR3;
        private System.Windows.Forms.RadioButton RR2;
        private System.Windows.Forms.RadioButton RR1;
        private System.Windows.Forms.Label label3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DateEnd;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DateStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}