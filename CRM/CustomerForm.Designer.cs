namespace CRM
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveBtn = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PhoneTXT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NameTXT);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن مشتری جدید";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.SaveBtn.ButtonImage = global::CRM.Properties.Resources.icons8_checkmark_480;
            this.SaveBtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.SaveBtn.ButtonText = "ثبت اطلاعات";
            this.SaveBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.SaveBtn.ClickTextColor = System.Drawing.Color.Blue;
            this.SaveBtn.CornerRadius = 5;
            this.SaveBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.SaveBtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SaveBtn.Location = new System.Drawing.Point(16, 35);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(155, 41);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn.Click += new System.EventHandler(this.xuiButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "شماره تماس";
            // 
            // PhoneTXT
            // 
            this.PhoneTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.PhoneTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.PhoneTXT.Border.Class = "TextBoxBorder";
            this.PhoneTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.PhoneTXT.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTXT.Location = new System.Drawing.Point(210, 34);
            this.PhoneTXT.MaxLength = 11;
            this.PhoneTXT.Name = "PhoneTXT";
            this.PhoneTXT.PreventEnterBeep = true;
            this.PhoneTXT.Size = new System.Drawing.Size(391, 42);
            this.PhoneTXT.TabIndex = 1;
            this.PhoneTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneTXT.TextChanged += new System.EventHandler(this.PhoneTXT_TextChanged);
            this.PhoneTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTXT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1115, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "نام مشتری";
            // 
            // NameTXT
            // 
            this.NameTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.NameTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.NameTXT.Border.Class = "TextBoxBorder";
            this.NameTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.NameTXT.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTXT.Location = new System.Drawing.Point(718, 34);
            this.NameTXT.MaxLength = 50;
            this.NameTXT.Name = "NameTXT";
            this.NameTXT.PreventEnterBeep = true;
            this.NameTXT.Size = new System.Drawing.Size(391, 42);
            this.NameTXT.TabIndex = 0;
            this.NameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SearchTXT);
            this.groupBox2.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 94);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو مشریان";
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
            this.SearchTXT.Location = new System.Drawing.Point(16, 35);
            this.SearchTXT.MaxLength = 50;
            this.SearchTXT.Name = "SearchTXT";
            this.SearchTXT.PreventEnterBeep = true;
            this.SearchTXT.Size = new System.Drawing.Size(1117, 42);
            this.SearchTXT.TabIndex = 0;
            this.SearchTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTXT.TextChanged += new System.EventHandler(this.SearchTXT_TextChanged);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Cursor = System.Windows.Forms.Cursors.PanWest;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGV.Location = new System.Drawing.Point(12, 215);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1220, 391);
            this.DGV.TabIndex = 11;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1032, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "کل مشتریان تا این لحظه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(959, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(676, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "صفحه";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(511, 619);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "صفحه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(611, 619);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 28);
            this.label9.TabIndex = 16;
            this.label9.Text = "از";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(645, 619);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("IRANSansWeb(FaNum) UltraLight", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(580, 619);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 28);
            this.label11.TabIndex = 18;
            this.label11.Text = "0";
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
            this.xuiButton1.Location = new System.Drawing.Point(12, 612);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(216, 41);
            this.xuiButton1.TabIndex = 1;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Image = global::CRM.Properties.Resources.icons8_edit_16;
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::CRM.Properties.Resources.icons8_delete_32;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // CustomerForm
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
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.xuiButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX PhoneTXT;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX NameTXT;
        private XanderUI.XUIButton SaveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX SearchTXT;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
    }
}