using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Đồ_án;
using Microsoft.SqlServer.Management.Smo;
using Project.Class;

namespace Project.fForm
{
    public partial class UC_FlightSchedule : UserControl
    {
        string userName;
        string password;
        string permission;
        
       
        public UC_FlightSchedule(string userName, string password, string permission)
        {
            this.userName = userName;
            this.password = password;
            this.permission = permission;
            InitializeComponent();
        }
       

        private void UC_FlightSchedule_Load(object sender, EventArgs e)
        {    
                dtgData.DataSource = TicketDAO.INSTANCE.showAllTicket1(userName, password);
          /*  dtgData.Columns[0].HeaderText = "ID_Ticket";
            dtgData.Columns[1].HeaderText = "ID_Flight";
            dtgData.Columns[2].HeaderText = "Price ";
            dtgData.Columns[3].HeaderText = "Booking Date ";
            dtgData.Columns[4].HeaderText = "Seat";
            dtgData.Columns[5].HeaderText = "Class";*/
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtgData.DataSource = TicketDAO.INSTANCE.showAllTicket(userName, password);
            txbSearchIDFlight.Text = "";
            txbSearchIDTicket.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
