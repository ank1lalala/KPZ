using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Csharp_Project
{
    class Customer
    {

        public void insertCustomer(string fname, string lname, string tel, string email)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@fname", SqlDbType.VarChar);
            parameters[0].Value = fname;

            parameters[1] = new SqlParameter("@lname", SqlDbType.VarChar, 50);
            parameters[1].Value = lname;

            parameters[2] = new SqlParameter("@tel", SqlDbType.NChar,20);
            parameters[2].Value = tel;

            parameters[3] = new SqlParameter("@mail", SqlDbType.VarChar, 50);
            parameters[3].Value = email;

            db.setData("spr_insert_customer", parameters);
            db.closeConnection();

        }

        public DataTable getCustomers()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_customers", null);
            db.closeConnection();
            return tab;
        }


        public DataTable searchProducts(string valueToSearch)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100);
            parameters[0].Value = valueToSearch;
            table = db.getData("spr_search_Products", parameters);
            db.closeConnection();
            return table;
        }

        public void deleteCustomer(int id)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            db.openConnection();
            db.setData("spr_delete_customer", parameters);
            db.closeConnection();

        }

        public void updateCustomer(int id, string fname, string lname, string tel, string email)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            parameters[1] = new SqlParameter("@fname", SqlDbType.VarChar,50);
            parameters[1].Value = fname;

            parameters[2] = new SqlParameter("@lname", SqlDbType.VarChar, 50);
            parameters[2].Value = lname;

            parameters[3] = new SqlParameter("@tel", SqlDbType.NChar,20);
            parameters[3].Value = tel;

            parameters[4] = new SqlParameter("@mail", SqlDbType.VarChar, 50);
            parameters[4].Value = email;

            db.setData("spr_update_customer", parameters);
            db.closeConnection();

        }

    }
}
