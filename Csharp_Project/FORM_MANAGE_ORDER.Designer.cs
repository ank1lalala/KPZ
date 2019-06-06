namespace Csharp_Project
{
    partial class FORM_MANAGE_ORDER
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
            this.DGV_CUSTOMER = new System.Windows.Forms.DataGridView();
            this.TB_ORDER_ID = new System.Windows.Forms.TextBox();
            this.TB_CUSTOMER_ID = new System.Windows.Forms.TextBox();
            this.COMBO_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.DGV_PRODUCTS = new System.Windows.Forms.DataGridView();
            this.DGV_PRODUCTS_IN_ORDER = new System.Windows.Forms.DataGridView();
            this.TB_SUM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_DELETE_PRODUCTS = new System.Windows.Forms.Button();
            this.CB_SELECT_ALL = new System.Windows.Forms.CheckBox();
            this.BTN_INSERT_ORDER = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BTN_NEW_CUSTOMER = new System.Windows.Forms.Button();
            this.PANEL_CLOSE = new System.Windows.Forms.Panel();
            this.PANEL_MIN = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_ALL_ORDERS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_ORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CUSTOMER
            // 
            this.DGV_CUSTOMER.AllowUserToAddRows = false;
            this.DGV_CUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CUSTOMER.Location = new System.Drawing.Point(12, 125);
            this.DGV_CUSTOMER.Name = "DGV_CUSTOMER";
            this.DGV_CUSTOMER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMER.Size = new System.Drawing.Size(509, 176);
            this.DGV_CUSTOMER.TabIndex = 0;
            this.DGV_CUSTOMER.Click += new System.EventHandler(this.DGV_CUSTOMER_Click);
            this.DGV_CUSTOMER.DoubleClick += new System.EventHandler(this.DGV_CUSTOMER_DoubleClick);
            // 
            // TB_ORDER_ID
            // 
            this.TB_ORDER_ID.Location = new System.Drawing.Point(881, 165);
            this.TB_ORDER_ID.Name = "TB_ORDER_ID";
            this.TB_ORDER_ID.ReadOnly = true;
            this.TB_ORDER_ID.Size = new System.Drawing.Size(100, 20);
            this.TB_ORDER_ID.TabIndex = 4;
            // 
            // TB_CUSTOMER_ID
            // 
            this.TB_CUSTOMER_ID.Location = new System.Drawing.Point(881, 123);
            this.TB_CUSTOMER_ID.Name = "TB_CUSTOMER_ID";
            this.TB_CUSTOMER_ID.ReadOnly = true;
            this.TB_CUSTOMER_ID.Size = new System.Drawing.Size(100, 20);
            this.TB_CUSTOMER_ID.TabIndex = 5;
            // 
            // COMBO_CATEGORIES
            // 
            this.COMBO_CATEGORIES.BackColor = System.Drawing.Color.Black;
            this.COMBO_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CATEGORIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_CATEGORIES.ForeColor = System.Drawing.Color.White;
            this.COMBO_CATEGORIES.FormattingEnabled = true;
            this.COMBO_CATEGORIES.Location = new System.Drawing.Point(130, 320);
            this.COMBO_CATEGORIES.Name = "COMBO_CATEGORIES";
            this.COMBO_CATEGORIES.Size = new System.Drawing.Size(171, 21);
            this.COMBO_CATEGORIES.TabIndex = 6;
            this.COMBO_CATEGORIES.SelectedIndexChanged += new System.EventHandler(this.COMBO_CATEGORIES_SelectedIndexChanged);
            // 
            // DGV_PRODUCTS
            // 
            this.DGV_PRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS.Location = new System.Drawing.Point(12, 362);
            this.DGV_PRODUCTS.Name = "DGV_PRODUCTS";
            this.DGV_PRODUCTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS.Size = new System.Drawing.Size(416, 287);
            this.DGV_PRODUCTS.TabIndex = 7;
            this.DGV_PRODUCTS.DoubleClick += new System.EventHandler(this.DGV_PRODUCTS_DoubleClick);
            // 
            // DGV_PRODUCTS_IN_ORDER
            // 
            this.DGV_PRODUCTS_IN_ORDER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS_IN_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS_IN_ORDER.Location = new System.Drawing.Point(497, 362);
            this.DGV_PRODUCTS_IN_ORDER.Name = "DGV_PRODUCTS_IN_ORDER";
            this.DGV_PRODUCTS_IN_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCTS_IN_ORDER.Size = new System.Drawing.Size(597, 287);
            this.DGV_PRODUCTS_IN_ORDER.TabIndex = 8;
            // 
            // TB_SUM
            // 
            this.TB_SUM.Location = new System.Drawing.Point(972, 655);
            this.TB_SUM.Name = "TB_SUM";
            this.TB_SUM.Size = new System.Drawing.Size(122, 20);
            this.TB_SUM.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(859, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Amount :";
            // 
            // BTN_DELETE_PRODUCTS
            // 
            this.BTN_DELETE_PRODUCTS.BackColor = System.Drawing.Color.Black;
            this.BTN_DELETE_PRODUCTS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_PRODUCTS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_DELETE_PRODUCTS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_PRODUCTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE_PRODUCTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_PRODUCTS.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_PRODUCTS.Location = new System.Drawing.Point(825, 327);
            this.BTN_DELETE_PRODUCTS.Name = "BTN_DELETE_PRODUCTS";
            this.BTN_DELETE_PRODUCTS.Size = new System.Drawing.Size(166, 29);
            this.BTN_DELETE_PRODUCTS.TabIndex = 11;
            this.BTN_DELETE_PRODUCTS.Text = "Delete Slected Products";
            this.BTN_DELETE_PRODUCTS.UseVisualStyleBackColor = false;
            this.BTN_DELETE_PRODUCTS.Click += new System.EventHandler(this.BTN_DELETE_PRODUCTS_Click);
            // 
            // CB_SELECT_ALL
            // 
            this.CB_SELECT_ALL.AutoSize = true;
            this.CB_SELECT_ALL.BackColor = System.Drawing.Color.Transparent;
            this.CB_SELECT_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_SELECT_ALL.Location = new System.Drawing.Point(997, 332);
            this.CB_SELECT_ALL.Name = "CB_SELECT_ALL";
            this.CB_SELECT_ALL.Size = new System.Drawing.Size(112, 19);
            this.CB_SELECT_ALL.TabIndex = 12;
            this.CB_SELECT_ALL.Text = "Выбрать все";
            this.CB_SELECT_ALL.UseVisualStyleBackColor = false;
            this.CB_SELECT_ALL.CheckedChanged += new System.EventHandler(this.CB_SELECT_ALL_CheckedChanged);
            // 
            // BTN_INSERT_ORDER
            // 
            this.BTN_INSERT_ORDER.BackColor = System.Drawing.Color.Black;
            this.BTN_INSERT_ORDER.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_INSERT_ORDER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_INSERT_ORDER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_INSERT_ORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_INSERT_ORDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERT_ORDER.ForeColor = System.Drawing.Color.White;
            this.BTN_INSERT_ORDER.Location = new System.Drawing.Point(497, 327);
            this.BTN_INSERT_ORDER.Name = "BTN_INSERT_ORDER";
            this.BTN_INSERT_ORDER.Size = new System.Drawing.Size(166, 29);
            this.BTN_INSERT_ORDER.TabIndex = 13;
            this.BTN_INSERT_ORDER.Text = "Insert Order";
            this.BTN_INSERT_ORDER.UseVisualStyleBackColor = false;
            this.BTN_INSERT_ORDER.Click += new System.EventHandler(this.BTN_INSERT_ORDER_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(881, 208);
            this.dateTimePicker1.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // BTN_NEW_CUSTOMER
            // 
            this.BTN_NEW_CUSTOMER.BackColor = System.Drawing.Color.Black;
            this.BTN_NEW_CUSTOMER.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_CUSTOMER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_NEW_CUSTOMER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_CUSTOMER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW_CUSTOMER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEW_CUSTOMER.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW_CUSTOMER.Location = new System.Drawing.Point(541, 125);
            this.BTN_NEW_CUSTOMER.Name = "BTN_NEW_CUSTOMER";
            this.BTN_NEW_CUSTOMER.Size = new System.Drawing.Size(148, 33);
            this.BTN_NEW_CUSTOMER.TabIndex = 16;
            this.BTN_NEW_CUSTOMER.Text = "Add New Customer";
            this.BTN_NEW_CUSTOMER.UseVisualStyleBackColor = false;
            this.BTN_NEW_CUSTOMER.Click += new System.EventHandler(this.BTN_NEW_CUSTOMER_Click);
            // 
            // PANEL_CLOSE
            // 
            this.PANEL_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_CLOSE.Location = new System.Drawing.Point(1042, 27);
            this.PANEL_CLOSE.Name = "PANEL_CLOSE";
            this.PANEL_CLOSE.Size = new System.Drawing.Size(52, 52);
            this.PANEL_CLOSE.TabIndex = 17;
            this.PANEL_CLOSE.Click += new System.EventHandler(this.PANEL_CLOSE_Click);
            // 
            // PANEL_MIN
            // 
            this.PANEL_MIN.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_MIN.Location = new System.Drawing.Point(968, 26);
            this.PANEL_MIN.Name = "PANEL_MIN";
            this.PANEL_MIN.Size = new System.Drawing.Size(52, 52);
            this.PANEL_MIN.TabIndex = 18;
            this.PANEL_MIN.Click += new System.EventHandler(this.PANEL_MIN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(776, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Заказчик Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(806, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Заказ Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(772, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Дата заказа :";
            // 
            // BTN_ALL_ORDERS
            // 
            this.BTN_ALL_ORDERS.BackColor = System.Drawing.Color.Black;
            this.BTN_ALL_ORDERS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_ALL_ORDERS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_ALL_ORDERS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_ALL_ORDERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ALL_ORDERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ALL_ORDERS.ForeColor = System.Drawing.Color.White;
            this.BTN_ALL_ORDERS.Location = new System.Drawing.Point(680, 327);
            this.BTN_ALL_ORDERS.Name = "BTN_ALL_ORDERS";
            this.BTN_ALL_ORDERS.Size = new System.Drawing.Size(130, 29);
            this.BTN_ALL_ORDERS.TabIndex = 22;
            this.BTN_ALL_ORDERS.Text = "Show All Orders";
            this.BTN_ALL_ORDERS.UseVisualStyleBackColor = false;
            this.BTN_ALL_ORDERS.Click += new System.EventHandler(this.BTN_ALL_ORDERS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "заказчик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Продукты";
            // 
            // FORM_MANAGE_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharp_Project.Properties.Resources.Manage_Order;
            this.ClientSize = new System.Drawing.Size(1111, 696);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_ALL_ORDERS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PANEL_MIN);
            this.Controls.Add(this.PANEL_CLOSE);
            this.Controls.Add(this.BTN_NEW_CUSTOMER);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BTN_INSERT_ORDER);
            this.Controls.Add(this.CB_SELECT_ALL);
            this.Controls.Add(this.BTN_DELETE_PRODUCTS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_SUM);
            this.Controls.Add(this.DGV_PRODUCTS_IN_ORDER);
            this.Controls.Add(this.DGV_PRODUCTS);
            this.Controls.Add(this.COMBO_CATEGORIES);
            this.Controls.Add(this.TB_CUSTOMER_ID);
            this.Controls.Add(this.TB_ORDER_ID);
            this.Controls.Add(this.DGV_CUSTOMER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_MANAGE_ORDER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_MANAGE_ORDER";
            this.Load += new System.EventHandler(this.FORM_MANAGE_ORDER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_ORDER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_ORDER_ID;
        private System.Windows.Forms.TextBox TB_CUSTOMER_ID;
        private System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS_IN_ORDER;
        private System.Windows.Forms.TextBox TB_SUM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_DELETE_PRODUCTS;
        private System.Windows.Forms.CheckBox CB_SELECT_ALL;
        private System.Windows.Forms.Button BTN_INSERT_ORDER;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BTN_NEW_CUSTOMER;
        public System.Windows.Forms.DataGridView DGV_CUSTOMER;
        private System.Windows.Forms.Panel PANEL_CLOSE;
        private System.Windows.Forms.Panel PANEL_MIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_ALL_ORDERS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}