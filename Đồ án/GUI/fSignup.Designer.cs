namespace Đồ_án
{
    partial class fSignup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSignUpIdentity = new System.Windows.Forms.Label();
            this.txbIdentity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbCheck = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txbConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbAccountName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSignUpConfirmPassword = new System.Windows.Forms.Label();
            this.lbSignUpPassword = new System.Windows.Forms.Label();
            this.lbSignUpAccountName = new System.Windows.Forms.Label();
            this.lbSignUpPhoneNumber = new System.Windows.Forms.Label();
            this.lbSignUpEmail = new System.Windows.Forms.Label();
            this.lbSignUpUserName = new System.Windows.Forms.Label();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.picSignUp = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbSignUpIdentity);
            this.panel1.Controls.Add(this.txbIdentity);
            this.panel1.Controls.Add(this.lbCheck);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txbConfirm);
            this.panel1.Controls.Add(this.txbPassword);
            this.panel1.Controls.Add(this.txbAccountName);
            this.panel1.Controls.Add(this.txbPhoneNumber);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.lbSignUpConfirmPassword);
            this.panel1.Controls.Add(this.lbSignUpPassword);
            this.panel1.Controls.Add(this.lbSignUpAccountName);
            this.panel1.Controls.Add(this.lbSignUpPhoneNumber);
            this.panel1.Controls.Add(this.lbSignUpEmail);
            this.panel1.Controls.Add(this.lbSignUpUserName);
            this.panel1.Location = new System.Drawing.Point(30, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 730);
            this.panel1.TabIndex = 0;
            // 
            // lbSignUpIdentity
            // 
            this.lbSignUpIdentity.AutoSize = true;
            this.lbSignUpIdentity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUpIdentity.ForeColor = System.Drawing.Color.DimGray;
            this.lbSignUpIdentity.Location = new System.Drawing.Point(22, 184);
            this.lbSignUpIdentity.Name = "lbSignUpIdentity";
            this.lbSignUpIdentity.Size = new System.Drawing.Size(91, 25);
            this.lbSignUpIdentity.TabIndex = 15;
            this.lbSignUpIdentity.Text = "Identity";
            // 
            // txbIdentity
            // 
            this.txbIdentity.BorderColor = System.Drawing.Color.LightGray;
            this.txbIdentity.BorderRadius = 10;
            this.txbIdentity.BorderThickness = 2;
            this.txbIdentity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIdentity.DefaultText = "";
            this.txbIdentity.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbIdentity.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbIdentity.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbIdentity.DisabledState.Parent = this.txbIdentity;
            this.txbIdentity.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbIdentity.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbIdentity.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbIdentity.FocusedState.Parent = this.txbIdentity;
            this.txbIdentity.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdentity.ForeColor = System.Drawing.Color.DimGray;
            this.txbIdentity.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbIdentity.HoverState.Parent = this.txbIdentity;
            this.txbIdentity.Location = new System.Drawing.Point(27, 213);
            this.txbIdentity.Margin = new System.Windows.Forms.Padding(4);
            this.txbIdentity.Name = "txbIdentity";
            this.txbIdentity.PasswordChar = '\0';
            this.txbIdentity.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbIdentity.PlaceholderText = "Identity";
            this.txbIdentity.SelectedText = "";
            this.txbIdentity.ShadowDecoration.Parent = this.txbIdentity;
            this.txbIdentity.Size = new System.Drawing.Size(394, 43);
            this.txbIdentity.TabIndex = 3;
            this.txbIdentity.TextOffset = new System.Drawing.Point(10, 0);
            this.txbIdentity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Location = new System.Drawing.Point(126, 639);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(16, 17);
            this.lbCheck.TabIndex = 13;
            this.lbCheck.Text = "ff";
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
            this.btnExit.Location = new System.Drawing.Point(287, 669);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(139, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnSubmit.Location = new System.Drawing.Point(32, 669);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(139, 45);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txbConfirm
            // 
            this.txbConfirm.BorderColor = System.Drawing.Color.LightGray;
            this.txbConfirm.BorderRadius = 10;
            this.txbConfirm.BorderThickness = 2;
            this.txbConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbConfirm.DefaultText = "";
            this.txbConfirm.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbConfirm.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbConfirm.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbConfirm.DisabledState.Parent = this.txbConfirm;
            this.txbConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbConfirm.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbConfirm.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbConfirm.FocusedState.Parent = this.txbConfirm;
            this.txbConfirm.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.txbConfirm.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbConfirm.HoverState.Parent = this.txbConfirm;
            this.txbConfirm.Location = new System.Drawing.Point(27, 581);
            this.txbConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txbConfirm.Name = "txbConfirm";
            this.txbConfirm.PasswordChar = '\0';
            this.txbConfirm.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbConfirm.PlaceholderText = "Confirm Password";
            this.txbConfirm.SelectedText = "";
            this.txbConfirm.ShadowDecoration.Parent = this.txbConfirm;
            this.txbConfirm.Size = new System.Drawing.Size(394, 43);
            this.txbConfirm.TabIndex = 7;
            this.txbConfirm.TextOffset = new System.Drawing.Point(10, 0);
            this.txbConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
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
            this.txbPassword.Location = new System.Drawing.Point(27, 488);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '\0';
            this.txbPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbPassword.PlaceholderText = "Password";
            this.txbPassword.SelectedText = "";
            this.txbPassword.ShadowDecoration.Parent = this.txbPassword;
            this.txbPassword.Size = new System.Drawing.Size(394, 43);
            this.txbPassword.TabIndex = 6;
            this.txbPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // txbAccountName
            // 
            this.txbAccountName.BorderColor = System.Drawing.Color.LightGray;
            this.txbAccountName.BorderRadius = 10;
            this.txbAccountName.BorderThickness = 2;
            this.txbAccountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAccountName.DefaultText = "";
            this.txbAccountName.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbAccountName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbAccountName.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbAccountName.DisabledState.Parent = this.txbAccountName;
            this.txbAccountName.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbAccountName.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbAccountName.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbAccountName.FocusedState.Parent = this.txbAccountName;
            this.txbAccountName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccountName.ForeColor = System.Drawing.Color.DimGray;
            this.txbAccountName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbAccountName.HoverState.Parent = this.txbAccountName;
            this.txbAccountName.Location = new System.Drawing.Point(27, 400);
            this.txbAccountName.Margin = new System.Windows.Forms.Padding(4);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.PasswordChar = '\0';
            this.txbAccountName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbAccountName.PlaceholderText = "Account Name";
            this.txbAccountName.SelectedText = "";
            this.txbAccountName.ShadowDecoration.Parent = this.txbAccountName;
            this.txbAccountName.Size = new System.Drawing.Size(394, 43);
            this.txbAccountName.TabIndex = 5;
            this.txbAccountName.TextOffset = new System.Drawing.Point(10, 0);
            this.txbAccountName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.BorderColor = System.Drawing.Color.LightGray;
            this.txbPhoneNumber.BorderRadius = 10;
            this.txbPhoneNumber.BorderThickness = 2;
            this.txbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhoneNumber.DefaultText = "";
            this.txbPhoneNumber.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbPhoneNumber.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbPhoneNumber.DisabledState.Parent = this.txbPhoneNumber;
            this.txbPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbPhoneNumber.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbPhoneNumber.FocusedState.Parent = this.txbPhoneNumber;
            this.txbPhoneNumber.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txbPhoneNumber.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbPhoneNumber.HoverState.Parent = this.txbPhoneNumber;
            this.txbPhoneNumber.Location = new System.Drawing.Point(27, 124);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.PasswordChar = '\0';
            this.txbPhoneNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbPhoneNumber.PlaceholderText = "Phone Number";
            this.txbPhoneNumber.SelectedText = "";
            this.txbPhoneNumber.ShadowDecoration.Parent = this.txbPhoneNumber;
            this.txbPhoneNumber.Size = new System.Drawing.Size(394, 43);
            this.txbPhoneNumber.TabIndex = 2;
            this.txbPhoneNumber.TextOffset = new System.Drawing.Point(10, 0);
            this.txbPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // txbEmail
            // 
            this.txbEmail.BorderColor = System.Drawing.Color.LightGray;
            this.txbEmail.BorderRadius = 10;
            this.txbEmail.BorderThickness = 2;
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "";
            this.txbEmail.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbEmail.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbEmail.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbEmail.DisabledState.Parent = this.txbEmail;
            this.txbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbEmail.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbEmail.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbEmail.FocusedState.Parent = this.txbEmail;
            this.txbEmail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbEmail.HoverState.Parent = this.txbEmail;
            this.txbEmail.Location = new System.Drawing.Point(27, 305);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbEmail.PlaceholderText = "Email";
            this.txbEmail.SelectedText = "";
            this.txbEmail.ShadowDecoration.Parent = this.txbEmail;
            this.txbEmail.Size = new System.Drawing.Size(394, 43);
            this.txbEmail.TabIndex = 4;
            this.txbEmail.TextOffset = new System.Drawing.Point(10, 0);
            this.txbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // txbName
            // 
            this.txbName.BorderColor = System.Drawing.Color.LightGray;
            this.txbName.BorderRadius = 10;
            this.txbName.BorderThickness = 2;
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.DefaultText = "";
            this.txbName.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbName.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbName.DisabledState.Parent = this.txbName;
            this.txbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbName.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbName.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbName.FocusedState.Parent = this.txbName;
            this.txbName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.DimGray;
            this.txbName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbName.HoverState.Parent = this.txbName;
            this.txbName.Location = new System.Drawing.Point(27, 33);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Name = "txbName";
            this.txbName.PasswordChar = '\0';
            this.txbName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbName.PlaceholderText = "Name";
            this.txbName.SelectedText = "";
            this.txbName.ShadowDecoration.Parent = this.txbName;
            this.txbName.Size = new System.Drawing.Size(394, 43);
            this.txbName.TabIndex = 1;
            this.txbName.TextOffset = new System.Drawing.Point(10, 0);
            this.txbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // lbSignUpConfirmPassword
            // 
            this.lbSignUpConfirmPassword.AutoSize = true;
            this.lbSignUpConfirmPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUpConfirmPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lbSignUpConfirmPassword.Location = new System.Drawing.Point(27, 552);
            this.lbSignUpConfirmPassword.Name = "lbSignUpConfirmPassword";
            this.lbSignUpConfirmPassword.Size = new System.Drawing.Size(192, 25);
            this.lbSignUpConfirmPassword.TabIndex = 0;
            this.lbSignUpConfirmPassword.Text = "Confirm Password";
            // 
            // lbSignUpPassword
            // 
            this.lbSignUpPassword.AutoSize = true;
            this.lbSignUpPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUpPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lbSignUpPassword.Location = new System.Drawing.Point(27, 462);
            this.lbSignUpPassword.Name = "lbSignUpPassword";
            this.lbSignUpPassword.Size = new System.Drawing.Size(105, 25);
            this.lbSignUpPassword.TabIndex = 0;
            this.lbSignUpPassword.Text = "Password";
            // 
            // lbSignUpAccountName
            // 
            this.lbSignUpAccountName.AutoSize = true;
            this.lbSignUpAccountName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUpAccountName.ForeColor = System.Drawing.Color.DimGray;
            this.lbSignUpAccountName.Location = new System.Drawing.Point(27, 371);
            this.lbSignUpAccountName.Name = "lbSignUpAccountName";
            this.lbSignUpAccountName.Size = new System.Drawing.Size(157, 25);
            this.lbSignUpAccountName.TabIndex = 0;
            this.lbSignUpAccountName.Text = "Account Name";
            // 
            // lbSignUpPhoneNumber
            // 
            this.lbSignUpPhoneNumber.AutoSize = true;
            this.lbSignUpPhoneNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUpPhoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.lbSignUpPhoneNumber.Location = new System.Drawing.Point(27, 95);
            this.lbSignUpPhoneNumber.Name = "lbSignUpPhoneNumber";
            this.lbSignUpPhoneNumber.Size = new System.Drawing.Size(161, 25);
            this.lbSignUpPhoneNumber.TabIndex = 0;
            this.lbSignUpPhoneNumber.Text = "Phone Number";
            // 
            // lbSignUpEmail
            // 
            this.lbSignUpEmail.AutoSize = true;
            this.lbSignUpEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUpEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lbSignUpEmail.Location = new System.Drawing.Point(27, 276);
            this.lbSignUpEmail.Name = "lbSignUpEmail";
            this.lbSignUpEmail.Size = new System.Drawing.Size(68, 25);
            this.lbSignUpEmail.TabIndex = 0;
            this.lbSignUpEmail.Text = "Email";
            // 
            // lbSignUpUserName
            // 
            this.lbSignUpUserName.AutoSize = true;
            this.lbSignUpUserName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUpUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lbSignUpUserName.Location = new System.Drawing.Point(22, 4);
            this.lbSignUpUserName.Name = "lbSignUpUserName";
            this.lbSignUpUserName.Size = new System.Drawing.Size(70, 25);
            this.lbSignUpUserName.TabIndex = 0;
            this.lbSignUpUserName.Text = "Name";
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.ForeColor = System.Drawing.Color.White;
            this.lbSignUp.Location = new System.Drawing.Point(197, 12);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(143, 36);
            this.lbSignUp.TabIndex = 0;
            this.lbSignUp.Text = "Sign Up";
            // 
            // picSignUp
            // 
            this.picSignUp.BackColor = System.Drawing.Color.Blue;
            this.picSignUp.Image = global::Đồ_án.Properties.Resources.Untitled1;
            this.picSignUp.Location = new System.Drawing.Point(78, 1);
            this.picSignUp.Name = "picSignUp";
            this.picSignUp.Size = new System.Drawing.Size(113, 61);
            this.picSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSignUp.TabIndex = 0;
            this.picSignUp.TabStop = false;
            // 
            // fSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(525, 810);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.picSignUp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSignup";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSignUp;
        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.Label lbSignUpUserName;
        private System.Windows.Forms.Label lbSignUpEmail;
        private System.Windows.Forms.Label lbSignUpAccountName;
        private System.Windows.Forms.Label lbSignUpPhoneNumber;
        private System.Windows.Forms.Label lbSignUpPassword;
        private System.Windows.Forms.Label lbSignUpConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txbName;
        private Guna.UI2.WinForms.Guna2TextBox txbConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txbPassword;
        private Guna.UI2.WinForms.Guna2TextBox txbAccountName;
        private Guna.UI2.WinForms.Guna2TextBox txbPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.Label lbSignUpIdentity;
        private Guna.UI2.WinForms.Guna2TextBox txbIdentity;
    }
}