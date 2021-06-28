
using Đồ_án;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using Project.Class;


namespace Project.fForm
{
    public partial class fLogin : Form
    {
       /* public Guna2TextBox tbx { get; private set; }*/

        public fLogin()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassword.Text;
            string permission = CustomerDAO.INSTANCE.getPer(userName, passWord);
            if (!string.IsNullOrWhiteSpace(GETID()) && !string.IsNullOrWhiteSpace(txbPassword.Text) && !string.IsNullOrWhiteSpace(txbUserName.Text)) 
            {
                fCustomer f = new fCustomer(userName, passWord, permission);
                this.Hide();
                f.ShowDialog();
                txbPassword.Text = "";
                txbUserName.Text = "";
                this.Show();
            }
            else
            {
                lbCheck.Text = "User Name or Password is INCORRECT !!";
                txbUserName.Focus();
            }
        }
        public string GETID()
        {
            return CustomerDAO.INSTANCE.getID(txbUserName.Text, txbPassword.Text);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to Exit ", "Flight Management", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void lbSignup_Click(object sender, EventArgs e)
        {
            fSignup f = new fSignup();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Guna2TextBox b = (Guna2TextBox)sender;
            if (e.KeyCode == Keys.Enter)
                {              
               /* if (b == txbUserName)
                    txbPassword.Focus();
                if (b == txbPassword)*/
                    btnSubmit.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
                btnExit.PerformClick();
        }
       /* private void txbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txbPassword.Focus();
        }*/
    }
}
