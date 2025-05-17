namespace MilkbarPOS
{
    partial class LoginForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnTogglePassword;
        private System.Windows.Forms.Button btnLogin;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTogglePassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Purple;
            this.lblTitle.Location = new System.Drawing.Point(80, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(364, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Milkbar POS";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(50, 80);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(150, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(50, 120);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(100, 23);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Location = new System.Drawing.Point(269, 117);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(29, 23);
            this.btnTogglePassword.TabIndex = 5;
            this.btnTogglePassword.Text = "👁️";
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Purple;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(150, 170);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 30);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 479);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnTogglePassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.Text = "Milkbar POS - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
