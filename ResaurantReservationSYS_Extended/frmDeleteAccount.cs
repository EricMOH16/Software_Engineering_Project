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
    public partial class frmDeleteAccount : Form
    {
        public frmDeleteAccount()
        {
            InitializeComponent();
        }
        public bool isNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            this.Hide();
            mainMenu.Show();

        }

        private void txtAccountID_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboBoxDeleteReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rea(object sender, EventArgs e)
        {

        }

        private void frmDeleteAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtAccountID.Text.Equals(""))
            {
                MessageBox.Show("You must enter your account id");
                txtAccountID.Focus();
                return;
            }
             
            
           
        
            if (!isNumeric(txtAccountID.Text))
            {
                MessageBox.Show("Account Id must be numeric");
                txtAccountID.Focus();
                return;
            }
            else
                MessageBox.Show("Account has been deleted\n\nYou can no longer make online Reservations");
            txtAccountID.Clear();
        }
    }
}
