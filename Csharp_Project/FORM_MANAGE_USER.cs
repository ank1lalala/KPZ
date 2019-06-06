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
    public partial class FORM_MANAGE_USER : Form
    {
        User user = new User();
        public FORM_MANAGE_USER()
        {
            InitializeComponent();
            DGV_USERS.DataSource = user.getUsers();
        }

        private void DGV_USERS_Click(object sender, EventArgs e)
        {
            TB_ID.Text       = DGV_USERS.CurrentRow.Cells[0].Value.ToString();
            TB_USERNAME.Text = DGV_USERS.CurrentRow.Cells[1].Value.ToString();
            TB_FULLNAME.Text = DGV_USERS.CurrentRow.Cells[3].Value.ToString();
            TB_TEL.Text      = DGV_USERS.CurrentRow.Cells[4].Value.ToString();
            TB_PASSWORD.Text = DGV_USERS.CurrentRow.Cells[2].Value.ToString();
            TB_EMAIL.Text    = DGV_USERS.CurrentRow.Cells[5].Value.ToString();
        }

        private void BTN_NEW_USER_Click(object sender, EventArgs e)
        {
            FORM_NEW_USER fnu = new FORM_NEW_USER();
            fnu.ShowDialog();
            DGV_USERS.DataSource = user.getUsers();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            
            if(TB_ID.Text != string.Empty)
            {
                if (MessageBox.Show("Do You Want To Delete This User", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    user.deleteUser(Convert.ToInt32(TB_ID.Text));
                    MessageBox.Show("User Deleted Successfully", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_USERS.DataSource = user.getUsers();
                }
            }
            else
            {
                MessageBox.Show("Select the User You Want To Delete");
            }
            

            
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            if (TB_ID.Text != string.Empty)
            {
                user.updateUser(TB_USERNAME.Text, TB_FULLNAME.Text, TB_PASSWORD.Text, TB_TEL.Text, TB_EMAIL.Text, Convert.ToInt32(TB_ID.Text));
                MessageBox.Show("User Updated Successfully", "Update User Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_USERS.DataSource = user.getUsers();
            }

            else
            {
                MessageBox.Show("Select the User You Want To Update");
            }
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
