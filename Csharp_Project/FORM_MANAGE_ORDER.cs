using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Csharp_Project
{
    public partial class FORM_MANAGE_ORDER : Form
    {
        Customer  customer   = new Customer();
        Categorie category   = new Categorie();
        Product   product    = new Product();
        Order order          = new Order();
        DB db                = new DB();

        public FORM_MANAGE_ORDER()
        {

            InitializeComponent();
            // populate datagridview and combobox
            DGV_CUSTOMER.DataSource = customer.getCustomers();
            COMBO_CATEGORIES.DataSource = category.getCategories();
            COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
            COMBO_CATEGORIES.ValueMember = "CAT_ID";
            try
            {
                TB_ORDER_ID.Text = (Convert.ToInt32(order.getOrderMaxId().Rows[0][0].ToString()) + 1).ToString();
            }
            catch (Exception ex)
            {
                TB_ORDER_ID.Text = 3.ToString();
            }

            // design the datagridview order detail
            DataGridViewTextBoxColumn dgvPId = new DataGridViewTextBoxColumn();
            dgvPId.HeaderText = "Id";
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPId);

            DataGridViewTextBoxColumn dgvPn = new DataGridViewTextBoxColumn();
            dgvPn.HeaderText = "Name";
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPn);

            DataGridViewTextBoxColumn dgvcPp = new DataGridViewTextBoxColumn();
            dgvcPp.HeaderText = "Price";
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvcPp);

            DataGridViewTextBoxColumn dgvPq = new DataGridViewTextBoxColumn();
            dgvPq.HeaderText = "Quantity";
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPq);

            DataGridViewTextBoxColumn dgvPqXp = new DataGridViewTextBoxColumn();
            dgvPqXp.HeaderText = "Quantity X Price";
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPqXp);

            DataGridViewCheckBoxColumn dgvPch = new DataGridViewCheckBoxColumn();
            dgvPch.HeaderText = "Select";
            DGV_PRODUCTS_IN_ORDER.Columns.Add(dgvPch);

            try
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DGV_PRODUCTS.AllowUserToAddRows = false;
                DGV_PRODUCTS.RowTemplate.Height = 50;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
               
                
            
        }

        // spr_products_by_category

        /*public DataTable getData()
        {
            DataTable table = new DataTable();
            return table;

        }*/

        // change datagridview products basd on the combo categories
        private void COMBO_CATEGORIES_SelectedIndexChanged(object sender, EventArgs e)
        {
                int val;
                Int32.TryParse(COMBO_CATEGORIES.SelectedValue.ToString(), out val);

                DGV_PRODUCTS.DataSource = product.getProductsByCategory(val);
                DGV_PRODUCTS.Columns[5].Visible = false;
                DGV_PRODUCTS.Columns[6].Visible = false;
        }

        private void FORM_MANAGE_ORDER_Load(object sender, EventArgs e)
        {
            COMBO_CATEGORIES_SelectedIndexChanged(null, null);
        }

        private void DGV_PRODUCTS_DoubleClick(object sender, EventArgs e)
        {
            // get the selected product that you want to add to order
            DataGridViewRow selectedRow = DGV_PRODUCTS.CurrentRow;

            // call add quantity form 
            FORM_QUANTITY fq = new FORM_QUANTITY();

            fq.pro_id = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            fq.ShowDialog();

            int index = 0;
            bool isExist = false;// to test if the product is already add

            if (fq.addTheProduct)// test if the user cancel the add product to order | addTheProduct variable is declared in the quantity form
            {

                string qty = fq.TB_QUANTITY.Text;// get the quantity from the quantity form
                double quantityXprice = Convert.ToInt32(qty) * Convert.ToDouble(selectedRow.Cells[3].Value.ToString());
               
                // if other products exist in the grid
                if (DGV_PRODUCTS_IN_ORDER.Rows.Count - 1 > 0)
                {
                    // check if the product is already add and set isExist to true
                    for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1 ; i++)
                    {
                        if (selectedRow.Cells[0].Value.ToString() == DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[0].Value.ToString())
                        {
                            isExist = true;
                            index = i;

                        }
                    }

                    // if the product already exist
                    // check the stock quantity
                    if(isExist)
                    {
                        // the quantity sum
                        int pqty = Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[3].Value.ToString()) +
                                                   Convert.ToInt32(qty);

                        DataTable table = new DataTable();
                        table = product.getProduct(Convert.ToInt32(selectedRow.Cells[0].Value.ToString()));

                        // if the quantity is heigher than the stock quantity than show a message
                        int qty2 = Convert.ToInt32(table.Rows[0]["STOCK_QTE"].ToString());
                        if (pqty > qty2)
                        {
                            MessageBox.Show("НЕдопустимое количество", "Quantity",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
 
                        }
                         // if quantity is fine add the product 
                        else
                        {
                            quantityXprice = quantityXprice = Convert.ToInt32(pqty) * Convert.ToDouble(selectedRow.Cells[3].Value.ToString());
                            DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[3].Value = pqty.ToString();
                            DGV_PRODUCTS_IN_ORDER.Rows[index].Cells[4].Value = quantityXprice.ToString();
                            getTotal();
                        }
                        
                    }
   
                     // if the product not exist => add product                  
                    else
                    {
                         DGV_PRODUCTS_IN_ORDER.Rows.Add(
                                                selectedRow.Cells[0].Value.ToString(),
                                                selectedRow.Cells[1].Value.ToString(),
                                                selectedRow.Cells[3].Value.ToString(),
                                                qty,
                                                quantityXprice.ToString(),
                                                false);
                        getTotal();
                    }
                }

                 // if the gridview is empty => add product       
                 else if (DGV_PRODUCTS_IN_ORDER.Rows.Count - 1 == 0)
                {
                    DGV_PRODUCTS_IN_ORDER.Rows.Add(selectedRow.Cells[0].Value.ToString(),
                                            selectedRow.Cells[1].Value.ToString(),
                                            selectedRow.Cells[3].Value.ToString(),
                                            qty,
                                            quantityXprice.ToString(),
                                            false);
                    getTotal();
                 }

                getTotal();

            }
        }

        // calculate the order total amount
        public void getTotal()
        {
            TB_SUM.Text = (from DataGridViewRow row in DGV_PRODUCTS_IN_ORDER.Rows
                           where row.Cells[4].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
        }

        // delete the checked products from the datagridview
        private void BTN_DELETE_PRODUCTS_Click(object sender, EventArgs e)
        {
            for (int i = DGV_PRODUCTS_IN_ORDER.Rows.Count - 2; i >= 0; i--)
            {
                bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[5].Value;

                //if the checkbox cell is checked

                 if (delete == true)
                {
                    DataGridViewRow rowToRemove = DGV_PRODUCTS_IN_ORDER.Rows[i];

                    DGV_PRODUCTS_IN_ORDER.Rows.Remove(rowToRemove);
                }
            }

            CB_SELECT_ALL.Checked = false;

            getTotal();
        }

        // select products to delete from datagridview
        private void CB_SELECT_ALL_CheckedChanged(object sender, EventArgs e)
        {
         if(CB_SELECT_ALL.Checked)
         {
             for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
             {
                 bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[5].Value;

                 if (delete == false)
                 {
                     DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[5].Value = true;
                 }
             }
         }
         else
         {
             for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
             {
                 bool delete = (bool)DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[5].Value;

                 if (delete == true)
                 {
                     DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[5].Value = false;
                 }
             }
         }             
        }

        // insrt order with his details
        private void BTN_INSERT_ORDER_Click(object sender, EventArgs e)
        {
            if(TB_CUSTOMER_ID.Text == string.Empty)
            {
                MessageBox.Show("Ни один заказчик не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                order.insertOrder(dateTimePicker1.Value, Convert.ToInt32(TB_CUSTOMER_ID.Text));
                for (int i = 0; i < DGV_PRODUCTS_IN_ORDER.Rows.Count - 1; i++)
                {
                    order.insertOrderDetail(Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[0].Value.ToString()),
                                           Convert.ToInt32(TB_ORDER_ID.Text),
                                           Convert.ToInt32(DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[3].Value.ToString()),
                                           DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[2].Value.ToString(),
                                           DGV_PRODUCTS_IN_ORDER.Rows[i].Cells[4].Value.ToString());
                }

                COMBO_CATEGORIES_SelectedIndexChanged(null, null);
                MessageBox.Show("Заказ вставлен с примечанием");
                TB_ORDER_ID.Text = (Convert.ToInt32(order.getOrderMaxId().Rows[0][0].ToString()) + 1).ToString();
            }
        }

        // get customer id from selected datagridview selected row into textbox
        private void DGV_CUSTOMER_Click(object sender, EventArgs e)
        {
            TB_CUSTOMER_ID.Text = DGV_CUSTOMER.CurrentRow.Cells[0].Value.ToString();
        }

        // show all the selected customer orders
        private void DGV_CUSTOMER_DoubleClick(object sender, EventArgs e)
        {
            FORM_CUSTOMER_ORDERS fco = new FORM_CUSTOMER_ORDERS();
            fco.DGV_CUSTOMER_ORDERS.DataSource = order.getCustomerOrders(Convert.ToInt32(DGV_CUSTOMER.CurrentRow.Cells[0].Value.ToString()));
            fco.LBL_CUSTOMER.Text = "Заказчик: " + DGV_CUSTOMER.CurrentRow.Cells[1].Value.ToString() + " " + DGV_CUSTOMER.CurrentRow.Cells[2].Value.ToString();
            fco.ShowDialog();
        }

        // add new customer => call FORM NEW CUSTOMER
        private void BTN_NEW_CUSTOMER_Click(object sender, EventArgs e)
        {
            FORM_NEW_CUSTOMER fnc = new FORM_NEW_CUSTOMER();
            fnc.ShowDialog();
            DGV_CUSTOMER.DataSource = customer.getCustomers();
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        // show all orders and print to pdf file the selected order
        // ( the orders are orderd from last to first [desc] so you can print your current order by selecting the first one )
        private void BTN_ALL_ORDERS_Click(object sender, EventArgs e)
        {
            FORM_ALL_ORDERS fallOd = new FORM_ALL_ORDERS();
            fallOd.DGV_ALL_ORDERS.DataSource = order.getAllOrders();
            fallOd.ShowDialog();
        }

        
    }
}
