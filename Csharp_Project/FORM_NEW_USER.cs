using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Project
{
    public partial class FORM_NEW_USER : Form
    {
        User user = new User();
        public FORM_NEW_USER()
        {
            InitializeComponent();
            this.ActiveControl = TB_USERNAME;
        }

        private void BTN_ADD_CUSTOMER_Click(object sender, EventArgs e)
        {
            if(TB_USERNAME.Text == string.Empty || TB_FULLNAME.Text == string.Empty || TB_PASSWORD.Text == string.Empty || TB_TEL.Text == string.Empty || TB_EMAIL.Text == string.Empty)
            {
                MessageBox.Show("One Or More Fields Are Empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user.insertUser(TB_USERNAME.Text, TB_FULLNAME.Text, TB_PASSWORD.Text, TB_TEL.Text, TB_EMAIL.Text);
                MessageBox.Show("New User Inserted Successfully", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
