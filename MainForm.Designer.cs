namespace MilkbarPOS
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Purple;
            this.lblTitle.Location = new System.Drawing.Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(349, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Milkbar POS - Dashboard";
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Purple;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Location = new System.Drawing.Point(186, 93);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(200, 40);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "Start Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Purple;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(186, 153);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 40);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "View Reports";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(186, 213);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnLogout);
            this.Name = "MainForm";
            this.Text = "Milkbar POS - Dashboard";
            this.ResumeLayout(false);
        }
    }
}
