namespace MilkbarPOS
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReturnToMain;
        private System.Windows.Forms.DataGridView dgvReport;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Purple;
            this.lblTitle.Location = new System.Drawing.Point(244, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transaction Report";
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(30, 60);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(300, 22);
            this.dtStart.TabIndex = 1;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(350, 60);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(300, 22);
            this.dtEnd.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Purple;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(250, 100);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(200, 30);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.BackColor = System.Drawing.Color.Gray;
            this.btnReturnToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToMain.ForeColor = System.Drawing.Color.White;
            this.btnReturnToMain.Location = new System.Drawing.Point(470, 100);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(150, 30);
            this.btnReturnToMain.TabIndex = 4;
            this.btnReturnToMain.Text = "Back to Home";
            this.btnReturnToMain.UseVisualStyleBackColor = false;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeight = 29;
            this.dgvReport.Location = new System.Drawing.Point(30, 150);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.Size = new System.Drawing.Size(732, 350);
            this.dgvReport.TabIndex = 5;
            // 
            // ReportForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 637);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnReturnToMain);
            this.Controls.Add(this.dgvReport);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milkbar POS - Transaction Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
