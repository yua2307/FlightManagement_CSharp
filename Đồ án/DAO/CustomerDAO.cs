using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
/*using Babel;*/

namespace Project.Class
{
    class CustomerDAO
    {
        private static CustomerDAO Instance;
        public static CustomerDAO INSTANCE
        {
            get
            {
                if (Instance == null)
                    Instance = new CustomerDAO();
                return CustomerDAO.Instance;
            }
            private set
            {
                CustomerDAO.Instance = value;
            }
        }
        /*// Constructor
        public Customer() { }
        public Customer(int id, string account, string password, string name, string email, string phonenumber)
        {
            this.ID_CUSTOMER = id;
            this.ACCOUNT_CUSTOMER = account;
            this.PASSWORD_CUSTOMER = password;
            this.NAME_CUSTOMER = name;
            this.EMAIL_CUSTOMER = email;
            this.PHONENUMBER_CUSTOMER = phonenumber;
        }*/
       /* public bool Login(string userName,  string passWord)
        {
            string query = "SELECT * FROM dbo.Users WHERE userName = '" + userName + "' AND pass = '" + passWord + "'";
            DataTable result = DBConnection.INSTANCE.ExecuteQuerry(query);
            return result.Rows.Count > 0;
        }*/
        public string getID(string userName, string passWord)
        {
            string id = "";
            string query = "SELECT * FROM dbo.Users WHERE userName = '" + userName + "' collate SQL_Latin1_General_CP1_CS_AS AND pass = '" + passWord + "' collate SQL_Latin1_General_CP1_CS_AS";
            try
            {
                DataTable result = DBConnection.INSTANCE.ExecuteQuerry(query);
                if (result != null)
                {
                    foreach (DataRow dr in result.Rows)
                        id = dr["ID_User"].ToString();
                }
            } catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;

        }
        public void addCustomerAccount(string Name, string PhoneNumber, string Identity, string Email, string AccountName, string Password)
        {
            string query = "EXEC addUser @name , @sdt , @CMND , @email , @userName , @pass , @permission ";
            try
            {
                DBConnection.INSTANCE.ExecuteNoneQuerry(query, new object[] { Name, PhoneNumber, Identity, Email, AccountName, Password, "Customer" });
            }catch (Exception)
            {
                MessageBox.Show("System Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool  checkUserExist(string UserName)
        {
            string query = "SELECT * FROM dbo.Users WHERE userName = '" + UserName + "'";
            DataTable data = DBConnection.INSTANCE.ExecuteQuerry(query);
            return data.Rows.Count > 0 ;
        }

        public string getPer(string userName, string passWord)
        {
            string per = "";
            string query = "SELECT * FROM dbo.Users WHERE userName = '" + userName + "' collate SQL_Latin1_General_CP1_CS_AS AND pass = '" + passWord + "' collate SQL_Latin1_General_CP1_CS_AS";
            try
            {
                DataTable result = DBConnection.INSTANCE.ExecuteQuerry(query);
                if (result != null)
                {
                    foreach (DataRow dr in result.Rows)
                    {
                        per = dr["permission"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Get Permission ");
            }
            return per;
        }
    }
}
