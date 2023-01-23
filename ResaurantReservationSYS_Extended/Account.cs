using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ResaurantReservationSYS
{
    class Account
    {
        private int accID;
        private String forename;
        private String surname;
        private int phoneNo;
        private String email;
        private String password;

        public Account()
        {
            this.accID = 0;
            this.forename = "";
            this.surname = "";
            this.phoneNo = 0;
            this.email = "";
            this.password = "";
        }
        
        public Account(int accID,string forename,string surname,int phoneNo,string email,string password) 
        {
            this.accID = accID;
            this.forename = forename;
            this.surname = surname;
            this.phoneNo = phoneNo;
            this.email = email;
            this.password = password;
        }

        //getters
        public int getAccID()
        {
            return this.accID;
        }
        public String getForename()
        {
            return this.forename;
        }
        public String getSurname()
        {
            return this.surname;
        }
        public int getPhoneNo()
        {
            return this.phoneNo;
        }
        public String getEmail()
        {
            return this.email;
        }
        public String getPassword()
        {
            return this.password;
        }

        //setters
        public void setAccID(int AccId)
        {
            accID = AccId;
        }

        public void setForename(String Forename)
        {
            forename = Forename;
        }

        public void setSurname(String Surname)
        {
            surname = Surname;
        }
        public void setPhoenNo(int PhoneNo)
        {
            phoneNo = PhoneNo;
        }
        public void setEmail(String Email)
        {
            email = Email;
        }

        public void setPassword(String Password)
        {
            password = Password;
        }

        //Creating the database connection

    }
}
