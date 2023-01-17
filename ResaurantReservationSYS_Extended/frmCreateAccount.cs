using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ResaurantReservationSYS
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            this.Hide();
            mainMenu.Show();
        }
        public bool isNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
        
        public bool isEmail(string value)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$"; // learned to use regex from mailtrap.io

            return Regex.IsMatch(value, regex, RegexOptions.IgnoreCase);
        }

       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Validation


            if (txtFirstName.Text.Equals("") && txtPhoneNumber.Text.Equals("") && txtSurname.Text.Equals("") && txtEmail.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtFirstName.Focus();
                return;
            }

            if (txtFirstName.Text.Equals("") || isNumeric(txtFirstName.Text))
            {
                MessageBox.Show("Invalid first name", "Invalid Input", MessageBoxButtons.OK);
                txtFirstName.Focus();
                return;
            }
            if (txtSurname.Text.Equals("") || isNumeric(txtSurname.Text))
            {
                MessageBox.Show("Invalid Surname", "Invalid Input", MessageBoxButtons.OK);
                txtSurname.Focus();
                return;
            }
            if (txtPhoneNumber.Text.Equals(""))
            {
                MessageBox.Show("Invalid Phone Number", "Invalid Input", MessageBoxButtons.OK);
                txtPhoneNumber.Focus();
                return;
            }
            if (txtEmail.Text.Equals("") || !isEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email", "Invalid Input", MessageBoxButtons.OK);
                txtEmail.Focus();
                return;
            }
            else

            MessageBox.Show("Customer Registered", "Success", MessageBoxButtons.OK);

            //Resets the UI
            txtFirstName.Clear();
            txtSurname.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtPassword.Clear();

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
