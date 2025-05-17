using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MilkbarPOS
{
    public partial class ReportForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3I4FG4K;Initial Catalog=MilkbarPOS;Integrated Security=True");

        public ReportForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string query = "SELECT T.TransactionID, T.TransactionDate, P.ProductName, TI.Quantity, TI.Price, (TI.Quantity * TI.Price) AS Total " +
                           "FROM Transactions T " +
                           "JOIN TransactionItems TI ON T.TransactionID = TI.TransactionID " +
                           "JOIN Products P ON TI.ProductID = P.ProductID " +
                           "WHERE T.TransactionDate BETWEEN @start AND @end";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@start", dtStart.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@end", dtEnd.Value.Date.AddDays(1).AddSeconds(-1));

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvReport.DataSource = dt;
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm(1);
            mainForm.Show();
            this.Close();
        }
    }
}
