namespace Csharp_Project
{
    partial class FORM_PRODUCTS_IN_CATEGORY
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
            this.LBL_CATEGORY = new System.Windows.Forms.Label();
            this.DGV_PRODUCTS_IN_CATEGORY = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PANEL_CLOSE = new System.Windows.Forms.Panel();
            this.PANEL_MIN = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_CATEGORY)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_CATEGORY
            // 
            this.LBL_CATEGORY.AutoSize = true;
            this.LBL_CATEGORY.BackColor = System.Drawing.Color.Transparent;
            this.LBL_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CATEGORY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.LBL_CATEGORY.Location = new System.Drawing.Point(425, 113);
            this.LBL_CATEGORY.Name = "LBL_CATEGORY";
            this.LBL_CATEGORY.Size = new System.Drawing.Size(57, 20);
            this.LBL_CATEGORY.TabIndex = 0;
            this.LBL_CATEGORY.Text = "label1";
            // 
            // DGV_PRODUCTS_IN_CATEGORY
            // 
            this.DGV_PRODUCTS_IN_CATEGORY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS_IN_CATEGORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS_IN_CATEGORY.Location = new System.Drawing.Point(25, 146);
            this.DGV_PRODUCTS_IN_CATEGORY.Name = "DGV_PRODUCTS_IN_CATEGORY";
            this.DGV_PRODUCTS_IN_CATEGORY.Size = new System.Drawing.Size(751, 321);
            this.DGV_PRODUCTS_IN_CATEGORY.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(185, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products In The Categorie : ";
            // 
            // PANEL_CLOSE
            // 
            this.PANEL_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_CLOSE.Location = new System.Drawing.Point(715, 22);
            this.PANEL_CLOSE.Name = "PANEL_CLOSE";
            this.PANEL_CLOSE.Size = new System.Drawing.Size(52, 52);
            this.PANEL_CLOSE.TabIndex = 3;
            this.PANEL_CLOSE.Click += new System.EventHandler(this.PANEL_CLOSE_Click);
            // 
            // PANEL_MIN
            // 
            this.PANEL_MIN.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_MIN.Location = new System.Drawing.Point(640, 22);
            this.PANEL_MIN.Name = "PANEL_MIN";
            this.PANEL_MIN.Size = new System.Drawing.Size(52, 52);
            this.PANEL_MIN.TabIndex = 4;
            this.PANEL_MIN.Click += new System.EventHandler(this.PANEL_MIN_Click);
            // 
            // FORM_PRODUCTS_IN_CATEGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharp_Project.Properties.Resources.Products_In_Categorie;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.PANEL_MIN);
            this.Controls.Add(this.PANEL_CLOSE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_PRODUCTS_IN_CATEGORY);
            this.Controls.Add(this.LBL_CATEGORY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_PRODUCTS_IN_CATEGORY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_PRODUCTS_IN_CATEGORY";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS_IN_CATEGORY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBL_CATEGORY;
        public System.Windows.Forms.DataGridView DGV_PRODUCTS_IN_CATEGORY;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PANEL_CLOSE;
        private System.Windows.Forms.Panel PANEL_MIN;
    }
}