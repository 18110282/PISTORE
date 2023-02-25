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
    class DAL_Bill
    {
        private const String TABLE_NAME = "Bill";
        private const String INSERT_QUERY = "Insert into " + TABLE_NAME + "(OrderID, ClientID, EmployeeID, BillDate, TotalPrice)" +
            " values(@OrderID, @ClientID, @EmployeeID, @BillDate, @TotalPrice)";

        private DAL_DBConnection conn;

        public DAL_Bill()
        {
            conn = new DAL_DBConnection();
        }
        public bool insertBillInDB(DTO_Bill dto_Bill)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            sqlParameters[0].Value = dto_Bill.OrderID;

            sqlParameters[1] = new SqlParameter("@ClientID", SqlDbType.Int);
            sqlParameters[1].Value = dto_Bill.ClientID;

            sqlParameters[2] = new SqlParameter("@EmployeeID", SqlDbType.Int);
            sqlParameters[2].Value = dto_Bill.EmployeeID;

            sqlParameters[3] = new SqlParameter("@BillDate", SqlDbType.DateTime);
            sqlParameters[3].Value = dto_Bill.BillDate;

            sqlParameters[4] = new SqlParameter("@TotalPrice", SqlDbType.Int);
            sqlParameters[4].Value = dto_Bill.TotalPrice;

            return conn.executeInsertQuery(INSERT_QUERY, sqlParameters);

        }

    }
}
