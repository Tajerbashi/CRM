namespace CRM
{
    partial class ActivityForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveBtn3 = new XanderUI.XUIButton();
            this.ActivityTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DateTXT = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.ReminderCheck = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SaveBtn = new XanderUI.XUIButton();
            this.InfoTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TitleTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SaveBtn2 = new XanderUI.XUIButton();
            this.SaveBtn1 = new XanderUI.XUIButton();
            this.UserNameTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CustomerTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.نمایشجزییاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییرحالتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateTXT)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveBtn3);
            this.groupBox1.Controls.Add(this.ActivityTXT);
            this.groupBox1.Controls.Add(this.DateTXT);
            this.groupBox1.Controls.Add(this.ReminderCheck);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.InfoTXT);
            this.groupBox1.Controls.Add(this.TitleTXT);
            this.groupBox1.Controls.Add(this.SaveBtn2);
            this.groupBox1.Controls.Add(this.SaveBtn1);
            this.groupBox1.Controls.Add(this.UserNameTXT);
            this.groupBox1.Controls.Add(this.CustomerTXT);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن فعالیت جدید";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SaveBtn3
            // 
            this.SaveBtn3.BackgroundColor = System.Drawing.Color.Transparent;
            this.SaveBtn3.ButtonImage = global::CRM.Properties.Resources.icons8_checkmark_480;
            this.SaveBtn3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.SaveBtn3.ButtonText = "";
            this.SaveBtn3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.SaveBtn3.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn3.CornerRadius = 5;
            this.SaveBtn3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.SaveBtn3.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SaveBtn3.Location = new System.Drawing.Point(771, 125);
            this.SaveBtn3.Name = "SaveBtn3";
            this.SaveBtn3.Size = new System.Drawing.Size(40, 40);
            this.SaveBtn3.TabIndex = 20;
            this.SaveBtn3.TextColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn3.Click += new System.EventHandler(this.SaveBtn3_Click);
            // 
            // ActivityTXT
            // 
            this.ActivityTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ActivityTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ActivityTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.ActivityTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.ActivityTXT.Border.Class = "TextBoxBorder";
            this.ActivityTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ActivityTXT.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityTXT.Location = new System.Drawing.Point(817, 124);
            this.ActivityTXT.Name = "ActivityTXT";
            this.ActivityTXT.PreventEnterBeep = true;
            this.ActivityTXT.Size = new System.Drawing.Size(397, 42);
            this.ActivityTXT.TabIndex = 19;
            this.ActivityTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ActivityTXT.WatermarkText = "دسته بندی فعالیت ها";
            // 
            // DateTXT
            // 
            // 
            // 
            // 
            this.DateTXT.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DateTXT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateTXT.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DateTXT.ButtonDropDown.Visible = true;
            this.DateTXT.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12.75F);
            this.DateTXT.ForeColor = System.Drawing.Color.Black;
            this.DateTXT.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.DateTXT.IsPopupCalendarOpen = false;
            this.DateTXT.Location = new System.Drawing.Point(224, 179);
            // 
            // 
            // 
            // 
            // 
            // 
            this.DateTXT.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateTXT.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DateTXT.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DateTXT.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DateTXT.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DateTXT.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DateTXT.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DateTXT.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DateTXT.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DateTXT.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateTXT.MonthCalendar.DisplayMonth = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.DateTXT.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DateTXT.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DateTXT.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DateTXT.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateTXT.MonthCalendar.TodayButtonVisible = true;
            this.DateTXT.Name = "DateTXT";
            this.DateTXT.Size = new System.Drawing.Size(240, 36);
            this.DateTXT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DateTXT.TabIndex = 18;
            // 
            // ReminderCheck
            // 
            // 
            // 
            // 
            this.ReminderCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ReminderCheck.Location = new System.Drawing.Point(487, 179);
            this.ReminderCheck.Name = "ReminderCheck";
            this.ReminderCheck.Size = new System.Drawing.Size(267, 37);
            this.ReminderCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ReminderCheck.TabIndex = 13;
            this.ReminderCheck.Text = "برای این فعالیت یاد آور تنظیم شود";
            this.ReminderCheck.TextColor = System.Drawing.Color.White;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.SaveBtn.ButtonImage = global::CRM.Properties.Resources.icons8_checkmark_480;
            this.SaveBtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.SaveBtn.ButtonText = "ثبت فعالیت جدید";
            this.SaveBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.SaveBtn.ClickTextColor = System.Drawing.Color.Blue;
            this.SaveBtn.CornerRadius = 5;
            this.SaveBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveBtn.HoverTextColor = System.Drawing.Color.Black;
            this.SaveBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SaveBtn.Location = new System.Drawing.Point(6, 178);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(183, 41);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // InfoTXT
            // 
            this.InfoTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.InfoTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.InfoTXT.Border.Class = "TextBoxBorder";
            this.InfoTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.InfoTXT.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTXT.Location = new System.Drawing.Point(6, 33);
            this.InfoTXT.Multiline = true;
            this.InfoTXT.Name = "InfoTXT";
            this.InfoTXT.PreventEnterBeep = true;
            this.InfoTXT.Size = new System.Drawing.Size(757, 139);
            this.InfoTXT.TabIndex = 8;
            this.InfoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfoTXT.WatermarkText = "توضیحات فعالیت را وارد کنید";
            // 
            // TitleTXT
            // 
            this.TitleTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.TitleTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.TitleTXT.Border.Class = "TextBoxBorder";
            this.TitleTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TitleTXT.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTXT.Location = new System.Drawing.Point(771, 171);
            this.TitleTXT.Name = "TitleTXT";
            this.TitleTXT.PreventEnterBeep = true;
            this.TitleTXT.Size = new System.Drawing.Size(443, 42);
            this.TitleTXT.TabIndex = 7;
            this.TitleTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TitleTXT.WatermarkText = "موضوع فعالیت";
            // 
            // SaveBtn2
            // 
            this.SaveBtn2.BackgroundColor = System.Drawing.Color.Transparent;
            this.SaveBtn2.ButtonImage = global::CRM.Properties.Resources.icons8_checkmark_480;
            this.SaveBtn2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.SaveBtn2.ButtonText = "";
            this.SaveBtn2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.SaveBtn2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn2.CornerRadius = 5;
            this.SaveBtn2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.SaveBtn2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SaveBtn2.Location = new System.Drawing.Point(771, 79);
            this.SaveBtn2.Name = "SaveBtn2";
            this.SaveBtn2.Size = new System.Drawing.Size(40, 40);
            this.SaveBtn2.TabIndex = 5;
            this.SaveBtn2.TextColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn2.Click += new System.EventHandler(this.SaveBtn2_Click);
            // 
            // SaveBtn1
            // 
            this.SaveBtn1.BackgroundColor = System.Drawing.Color.Transparent;
            this.SaveBtn1.ButtonImage = global::CRM.Properties.Resources.icons8_checkmark_480;
            this.SaveBtn1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.SaveBtn1.ButtonText = "";
            this.SaveBtn1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.SaveBtn1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn1.CornerRadius = 5;
            this.SaveBtn1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.SaveBtn1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SaveBtn1.Location = new System.Drawing.Point(771, 33);
            this.SaveBtn1.Name = "SaveBtn1";
            this.SaveBtn1.Size = new System.Drawing.Size(40, 40);
            this.SaveBtn1.TabIndex = 0;
            this.SaveBtn1.TextColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn1.Click += new System.EventHandler(this.SaveBtn1_Click);
            // 
            // UserNameTXT
            // 
            this.UserNameTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UserNameTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UserNameTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.UserNameTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.UserNameTXT.Border.Class = "TextBoxBorder";
            this.UserNameTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.UserNameTXT.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTXT.Location = new System.Drawing.Point(817, 78);
            this.UserNameTXT.Name = "UserNameTXT";
            this.UserNameTXT.PreventEnterBeep = true;
            this.UserNameTXT.Size = new System.Drawing.Size(397, 42);
            this.UserNameTXT.TabIndex = 3;
            this.UserNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserNameTXT.WatermarkText = "جستجوی کاربر بر اساس نام کاربری";
            // 
            // CustomerTXT
            // 
            this.CustomerTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CustomerTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.CustomerTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.CustomerTXT.Border.Class = "TextBoxBorder";
            this.CustomerTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.CustomerTXT.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTXT.Location = new System.Drawing.Point(817, 32);
            this.CustomerTXT.Name = "CustomerTXT";
            this.CustomerTXT.PreventEnterBeep = true;
            this.CustomerTXT.Size = new System.Drawing.Size(397, 42);
            this.CustomerTXT.TabIndex = 2;
            this.CustomerTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerTXT.WatermarkText = "جستجو مشتری بر اساس  شماره تماس";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxX2);
            this.groupBox2.Controls.Add(this.checkBoxX1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SearchTXT);
            this.groupBox2.Controls.Add(this.DGV);
            this.groupBox2.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 377);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو و نمایش فعالیت ها";
            // 
            // checkBoxX2
            // 
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.Location = new System.Drawing.Point(33, 31);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(118, 37);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 13;
            this.checkBoxX2.Text = "نام مشتری";
            this.checkBoxX2.TextColor = System.Drawing.Color.White;
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(157, 31);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(100, 37);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 12;
            this.checkBoxX1.Text = "نام فاکتور";
            this.checkBoxX1.TextColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "بر اساس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1138, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "جستجو";
            // 
            // SearchTXT
            // 
            this.SearchTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.SearchTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTXT.Border.Class = "TextBoxBorder";
            this.SearchTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.SearchTXT.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTXT.Location = new System.Drawing.Point(399, 30);
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.PreventEnterBeep = true;
            this.SearchTXT.Size = new System.Drawing.Size(733, 42);
            this.SearchTXT.TabIndex = 11;
            this.SearchTXT.TextChanged += new System.EventHandler(this.SearchTXT_TextChanged);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGV.Location = new System.Drawing.Point(6, 83);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1208, 287);
            this.DGV.TabIndex = 4;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(572, 615);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 28);
            this.label11.TabIndex = 37;
            this.label11.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(611, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 28);
            this.label9.TabIndex = 35;
            this.label9.Text = "از";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(508, 616);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 28);
            this.label8.TabIndex = 34;
            this.label8.Text = "صفحه";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(675, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "صفحه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(874, 616);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 28);
            this.label6.TabIndex = 32;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(951, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "موجودی کل فعالیت ها تا این لحظه";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(643, 614);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 28);
            this.label10.TabIndex = 36;
            this.label10.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.نمایشجزییاتToolStripMenuItem,
            this.تغییرحالتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 92);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Image = global::CRM.Properties.Resources.icons8_edit_16;
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::CRM.Properties.Resources.icons8_delete_32;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // نمایشجزییاتToolStripMenuItem
            // 
            this.نمایشجزییاتToolStripMenuItem.Image = global::CRM.Properties.Resources.icons8_information_gradient_16;
            this.نمایشجزییاتToolStripMenuItem.Name = "نمایشجزییاتToolStripMenuItem";
            this.نمایشجزییاتToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.نمایشجزییاتToolStripMenuItem.Text = "نمایش جزییات";
            this.نمایشجزییاتToolStripMenuItem.Click += new System.EventHandler(this.نمایشجزییاتToolStripMenuItem_Click);
            // 
            // تغییرحالتToolStripMenuItem
            // 
            this.تغییرحالتToolStripMenuItem.Image = global::CRM.Properties.Resources.icons8_change_18__ldpi_;
            this.تغییرحالتToolStripMenuItem.Name = "تغییرحالتToolStripMenuItem";
            this.تغییرحالتToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.تغییرحالتToolStripMenuItem.Text = "تغییر حالت";
            this.تغییرحالتToolStripMenuItem.Click += new System.EventHandler(this.تغییرحالتToolStripMenuItem_Click);
            // 
            // xuiButton5
            // 
            this.xuiButton5.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton5.ButtonImage = global::CRM.Properties.Resources.icons8_back_to_96;
            this.xuiButton5.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton5.ButtonText = "برگشت به صفحه اصلی";
            this.xuiButton5.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton5.ClickTextColor = System.Drawing.Color.Blue;
            this.xuiButton5.CornerRadius = 5;
            this.xuiButton5.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold);
            this.xuiButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton5.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton5.Location = new System.Drawing.Point(12, 608);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(216, 41);
            this.xuiButton5.TabIndex = 30;
            this.xuiButton5.TextColor = System.Drawing.Color.White;
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.Click += new System.EventHandler(this.xuiButton5_Click);
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1244, 661);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.xuiButton5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActivityForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateTXT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private XanderUI.XUIButton SaveBtn2;
        private XanderUI.XUIButton SaveBtn1;
        private DevComponents.DotNetBar.Controls.TextBoxX UserNameTXT;
        private DevComponents.DotNetBar.Controls.TextBoxX CustomerTXT;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGV;
        private DevComponents.DotNetBar.Controls.TextBoxX TitleTXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private XanderUI.XUIButton xuiButton5;
        private DevComponents.DotNetBar.Controls.TextBoxX InfoTXT;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX SearchTXT;
        private DevComponents.DotNetBar.Controls.CheckBoxX ReminderCheck;
        private XanderUI.XUIButton SaveBtn;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DateTXT;
        private XanderUI.XUIButton SaveBtn3;
        private DevComponents.DotNetBar.Controls.TextBoxX ActivityTXT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نمایشجزییاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تغییرحالتToolStripMenuItem;
    }
}