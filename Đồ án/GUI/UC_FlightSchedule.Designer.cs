namespace Project.fForm
{
    partial class UC_FlightSchedule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbSearchIDTicket = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbSearchIDFlight = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.lbReport = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.lbID_Ticket = new System.Windows.Forms.Label();
            this.lbID_Flight = new System.Windows.Forms.Label();
            this.dtgData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSearchIDTicket
            // 
            this.txbSearchIDTicket.BorderColor = System.Drawing.Color.LightGray;
            this.txbSearchIDTicket.BorderRadius = 10;
            this.txbSearchIDTicket.BorderThickness = 2;
            this.txbSearchIDTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchIDTicket.DefaultText = "";
            this.txbSearchIDTicket.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbSearchIDTicket.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbSearchIDTicket.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbSearchIDTicket.DisabledState.Parent = this.txbSearchIDTicket;
            this.txbSearchIDTicket.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbSearchIDTicket.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbSearchIDTicket.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbSearchIDTicket.FocusedState.Parent = this.txbSearchIDTicket;
            this.txbSearchIDTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchIDTicket.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchIDTicket.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbSearchIDTicket.HoverState.Parent = this.txbSearchIDTicket;
            this.txbSearchIDTicket.Location = new System.Drawing.Point(168, 109);
            this.txbSearchIDTicket.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchIDTicket.Name = "txbSearchIDTicket";
            this.txbSearchIDTicket.PasswordChar = '\0';
            this.txbSearchIDTicket.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbSearchIDTicket.PlaceholderText = "ID_Ticket";
            this.txbSearchIDTicket.SelectedText = "";
            this.txbSearchIDTicket.ShadowDecoration.Parent = this.txbSearchIDTicket;
            this.txbSearchIDTicket.Size = new System.Drawing.Size(243, 49);
            this.txbSearchIDTicket.TabIndex = 2;
            this.txbSearchIDTicket.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txbSearchIDFlight
            // 
            this.txbSearchIDFlight.BorderColor = System.Drawing.Color.LightGray;
            this.txbSearchIDFlight.BorderRadius = 10;
            this.txbSearchIDFlight.BorderThickness = 2;
            this.txbSearchIDFlight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearchIDFlight.DefaultText = "";
            this.txbSearchIDFlight.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txbSearchIDFlight.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbSearchIDFlight.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.txbSearchIDFlight.DisabledState.Parent = this.txbSearchIDFlight;
            this.txbSearchIDFlight.DisabledState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbSearchIDFlight.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.txbSearchIDFlight.FocusedState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbSearchIDFlight.FocusedState.Parent = this.txbSearchIDFlight;
            this.txbSearchIDFlight.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchIDFlight.ForeColor = System.Drawing.Color.DimGray;
            this.txbSearchIDFlight.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.txbSearchIDFlight.HoverState.Parent = this.txbSearchIDFlight;
            this.txbSearchIDFlight.Location = new System.Drawing.Point(168, 40);
            this.txbSearchIDFlight.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchIDFlight.Name = "txbSearchIDFlight";
            this.txbSearchIDFlight.PasswordChar = '\0';
            this.txbSearchIDFlight.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txbSearchIDFlight.PlaceholderText = "ID_Flight";
            this.txbSearchIDFlight.SelectedText = "";
            this.txbSearchIDFlight.ShadowDecoration.Parent = this.txbSearchIDFlight;
            this.txbSearchIDFlight.Size = new System.Drawing.Size(243, 49);
            this.txbSearchIDFlight.TabIndex = 3;
            this.txbSearchIDFlight.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.lbReport);
            this.grbSearch.Controls.Add(this.btnReset);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.lbID_Ticket);
            this.grbSearch.Controls.Add(this.lbID_Flight);
            this.grbSearch.Controls.Add(this.txbSearchIDFlight);
            this.grbSearch.Controls.Add(this.txbSearchIDTicket);
            this.grbSearch.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.ForeColor = System.Drawing.Color.DimGray;
            this.grbSearch.Location = new System.Drawing.Point(14, 3);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(690, 212);
            this.grbSearch.TabIndex = 5;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // lbReport
            // 
            this.lbReport.AutoSize = true;
            this.lbReport.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReport.Location = new System.Drawing.Point(165, 177);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(0, 18);
            this.lbReport.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 10;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.Blue;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReset.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(488, 109);
            this.btnReset.Name = "btnReset";
            this.btnReset.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(136, 49);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.Blue;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(488, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(136, 49);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbID_Ticket
            // 
            this.lbID_Ticket.AutoSize = true;
            this.lbID_Ticket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID_Ticket.Location = new System.Drawing.Point(27, 125);
            this.lbID_Ticket.Name = "lbID_Ticket";
            this.lbID_Ticket.Size = new System.Drawing.Size(102, 20);
            this.lbID_Ticket.TabIndex = 5;
            this.lbID_Ticket.Text = "ID_Ticket";
            // 
            // lbID_Flight
            // 
            this.lbID_Flight.AutoSize = true;
            this.lbID_Flight.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID_Flight.Location = new System.Drawing.Point(27, 56);
            this.lbID_Flight.Name = "lbID_Flight";
            this.lbID_Flight.Size = new System.Drawing.Size(99, 20);
            this.lbID_Flight.TabIndex = 4;
            this.lbID_Flight.Text = "ID_Flight";
            // 
            // dtgData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtgData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgData.BackgroundColor = System.Drawing.Color.White;
            this.dtgData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgData.ColumnHeadersHeight = 20;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgData.EnableHeadersVisualStyles = false;
            this.dtgData.GridColor = System.Drawing.Color.White;
            this.dtgData.Location = new System.Drawing.Point(14, 221);
            this.dtgData.Name = "dtgData";
            this.dtgData.RowHeadersVisible = false;
            this.dtgData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgData.RowTemplate.Height = 24;
            this.dtgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgData.Size = new System.Drawing.Size(690, 287);
            this.dtgData.TabIndex = 6;
            this.dtgData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgData.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dtgData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dtgData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgData.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.dtgData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dtgData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgData.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgData.ThemeStyle.ReadOnly = false;
            this.dtgData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dtgData.ThemeStyle.RowsStyle.Height = 24;
            this.dtgData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            // 
            // UC_FlightSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtgData);
            this.Controls.Add(this.grbSearch);
            this.Name = "UC_FlightSchedule";
            this.Size = new System.Drawing.Size(714, 521);
            this.Load += new System.EventHandler(this.UC_FlightSchedule_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txbSearchIDTicket;
        private Guna.UI2.WinForms.Guna2TextBox txbSearchIDFlight;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Label lbID_Ticket;
        private System.Windows.Forms.Label lbID_Flight;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dtgData;
        private System.Windows.Forms.Label lbReport;
    }
}
