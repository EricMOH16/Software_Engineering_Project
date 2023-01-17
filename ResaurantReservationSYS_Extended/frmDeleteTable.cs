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
    public partial class frmDeleteTable : Form
    {
        public frmDeleteTable()
        {
            InitializeComponent();
        }

        private void cboBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
           var choice =  MessageBox.Show("Are you sure you want to delete this table?", "Confrim", MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes)
            {
                MessageBox.Show("Table has been removed from the system");
                Application.Exit();
            }
            else
                return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            this.Hide();
            mainMenu.Show();
        }
    }
}
