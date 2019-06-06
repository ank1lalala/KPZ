namespace Csharp_Project
{
    partial class FORM_MANAGE_CATEGORIES
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
            this.DGV_CATEGORIES = new System.Windows.Forms.DataGridView();
            this.BTN_INSERT_CTG = new System.Windows.Forms.Button();
            this.BTN_UPDATE_CTG = new System.Windows.Forms.Button();
            this.BTN_DELETE_CTG = new System.Windows.Forms.Button();
            this.TB_CATG_ID = new System.Windows.Forms.TextBox();
            this.TB_CATG_NAME = new System.Windows.Forms.TextBox();
            this.BTN_NEXT = new System.Windows.Forms.Button();
            this.BTN_PREVIOUS = new System.Windows.Forms.Button();
            this.BTN_NEW_CATEGORY = new System.Windows.Forms.Button();
            this.LSTB_PRODUCTS_IN_CATEGORY = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PANEL_CLOSE = new System.Windows.Forms.Panel();
            this.PANEL_MIN = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CATEGORIES
            // 
            this.DGV_CATEGORIES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CATEGORIES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CATEGORIES.Location = new System.Drawing.Point(314, 92);
            this.DGV_CATEGORIES.Name = "DGV_CATEGORIES";
            this.DGV_CATEGORIES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CATEGORIES.Size = new System.Drawing.Size(340, 208);
            this.DGV_CATEGORIES.TabIndex = 0;
            this.DGV_CATEGORIES.Click += new System.EventHandler(this.DGV_CATEGORIES_Click);
            this.DGV_CATEGORIES.DoubleClick += new System.EventHandler(this.DGV_CATEGORIES_DoubleClick);
            // 
            // BTN_INSERT_CTG
            // 
            this.BTN_INSERT_CTG.BackColor = System.Drawing.Color.Black;
            this.BTN_INSERT_CTG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_INSERT_CTG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_INSERT_CTG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_INSERT_CTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_INSERT_CTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERT_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_INSERT_CTG.Location = new System.Drawing.Point(314, 306);
            this.BTN_INSERT_CTG.Name = "BTN_INSERT_CTG";
            this.BTN_INSERT_CTG.Size = new System.Drawing.Size(80, 30);
            this.BTN_INSERT_CTG.TabIndex = 1;
            this.BTN_INSERT_CTG.Text = "Insert";
            this.BTN_INSERT_CTG.UseVisualStyleBackColor = false;
            this.BTN_INSERT_CTG.Click += new System.EventHandler(this.BTN_INSERT_CTG_Click);
            // 
            // BTN_UPDATE_CTG
            // 
            this.BTN_UPDATE_CTG.BackColor = System.Drawing.Color.Black;
            this.BTN_UPDATE_CTG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_UPDATE_CTG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_UPDATE_CTG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_UPDATE_CTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UPDATE_CTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UPDATE_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_UPDATE_CTG.Location = new System.Drawing.Point(400, 306);
            this.BTN_UPDATE_CTG.Name = "BTN_UPDATE_CTG";
            this.BTN_UPDATE_CTG.Size = new System.Drawing.Size(80, 30);
            this.BTN_UPDATE_CTG.TabIndex = 2;
            this.BTN_UPDATE_CTG.Text = "Update";
            this.BTN_UPDATE_CTG.UseVisualStyleBackColor = false;
            this.BTN_UPDATE_CTG.Click += new System.EventHandler(this.BTN_UPDATE_CTG_Click);
            // 
            // BTN_DELETE_CTG
            // 
            this.BTN_DELETE_CTG.BackColor = System.Drawing.Color.Black;
            this.BTN_DELETE_CTG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_CTG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_DELETE_CTG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_CTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE_CTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_CTG.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_CTG.Location = new System.Drawing.Point(486, 306);
            this.BTN_DELETE_CTG.Name = "BTN_DELETE_CTG";
            this.BTN_DELETE_CTG.Size = new System.Drawing.Size(80, 30);
            this.BTN_DELETE_CTG.TabIndex = 3;
            this.BTN_DELETE_CTG.Text = "Delete";
            this.BTN_DELETE_CTG.UseVisualStyleBackColor = false;
            this.BTN_DELETE_CTG.Click += new System.EventHandler(this.BTN_DELETE_CTG_Click);
            // 
            // TB_CATG_ID
            // 
            this.TB_CATG_ID.Location = new System.Drawing.Point(125, 91);
            this.TB_CATG_ID.Name = "TB_CATG_ID";
            this.TB_CATG_ID.ReadOnly = true;
            this.TB_CATG_ID.Size = new System.Drawing.Size(147, 20);
            this.TB_CATG_ID.TabIndex = 4;
            // 
            // TB_CATG_NAME
            // 
            this.TB_CATG_NAME.Location = new System.Drawing.Point(125, 136);
            this.TB_CATG_NAME.Name = "TB_CATG_NAME";
            this.TB_CATG_NAME.Size = new System.Drawing.Size(147, 20);
            this.TB_CATG_NAME.TabIndex = 5;
            // 
            // BTN_NEXT
            // 
            this.BTN_NEXT.BackColor = System.Drawing.Color.Black;
            this.BTN_NEXT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_NEXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEXT.ForeColor = System.Drawing.Color.White;
            this.BTN_NEXT.Location = new System.Drawing.Point(113, 192);
            this.BTN_NEXT.Name = "BTN_NEXT";
            this.BTN_NEXT.Size = new System.Drawing.Size(75, 23);
            this.BTN_NEXT.TabIndex = 6;
            this.BTN_NEXT.Text = "Next";
            this.BTN_NEXT.UseVisualStyleBackColor = false;
            this.BTN_NEXT.Click += new System.EventHandler(this.BTN_NEXT_Click);
            // 
            // BTN_PREVIOUS
            // 
            this.BTN_PREVIOUS.BackColor = System.Drawing.Color.Black;
            this.BTN_PREVIOUS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_PREVIOUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_PREVIOUS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_PREVIOUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PREVIOUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PREVIOUS.ForeColor = System.Drawing.Color.White;
            this.BTN_PREVIOUS.Location = new System.Drawing.Point(194, 192);
            this.BTN_PREVIOUS.Name = "BTN_PREVIOUS";
            this.BTN_PREVIOUS.Size = new System.Drawing.Size(75, 23);
            this.BTN_PREVIOUS.TabIndex = 7;
            this.BTN_PREVIOUS.Text = "Previous";
            this.BTN_PREVIOUS.UseVisualStyleBackColor = false;
            this.BTN_PREVIOUS.Click += new System.EventHandler(this.BTN_PREVIOUS_Click);
            // 
            // BTN_NEW_CATEGORY
            // 
            this.BTN_NEW_CATEGORY.BackColor = System.Drawing.Color.Black;
            this.BTN_NEW_CATEGORY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_CATEGORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_NEW_CATEGORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEW_CATEGORY.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW_CATEGORY.Location = new System.Drawing.Point(197, 306);
            this.BTN_NEW_CATEGORY.Name = "BTN_NEW_CATEGORY";
            this.BTN_NEW_CATEGORY.Size = new System.Drawing.Size(75, 23);
            this.BTN_NEW_CATEGORY.TabIndex = 8;
            this.BTN_NEW_CATEGORY.Text = "Reset";
            this.BTN_NEW_CATEGORY.UseVisualStyleBackColor = false;
            this.BTN_NEW_CATEGORY.Click += new System.EventHandler(this.BTN_NEW_CATEGORY_Click);
            // 
            // LSTB_PRODUCTS_IN_CATEGORY
            // 
            this.LSTB_PRODUCTS_IN_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTB_PRODUCTS_IN_CATEGORY.FormattingEnabled = true;
            this.LSTB_PRODUCTS_IN_CATEGORY.ItemHeight = 20;
            this.LSTB_PRODUCTS_IN_CATEGORY.Location = new System.Drawing.Point(674, 92);
            this.LSTB_PRODUCTS_IN_CATEGORY.Name = "LSTB_PRODUCTS_IN_CATEGORY";
            this.LSTB_PRODUCTS_IN_CATEGORY.Size = new System.Drawing.Size(238, 204);
            this.LSTB_PRODUCTS_IN_CATEGORY.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name : ";
            // 
            // PANEL_CLOSE
            // 
            this.PANEL_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_CLOSE.Location = new System.Drawing.Point(860, 7);
            this.PANEL_CLOSE.Name = "PANEL_CLOSE";
            this.PANEL_CLOSE.Size = new System.Drawing.Size(52, 52);
            this.PANEL_CLOSE.TabIndex = 12;
            this.PANEL_CLOSE.Click += new System.EventHandler(this.PANEL_CLOSE_Click);
            // 
            // PANEL_MIN
            // 
            this.PANEL_MIN.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_MIN.Location = new System.Drawing.Point(796, 7);
            this.PANEL_MIN.Name = "PANEL_MIN";
            this.PANEL_MIN.Size = new System.Drawing.Size(52, 52);
            this.PANEL_MIN.TabIndex = 13;
            this.PANEL_MIN.Click += new System.EventHandler(this.PANEL_MIN_Click);
            // 
            // FORM_MANAGE_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharp_Project.Properties.Resources.Manage_Categories;
            this.ClientSize = new System.Drawing.Size(934, 364);
            this.Controls.Add(this.PANEL_MIN);
            this.Controls.Add(this.PANEL_CLOSE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LSTB_PRODUCTS_IN_CATEGORY);
            this.Controls.Add(this.BTN_NEW_CATEGORY);
            this.Controls.Add(this.BTN_PREVIOUS);
            this.Controls.Add(this.BTN_NEXT);
            this.Controls.Add(this.TB_CATG_NAME);
            this.Controls.Add(this.TB_CATG_ID);
            this.Controls.Add(this.BTN_DELETE_CTG);
            this.Controls.Add(this.BTN_UPDATE_CTG);
            this.Controls.Add(this.BTN_INSERT_CTG);
            this.Controls.Add(this.DGV_CATEGORIES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_MANAGE_CATEGORIES";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_MANAGE_CATEGORIES";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CATEGORIES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_CATEGORIES;
        private System.Windows.Forms.Button BTN_INSERT_CTG;
        private System.Windows.Forms.Button BTN_UPDATE_CTG;
        private System.Windows.Forms.Button BTN_DELETE_CTG;
        private System.Windows.Forms.TextBox TB_CATG_ID;
        private System.Windows.Forms.TextBox TB_CATG_NAME;
        private System.Windows.Forms.Button BTN_NEXT;
        private System.Windows.Forms.Button BTN_PREVIOUS;
        private System.Windows.Forms.Button BTN_NEW_CATEGORY;
        private System.Windows.Forms.ListBox LSTB_PRODUCTS_IN_CATEGORY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PANEL_CLOSE;
        private System.Windows.Forms.Panel PANEL_MIN;
    }
}