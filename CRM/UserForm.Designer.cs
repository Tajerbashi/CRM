namespace CRM
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.TypeTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.RePassTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PassTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.UserNameTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SaveBtn = new XanderUI.XUIButton();
            this.NameTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Controls.Add(this.Pic);
            this.groupBox1.Controls.Add(this.TypeTXT);
            this.groupBox1.Controls.Add(this.RePassTXT);
            this.groupBox1.Controls.Add(this.PassTXT);
            this.groupBox1.Controls.Add(this.UserNameTXT);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.NameTXT);
            this.groupBox1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن کاربر جدید";
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Cursor = System.Windows.Forms.Cursors.PanWest;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansWeb", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGV.Location = new System.Drawing.Point(6, 32);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(567, 226);
            this.DGV.TabIndex = 12;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseClick);
            // 
            // Pic
            // 
            this.Pic.Image = global::CRM.Properties.Resources.icons8_picture_gradient_144;
            this.Pic.Location = new System.Drawing.Point(579, 32);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(225, 179);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 7;
            this.Pic.TabStop = false;
            this.Pic.Click += new System.EventHandler(this.Pic_Click);
            // 
            // TypeTXT
            // 
            this.TypeTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.TypeTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.TypeTXT.Border.Class = "TextBoxBorder";
            this.TypeTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TypeTXT.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeTXT.Location = new System.Drawing.Point(810, 217);
            this.TypeTXT.Name = "TypeTXT";
            this.TypeTXT.PreventEnterBeep = true;
            this.TypeTXT.Size = new System.Drawing.Size(391, 40);
            this.TypeTXT.TabIndex = 4;
            this.TypeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TypeTXT.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TypeTXT.WatermarkText = "نوع حساب کاربری";
            // 
            // RePassTXT
            // 
            this.RePassTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.RePassTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.RePassTXT.Border.Class = "TextBoxBorder";
            this.RePassTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.RePassTXT.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePassTXT.Location = new System.Drawing.Point(810, 171);
            this.RePassTXT.MaxLength = 100;
            this.RePassTXT.Name = "RePassTXT";
            this.RePassTXT.PreventEnterBeep = true;
            this.RePassTXT.Size = new System.Drawing.Size(391, 40);
            this.RePassTXT.TabIndex = 3;
            this.RePassTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RePassTXT.UseSystemPasswordChar = true;
            this.RePassTXT.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RePassTXT.WatermarkText = "تکرار کلمه عبور";
            // 
            // PassTXT
            // 
            this.PassTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.PassTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.PassTXT.Border.Class = "TextBoxBorder";
            this.PassTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.PassTXT.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTXT.Location = new System.Drawing.Point(810, 125);
            this.PassTXT.MaxLength = 100;
            this.PassTXT.Name = "PassTXT";
            this.PassTXT.PreventEnterBeep = true;
            this.PassTXT.Size = new System.Drawing.Size(391, 40);
            this.PassTXT.TabIndex = 2;
            this.PassTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassTXT.UseSystemPasswordChar = true;
            this.PassTXT.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.PassTXT.WatermarkText = "کلمه رمز عبور";
            // 
            // UserNameTXT
            // 
            this.UserNameTXT.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.UserNameTXT.Border.BackColor = System.Drawing.SystemColors.Window;
            this.UserNameTXT.Border.Class = "TextBoxBorder";
            this.UserNameTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.UserNameTXT.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTXT.Location = new System.Drawing.Point(810, 79);
            this.UserNameTXT.MaxLength = 11;
            this.UserNameTXT.Name = "UserNameTXT";
            this.UserNameTXT.PreventEnterBeep = true;
            this.UserNameTXT.Size = new System.Drawing.Size(391, 40);
            this.UserNameTXT.TabIndex = 1;
            this.UserNameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserNameTXT.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserNameTXT.WatermarkText = "نام کاربری";
            this.UserNameTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNameTXT_KeyPress);
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
            this.SaveBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveBtn.HoverTextColor = System.Drawing.Color.Black;
            this.SaveBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SaveBtn.Location = new System.Drawing.Point(579, 217);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(225, 41);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.NameTXT.Font = new System.Drawing.Font("IRANSansWeb", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTXT.Location = new System.Drawing.Point(810, 33);
            this.NameTXT.Name = "NameTXT";
            this.NameTXT.PreventEnterBeep = true;
            this.NameTXT.Size = new System.Drawing.Size(391, 40);
            this.NameTXT.TabIndex = 0;
            this.NameTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTXT.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameTXT.WatermarkText = "نام و نام خانوادگی کاربر";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
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
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1244, 661);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Pic;
        private DevComponents.DotNetBar.Controls.TextBoxX TypeTXT;
        private DevComponents.DotNetBar.Controls.TextBoxX RePassTXT;
        private DevComponents.DotNetBar.Controls.TextBoxX PassTXT;
        private DevComponents.DotNetBar.Controls.TextBoxX UserNameTXT;
        private XanderUI.XUIButton SaveBtn;
        private DevComponents.DotNetBar.Controls.TextBoxX NameTXT;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
    }
}