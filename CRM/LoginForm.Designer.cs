namespace CRM
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LodingLBL = new System.Windows.Forms.Label();
            this.WelcomeLBL = new System.Windows.Forms.Label();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.MainPanel = new DevComponents.DotNetBar.PanelEx();
            this.ExitBtn = new XanderUI.XUISuperButton();
            this.SuspendLayout();
            // 
            // LodingLBL
            // 
            this.LodingLBL.AutoSize = true;
            this.LodingLBL.Font = new System.Drawing.Font("IRANSansWeb", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LodingLBL.ForeColor = System.Drawing.Color.White;
            this.LodingLBL.Location = new System.Drawing.Point(474, 551);
            this.LodingLBL.Name = "LodingLBL";
            this.LodingLBL.Size = new System.Drawing.Size(297, 36);
            this.LodingLBL.TabIndex = 0;
            this.LodingLBL.Text = "درحال بارگذاری اطلاعات برنامه ...";
            this.LodingLBL.Visible = false;
            // 
            // WelcomeLBL
            // 
            this.WelcomeLBL.AutoSize = true;
            this.WelcomeLBL.Font = new System.Drawing.Font("IRANSansWeb", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLBL.ForeColor = System.Drawing.Color.White;
            this.WelcomeLBL.Location = new System.Drawing.Point(397, 292);
            this.WelcomeLBL.Name = "WelcomeLBL";
            this.WelcomeLBL.Size = new System.Drawing.Size(450, 36);
            this.WelcomeLBL.TabIndex = 1;
            this.WelcomeLBL.Text = "به نرم افزار مدیریت مشتریان توسعه گر خوش آمدید";
            this.WelcomeLBL.Visible = false;
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.progressBarX1.BackgroundStyle.BorderBottomColor = System.Drawing.Color.White;
            this.progressBarX1.BackgroundStyle.BorderBottomWidth = 1;
            this.progressBarX1.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(8)))), ((int)(((byte)(123)))));
            this.progressBarX1.BackgroundStyle.BorderColor2 = System.Drawing.Color.Black;
            this.progressBarX1.BackgroundStyle.BorderGradientAngle = 0;
            this.progressBarX1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.progressBarX1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.progressBarX1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(-4, 599);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(1253, 50);
            this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.progressBarX1.TabIndex = 4;
            // 
            // MainPanel
            // 
            this.MainPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.MainPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.MainPanel.Location = new System.Drawing.Point(411, 28);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(422, 566);
            this.MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.MainPanel.Style.BackColor1.Color = System.Drawing.Color.MidnightBlue;
            this.MainPanel.Style.BackColor2.Color = System.Drawing.Color.MidnightBlue;
            this.MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.MainPanel.Style.BorderWidth = 0;
            this.MainPanel.Style.CornerDiameter = 10;
            this.MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.MainPanel.Style.GradientAngle = 90;
            this.MainPanel.TabIndex = 5;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.ExitBtn.ButtonImage = global::CRM.Properties.Resources.icons8_exit_64;
            this.ExitBtn.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.ExitBtn.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.ExitBtn.ButtonText = "انصراف و خروج از برنامه";
            this.ExitBtn.CornerRadius = 5;
            this.ExitBtn.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.ExitBtn.HoverBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.ExitBtn.HoverTextColor = System.Drawing.Color.White;
            this.ExitBtn.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.ExitBtn.Location = new System.Drawing.Point(10, 600);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.SelectedBackColor = System.Drawing.Color.LightCoral;
            this.ExitBtn.SelectedTextColor = System.Drawing.Color.White;
            this.ExitBtn.Size = new System.Drawing.Size(219, 49);
            this.ExitBtn.SuperSelected = false;
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.TextColor = System.Drawing.Color.White;
            this.ExitBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.ExitBtn.Visible = false;
            this.ExitBtn.Click += new System.EventHandler(this.xuiSuperButton1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1244, 661);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LodingLBL);
            this.Controls.Add(this.WelcomeLBL);
            this.Controls.Add(this.progressBarX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LodingLBL;
        private System.Windows.Forms.Label WelcomeLBL;
        private XanderUI.XUISuperButton ExitBtn;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        public DevComponents.DotNetBar.PanelEx MainPanel;
    }
}