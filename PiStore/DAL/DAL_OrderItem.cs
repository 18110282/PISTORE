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
    class DAL_OrderItem
    {
        private const String TABLE_NAME = "OrderItem";
        private const String INSERT_QUERY = "Insert into " + TABLE_NAME + "(OrderID, ProductID, Quantity)" +
    " values(@OrderID, @ProductID, @Quantity)";
        private const String UPDATE_QUERY = "Update " + TABLE_NAME + " SET OrderID = @OrderID, ProductID = @ProductID, Quantity = @Quantity" +
            " where ID = @ID";

        private DAL_DBConnection conn;

        public DAL_OrderItem()
        {
            conn = new DAL_DBConnection();
        }

        public DataTable getOrderItemByIDInDB(int ID)
        {
            return DAL_Util.getByID(TABLE_NAME, ID);
        }
        public DataTable getAllOrderItem()
        {
            return DAL_Util.listAll(TABLE_NAME);
        }
        public bool insertOrderItemInDB(DTO_OrderItem dto_OrderItem)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            sqlParameters[0].Value = dto_OrderItem.OrderID;

            sqlParameters[1] = new SqlParameter("@ProductID", SqlDbType.Int);
            sqlParameters[1].Value = dto_OrderItem.ProductID;

            sqlParameters[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            sqlParameters[2].Value = dto_OrderItem.Quantity;

            return conn.executeInsertQuery(INSERT_QUERY, sqlParameters);
        }
        public bool updateOrderItemInDB(DTO_OrderItem dto_OrderItem)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            sqlParameters[0].Value = dto_OrderItem.OrderID;

            sqlParameters[1] = new SqlParameter("@ProductID", SqlDbType.Int);
            sqlParameters[1].Value = dto_OrderItem.ProductID;

            sqlParameters[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            sqlParameters[2].Value = dto_OrderItem.Quantity;

            sqlParameters[3] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[3].Value = dto_OrderItem.ID1;

            return conn.executeUpdateQuery(UPDATE_QUERY, sqlParameters);
        }
        public bool deleteOrderItemInDB(int ID)
        {
            return DAL_Util.delete(TABLE_NAME, ID);
        }
    }
}
