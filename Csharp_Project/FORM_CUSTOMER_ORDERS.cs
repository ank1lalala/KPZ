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
    public partial class FORM_CUSTOMER_ORDERS : Form
    {
        Order order = new Order();
        public FORM_CUSTOMER_ORDERS()
        {
            InitializeComponent();

        }
        // Внести в листбокс название продуктов  из выбраного заказа
        private void FORM_CUSTOMER_ORDERS_Load(object sender, EventArgs e)
        {
            // show customer oreders
            if(DGV_CUSTOMER_ORDERS.Rows.Count -1 != 0)
            {
                int orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value.ToString());
                DataTable details = new DataTable();
                // get the order details
                details = order.getOrderDetails(orderId);
                if (details.Rows.Count != 0)
                {
                    // show the products in the listbox
                    LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = order.getOrderDetails(orderId);
                    LSB_CUSTOMER_ORDER_PRODUCTS.DisplayMember = "PRO_NAME";
                }
                else
                {
                    LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = null;
                    LSB_CUSTOMER_ORDER_PRODUCTS.Items.Add("Продукт не выбран");
                }
            }
            
        }

        // Внести в листбокс название продуктов  из выбраного заказа
        private void DGV_CUSTOMER_ORDERS_DoubleClick(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value.ToString());
            DataTable details = new DataTable();
            details = order.getOrderDetails(orderId);
            if (details.Rows.Count != 0)
            {
                LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = order.getOrderDetails(orderId);
                LSB_CUSTOMER_ORDER_PRODUCTS.DisplayMember = "PRO_NAME";
            }
            else
            {
                LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = null;
                LSB_CUSTOMER_ORDER_PRODUCTS.Items.Add("Продукт не выбран");
            }
        }

        // show products in the selected order 
        private void DGV_CUSTOMER_ORDERS_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value.ToString());
            DataTable details = new DataTable();
            details = order.getOrderDetails(orderId);
            if (details.Rows.Count != 0)
            {
                LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = order.getOrderDetails(orderId);
                LSB_CUSTOMER_ORDER_PRODUCTS.DisplayMember = "PRO_NAME";
            }
            else
            {
                LSB_CUSTOMER_ORDER_PRODUCTS.DataSource = null;
                LSB_CUSTOMER_ORDER_PRODUCTS.Items.Add("Продукт не выбран");
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
