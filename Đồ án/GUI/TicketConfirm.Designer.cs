namespace Đồ_án.GUI
{
    partial class TicketConfirm
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
            this.grbConfirm = new System.Windows.Forms.GroupBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.txbTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNumberOfPassenger = new System.Windows.Forms.Label();
            this.cbNumberOfPassenger = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbSeatClass = new System.Windows.Forms.Label();
            this.lbDe_Time = new System.Windows.Forms.Label();
            this.lbAr_Time = new System.Windows.Forms.Label();
            this.lbDe_Airport = new System.Windows.Forms.Label();
            this.lbAr_Airport = new System.Windows.Forms.Label();
            this.txbSeatClass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbDe_Time = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbAr_Time = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDe_Airport = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbAr_Airport = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSeat = new System.Windows.Forms.Label();
            this.lbIDTicket = new System.Windows.Forms.Label();
            this.txbSeat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbIDTicket = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTicket = new System.Windows.Forms.Label();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.cbTicket = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grbConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConfirm
            // 
            this.grbConfirm.BackColor = System.Drawing.Color.White;
            this.grbConfirm.Controls.Add(this.lbPrice);
            this.grbConfirm.Controls.Add(this.cbTicket);
            this.grbConfirm.Controls.Add(this.guna2Separator1);
            this.grbConfirm.Controls.Add(this.txbSeat);
            this.grbConfirm.Controls.Add(this.lbTotalPrice);
            this.grbConfirm.Controls.Add(this.txbSeatClass);
            this.grbConfirm.Controls.Add(this.txbPrice);
            this.grbConfirm.Controls.Add(this.btnConfirm);
            this.grbConfirm.Controls.Add(this.btnExit);
            this.grbConfirm.Controls.Add(this.txbTotalPrice);
            this.grbConfirm.Controls.Add(this.lbSeat);
            this.grbConfirm.Controls.Add(this.txbName);
            this.grbConfirm.Controls.Add(this.lbIDTicket);
            this.grbConfirm.Controls.Add(this.lbTicket);
            this.grbConfirm.Controls.Add(this.lbSeatClass);
            this.grbConfirm.Controls.Add(this.lbNumberOfPassenger);
            this.grbConfirm.Controls.Add(this.cbNumberOfPassenger);
            this.grbConfirm.Controls.Add(this.lbDe_Time);
            this.grbConfirm.Controls.Add(this.txbIDTicket);
            this.grbConfirm.Controls.Add(this.lbAr_Time);
            this.grbConfirm.Controls.Add(this.lbDe_Airport);
            this.grbConfirm.Controls.Add(this.lbAr_Airport);
            this.grbConfirm.Controls.Add(this.txbDe_Time);
            this.grbConfirm.Controls.Add(this.txbAr_Time);
            this.grbConfirm.Controls.Add(this.btnDe_Airport);
            this.grbConfirm.Controls.Add(this.txbAr_Airport);
            this.grbConfirm.Controls.Add(this.lbName);
            this.grbConfirm.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.grbConfirm.Location = new System.Drawing.Point(12, 12);
            this.grbConfirm.Name = "grbConfirm";
            this.grbConfirm.Size = new System.Drawing.Size(661, 720);
            this.grbConfirm.TabIndex = 0;
            this.grbConfirm.TabStop = false;
            this.grbConfirm.Text = "Ticket Verify";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTotalPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lbTotalPrice.Location = new System.Drawing.Point(364, 288);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(126, 23);
            this.lbTotalPrice.TabIndex = 20;
            this.lbTotalPrice.Text = "Total Price";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.BorderColor = System.Drawing.Color.LightGray;
            this.txbTotalPrice.BorderRadius = 10;
            this.txbTotalPrice.BorderThickness = 2;
            this.txbTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTotalPrice.DefaultText = "";
            this.txbTotalPrice.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbTotalPrice.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbTotalPrice.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbTotalPrice.DisabledState.Parent = this.txbTotalPrice;
            this.txbTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbTotalPrice.Enabled = false;
            this.txbTotalPrice.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbTotalPrice.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbTotalPrice.FocusedState.Parent = this.txbTotalPrice;
            this.txbTotalPrice.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txbTotalPrice.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbTotalPrice.HoverState.Parent = this.txbTotalPrice;
            this.txbTotalPrice.Location = new System.Drawing.Point(368, 315);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.PasswordChar = '\0';
            this.txbTotalPrice.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbTotalPrice.PlaceholderText = "Total amount";
            this.txbTotalPrice.SelectedText = "";
            this.txbTotalPrice.ShadowDecoration.Parent = this.txbTotalPrice;
            this.txbTotalPrice.Size = new System.Drawing.Size(283, 45);
            this.txbTotalPrice.TabIndex = 6;
            this.txbTotalPrice.TextOffset = new System.Drawing.Point(10, 0);
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
            this.txbName.Enabled = false;
            this.txbName.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbName.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbName.FocusedState.Parent = this.txbName;
            this.txbName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.DimGray;
            this.txbName.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbName.HoverState.Parent = this.txbName;
            this.txbName.Location = new System.Drawing.Point(10, 65);
            this.txbName.Margin = new System.Windows.Forms.Padding(4);
            this.txbName.Name = "txbName";
            this.txbName.PasswordChar = '\0';
            this.txbName.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txbName.PlaceholderText = "Name";
            this.txbName.SelectedText = "";
            this.txbName.ShadowDecoration.Parent = this.txbName;
            this.txbName.Size = new System.Drawing.Size(283, 45);
            this.txbName.TabIndex = 19;
            this.txbName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lbNumberOfPassenger
            // 
            this.lbNumberOfPassenger.AutoSize = true;
            this.lbNumberOfPassenger.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbNumberOfPassenger.ForeColor = System.Drawing.Color.DimGray;
            this.lbNumberOfPassenger.Location = new System.Drawing.Point(6, 288);
            this.lbNumberOfPassenger.Name = "lbNumberOfPassenger";
            this.lbNumberOfPassenger.Size = new System.Drawing.Size(241, 23);
            this.lbNumberOfPassenger.TabIndex = 18;
            this.lbNumberOfPassenger.Text = "Number of Passenger";
            // 
            // cbNumberOfPassenger
            // 
            this.cbNumberOfPassenger.BackColor = System.Drawing.Color.Transparent;
            this.cbNumberOfPassenger.BorderColor = System.Drawing.Color.LightGray;
            this.cbNumberOfPassenger.BorderRadius = 14;
            this.cbNumberOfPassenger.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNumberOfPassenger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumberOfPassenger.FocusedColor = System.Drawing.Color.DimGray;
            this.cbNumberOfPassenger.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.cbNumberOfPassenger.FocusedState.ForeColor = System.Drawing.Color.DimGray;
            this.cbNumberOfPassenger.FocusedState.Parent = this.cbNumberOfPassenger;
            this.cbNumberOfPassenger.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNumberOfPassenger.ForeColor = System.Drawing.Color.Black;
            this.cbNumberOfPassenger.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.cbNumberOfPassenger.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.cbNumberOfPassenger.HoverState.Parent = this.cbNumberOfPassenger;
            this.cbNumberOfPassenger.ItemHeight = 30;
            this.cbNumberOfPassenger.ItemsAppearance.Parent = this.cbNumberOfPassenger;
            this.cbNumberOfPassenger.ItemsAppearance.SelectedForeColor = System.Drawing.Color.DimGray;
            this.cbNumberOfPassenger.Location = new System.Drawing.Point(48, 324);
            this.cbNumberOfPassenger.Name = "cbNumberOfPassenger";
            this.cbNumberOfPassenger.ShadowDecoration.Parent = this.cbNumberOfPassenger;
            this.cbNumberOfPassenger.Size = new System.Drawing.Size(190, 36);
            this.cbNumberOfPassenger.TabIndex = 17;
            // 
            // lbSeatClass
            // 
            this.lbSeatClass.AutoSize = true;
            this.lbSeatClass.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbSeatClass.ForeColor = System.Drawing.Color.DimGray;
            this.lbSeatClass.Location = new System.Drawing.Point(364, 536);
            this.lbSeatClass.Name = "lbSeatClass";
            this.lbSeatClass.Size = new System.Drawing.Size(122, 23);
            this.lbSeatClass.TabIndex = 16;
            this.lbSeatClass.Text = "Seat Class";
            // 
            // lbDe_Time
            // 
            this.lbDe_Time.AutoSize = true;
            this.lbDe_Time.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbDe_Time.ForeColor = System.Drawing.Color.DimGray;
            this.lbDe_Time.Location = new System.Drawing.Point(6, 203);
            this.lbDe_Time.Name = "lbDe_Time";
            this.lbDe_Time.Size = new System.Drawing.Size(179, 23);
            this.lbDe_Time.TabIndex = 14;
            this.lbDe_Time.Text = "Departure Time";
            // 
            // lbAr_Time
            // 
            this.lbAr_Time.AutoSize = true;
            this.lbAr_Time.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbAr_Time.ForeColor = System.Drawing.Color.DimGray;
            this.lbAr_Time.Location = new System.Drawing.Point(364, 203);
            this.lbAr_Time.Name = "lbAr_Time";
            this.lbAr_Time.Size = new System.Drawing.Size(142, 23);
            this.lbAr_Time.TabIndex = 13;
            this.lbAr_Time.Text = "Arrival Time";
            // 
            // lbDe_Airport
            // 
            this.lbDe_Airport.AutoSize = true;
            this.lbDe_Airport.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbDe_Airport.ForeColor = System.Drawing.Color.DimGray;
            this.lbDe_Airport.Location = new System.Drawing.Point(6, 119);
            this.lbDe_Airport.Name = "lbDe_Airport";
            this.lbDe_Airport.Size = new System.Drawing.Size(201, 23);
            this.lbDe_Airport.TabIndex = 12;
            this.lbDe_Airport.Text = "Departure Airport";
            // 
            // lbAr_Airport
            // 
            this.lbAr_Airport.AutoSize = true;
            this.lbAr_Airport.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbAr_Airport.ForeColor = System.Drawing.Color.DimGray;
            this.lbAr_Airport.Location = new System.Drawing.Point(364, 119);
            this.lbAr_Airport.Name = "lbAr_Airport";
            this.lbAr_Airport.Size = new System.Drawing.Size(164, 23);
            this.lbAr_Airport.TabIndex = 11;
            this.lbAr_Airport.Text = "Arrival Airport";
            // 
            // txbSeatClass
            // 
            this.txbSeatClass.BorderColor = System.Drawing.Color.LightGray;
            this.txbSeatClass.BorderRadius = 10;
            this.txbSeatClass.BorderThickness = 2;
            this.txbSeatClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSeatClass.DefaultText = "";
            this.txbSeatClass.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbSeatClass.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbSeatClass.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbSeatClass.DisabledState.Parent = this.txbSeatClass;
            this.txbSeatClass.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbSeatClass.Enabled = false;
            this.txbSeatClass.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbSeatClass.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbSeatClass.FocusedState.Parent = this.txbSeatClass;
            this.txbSeatClass.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSeatClass.ForeColor = System.Drawing.Color.DimGray;
            this.txbSeatClass.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbSeatClass.HoverState.Parent = this.txbSeatClass;
            this.txbSeatClass.Location = new System.Drawing.Point(368, 563);
            this.txbSeatClass.Margin = new System.Windows.Forms.Padding(4);
            this.txbSeatClass.Name = "txbSeatClass";
            this.txbSeatClass.PasswordChar = '\0';
            this.txbSeatClass.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txbSeatClass.PlaceholderText = "Seat Class";
            this.txbSeatClass.SelectedText = "";
            this.txbSeatClass.ShadowDecoration.Parent = this.txbSeatClass;
            this.txbSeatClass.Size = new System.Drawing.Size(283, 45);
            this.txbSeatClass.TabIndex = 10;
            this.txbSeatClass.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txbDe_Time
            // 
            this.txbDe_Time.BorderColor = System.Drawing.Color.LightGray;
            this.txbDe_Time.BorderRadius = 10;
            this.txbDe_Time.BorderThickness = 2;
            this.txbDe_Time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDe_Time.DefaultText = "";
            this.txbDe_Time.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbDe_Time.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbDe_Time.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbDe_Time.DisabledState.Parent = this.txbDe_Time;
            this.txbDe_Time.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbDe_Time.Enabled = false;
            this.txbDe_Time.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbDe_Time.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbDe_Time.FocusedState.Parent = this.txbDe_Time;
            this.txbDe_Time.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDe_Time.ForeColor = System.Drawing.Color.DimGray;
            this.txbDe_Time.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbDe_Time.HoverState.Parent = this.txbDe_Time;
            this.txbDe_Time.Location = new System.Drawing.Point(10, 230);
            this.txbDe_Time.Margin = new System.Windows.Forms.Padding(4);
            this.txbDe_Time.Name = "txbDe_Time";
            this.txbDe_Time.PasswordChar = '\0';
            this.txbDe_Time.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txbDe_Time.PlaceholderText = "Departure Time";
            this.txbDe_Time.SelectedText = "";
            this.txbDe_Time.ShadowDecoration.Parent = this.txbDe_Time;
            this.txbDe_Time.Size = new System.Drawing.Size(283, 45);
            this.txbDe_Time.TabIndex = 8;
            this.txbDe_Time.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txbAr_Time
            // 
            this.txbAr_Time.BorderColor = System.Drawing.Color.LightGray;
            this.txbAr_Time.BorderRadius = 10;
            this.txbAr_Time.BorderThickness = 2;
            this.txbAr_Time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAr_Time.DefaultText = "";
            this.txbAr_Time.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbAr_Time.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbAr_Time.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbAr_Time.DisabledState.Parent = this.txbAr_Time;
            this.txbAr_Time.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbAr_Time.Enabled = false;
            this.txbAr_Time.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbAr_Time.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbAr_Time.FocusedState.Parent = this.txbAr_Time;
            this.txbAr_Time.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAr_Time.ForeColor = System.Drawing.Color.DimGray;
            this.txbAr_Time.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbAr_Time.HoverState.Parent = this.txbAr_Time;
            this.txbAr_Time.Location = new System.Drawing.Point(368, 230);
            this.txbAr_Time.Margin = new System.Windows.Forms.Padding(4);
            this.txbAr_Time.Name = "txbAr_Time";
            this.txbAr_Time.PasswordChar = '\0';
            this.txbAr_Time.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txbAr_Time.PlaceholderText = "Arrival Time";
            this.txbAr_Time.SelectedText = "";
            this.txbAr_Time.ShadowDecoration.Parent = this.txbAr_Time;
            this.txbAr_Time.Size = new System.Drawing.Size(283, 45);
            this.txbAr_Time.TabIndex = 7;
            this.txbAr_Time.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnDe_Airport
            // 
            this.btnDe_Airport.BorderColor = System.Drawing.Color.LightGray;
            this.btnDe_Airport.BorderRadius = 10;
            this.btnDe_Airport.BorderThickness = 2;
            this.btnDe_Airport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnDe_Airport.DefaultText = "";
            this.btnDe_Airport.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnDe_Airport.DisabledState.FillColor = System.Drawing.Color.White;
            this.btnDe_Airport.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.btnDe_Airport.DisabledState.Parent = this.btnDe_Airport;
            this.btnDe_Airport.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.btnDe_Airport.Enabled = false;
            this.btnDe_Airport.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.btnDe_Airport.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDe_Airport.FocusedState.Parent = this.btnDe_Airport;
            this.btnDe_Airport.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDe_Airport.ForeColor = System.Drawing.Color.DimGray;
            this.btnDe_Airport.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnDe_Airport.HoverState.Parent = this.btnDe_Airport;
            this.btnDe_Airport.Location = new System.Drawing.Point(10, 146);
            this.btnDe_Airport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDe_Airport.Name = "btnDe_Airport";
            this.btnDe_Airport.PasswordChar = '\0';
            this.btnDe_Airport.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.btnDe_Airport.PlaceholderText = "Departure Airport";
            this.btnDe_Airport.SelectedText = "";
            this.btnDe_Airport.ShadowDecoration.Parent = this.btnDe_Airport;
            this.btnDe_Airport.Size = new System.Drawing.Size(283, 45);
            this.btnDe_Airport.TabIndex = 6;
            this.btnDe_Airport.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txbAr_Airport
            // 
            this.txbAr_Airport.BorderColor = System.Drawing.Color.LightGray;
            this.txbAr_Airport.BorderRadius = 10;
            this.txbAr_Airport.BorderThickness = 2;
            this.txbAr_Airport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAr_Airport.DefaultText = "";
            this.txbAr_Airport.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbAr_Airport.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbAr_Airport.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbAr_Airport.DisabledState.Parent = this.txbAr_Airport;
            this.txbAr_Airport.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbAr_Airport.Enabled = false;
            this.txbAr_Airport.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbAr_Airport.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbAr_Airport.FocusedState.Parent = this.txbAr_Airport;
            this.txbAr_Airport.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAr_Airport.ForeColor = System.Drawing.Color.DimGray;
            this.txbAr_Airport.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbAr_Airport.HoverState.Parent = this.txbAr_Airport;
            this.txbAr_Airport.Location = new System.Drawing.Point(368, 146);
            this.txbAr_Airport.Margin = new System.Windows.Forms.Padding(4);
            this.txbAr_Airport.Name = "txbAr_Airport";
            this.txbAr_Airport.PasswordChar = '\0';
            this.txbAr_Airport.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txbAr_Airport.PlaceholderText = "Arrival Airport";
            this.txbAr_Airport.SelectedText = "";
            this.txbAr_Airport.ShadowDecoration.Parent = this.txbAr_Airport;
            this.txbAr_Airport.Size = new System.Drawing.Size(283, 45);
            this.txbAr_Airport.TabIndex = 5;
            this.txbAr_Airport.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.DimGray;
            this.lbName.Location = new System.Drawing.Point(6, 38);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(72, 23);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lbPrice.Location = new System.Drawing.Point(13, 438);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(64, 23);
            this.lbPrice.TabIndex = 26;
            this.lbPrice.Text = "Price";
            // 
            // txbPrice
            // 
            this.txbPrice.BorderColor = System.Drawing.Color.LightGray;
            this.txbPrice.BorderRadius = 10;
            this.txbPrice.BorderThickness = 2;
            this.txbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPrice.DefaultText = "";
            this.txbPrice.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbPrice.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbPrice.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbPrice.DisabledState.Parent = this.txbPrice;
            this.txbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbPrice.Enabled = false;
            this.txbPrice.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbPrice.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbPrice.FocusedState.Parent = this.txbPrice;
            this.txbPrice.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txbPrice.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbPrice.HoverState.Parent = this.txbPrice;
            this.txbPrice.Location = new System.Drawing.Point(10, 465);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.PasswordChar = '\0';
            this.txbPrice.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txbPrice.PlaceholderText = "Price/1 Ticket";
            this.txbPrice.SelectedText = "";
            this.txbPrice.ShadowDecoration.Parent = this.txbPrice;
            this.txbPrice.Size = new System.Drawing.Size(283, 45);
            this.txbPrice.TabIndex = 25;
            this.txbPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbSeat.ForeColor = System.Drawing.Color.DimGray;
            this.lbSeat.Location = new System.Drawing.Point(13, 536);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(151, 23);
            this.lbSeat.TabIndex = 24;
            this.lbSeat.Text = "Seat Number";
            // 
            // lbIDTicket
            // 
            this.lbIDTicket.AutoSize = true;
            this.lbIDTicket.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbIDTicket.ForeColor = System.Drawing.Color.DimGray;
            this.lbIDTicket.Location = new System.Drawing.Point(364, 438);
            this.lbIDTicket.Name = "lbIDTicket";
            this.lbIDTicket.Size = new System.Drawing.Size(109, 23);
            this.lbIDTicket.TabIndex = 23;
            this.lbIDTicket.Text = "ID Ticket";
            // 
            // txbSeat
            // 
            this.txbSeat.BorderColor = System.Drawing.Color.LightGray;
            this.txbSeat.BorderRadius = 10;
            this.txbSeat.BorderThickness = 2;
            this.txbSeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSeat.DefaultText = "";
            this.txbSeat.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbSeat.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbSeat.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbSeat.DisabledState.Parent = this.txbSeat;
            this.txbSeat.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbSeat.Enabled = false;
            this.txbSeat.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbSeat.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbSeat.FocusedState.Parent = this.txbSeat;
            this.txbSeat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSeat.ForeColor = System.Drawing.Color.DimGray;
            this.txbSeat.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbSeat.HoverState.Parent = this.txbSeat;
            this.txbSeat.Location = new System.Drawing.Point(7, 563);
            this.txbSeat.Margin = new System.Windows.Forms.Padding(4);
            this.txbSeat.Name = "txbSeat";
            this.txbSeat.PasswordChar = '\0';
            this.txbSeat.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txbSeat.PlaceholderText = "Seat number";
            this.txbSeat.SelectedText = "";
            this.txbSeat.ShadowDecoration.Parent = this.txbSeat;
            this.txbSeat.Size = new System.Drawing.Size(283, 45);
            this.txbSeat.TabIndex = 22;
            this.txbSeat.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txbIDTicket
            // 
            this.txbIDTicket.BorderColor = System.Drawing.Color.LightGray;
            this.txbIDTicket.BorderRadius = 10;
            this.txbIDTicket.BorderThickness = 2;
            this.txbIDTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDTicket.DefaultText = "";
            this.txbIDTicket.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbIDTicket.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbIDTicket.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbIDTicket.DisabledState.Parent = this.txbIDTicket;
            this.txbIDTicket.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbIDTicket.Enabled = false;
            this.txbIDTicket.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbIDTicket.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbIDTicket.FocusedState.Parent = this.txbIDTicket;
            this.txbIDTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDTicket.ForeColor = System.Drawing.Color.DimGray;
            this.txbIDTicket.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbIDTicket.HoverState.Parent = this.txbIDTicket;
            this.txbIDTicket.Location = new System.Drawing.Point(368, 465);
            this.txbIDTicket.Margin = new System.Windows.Forms.Padding(4);
            this.txbIDTicket.Name = "txbIDTicket";
            this.txbIDTicket.PasswordChar = '\0';
            this.txbIDTicket.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbIDTicket.PlaceholderText = "ID Ticket";
            this.txbIDTicket.SelectedText = "";
            this.txbIDTicket.ShadowDecoration.Parent = this.txbIDTicket;
            this.txbIDTicket.Size = new System.Drawing.Size(283, 45);
            this.txbIDTicket.TabIndex = 21;
            this.txbIDTicket.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lbTicket
            // 
            this.lbTicket.AutoSize = true;
            this.lbTicket.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbTicket.ForeColor = System.Drawing.Color.DimGray;
            this.lbTicket.Location = new System.Drawing.Point(13, 380);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(76, 23);
            this.lbTicket.TabIndex = 21;
            this.lbTicket.Text = "Ticket";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 14;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.Blue;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(116, 650);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(131, 46);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 14;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Blue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(412, 650);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(131, 46);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(-9, 367);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(683, 10);
            this.guna2Separator1.TabIndex = 26;
            // 
            // cbTicket
            // 
            this.cbTicket.BackColor = System.Drawing.Color.Transparent;
            this.cbTicket.BorderColor = System.Drawing.Color.LightGray;
            this.cbTicket.BorderRadius = 14;
            this.cbTicket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicket.FocusedColor = System.Drawing.Color.DimGray;
            this.cbTicket.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.cbTicket.FocusedState.ForeColor = System.Drawing.Color.DimGray;
            this.cbTicket.FocusedState.Parent = this.cbTicket;
            this.cbTicket.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTicket.ForeColor = System.Drawing.Color.Black;
            this.cbTicket.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.cbTicket.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.cbTicket.HoverState.Parent = this.cbTicket;
            this.cbTicket.ItemHeight = 30;
            this.cbTicket.ItemsAppearance.Parent = this.cbTicket;
            this.cbTicket.ItemsAppearance.SelectedForeColor = System.Drawing.Color.DimGray;
            this.cbTicket.Location = new System.Drawing.Point(113, 380);
            this.cbTicket.Name = "cbTicket";
            this.cbTicket.ShadowDecoration.Parent = this.cbTicket;
            this.cbTicket.Size = new System.Drawing.Size(177, 36);
            this.cbTicket.TabIndex = 27;
            // 
            // TicketConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(685, 744);
            this.Controls.Add(this.grbConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketConfirm";
            this.grbConfirm.ResumeLayout(false);
            this.grbConfirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConfirm;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTotalPrice;
        private Guna.UI2.WinForms.Guna2TextBox txbTotalPrice;
        private Guna.UI2.WinForms.Guna2TextBox txbName;
        private System.Windows.Forms.Label lbNumberOfPassenger;
        private Guna.UI2.WinForms.Guna2ComboBox cbNumberOfPassenger;
        private System.Windows.Forms.Label lbSeatClass;
        private System.Windows.Forms.Label lbDe_Time;
        private System.Windows.Forms.Label lbAr_Time;
        private System.Windows.Forms.Label lbDe_Airport;
        private System.Windows.Forms.Label lbAr_Airport;
        private Guna.UI2.WinForms.Guna2TextBox txbSeatClass;
        private Guna.UI2.WinForms.Guna2TextBox txbDe_Time;
        private Guna.UI2.WinForms.Guna2TextBox txbAr_Time;
        private Guna.UI2.WinForms.Guna2TextBox btnDe_Airport;
        private Guna.UI2.WinForms.Guna2TextBox txbAr_Airport;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.Label lbIDTicket;
        private Guna.UI2.WinForms.Guna2TextBox txbSeat;
        private Guna.UI2.WinForms.Guna2TextBox txbIDTicket;
        private System.Windows.Forms.Label lbTicket;
        private System.Windows.Forms.Label lbPrice;
        private Guna.UI2.WinForms.Guna2TextBox txbPrice;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2ComboBox cbTicket;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}