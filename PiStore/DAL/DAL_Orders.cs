using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PiStore.DTO;

namespace PiStore.DAL
{
    class DAL_Orders
    {
        private const String TABLE_NAME = "Orders";
        private const String INSERT_QUERY = "Insert into " + TABLE_NAME + "(ClientID, EmployeeID, OrderDate, TotalPrice)" +
    " values(@ClientID, @EmployeeID, @OrderDate, @TotalPrice)";
        private const String UPDATE_QUERY = "Update " + TABLE_NAME + " SET ClientID = @ClientID, EmployeeID = @EmployeeID, OrderDate = @OrderDate, TotalPrice = @TotalPrice " +
            " where ID = @ID";

        private DAL_DBConnection conn;

        public DAL_Orders()
        {
            conn = new DAL_DBConnection();
        }

        public DataTable getOrdersByIDInDB(int ID)
        {
            return DAL_Util.getByID(TABLE_NAME, ID);
        }
        public DataTable getAllOrders()
        {
            return DAL_Util.listAll(TABLE_NAME);
        }
        public bool insertOrdersInDB(DTO_Orders dto_Orders)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@ClientID", SqlDbType.Int);
            sqlParameters[0].Value = dto_Orders.ClientID;

            sqlParameters[1] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            sqlParameters[1].Value = dto_Orders.EmployeeID;

            sqlParameters[2] = new SqlParameter("@OrderDate", SqlDbType.Int);
            sqlParameters[2].Value = dto_Orders.OrderDate;

            sqlParameters[3] = new SqlParameter("@TotalPrice", SqlDbType.Int);
            sqlParameters[3].Value = dto_Orders.TotalPrice;

            return conn.executeInsertQuery(INSERT_QUERY, sqlParameters);
        }
        public bool updateOrdersInDB(DTO_Orders dto_Orders)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@ClientID", SqlDbType.Int);
            sqlParameters[0].Value = dto_Orders.ClientID;

            sqlParameters[1] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            sqlParameters[1].Value = dto_Orders.EmployeeID;

            sqlParameters[2] = new SqlParameter("@OrderDate", SqlDbType.Int);
            sqlParameters[2].Value = dto_Orders.OrderDate;

            sqlParameters[3] = new SqlParameter("@TotalPrice", SqlDbType.Int);
            sqlParameters[3].Value = dto_Orders.TotalPrice;

            sqlParameters[4] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[4].Value = dto_Orders.ID1;

            return conn.executeUpdateQuery(UPDATE_QUERY, sqlParameters);
        }
        public bool deleteOrdersInDB(int ID)
        {
            return DAL_Util.delete(TABLE_NAME, ID);
        }
    }
}
