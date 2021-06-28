using Bunifu.Framework.UI;
using Guna.UI2.WinForms;
using Project.fForm;
using Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.HadrModel;
using Microsoft.SqlServer.Management.Assessment.Checks;

namespace Đồ_án
{
    public partial class fSignup : Form
    {
        public fSignup()
        {
            InitializeComponent();          
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!CHECKFULLINFO())
            {
                if (string.IsNullOrWhiteSpace(txbName.Text))
                {
                    lbCheck.Text = "Please enter your Name";
                    txbName.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txbPhoneNumber.Text))
                {
                    lbCheck.Text = "Please enter your Phone Number";
                    txbPhoneNumber.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txbIdentity.Text))
                {
                    lbCheck.Text = "Please enter your Identity";
                    txbIdentity.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txbEmail.Text))
                {
                    lbCheck.Text = "Please enter your Email";
                    txbEmail.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txbAccountName.Text))
                {
                    lbCheck.Text = "Please enter your Account Name";
                    txbAccountName.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txbPassword.Text))
                {
                    lbCheck.Text = "Please enter your Password";
                    txbPassword.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txbConfirm.Text))
                {
                    lbCheck.Text = "Please confirm your Password";
                    txbConfirm.Focus();
                }
               
            }
            else if (!CHECKPHONENUMBER(txbPhoneNumber.Text))
            {
                lbCheck.Text = "Please enter your Phone Number again";
                txbPhoneNumber.Focus();
            }
            else if (txbEmail.Text.Contains('@') == false)
            {
                lbCheck.Text = "Please enter your Email again";
                txbEmail.Focus();
            }
            else if (string.Compare(txbPassword.Text, txbConfirm.Text, false) != 0)
            {
                lbCheck.Text = "Please confirm your Password again";
                txbConfirm.Focus();
            }
            else if (CHECKUSEREXIST(txbAccountName.Text))
            {
                lbCheck.Text ="Account Name already exist";
                txbAccountName.Focus();
            }
            else
            {
                CustomerDAO.INSTANCE.addCustomerAccount(txbName.Text,  txbPhoneNumber.Text, txbIdentity.Text, txbEmail.Text, txbAccountName.Text, txbPassword.Text);
                MessageBox.Show("Sign up succesfully");
                fLogin f = new fLogin();
                this.Hide();
                f.ShowDialog();

            }


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            lbCheck.Text = "";
            Guna2TextBox x = (Guna2TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
               /* if (x == guna2TextBox1)
                    guna2TextBox2.Focus();
                if (x == guna2TextBox2)
                    guna2TextBox3.Focus();
                if (x == guna2TextBox3)
                    guna2TextBox4.Focus();
                if (x == guna2TextBox4)
                    guna2TextBox5.Focus();
                if (x == guna2TextBox5)
                    guna2TextBox6.Focus();
                if (x == guna2TextBox6)*/
                    btnSubmit.PerformClick();                   
            }
            if (e.KeyCode == Keys.Escape)
                btnExit.PerformClick();
        }
        private bool CHECKUSEREXIST(string userName)
        {
            return CustomerDAO.INSTANCE.checkUserExist(userName);
        }
        private bool CHECKFULLINFO()
        {
            bool check = true;
            if (string.IsNullOrWhiteSpace(txbName.Text) || string.IsNullOrWhiteSpace(txbEmail.Text) || string.IsNullOrWhiteSpace(txbPhoneNumber.Text)  || string.IsNullOrWhiteSpace(txbAccountName.Text) || string.IsNullOrWhiteSpace(txbPassword.Text) || string.IsNullOrWhiteSpace(txbConfirm.Text) || string.IsNullOrWhiteSpace(txbIdentity.Text))
                check = false;
            return check;
        }
        private bool CHECKPHONENUMBER(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            if (s.Length > 11 || s.Length < 10)
                return false;
            return true;
        }

       
    }
}