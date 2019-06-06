using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Login
    {

        public DataTable login(string username, string password)
        {
            DB db = new DB();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 20);
            param[0].Value = username;
            param[1] = new SqlParameter("@pass", SqlDbType.VarChar, 20);
            param[1].Value = password;
            DataTable tab = new DataTable();
            tab = db.getData("spr_login", param);
            db.closeConnection();
            return tab;
        }

    }
}
