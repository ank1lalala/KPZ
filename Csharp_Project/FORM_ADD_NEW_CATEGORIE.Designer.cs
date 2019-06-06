namespace Csharp_Project
{
    partial class FORM_ADD_NEW_CATEGORIE
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
            this.BTN_ADD_CATEGORY = new System.Windows.Forms.Button();
            this.TB_CATEGORY_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PANEL_CLOSE = new System.Windows.Forms.Panel();
            this.PANEL_MIN = new System.Windows.Forms.Panel();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_ADD_CATEGORY
            // 
            this.BTN_ADD_CATEGORY.BackColor = System.Drawing.Color.Black;
            this.BTN_ADD_CATEGORY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_ADD_CATEGORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_ADD_CATEGORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_ADD_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD_CATEGORY.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD_CATEGORY.Location = new System.Drawing.Point(359, 82);
            this.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY";
            this.BTN_ADD_CATEGORY.Size = new System.Drawing.Size(75, 23);
            this.BTN_ADD_CATEGORY.TabIndex = 0;
            this.BTN_ADD_CATEGORY.Text = "Add";
            this.BTN_ADD_CATEGORY.UseVisualStyleBackColor = false;
            this.BTN_ADD_CATEGORY.Click += new System.EventHandler(this.BTN_ADD_CATEGORY_Click);
            // 
            // TB_CATEGORY_NAME
            // 
            this.TB_CATEGORY_NAME.Location = new System.Drawing.Point(158, 83);
            this.TB_CATEGORY_NAME.Name = "TB_CATEGORY_NAME";
            this.TB_CATEGORY_NAME.Size = new System.Drawing.Size(192, 20);
            this.TB_CATEGORY_NAME.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя категории :";
            // 
            // PANEL_CLOSE
            // 
            this.PANEL_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_CLOSE.Location = new System.Drawing.Point(431, 9);
            this.PANEL_CLOSE.Name = "PANEL_CLOSE";
            this.PANEL_CLOSE.Size = new System.Drawing.Size(29, 29);
            this.PANEL_CLOSE.TabIndex = 3;
            this.PANEL_CLOSE.Click += new System.EventHandler(this.PANEL_CLOSE_Click);
            // 
            // PANEL_MIN
            // 
            this.PANEL_MIN.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_MIN.Location = new System.Drawing.Point(393, 9);
            this.PANEL_MIN.Name = "PANEL_MIN";
            this.PANEL_MIN.Size = new System.Drawing.Size(29, 29);
            this.PANEL_MIN.TabIndex = 4;
            this.PANEL_MIN.Click += new System.EventHandler(this.PANEL_MIN_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.BackColor = System.Drawing.Color.Black;
            this.BTN_CANCEL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_CANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_CANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BTN_CANCEL.Location = new System.Drawing.Point(202, 135);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.BTN_CANCEL.TabIndex = 5;
            this.BTN_CANCEL.Text = "Cancel";
            this.BTN_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // FORM_ADD_NEW_CATEGORIE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharp_Project.Properties.Resources.add_Categorie;
            this.ClientSize = new System.Drawing.Size(468, 170);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.PANEL_MIN);
            this.Controls.Add(this.PANEL_CLOSE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CATEGORY_NAME);
            this.Controls.Add(this.BTN_ADD_CATEGORY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_ADD_NEW_CATEGORIE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORM_ADD_NEW_CATEGORIE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ADD_CATEGORY;
        private System.Windows.Forms.TextBox TB_CATEGORY_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PANEL_CLOSE;
        private System.Windows.Forms.Panel PANEL_MIN;
        private System.Windows.Forms.Button BTN_CANCEL;
    }
}