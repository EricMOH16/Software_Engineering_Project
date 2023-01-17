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
    public partial class frmRecordBillPayed : Form
    {
        public frmRecordBillPayed()
        {
            InitializeComponent();
        }
        public bool isNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtBoxSurname.Equals("") && txtResId.Equals("") && txtTableNo.Equals(""))
            {
                MessageBox.Show("All field must be filled!");
            }
            if (txtBoxSurname.Text.Equals("") || isNumeric(txtBoxSurname.Text))
            {
                MessageBox.Show("Invalid Surname", "Invalid Input", MessageBoxButtons.OK);
                txtBoxSurname.Focus();
                return;
            }

            int numeric;

            bool isNumber = int.TryParse(txtResId.Text, out numeric);//Learned from arungudelli.com

            if (isNumber == false)
            {
                MessageBox.Show("Invalid Reservation Id");
                txtResId.Focus();
                return;
            }
            bool isCost = int.TryParse(txtCost.Text, out numeric);//Learned from arungudelli.com

            if (isCost == false)
            {
                MessageBox.Show("Invalid Cost!");
                txtCost.Focus();
                return;

            }
            int cost = Convert.ToInt32(txtCost.Text);
                if (cost <= 0)
            {
                MessageBox.Show("Cost must be greater than 0");
            }


            else
                MessageBox.Show("The customer's payment has been recorded!");
            txtResId.Clear();
            txtBoxSurname.Clear();
            txtCost.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to return to the main menu?", "Cancel", MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes)
            {
                frmMainMenu mainMenu = new frmMainMenu();
                this.Hide();
                mainMenu.Show();
            }
            else
                return;
        }
    }
}
