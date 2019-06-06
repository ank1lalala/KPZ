using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Order
    {


        public void insertOrder(DateTime order_date, int customer_id)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@o_date", SqlDbType.DateTime);
            parameters[0].Value = order_date;

            parameters[1] = new SqlParameter("@cus_id", SqlDbType.Int);
            parameters[1].Value = customer_id;

            db.setData("spr_insert_order", parameters);
            db.closeConnection();

        }

        public void insertOrderDetail(int p_id, int o_id, int qty, string price, string total)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@p_id", SqlDbType.Int);
            parameters[0].Value = p_id;

            parameters[1] = new SqlParameter("@o_id", SqlDbType.Int);
            parameters[1].Value = o_id;

            parameters[2] = new SqlParameter("@qty", SqlDbType.Int);
            parameters[2].Value = qty;

            parameters[3] = new SqlParameter("@price", SqlDbType.VarChar,50);
            parameters[3].Value = price;

            parameters[4] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            parameters[4].Value = total;

            db.setData("spr_insert_order_detail", parameters);
            db.closeConnection();

        }

        public DataTable getCustomerOrders(int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = customerId;
            tab = db.getData("spr_get_all_customer_orders", parameters);
            db.closeConnection();

            return tab;
        }

        public DataTable getAllOrders()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_all_orders", null);
            db.closeConnection();
            return tab;
        }

        public DataTable getOrderMaxId()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_order_max_id", null);
            db.closeConnection();
            return tab;
        }

        public DataTable getOrderDetails(int orderId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id",SqlDbType.Int);
            parameters[0].Value = orderId;
            tab = db.getData("spr_get_order_details", parameters);
            db.closeConnection();
            return tab;
        }

        public DataTable getOrderTotalAmount(int orderId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = orderId;
            tab = db.getData("spr_get_total_order_amount", parameters);
            db.closeConnection();
            return tab;
        }

        public string getCustomerOrdersCount(int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = customerId;
            tab = db.getData("spr_get_customer_orders_count", parameters);
            db.closeConnection();
            if (tab.Rows.Count == 0)
            {
                return "No Orders";
            }
            else
            {
                return tab.Rows[0][1].ToString();
            }
        }

        public string getCustomerOrdersTotalAmount(int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = customerId;
            tab = db.getData("spr_get_customer_orders_amount", parameters);
            db.closeConnection();  
            if(tab.Rows.Count == 0)
            {
                return "0";
            }
            else
            {
                return tab.Rows[0][2].ToString();
            }
        }

        //spr_get_customer_last_order_date
        public string getCustomerLastOrderDate(int customerId)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = customerId;
            tab = db.getData("spr_get_customer_last_order_date", parameters);
            db.closeConnection();
            if (tab.Rows.Count == 0)
            {
                return "No Order";
            }
            else
            {
                return tab.Rows[0][0].ToString();
            }
        }
    }
}
