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
    public partial class FORM_LOGIN : Form
    {
        Login log = new Login();
        public FORM_LOGIN()
        {
            InitializeComponent();
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        // login
        private void PANEL_LOGIN_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = log.login(TB_USERNAME.Text, TB_PASSWORD.Text);
            if (table.Rows.Count > 0)
            {
                //if the user is admin 
                // => hide the current form and show the home form
                if(table.Rows[0][3].ToString() == "admin")
                {
                    this.Hide();
                    FORM_HOME FH = new FORM_HOME();
                    FH.Closed += (s, args) => this.Close();
                    FH.Show();
                    
                }
                //else the user is not an admin 
                // => hide the current form and show the home form
                // => and don't show the user tab
                // => a simple user cannot see the user tab  
                else
                {
                    this.Hide();
                    FORM_HOME FH = new FORM_HOME();
                    FH.Closed += (s, args) => this.Close();
                    FH.userToolStripMenuItem.Visible = false;
                    FH.Show();
                    
                }
                
            }
            else
            {
                MessageBox.Show("Username Or Password Are Incorrect");
            }
        }

        // show the password characters or not
        private void CB_PASSWORD_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_PASSWORD.Checked)
            {
                TB_PASSWORD.UseSystemPasswordChar = true;
            }
            else
            {
                TB_PASSWORD.UseSystemPasswordChar = false;
            }
        }
  
    }
}
