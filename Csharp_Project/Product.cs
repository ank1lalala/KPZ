using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Csharp_Project
{
    class Product
    {

        public void insertProduct(int cid, string name, string price, byte[] image, int quantity, string desc)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@c_id", SqlDbType.Int);
            parameters[0].Value = cid;

            parameters[1] = new SqlParameter("@p_name", SqlDbType.VarChar,50);
            parameters[1].Value = name;

            parameters[2] = new SqlParameter("@s_qty", SqlDbType.Int);
            parameters[2].Value = quantity;

            parameters[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            parameters[3].Value = price;

            parameters[4] = new SqlParameter("@desc", SqlDbType.VarChar);
            parameters[4].Value = desc;

            parameters[5] = new SqlParameter("@img", SqlDbType.Image);
            parameters[5].Value = image;

            db.setData("spr_insert_product", parameters);
            db.closeConnection();

        }

        public DataTable getProducts()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_Products", null);
            db.closeConnection();
            return tab;
        }

        public DataTable getProduct(int id)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            tab = db.getData("spr_get_Product_by_id", parameters);
            db.closeConnection();
            return tab;
        }

        public DataTable getProductsByCategory(int cat_id)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@cid", SqlDbType.Int);
            parameters[0].Value = cat_id;
            table = db.getData("spr_products_by_category", parameters);
            db.closeConnection();
            return table;
        }


        public DataTable searchProducts(string valueToSearch)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100);
            parameters[0].Value = valueToSearch;
            table = db.getData("spr_search_Products",parameters);
            db.closeConnection();
            return table;
        }

        public void deleteProducts(int product_id)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@pid", SqlDbType.Int);
            parameters[0].Value = product_id;

            db.openConnection();
            db.setData("spr_delete_Products", parameters);
            db.closeConnection();
           
        }

        public void updateProduct(int pid, int cid, string name, string price, byte[] image, int quantity, string desc)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[7];

            parameters[0] = new SqlParameter("@pid", SqlDbType.Int);
            parameters[0].Value = pid;
           
            parameters[1] = new SqlParameter("@c_id", SqlDbType.Int);
            parameters[1].Value = cid;

            parameters[2] = new SqlParameter("@p_name", SqlDbType.VarChar, 50);
            parameters[2].Value = name;

            parameters[3] = new SqlParameter("@s_qty", SqlDbType.Int);
            parameters[3].Value = quantity;

            parameters[4] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            parameters[4].Value = price;

            parameters[5] = new SqlParameter("@desc", SqlDbType.VarChar);
            parameters[5].Value = desc;

            parameters[6] = new SqlParameter("@img", SqlDbType.Image);
            parameters[6].Value = image;

            db.setData("spr_update_Product", parameters);
            db.closeConnection();
            
        }

    }
}
