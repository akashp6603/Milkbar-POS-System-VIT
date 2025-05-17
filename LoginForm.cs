using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MilkbarPOS
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3I4FG4K;Initial Catalog=MilkbarPOS;Integrated Security=True");
        private bool passwordVisible = false;

        public LoginForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both Username and Password.");
                return;
            }

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT RoleID FROM Users WHERE Username = @username AND PasswordHash = @password", conn);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var mainForm = new MainForm(Convert.ToInt32(reader["RoleID"]));
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }

            conn.Close();
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            txtPassword.PasswordChar = passwordVisible ? '\0' : '*';
            btnTogglePassword.Text = passwordVisible ? "🙈" : "👁️";
        }
    }
}
