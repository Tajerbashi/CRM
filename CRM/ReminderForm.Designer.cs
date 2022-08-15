namespace CRM
{
    partial class ReminderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveUserBtn = new XanderUI.XUIButton();
            this.dateTXt = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.titleeTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SaveBtn = new XanderUI.XUIButton();
            this.InfoTxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.UsernameTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییروضعیتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTXt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveUserBtn);
            this.groupBox1.Controls.Add(this.dateTXt);
            this.groupBox1.Controls.Add(this.titleeTXT);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.InfoTxt);
            this.groupBox1.Controls.Add(this.UsernameTXT);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن یادآور جدید";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SaveUserBtn
            // 
            this.SaveUserBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.SaveUserBtn.ButtonImage = global::CRM.Properties.Resources.icons8_checkmark_480;
            this.SaveUserBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.SaveUserBtn.ButtonText = "";
            this.SaveUserBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.SaveUserBtn.ClickTextColor = System.Drawing.Color.Blue;
            this.SaveUserBtn.CornerRadius = 5;
            this.SaveUserBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveUserBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveUserBtn.HoverTextColor = System.Drawing.Color.Black;
            this.SaveUserBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SaveUserBtn.Location = new System.Drawing.Point(812, 34);
            this.SaveUserBtn.Name = "SaveUserBtn";
            this.SaveUserBtn.Size = new System.Drawing.Size(40, 40);
            this.SaveUserBtn.TabIndex = 5;
            this.SaveUserBtn.TextColor = System.Drawing.Color.White;
            this.SaveUserBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveUserBtn.Click += new System.EventHandler(this.SaveUserBtn_Click);
            // 
            // dateTXt
            // 
            // 
            // 
            // 
            this.dateTXt.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTXt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTXt.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTXt.ButtonDropDown.Visible = true;
            this.dateTXt.ForeColor = System.Drawing.Color.Black;
            this.dateTXt.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.dateTXt.IsPopupCalendarOpen = false;
            this.dateTXt.Location = new System.Drawing.Point(16, 33);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTXt.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTXt.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTXt.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTXt.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTXt.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTXt.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTXt.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTXt.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTXt.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTXt.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTXt.MonthCalendar.DisplayMonth = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTXt.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTXt.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTXt.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTXt.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTXt.MonthCalendar.TodayButtonVisible = true;
            this.dateTXt.Name = "dateTXt";
            this.dateTXt.Size = new System.Drawing.Size(155, 34);
            this.dateTXt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTXt.TabIndex = 3;
            this.dateTXt.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            // 
            // titleeTXT
            // 
            this.titleeTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.titleeTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.titleeTXT.Border.Class = "TextBoxBorder";
            this.titleeTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.titleeTXT.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleeTXT.Location = new System.Drawing.Point(810, 81);
            this.titleeTXT.Name = "titleeTXT";
            this.titleeTXT.PreventEnterBeep = true;
            this.titleeTXT.Size = new System.Drawing.Size(391, 42);
            this.titleeTXT.TabIndex = 1;
            this.titleeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleeTXT.WatermarkText = "موضوع یادآور";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.SaveBtn.ButtonImage = global::CRM.Properties.Resources.icons8_checkmark_480;
            this.SaveBtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.SaveBtn.ButtonText = "ثبت یادآور";
            this.SaveBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.SaveBtn.ClickTextColor = System.Drawing.Color.Blue;
            this.SaveBtn.CornerRadius = 5;
            this.SaveBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveBtn.HoverTextColor = System.Drawing.Color.Black;
            this.SaveBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SaveBtn.Location = new System.Drawing.Point(16, 82);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(155, 41);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // InfoTxt
            // 
            this.InfoTxt.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.InfoTxt.Border.BackColor = System.Drawing.SystemColors.Window;
            this.InfoTxt.Border.Class = "TextBoxBorder";
            this.InfoTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.InfoTxt.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTxt.Location = new System.Drawing.Point(177, 34);
            this.InfoTxt.Multiline = true;
            this.InfoTxt.Name = "InfoTxt";
            this.InfoTxt.PreventEnterBeep = true;
            this.InfoTxt.Size = new System.Drawing.Size(629, 90);
            this.InfoTxt.TabIndex = 2;
            this.InfoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfoTxt.WatermarkText = "جزییات یادآور";
            // 
            // UsernameTXT
            // 
            this.UsernameTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UsernameTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UsernameTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.UsernameTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.UsernameTXT.Border.Class = "TextBoxBorder";
            this.UsernameTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.UsernameTXT.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTXT.Location = new System.Drawing.Point(858, 33);
            this.UsernameTXT.Name = "UsernameTXT";
            this.UsernameTXT.PreventEnterBeep = true;
            this.UsernameTXT.Size = new System.Drawing.Size(343, 42);
            this.UsernameTXT.TabIndex = 0;
            this.UsernameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameTXT.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.UsernameTXT.WatermarkText = "جستجو کاربر بر اساس نام";
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGV.Location = new System.Drawing.Point(12, 252);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(1220, 350);
            this.DGV.TabIndex = 13;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxX4);
            this.groupBox2.Controls.Add(this.checkBoxX2);
            this.groupBox2.Controls.Add(this.checkBoxX1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(7, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "افزودن مشتری جدید";
            // 
            // textBoxX4
            // 
            this.textBoxX4.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.textBoxX4.Border.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.textBoxX4.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX4.Location = new System.Drawing.Point(372, 33);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.PreventEnterBeep = true;
            this.textBoxX4.Size = new System.Drawing.Size(761, 42);
            this.textBoxX4.TabIndex = 11;
            this.textBoxX4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxX4.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.textBoxX4.WatermarkText = "جستجو کاربر بر اساس نام";
            // 
            // checkBoxX2
            // 
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.Location = new System.Drawing.Point(16, 40);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(118, 37);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 2;
            this.checkBoxX2.Text = "موضوع یادآور";
            this.checkBoxX2.TextColor = System.Drawing.Color.White;
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(155, 40);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(83, 37);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 1;
            this.checkBoxX1.Text = "نام کاربر";
            this.checkBoxX1.TextColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "بر اساس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1139, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "جستجو";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(572, 615);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 28);
            this.label11.TabIndex = 26;
            this.label11.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(643, 614);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 28);
            this.label10.TabIndex = 25;
            this.label10.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(611, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 28);
            this.label9.TabIndex = 24;
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
            this.label8.TabIndex = 23;
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
            this.label7.TabIndex = 22;
            this.label7.Text = "صفحه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(821, 616);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(879, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "تعداد کل یاد آور های انجام شده در این لحظه";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton1.ButtonImage = global::CRM.Properties.Resources.icons8_back_to_96;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "برگشت به صفحه اصلی";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.Blue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold);
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(12, 608);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(216, 41);
            this.xuiButton1.TabIndex = 2;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.تغییروضعیتToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 94);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11F);
            this.ویرایشToolStripMenuItem.Image = global::CRM.Properties.Resources.icons8_edit_16;
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            // 
            // تغییروضعیتToolStripMenuItem
            // 
            this.تغییروضعیتToolStripMenuItem.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11F);
            this.تغییروضعیتToolStripMenuItem.Image = global::CRM.Properties.Resources.icons8_change_18__ldpi_;
            this.تغییروضعیتToolStripMenuItem.Name = "تغییروضعیتToolStripMenuItem";
            this.تغییروضعیتToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.تغییروضعیتToolStripMenuItem.Text = "تغییر وضعیت";
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.حذفToolStripMenuItem.Image = global::CRM.Properties.Resources.icons8_delete_32;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.حذفToolStripMenuItem.Text = "حذف";
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1244, 661);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReminderForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReminderForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTXt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private XanderUI.XUIButton SaveBtn;
        private DevComponents.DotNetBar.Controls.TextBoxX InfoTxt;
        private DevComponents.DotNetBar.Controls.TextBoxX UsernameTXT;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTXt;
        private DevComponents.DotNetBar.Controls.TextBoxX titleeTXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private XanderUI.XUIButton xuiButton1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تغییروضعیتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private XanderUI.XUIButton SaveUserBtn;
    }
}