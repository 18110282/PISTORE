using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PiStore.DAL
{
    class DAL_Util
    {
        private static DAL_DBConnection conn = new DAL_DBConnection();

        //public DAL_Util()
        //{
        //    conn = new DAL_DBConnection();
        //}

        public static DataTable listAll(String tableName)
        {
            String selectAllQuery = "Select * from " + tableName;
            return conn.executeSelectQuery(selectAllQuery);
        }

        public static bool delete(String tableName, int ID)
        {
            String deleteQuery = "Delete from " + tableName + " where ID=@ID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = ID;
            return conn.executeUpdateQuery(deleteQuery, sqlParameters);
        }

        public static DataTable getByID(String tableName, int ID)
        {
            String selectQuery = "Select * from " + tableName + " where ID =@ID"; 
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[0].Value = ID;
            return conn.executeSelectQueryWithParams(selectQuery, sqlParameters);
        }

    }
}
