using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Project
{
    public partial class FORM_NEW_CUSTOMER : Form
    {
        Customer customer = new Customer();
        public FORM_NEW_CUSTOMER()
        {
            InitializeComponent();
            this.ActiveControl = TB_FNAME;
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_ADD_CUSTOMER_Click(object sender, EventArgs e)
        {
            if (TB_FNAME.Text == string.Empty || TB_LNAME.Text == string.Empty || TB_TEL.Text == string.Empty || TB_EMAIL.Text == string.Empty)
            {
                MessageBox.Show("One Or More Fields Are Empty","Empty Fields",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                customer.insertCustomer(TB_FNAME.Text, TB_LNAME.Text, TB_TEL.Text, TB_EMAIL.Text);
               
                MessageBox.Show("Customer Added", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public Boolean RegExp(string re, TextBox tb)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                return true;
            }
            else
            {
                return false;
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
