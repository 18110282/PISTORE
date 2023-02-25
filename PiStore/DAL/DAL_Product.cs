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
    class DAL_Product
    {
        private const String TABLE_NAME = "Product";
        private const String INSERT_QUERY = "Insert into " + TABLE_NAME + "(Name, Description, Price, Quantity)" +
    " values(@Name, @Description, @Price, @Quantity)";
        private const String UPDATE_QUERY = "Update " + TABLE_NAME + " SET Name = @Name, Description = @Description, Price = @Price, Quantity = @Quantity " +
            " where ID = @ID";

        private DAL_DBConnection conn;

        public DAL_Product()
        {
            conn = new DAL_DBConnection();
        }

        public DataTable getProductByIDInDB(int ID)
        {
            return DAL_Util.getByID(TABLE_NAME, ID);
        }
        public DataTable getAllProduct()
        {
            return DAL_Util.listAll(TABLE_NAME);
        }
        public bool insertProductInDB(DTO_Product dto_Product)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.Int);
            sqlParameters[0].Value = dto_Product.Name;

            sqlParameters[1] = new SqlParameter("@Description", SqlDbType.Int);
            sqlParameters[1].Value = dto_Product.Description;

            sqlParameters[2] = new SqlParameter("@Price", SqlDbType.Int);
            sqlParameters[2].Value = dto_Product.Price;

            sqlParameters[3] = new SqlParameter("@Quantity", SqlDbType.Int);
            sqlParameters[3].Value = dto_Product.Quantity;

            return conn.executeInsertQuery(INSERT_QUERY, sqlParameters);
        }
        public bool updateProductInDB(DTO_Product dto_Product)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.Int);
            sqlParameters[0].Value = dto_Product.Name;

            sqlParameters[1] = new SqlParameter("@Description", SqlDbType.Int);
            sqlParameters[1].Value = dto_Product.Description;

            sqlParameters[2] = new SqlParameter("@Price", SqlDbType.Int);
            sqlParameters[2].Value = dto_Product.Price;

            sqlParameters[3] = new SqlParameter("@Quantity", SqlDbType.Int);
            sqlParameters[3].Value = dto_Product.Quantity;

            sqlParameters[4] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[4].Value = dto_Product.ID1;

            return conn.executeUpdateQuery(UPDATE_QUERY, sqlParameters);
        }
        public bool deleteProductInDB(int ID)
        {
            return DAL_Util.delete(TABLE_NAME, ID);
        }
    }
}
