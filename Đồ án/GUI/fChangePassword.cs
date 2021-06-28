
using Microsoft.VisualBasic.Compatibility.VB6;
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
    public partial class fChangePassword : Form
    {
        string userName;
        string passWord;
        string permission;
       /* private static fChangePassword Instance(string user, string pass, string per);
        public static fChangePassword INSTANCE
        {
            get
            {
                if (Instance(userName, pasWords, permission) == null)
                    Instance = new fChangePassword(WebClas);
                return fChangePassword.Instance;
            }
            private set
            {
                fChangePassword.Instance = value;
            }*/
              
        public fChangePassword(string user, string pass, string per)
        {
            userName = user;
            passWord = pass;
            permission = per;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
