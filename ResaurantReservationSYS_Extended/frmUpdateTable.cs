using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResaurantReservationSYS
{
    public partial class frmUpdateTable : Form
    {
        public frmUpdateTable()
        {
            InitializeComponent();
        }
        public bool isNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtBoxSeats.Text.Equals("") && txtBoxLocation.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtBoxSeats.Focus();
                return;
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
                MessageBox.Show("Tabbel information has been updated");



        }

        private void frmUpdateTable_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            this.Hide();
            mainMenu.Show();
        }
    }
    }

