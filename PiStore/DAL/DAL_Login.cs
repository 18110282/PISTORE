using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace PiStore.DAL
{
    class DAL_Login
    {
        private DAL_DBConnection conn = new DAL_DBConnection();
        private const String CHECK_LOGIN_QUERY = "Select * from AccountLogin a where a.Username = @username and a.Password = @password";

        public DAL_Login()
        {
            conn = new DAL_DBConnection();
        }
 
        public int checkLoginInDB(String username, String password)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = username;
            sqlParameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            sqlParameters[1].Value = password;
            DataTable result = conn.executeSelectQueryWithParams(CHECK_LOGIN_QUERY, sqlParameters);
            //0 is non-exist
            return result.Rows.Count;
        }

    }
}
