using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án
{
    public partial class fEmployee : Form
    {
        private string username;
        private string password;
        private string permission;
        public fEmployee(string user, string pass ,string per)
        {
            username = user;
            password = pass;
            permission = per;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fEmployee_Load(object sender, EventArgs e)
        {
            if (string.Compare(permission, "employee", true) == 0)
            {
                btnE_Management.Visible = false;
                btnF_Management.Visible = false;
            }
        }

        private void btnE_Management_Click(object sender, EventArgs e)
        {
            groupBoxE.BringToFront();
            btnF_Management.BringToFront();
            textBoxE.BringToFront();
        }

        private void btnF_Management_Click(object sender, EventArgs e)
        {
            groupBoxE.SendToBack();
            groupBoxF.BringToFront();
            btnE_Management.BringToFront();
            textBoxF.BringToFront();
        }
    }
}
