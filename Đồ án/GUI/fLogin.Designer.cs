using System.Drawing;

namespace Project.fForm
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSignIn = new System.Windows.Forms.Label();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbCheck = new System.Windows.Forms.Label();
            this.lbSignup = new System.Windows.Forms.Label();
            this.picCreateNewAccount = new System.Windows.Forms.PictureBox();
            this.txbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateNewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lbSignIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 135);
            this.panel1.TabIndex = 0;
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignIn.ForeColor = System.Drawing.Color.White;
            this.lbSignIn.Location = new System.Drawing.Point(181, 59);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(170, 40);
            this.lbSignIn.TabIndex = 0;
            this.lbSignIn.Text = "SIGN IN";
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbPassword.Location = new System.Drawing.Point(81, 268);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(99, 17);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "PASSWORD";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbUserName.Location = new System.Drawing.Point(80, 171);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(100, 17);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "USER NAME";
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.ForeColor = System.Drawing.Color.Black;
            this.lbCheck.Location = new System.Drawing.Point(138, 355);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(20, 17);
            this.lbCheck.TabIndex = 5;
            this.lbCheck.Text = "!!";
            // 
            // lbSignup
            // 
            this.lbSignup.AutoSize = true;
            this.lbSignup.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignup.ForeColor = System.Drawing.Color.Black;
            this.lbSignup.Location = new System.Drawing.Point(184, 477);
            this.lbSignup.Name = "lbSignup";
            this.lbSignup.Size = new System.Drawing.Size(164, 17);
            this.lbSignup.TabIndex = 7;
            this.lbSignup.Text = "Create new Account";
            this.lbSignup.Click += new System.EventHandler(this.lbSignup_Click);
            // 
            // picCreateNewAccount
            // 
            this.picCreateNewAccount.Image = global::Đồ_án.Properties.Resources.download11;
            this.picCreateNewAccount.InitialImage = global::Đồ_án.Properties.Resources.download11;
            this.picCreateNewAccount.Location = new System.Drawing.Point(130, 464);
            this.picCreateNewAccount.Name = "picCreateNewAccount";
            this.picCreateNewAccount.Size = new System.Drawing.Size(49, 40);
            this.picCreateNewAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCreateNewAccount.TabIndex = 6;
            this.picCreateNewAccount.TabStop = false;
            // 
            // txbUserName
            // 
            this.txbUserName.BorderColor = System.Drawing.Color.LightGray;
            this.txbUserName.BorderRadius = 10;
            this.txbUserName.BorderThickness = 2;
            this.txbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUserName.DefaultText = "";
            this.txbUserName.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbUserName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbUserName.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbUserName.DisabledState.Parent = this.txbUserName;
            this.txbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbUserName.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbUserName.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbUserName.FocusedState.Parent = this.txbUserName;
            this.txbUserName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txbUserName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbUserName.HoverState.Parent = this.txbUserName;
            this.txbUserName.Location = new System.Drawing.Point(84, 192);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.PasswordChar = '\0';
            this.txbUserName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbUserName.PlaceholderText = "User Name";
            this.txbUserName.SelectedText = "";
            this.txbUserName.ShadowDecoration.Parent = this.txbUserName;
            this.txbUserName.Size = new System.Drawing.Size(335, 43);
            this.txbUserName.TabIndex = 8;
            this.txbUserName.TextOffset = new System.Drawing.Point(10, 0);
            this.txbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown);
            // 
            // txbPassword
            // 
            this.txbPassword.BorderColor = System.Drawing.Color.LightGray;
            this.txbPassword.BorderRadius = 10;
            this.txbPassword.BorderThickness = 2;
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.DefaultText = "";
            this.txbPassword.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbPassword.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbPassword.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbPassword.DisabledState.Parent = this.txbPassword;
            this.txbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbPassword.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbPassword.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbPassword.FocusedState.Parent = this.txbPassword;
            this.txbPassword.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txbPassword.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbPassword.HoverState.Parent = this.txbPassword;
            this.txbPassword.Location = new System.Drawing.Point(84, 289);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbPassword.PlaceholderText = "Password";
            this.txbPassword.SelectedText = "";
            this.txbPassword.ShadowDecoration.Parent = this.txbPassword;
            this.txbPassword.Size = new System.Drawing.Size(335, 43);
            this.txbPassword.TabIndex = 9;
            this.txbPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 10;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.Blue;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(84, 386);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(136, 45);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 10;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Blue;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(283, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(136, 45);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 522);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.lbSignup);
            this.Controls.Add(this.picCreateNewAccount);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateNewAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSignIn;
        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.PictureBox picCreateNewAccount;
        private System.Windows.Forms.Label lbSignup;
        private Guna.UI2.WinForms.Guna2TextBox txbPassword;
        private Guna.UI2.WinForms.Guna2TextBox txbUserName;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}

