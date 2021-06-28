using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    class Staff
    {
        // Fields
        private int ID_Staff;
        private string TypeOf_Staff;
        private string Account_Staff;
        private string Password_Staff;
        private string Name_Staff;
        private string Email_Staff;
        private string PhoneNumber_Staff;
        // Properties
        public int ID_STAFF
        {
            get
            {
                return ID_Staff;
            }
            set
            {
                ID_Staff = value;
            }
        }
        public string TYPEOF_STAFF
        {
            get
            {
                return TypeOf_Staff;
            }
            set
            {
                TypeOf_Staff = value;
            }
        }
        public string ACCOUNT_STAFF
        {
            get
            {
                return Account_Staff;
            }
            set
            {
                Account_Staff = value;
            }
        }
        public string PASSWORD_STAFF
        {
            get
            {
                return Password_Staff;
            }
            set
            {
                Password_Staff = value;
            }
        }
        public string NAME_STAFF
        {
            get
            {
                return Name_Staff;
            }
            set
            {
                Name_Staff = value;
            }
        }
        public string EMAIL_STAFF
        {
            get
            {
                return Email_Staff;
            }
            set
            {
                Email_Staff = value;
            }
        }
        public string PHONENUMBER_STAFF
        {
            get
            {
                return PhoneNumber_Staff;
            }
            set
            {
                PhoneNumber_Staff = value;
            }
        }
        // Constructor
        public Staff() { }
        public Staff(int id, string typeofstaff, string account, string password, string name, string email, string phonenumber)
        {
            this.ID_STAFF = id;
            this.TYPEOF_STAFF = typeofstaff;
            this.ACCOUNT_STAFF = account;
            this.PASSWORD_STAFF = password;
            this.NAME_STAFF = name;
            this.EMAIL_STAFF = email;
            this.PHONENUMBER_STAFF = phonenumber;
        }
    }
}
