namespace MilkbarPOS
{
    partial class TransactionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnReturnToMain;
        private System.Windows.Forms.Label lblTotal;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Purple;
            this.lblTitle.Location = new System.Drawing.Point(133, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Milkbar POS - New Transaction";
            // 
            // lblProductId
            // 
            this.lblProductId.Location = new System.Drawing.Point(43, 146);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(100, 23);
            this.lblProductId.TabIndex = 1;
            this.lblProductId.Text = "Product ID:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(43, 176);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 23);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(160, 146);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 22);
            this.txtProductID.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(160, 176);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 4;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Purple;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(402, 146);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(100, 38);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeight = 29;
            this.dgvCart.Location = new System.Drawing.Point(43, 216);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(540, 150);
            this.dgvCart.TabIndex = 6;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(43, 386);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(200, 24);
            this.cmbPaymentMethod.TabIndex = 7;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Purple;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(263, 386);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(150, 30);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.BackColor = System.Drawing.Color.Gray;
            this.btnReturnToMain.ForeColor = System.Drawing.Color.White;
            this.btnReturnToMain.Location = new System.Drawing.Point(433, 386);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(150, 30);
            this.btnReturnToMain.TabIndex = 9;
            this.btnReturnToMain.Text = "Back to Home";
            this.btnReturnToMain.UseVisualStyleBackColor = false;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(43, 436);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 23);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total: $0.00";
            // 
            // TransactionForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 590);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnReturnToMain);
            this.Controls.Add(this.lblTotal);
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milkbar POS - Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
