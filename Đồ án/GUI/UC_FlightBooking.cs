using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Đồ_án.GUI;

namespace Project.fForm
{
    public partial class UC_FlightBooking : UserControl
    {
        /* private static UC_FlightBooking Instance;
         public static UC_FlightBooking INSTANCE
         {
             get
             {
                 if (Instance == null)
                     Instance = new UC_FlightBooking();
                 return UC_FlightBooking.Instance;
             }
             private set
             {
                 UC_FlightBooking.Instance = value;
             }
         }*/
        string userName;
        string password;
        string permission;
        public UC_FlightBooking(string user, string pass , string per)
        {
            userName = user;
            password = pass;
            permission = per;
            InitializeComponent();
        }

        private void UC_FlightBooking_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TicketConfirm f = new TicketConfirm();
            f.ShowDialog();
        }
    }
}
