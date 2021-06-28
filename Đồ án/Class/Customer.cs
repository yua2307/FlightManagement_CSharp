using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_án
{
    class Customer
    {
        // Fields
        private int ID_Custommer;
        private string Account_Customer;
        private string Password_Customer;
        private string Name_Customer;
        private string Identity_Customer;
        private string Email_Customer;
        private string PhoneNumber_Customer;
        private string Permission;
        // Properties
        public int ID_CUSTOMER
        {
            get
            {
                return ID_Custommer;
            }
            set
            {
                ID_Custommer = value;
            }
        }
        public string ACCOUNT_CUSTOMER
        {
            get
            {
                return Account_Customer;
            }
            set
            {
                Account_Customer = value;
            }
        }
        public string PASSWORD_CUSTOMER
        {
            get
            {
                return Password_Customer;
            }
            set
            {
                Password_Customer = value;
            }
        }
        public string NAME_CUSTOMER
        {
            get
            {
                return Name_Customer;
            }
            set
            {
                Name_Customer = value;
            }
        }
        public string EMAIL_CUSTOMER
        {
            get
            {
                return Email_Customer;
            }
            set
            {
                Email_Customer = value;
            }
        }
        public string PHONENUMBER_CUSTOMER
        {
            get
            {
                return PhoneNumber_Customer;
            }
            set
            {
                PhoneNumber_Customer = value;
            }
        }
        public string IDENTITY_CUSTOMER 
        {
            get
            {
                return Identity_Customer;
            }
            set
            {
                Identity_Customer = value;
            }
        }
        public string PERMISSION
        {
            get
            {
                return Permission;
            }
            set
            {
                Permission = value;
            }
        }

    }
}
