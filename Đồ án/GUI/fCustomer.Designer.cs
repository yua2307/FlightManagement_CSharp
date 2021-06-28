namespace Project.fForm
{
    partial class fCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnFlightBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnFlightSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelManage = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.CircleBtnAccessF = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.panelAccessF = new Guna.UI2.WinForms.Guna2Panel();
            this.txbPermission = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.btnManage = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelManage.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelAccessF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnFlightBooking);
            this.panel1.Controls.Add(this.btnFlightSchedule);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 644);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 22;
            this.btnExit.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnExit.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnExit.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Blue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.HoverState.Image")));
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnExit.Location = new System.Drawing.Point(65, 514);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(138, 105);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.BorderRadius = 22;
            this.btnAccount.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAccount.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAccount.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnAccount.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAccount.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.btnAccount.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.CheckedState.Image")));
            this.btnAccount.CheckedState.Parent = this.btnAccount;
            this.btnAccount.CustomImages.Parent = this.btnAccount;
            this.btnAccount.FillColor = System.Drawing.Color.Blue;
            this.btnAccount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.btnAccount.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.HoverState.Image")));
            this.btnAccount.HoverState.Parent = this.btnAccount;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAccount.Location = new System.Drawing.Point(12, 404);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.ShadowDecoration.Parent = this.btnAccount;
            this.btnAccount.Size = new System.Drawing.Size(268, 58);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseTransparentBackground = true;
            this.btnAccount.CheckedChanged += new System.EventHandler(this.Button_CheckedChanged);
            // 
            // btnFlightBooking
            // 
            this.btnFlightBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnFlightBooking.BorderRadius = 22;
            this.btnFlightBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFlightBooking.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnFlightBooking.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnFlightBooking.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFlightBooking.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.btnFlightBooking.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnFlightBooking.CheckedState.Image")));
            this.btnFlightBooking.CheckedState.Parent = this.btnFlightBooking;
            this.btnFlightBooking.CustomImages.Parent = this.btnFlightBooking;
            this.btnFlightBooking.FillColor = System.Drawing.Color.Blue;
            this.btnFlightBooking.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightBooking.ForeColor = System.Drawing.Color.White;
            this.btnFlightBooking.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(160)))));
            this.btnFlightBooking.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnFlightBooking.HoverState.Image")));
            this.btnFlightBooking.HoverState.Parent = this.btnFlightBooking;
            this.btnFlightBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnFlightBooking.Image")));
            this.btnFlightBooking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFlightBooking.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFlightBooking.Location = new System.Drawing.Point(12, 299);
            this.btnFlightBooking.Name = "btnFlightBooking";
            this.btnFlightBooking.ShadowDecoration.Parent = this.btnFlightBooking;
            this.btnFlightBooking.Size = new System.Drawing.Size(268, 58);
            this.btnFlightBooking.TabIndex = 4;
            this.btnFlightBooking.Text = "Flight Booking";
            this.btnFlightBooking.UseTransparentBackground = true;
            this.btnFlightBooking.CheckedChanged += new System.EventHandler(this.Button_CheckedChanged);
            // 
            // btnFlightSchedule
            // 
            this.btnFlightSchedule.BackColor = System.Drawing.Color.Transparent;
            this.btnFlightSchedule.BorderRadius = 22;
            this.btnFlightSchedule.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFlightSchedule.Checked = true;
            this.btnFlightSchedule.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnFlightSchedule.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnFlightSchedule.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFlightSchedule.CheckedState.ForeColor = System.Drawing.Color.Blue;
            this.btnFlightSchedule.CheckedState.Image = global::Đồ_án.Properties.Resources.computer_icons_calendar_day_time_schedule_png_clip_art_thumbnail;
            this.btnFlightSchedule.CheckedState.Parent = this.btnFlightSchedule;
            this.btnFlightSchedule.CustomImages.Parent = this.btnFlightSchedule;
            this.btnFlightSchedule.FillColor = System.Drawing.Color.Blue;
            this.btnFlightSchedule.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlightSchedule.ForeColor = System.Drawing.Color.White;
            this.btnFlightSchedule.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFlightSchedule.HoverState.Parent = this.btnFlightSchedule;
            this.btnFlightSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnFlightSchedule.Image")));
            this.btnFlightSchedule.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFlightSchedule.ImageSize = new System.Drawing.Size(24, 24);
            this.btnFlightSchedule.Location = new System.Drawing.Point(12, 197);
            this.btnFlightSchedule.Name = "btnFlightSchedule";
            this.btnFlightSchedule.ShadowDecoration.Parent = this.btnFlightSchedule;
            this.btnFlightSchedule.Size = new System.Drawing.Size(268, 58);
            this.btnFlightSchedule.TabIndex = 2;
            this.btnFlightSchedule.Text = "Flight Schedule";
            this.btnFlightSchedule.UseTransparentBackground = true;
            this.btnFlightSchedule.CheckedChanged += new System.EventHandler(this.Button_CheckedChanged);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picLogo.ErrorImage")));
            this.picLogo.Image = global::Đồ_án.Properties.Resources.airplane_clipart_logo_312;
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(290, 136);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Blue;
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.Image = global::Đồ_án.Properties.Resources.temp2;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(253, 174);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(40, 107);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // panelManage
            // 
            this.panelManage.Controls.Add(this.panelLogo);
            this.panelManage.Controls.Add(this.panelCustomer);
            this.panelManage.Location = new System.Drawing.Point(295, 3);
            this.panelManage.Name = "panelManage";
            this.panelManage.Size = new System.Drawing.Size(717, 641);
            this.panelManage.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.CircleBtnAccessF);
            this.panelLogo.Location = new System.Drawing.Point(4, 9);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(710, 114);
            this.panelLogo.TabIndex = 1;
            // 
            // CircleBtnAccessF
            // 
            this.CircleBtnAccessF.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CircleBtnAccessF.CheckedState.ForeColor = System.Drawing.Color.White;
            this.CircleBtnAccessF.CheckedState.Parent = this.CircleBtnAccessF;
            this.CircleBtnAccessF.CustomImages.Parent = this.CircleBtnAccessF;
            this.CircleBtnAccessF.FillColor = System.Drawing.Color.Blue;
            this.CircleBtnAccessF.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleBtnAccessF.ForeColor = System.Drawing.Color.White;
            this.CircleBtnAccessF.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CircleBtnAccessF.HoverState.ForeColor = System.Drawing.Color.White;
            this.CircleBtnAccessF.HoverState.Parent = this.CircleBtnAccessF;
            this.CircleBtnAccessF.Location = new System.Drawing.Point(633, 57);
            this.CircleBtnAccessF.Name = "CircleBtnAccessF";
            this.CircleBtnAccessF.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleBtnAccessF.ShadowDecoration.Parent = this.CircleBtnAccessF;
            this.CircleBtnAccessF.Size = new System.Drawing.Size(60, 54);
            this.CircleBtnAccessF.TabIndex = 0;
            this.CircleBtnAccessF.Visible = false;
            this.CircleBtnAccessF.Click += new System.EventHandler(this.CircleBtnAccessF_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.panelAccessF);
            this.panelCustomer.Location = new System.Drawing.Point(3, 129);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(711, 509);
            this.panelCustomer.TabIndex = 0;
            // 
            // panelAccessF
            // 
            this.panelAccessF.BorderColor = System.Drawing.Color.Gray;
            this.panelAccessF.BorderRadius = 12;
            this.panelAccessF.BorderThickness = 2;
            this.panelAccessF.Controls.Add(this.txbPermission);
            this.panelAccessF.Controls.Add(this.txbUsername);
            this.panelAccessF.Controls.Add(this.btnManage);
            this.panelAccessF.FillColor = System.Drawing.Color.White;
            this.panelAccessF.Location = new System.Drawing.Point(494, 3);
            this.panelAccessF.Name = "panelAccessF";
            this.panelAccessF.ShadowDecoration.Parent = this.panelAccessF;
            this.panelAccessF.Size = new System.Drawing.Size(200, 185);
            this.panelAccessF.TabIndex = 0;
            this.panelAccessF.Visible = false;
            // 
            // txbPermission
            // 
            this.txbPermission.BackColor = System.Drawing.Color.White;
            this.txbPermission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPermission.Enabled = false;
            this.txbPermission.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPermission.Location = new System.Drawing.Point(3, 20);
            this.txbPermission.Name = "txbPermission";
            this.txbPermission.Size = new System.Drawing.Size(194, 22);
            this.txbPermission.TabIndex = 12;
            this.txbPermission.Text = "Permission";
            this.txbPermission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.White;
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Enabled = false;
            this.txbUsername.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(3, 62);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(194, 19);
            this.txbUsername.TabIndex = 1;
            this.txbUsername.Text = "userName";
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnManage
            // 
            this.btnManage.BorderRadius = 10;
            this.btnManage.CheckedState.Parent = this.btnManage;
            this.btnManage.CustomImages.Parent = this.btnManage;
            this.btnManage.FillColor = System.Drawing.Color.Blue;
            this.btnManage.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnManage.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnManage.HoverState.Parent = this.btnManage;
            this.btnManage.Location = new System.Drawing.Point(31, 109);
            this.btnManage.Name = "btnManage";
            this.btnManage.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnManage.ShadowDecoration.Parent = this.btnManage;
            this.btnManage.Size = new System.Drawing.Size(144, 57);
            this.btnManage.TabIndex = 11;
            this.btnManage.Text = "Manage";
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 644);
            this.Controls.Add(this.panelManage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fManage";
            this.Load += new System.EventHandler(this.fCustomer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelManage.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panelAccessF.ResumeLayout(false);
            this.panelAccessF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Button btnFlightSchedule;
        private System.Windows.Forms.PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Button btnFlightBooking;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Panel panelManage;
        private System.Windows.Forms.Panel panelCustomer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panelLogo;
        private Guna.UI2.WinForms.Guna2CircleButton CircleBtnAccessF;
        private Guna.UI2.WinForms.Guna2Panel panelAccessF;
        private Guna.UI2.WinForms.Guna2Button btnManage;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPermission;
    }
}