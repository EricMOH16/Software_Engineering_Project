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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void registerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateAccount CreateAccount = new frmCreateAccount();
            this.Hide();
            CreateAccount.Show();


        }

        private void updateCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateAccount UpdateAccount = new frmUpdateAccount();
            this.Hide();
            UpdateAccount.Show();

        }

        private void cancelRegistraionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteAccount DeleteAccount = new frmDeleteAccount();
            this.Hide();
            DeleteAccount.Show();

        }

        private void makeReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMakeReservation makeReservation = new frmMakeReservation();
            this.Hide();
            makeReservation.Show();
        }

        private void addTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddTable addTable = new frmAddTable();
            this.Hide();
            addTable.Show();
        }

        private void updateTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTable updateTable = new frmUpdateTable();
            this.Hide();
            updateTable.Show();
        }

        private void removeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteTable deleteTable = new frmDeleteTable();
            this.Hide();
            deleteTable.Show();
        }

        private void cancelReseravtionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelRes cancelRes = new frmCancelRes();
            this.Hide();
            cancelRes.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
               
        }

        private void recordArrivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecordArrival recordArrival = new frmRecordArrival();
            this.Hide();
            recordArrival.Show();
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecordBillPayed recordBillPayed = new frmRecordBillPayed();
            this.Hide();
            recordBillPayed.Show();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRevenueAnalysis revenueAnalysis = new frmRevenueAnalysis();
            this.Hide();
            revenueAnalysis.Show();
        }

        private void yearlyTableAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTableAnalysis tableAnalysis = new frmTableAnalysis();
            this.Hide();
            tableAnalysis.Show();
        }
    }
}
