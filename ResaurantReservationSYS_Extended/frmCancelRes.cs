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
    public partial class frmCancelRes : Form
    {
        public frmCancelRes()
        {
            InitializeComponent();
        }

        private void cboBoxReason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewRes_Click(object sender, EventArgs e)
        {
            frmMakeReservation makeReservation = new frmMakeReservation();
            this.Hide();
            makeReservation.Show();

        }

        private void btnConfrim_Click(object sender, EventArgs e)
        {
            int numeric;
            bool isNumber = int.TryParse(txtBoxResId.Text, out numeric);//Learned from arungudelli.com

            if (isNumber == false)
            {
                MessageBox.Show("Invalid Reservation Id");
                txtBoxResId.Focus();
                return;
            }
            

           var input =  MessageBox.Show("Are you sure you want to cancel this reservation?","Confrim",MessageBoxButtons.YesNo);

            if (input == DialogResult.No)
            {
                return;
            }
            else
                MessageBox.Show("We are sorry to see you go!");

            //Reset UI
            txtBoxResId.Clear();
            txtBoxReason.Clear();

                

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            var choice = MessageBox.Show("Are you sure you want to return to the main menu?", "Confrim", MessageBoxButtons.YesNo);

            if (choice == DialogResult.No)
            {
                frmMainMenu mainMenu = new frmMainMenu();
                this.Hide();
                mainMenu.Show();
            }
            else
                return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
