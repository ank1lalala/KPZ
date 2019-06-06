namespace Csharp_Project
{
    partial class FORM_CUSTOMER_ORDERS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_CUSTOMER_ORDERS = new System.Windows.Forms.DataGridView();
            this.LSB_CUSTOMER_ORDER_PRODUCTS = new System.Windows.Forms.ListBox();
            this.LBL_CUSTOMER = new System.Windows.Forms.Label();
            this.PANEL_CLOSE = new System.Windows.Forms.Panel();
            this.PANEL_MIN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER_ORDERS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CUSTOMER_ORDERS
            // 
            this.DGV_CUSTOMER_ORDERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMER_ORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CUSTOMER_ORDERS.Location = new System.Drawing.Point(12, 131);
            this.DGV_CUSTOMER_ORDERS.Name = "DGV_CUSTOMER_ORDERS";
            this.DGV_CUSTOMER_ORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMER_ORDERS.Size = new System.Drawing.Size(328, 371);
            this.DGV_CUSTOMER_ORDERS.TabIndex = 0;
            this.DGV_CUSTOMER_ORDERS.Click += new System.EventHandler(this.DGV_CUSTOMER_ORDERS_Click);
            this.DGV_CUSTOMER_ORDERS.DoubleClick += new System.EventHandler(this.DGV_CUSTOMER_ORDERS_DoubleClick);
            // 
            // LSB_CUSTOMER_ORDER_PRODUCTS
            // 
            this.LSB_CUSTOMER_ORDER_PRODUCTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSB_CUSTOMER_ORDER_PRODUCTS.FormattingEnabled = true;
            this.LSB_CUSTOMER_ORDER_PRODUCTS.ItemHeight = 20;
            this.LSB_CUSTOMER_ORDER_PRODUCTS.Location = new System.Drawing.Point(413, 138);
            this.LSB_CUSTOMER_ORDER_PRODUCTS.Name = "LSB_CUSTOMER_ORDER_PRODUCTS";
            this.LSB_CUSTOMER_ORDER_PRODUCTS.Size = new System.Drawing.Size(221, 364);
            this.LSB_CUSTOMER_ORDER_PRODUCTS.TabIndex = 1;
            // 
            // LBL_CUSTOMER
            // 
            this.LBL_CUSTOMER.AutoSize = true;
            this.LBL_CUSTOMER.BackColor = System.Drawing.Color.Transparent;
            this.LBL_CUSTOMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CUSTOMER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.LBL_CUSTOMER.Location = new System.Drawing.Point(16, 103);
            this.LBL_CUSTOMER.Name = "LBL_CUSTOMER";
            this.LBL_CUSTOMER.Size = new System.Drawing.Size(0, 25);
            this.LBL_CUSTOMER.TabIndex = 2;
            // 
            // PANEL_CLOSE
            // 
            this.PANEL_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_CLOSE.Location = new System.Drawing.Point(625, 18);
            this.PANEL_CLOSE.Name = "PANEL_CLOSE";
            this.PANEL_CLOSE.Size = new System.Drawing.Size(33, 32);
            this.PANEL_CLOSE.TabIndex = 3;
            this.PANEL_CLOSE.Click += new System.EventHandler(this.PANEL_CLOSE_Click);
            // 
            // PANEL_MIN
            // 
            this.PANEL_MIN.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_MIN.Location = new System.Drawing.Point(577, 17);
            this.PANEL_MIN.Name = "PANEL_MIN";
            this.PANEL_MIN.Size = new System.Drawing.Size(33, 32);
            this.PANEL_MIN.TabIndex = 4;
            this.PANEL_MIN.Click += new System.EventHandler(this.PANEL_MIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(413, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Продукт";
            // 
            // FORM_CUSTOMER_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharp_Project.Properties.Resources.Customer_Orders;
            this.ClientSize = new System.Drawing.Size(670, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PANEL_MIN);
            this.Controls.Add(this.PANEL_CLOSE);
            this.Controls.Add(this.LBL_CUSTOMER);
            this.Controls.Add(this.LSB_CUSTOMER_ORDER_PRODUCTS);
            this.Controls.Add(this.DGV_CUSTOMER_ORDERS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_CUSTOMER_ORDERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_CUSTOMER_ORDERS";
            this.Load += new System.EventHandler(this.FORM_CUSTOMER_ORDERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER_ORDERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_CUSTOMER_ORDERS;
        public System.Windows.Forms.ListBox LSB_CUSTOMER_ORDER_PRODUCTS;
        public System.Windows.Forms.Label LBL_CUSTOMER;
        private System.Windows.Forms.Panel PANEL_CLOSE;
        private System.Windows.Forms.Panel PANEL_MIN;
        public System.Windows.Forms.Label label1;

    }
}