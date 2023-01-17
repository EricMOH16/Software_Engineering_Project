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
    public partial class frmMakeReservation : Form
    {
        public frmMakeReservation()
        {
            InitializeComponent();
        }

        private void bbtnAvailablility_Click(object sender, EventArgs e)
        {
  

            if (dtpDate.Value.ToShortDateString() == "25/12/2022")
            {
                MessageBox.Show("Restaurant is closed on selected date");
                dtpDate.Focus();
                return;
            }

            else
                MessageBox.Show("Tables are available!");
                 grpBoxTable.Visible = true;

            listBoxTables.Items.Add("12");
            listBoxTables.Items.Add("19");
            listBoxTables.Items.Add("07");
            listBoxTables.Items.Add("15");
            listBoxTables.Items.Add("22");

        }

        private void listBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpBoxGuestInfo.Visible = true;
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            

            if (txtBoxForename.Text.Equals(""))
            {
                MessageBox.Show("First Name must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtBoxForename.Focus();
                return;
            }
            if (txtBoxSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtBoxSurname.Focus();
                return;
            }
            if (txtBoxEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Invalid Input", MessageBoxButtons.OK);
                txtBoxEmail.Focus();
                return;
            }
           
            else
                MessageBox.Show("A reservation has been made!");

            
            //Reset UI
            grpBoxGuestInfo.Visible = false;
            grpBoxTable.Visible = false;
            dtpDate.Value = DateTime.Now;

        }

        private void txtBoxForename_TextChanged(object sender, EventArgs e)
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
