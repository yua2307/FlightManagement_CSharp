using Đồ_án;
using Guna.UI2.WinForms;
using Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.fForm
{
    public partial class fCustomer : Form
    {
        string userName ;
        string passWord ;
        string permission ;

        public fCustomer( string user, string pass, string per)
        {
            this.userName = user;
            this.passWord = pass;
            this.permission = per;
            InitializeComponent();
            UC_FlightSchedule fUC = new UC_FlightSchedule(user, pass, per);
            panelCustomer.Controls.Add(fUC);
           
        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            if (string.Compare(permission, "customer", true) != 0)
            {
                CircleBtnAccessF.Visible = true;
                CircleBtnAccessF.Text = (this.userName.Substring(0, 1)).ToUpper();
                txbPermission.Text = "#"+this.permission +"#";
                txbUsername.Text = this.userName;
            }
        }
        private void MovePictureBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            pictureBox.Location = new Point(b.Location.X+180 , b.Location.Y -19);
            pictureBox.SendToBack();
        }
        private void DisplayUC(object sender)
        {
            /* UC_FlightSchedule f1 = new UC_FlightSchedule();
             UC_FlightBooking f2 = new UC_FlightBooking();*/
           
            Guna2Button b = (Guna2Button)sender;
            //  panelManage.Controls.Add(f1);
            if (b == btnFlightSchedule)
            {
                panelCustomer.Controls.Clear();
                panelCustomer.Controls.Add(panelAccessF);
                panelAccessF.Visible = false;
                UC_FlightSchedule fUC = new UC_FlightSchedule(userName, passWord, permission);
                panelCustomer.Controls.Add(fUC);
            }
            if(b == btnFlightBooking) 
            {
                panelCustomer.Controls.Clear();
                panelCustomer.Controls.Add(panelAccessF);
                panelAccessF.Visible = false;
                UC_FlightBooking fUC = new UC_FlightBooking(userName, passWord, permission);
                panelCustomer.Controls.Add(fUC);
              

            }
            if (b == btnAccount)
            {
                panelCustomer.Controls.Clear();
                panelCustomer.Controls.Add(panelAccessF);
                panelAccessF.Visible = false;
                UC_Account fUC = new UC_Account(userName, passWord, permission);
                panelCustomer.Controls.Add(fUC);        
            }
            
        }

        private void Button_CheckedChanged(object sender, EventArgs e)
        {
            MovePictureBox(sender);
            DisplayUC(sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void CircleBtnAccessF_Click(object sender, EventArgs e)
        {          
            if (panelAccessF.Visible == false)
            {
                panelAccessF.Visible = true;
            }
            else
            {
                panelAccessF.Visible = false;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            fEmployee f = new fEmployee(userName,passWord,permission);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       
    }
}
