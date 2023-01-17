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
    public partial class frmAddTable : Form
    {
        public frmAddTable()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public bool isNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            if (txtBoxNumber.Text.Equals("") && txtBoxSeats.Text.Equals("") && txtBoxLocation.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtBoxNumber.Focus();
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Seat number can only be numeric.");
                txtBoxNumber.Text = txtBoxNumber.Text.Remove(txtBoxNumber.Text.Length - 1);//Stack overflow
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxSeats.Text, "[^0-9]"))
            {
                MessageBox.Show("Number of seats can only be numeric.");
                txtBoxSeats.Text = txtBoxSeats.Text.Remove(txtBoxSeats.Text.Length - 1);
            }
            if (isNumeric(txtBoxLocation.Text) || txtBoxLocation.Equals(""))
            {
                MessageBox.Show("Invalid Location");
            }
            else
                MessageBox.Show("Tbale added to the system");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void txtBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
