using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Csharp_Project
{
    class User
    {

        public DataTable getUsers()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_users", null);
            db.closeConnection();
            return tab;
        }

        public void insertUser(string username, string fullname, string password, string tel, string email)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 20);
            parameters[0].Value = username;

            parameters[1] = new SqlParameter("@FULL_NAME", SqlDbType.VarChar, 100);
            parameters[1].Value = fullname;

            parameters[2] = new SqlParameter("@PASS", SqlDbType.VarChar, 20);
            parameters[2].Value = password;

            parameters[3] = new SqlParameter("@TEL", SqlDbType.VarChar, 20);
            parameters[3].Value = tel;

            parameters[4] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 20);
            parameters[4].Value = email;

            db.setData("spr_insert_user", parameters);
            db.closeConnection();

        }

        public void updateUser(string username, string fullname, string password, string tel, string email, int uid)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 20);
            parameters[0].Value = username;

            parameters[1] = new SqlParameter("@FULL_NAME", SqlDbType.VarChar, 100);
            parameters[1].Value = fullname;

            parameters[2] = new SqlParameter("@PASS", SqlDbType.VarChar, 20);
            parameters[2].Value = password;

            parameters[3] = new SqlParameter("@TEL", SqlDbType.VarChar, 20);
            parameters[3].Value = tel;

            parameters[4] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 20);
            parameters[4].Value = email;

            parameters[5] = new SqlParameter("@id", SqlDbType.Int);
            parameters[5].Value = uid;

            db.setData("spr_update_user", parameters);
            db.closeConnection();

        }

        public void deleteUser(int userId)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            
            parameters[0] = new SqlParameter("@uid", SqlDbType.Int);
            parameters[0].Value = userId;

            db.setData("spr_delete_user", parameters);
            db.closeConnection();

        }
    }
}
