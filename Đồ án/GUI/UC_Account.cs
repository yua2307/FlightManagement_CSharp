using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Đồ_án;
using System.Runtime.CompilerServices;
using Microsoft.SqlServer.Management.Smo;
using Project.fForm;

namespace Project.fForm
{
    public partial class UC_Account : UserControl
    {
        string userName;
        string password;
        string permission;

        /* private static UC_Account Instance;
         public static UC_Account INSTANCE
         {
             get
             {
                 if (Instance == null)
                     Instance = new UC_Account();
                 return UC_Account.Instance;
             }
             private set
             {
                 UC_Account.Instance = value;
             }

         }*/
        public UC_Account(string user, string pass, string per)
        {
            this.userName = user;
            this.password = pass;
            this.permission = per;
            InitializeComponent();           
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword(userName, password, permission);
            f.ShowDialog();
        }

     

        private void btnSeePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
