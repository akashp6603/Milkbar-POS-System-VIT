using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MilkbarPOS
{
    public partial class TransactionForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3I4FG4K;Initial Catalog=MilkbarPOS;Integrated Security=True");
        DataTable cartTable = new DataTable();

        public TransactionForm()
        {
            InitializeComponent();
            CenterToScreen();
            SetupCartTable();
        }

        private void SetupCartTable()
        {
            cartTable.Columns.Add("Product ID", typeof(int));
            cartTable.Columns.Add("Product Name", typeof(string));
            cartTable.Columns.Add("Price", typeof(decimal));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Total", typeof(decimal));
            dgvCart.DataSource = cartTable;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please enter Product ID and Quantity.");
                return;
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ProductName, Price FROM Products WHERE ProductID = @id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtProductID.Text));
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string name = reader["ProductName"].ToString();
                decimal price = Convert.ToDecimal(reader["Price"]);
                int quantity = int.Parse(txtQuantity.Text);
                decimal total = price * quantity;
                cartTable.Rows.Add(int.Parse(txtProductID.Text), name, price, quantity, total);
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
            conn.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0 || cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please add products and select a payment method.");
                return;
            }

            decimal totalAmount = CalculateCartTotal();
            conn.Open();
            SqlCommand cmd = new SqlCommand("EXEC AddTransaction @userID, @totalAmount, @paymentMethod, @transactionID OUTPUT", conn);
            cmd.Parameters.AddWithValue("@userID", 1);
            cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
            cmd.Parameters.AddWithValue("@paymentMethod", cmbPaymentMethod.Text);
            SqlParameter outputIdParam = new SqlParameter("@transactionID", SqlDbType.Int) { Direction = ParameterDirection.Output };
            cmd.Parameters.Add(outputIdParam);
            cmd.ExecuteNonQuery();
            int transactionId = (int)outputIdParam.Value;

            foreach (DataRow row in cartTable.Rows)
            {
                SqlCommand itemCmd = new SqlCommand("EXEC AddTransactionItem @transactionID, @productID, @quantity, @price", conn);
                itemCmd.Parameters.AddWithValue("@transactionID", transactionId);
                itemCmd.Parameters.AddWithValue("@productID", (int)row["Product ID"]);
                itemCmd.Parameters.AddWithValue("@quantity", (int)row["Quantity"]);
                itemCmd.Parameters.AddWithValue("@price", (decimal)row["Price"]);
                itemCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Transaction completed successfully.");
            cartTable.Clear();
            UpdateTotal();
            conn.Close();
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm(1);
            mainForm.Show();
            this.Close();
        }

        private void UpdateTotal()
        {
            lblTotal.Text = $"Total: ${CalculateCartTotal()}";
        }

        private decimal CalculateCartTotal()
        {
            decimal total = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                total += (decimal)row["Total"];
            }
            return total;
        }
    }
}