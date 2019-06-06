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
    public partial class FORM_MANAGE_CUSTOMER : Form
    {
        Customer customer = new Customer();
        Order order = new Order();
        int position = 0;
        public FORM_MANAGE_CUSTOMER()
        {
            InitializeComponent();
            DGV_CUSTOMERS.DataSource = customer.getCustomers();

        }

        private void FORM_MANAGE_CUSTOMER_Load(object sender, EventArgs e)
        {
           navigation(position);
           int cc = Convert.ToInt32(DGV_CUSTOMERS.Rows[0].Cells[0].Value.ToString());
           LBL_ORDER_COUNT.Text = order.getCustomerOrdersCount(Convert.ToInt32(cc));
           LBL_ORDER_AMOUNT.Text = order.getCustomerOrdersTotalAmount(Convert.ToInt32(cc));
           LBL_LAST_ORDER_DATE.Text = order.getCustomerLastOrderDate(Convert.ToInt32(cc)).ToString();
        }

        // add customer
        private void BTN_INSERT_CUSTOMER_Click(object sender, EventArgs e)
        {
            customer.insertCustomer(TB_FNAME.Text,TB_LNAME.Text, TB_TEL.Text,TB_EMAIL.Text);
            MessageBox.Show("New Customer Inserted Successfully", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_CUSTOMERS.DataSource = customer.getCustomers();
        }

        // get selected customer info in textboxes
        private void DGV_CUSTOMERS_Click(object sender, EventArgs e)
        {

                TB_ID_CUSTOMER.Text = DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString();
                TB_FNAME.Text = DGV_CUSTOMERS.CurrentRow.Cells[1].Value.ToString();
                TB_LNAME.Text = DGV_CUSTOMERS.CurrentRow.Cells[2].Value.ToString();
                TB_TEL.Text = DGV_CUSTOMERS.CurrentRow.Cells[3].Value.ToString();
                TB_EMAIL.Text = DGV_CUSTOMERS.CurrentRow.Cells[4].Value.ToString();
                LBL_ORDER_COUNT.Text = order.getCustomerOrdersCount(Convert.ToInt32(DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString()));
                LBL_ORDER_AMOUNT.Text = order.getCustomerOrdersTotalAmount(Convert.ToInt32(DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString()));
                LBL_LAST_ORDER_DATE.Text = order.getCustomerLastOrderDate(Convert.ToInt32(DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString()));
        }

        // update customer
        private void BTN_UPDATE_CUSTOMER_Click(object sender, EventArgs e)
        {
            if (TB_ID_CUSTOMER.Text == string.Empty)
            {
                MessageBox.Show("Select The Costumer To Update", "Select A Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                customer.updateCustomer(Convert.ToInt32(TB_ID_CUSTOMER.Text), TB_FNAME.Text, TB_LNAME.Text, TB_TEL.Text, TB_EMAIL.Text);
                MessageBox.Show("Customer Updated Successfully", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_CUSTOMERS.DataSource = customer.getCustomers();
            }
            
        }

        // delete customer
        private void BTN_DELETE_CUSTOMER_Click(object sender, EventArgs e)
        {
            if (TB_ID_CUSTOMER.Text == string.Empty)
            {
                MessageBox.Show("Select The Costumer To Delete", "Delete A Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("do you really want to delete this Customer", "Remove Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customer.deleteCustomer(Convert.ToInt32(TB_ID_CUSTOMER.Text));
                    DGV_CUSTOMERS.DataSource = customer.getCustomers();
                    MessageBox.Show("Customer Deleted Successfully", "Remove Customer");
                    TB_ID_CUSTOMER.Text = "";
                    TB_FNAME.Text = "";
                    TB_LNAME.Text = "";
                    TB_TEL.Text = "";
                    TB_EMAIL.Text = "";
                }
            }
        }

        public void navigation(int pos)
        {
            DataTable table = new DataTable();
            table = customer.getCustomers();
            TB_ID_CUSTOMER.Text = table.Rows[pos][0].ToString();
            TB_FNAME.Text = table.Rows[pos][1].ToString();
            TB_LNAME.Text = table.Rows[pos][2].ToString();
            TB_TEL.Text = table.Rows[pos][3].ToString();
            TB_EMAIL.Text = table.Rows[pos][4].ToString();
        }

        private void BTN_PREVIOUS_Click(object sender, EventArgs e)
        {
            if (position == 0)
                return;
            position --;
            navigation(position);
        }

        private void BTN_NEXT_Click(object sender, EventArgs e)
        {
            if (position == customer.getCustomers().Rows.Count - 1)
                return;
            position ++;
            navigation(position);
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            TB_ID_CUSTOMER.Text = "";
            TB_FNAME.Text = "";
            TB_LNAME.Text = "";
            TB_TEL.Text = "";
            TB_EMAIL.Text = "";
        }      
    }
}
