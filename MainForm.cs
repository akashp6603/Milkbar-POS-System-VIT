using System;
using System.Windows.Forms;

namespace MilkbarPOS
{
    public partial class MainForm : Form
    {
        private int roleId;

        public MainForm(int roleId)
        {
            this.roleId = roleId;
            InitializeComponent(); // Load UI from Designer

            // Set welcome text based on role
            lblTitle.Text = roleId == 1 ? "Welcome, Admin" : "Welcome, Cashier";
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            new TransactionForm().ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new ReportForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
