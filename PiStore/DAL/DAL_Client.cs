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
    class DAL_Client
    {
        private const String TABLE_NAME = "Client";
        private const String INSERT_QUERY = "Insert into " + TABLE_NAME + "(Name, Email, Phone, Address)" +
    " values(@Name, @Email, @Phone, @Address)";
        private const String UPDATE_QUERY = "Update " + TABLE_NAME + " SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address " +
            " where ID = @ID";

        private DAL_DBConnection conn;

        public DAL_Client()
        {
            conn = new DAL_DBConnection();
        }

        public DataTable getClientByIDInDB(int ID)
        {
            return DAL_Util.getByID(TABLE_NAME, ID);
        }
        public DataTable getAllClient()
        {
            return DAL_Util.listAll(TABLE_NAME);
        }
        public bool insertClientInDB(DTO_Client dto_Client)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar);
            sqlParameters[0].Value = dto_Client.Name;

            sqlParameters[1] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParameters[1].Value = dto_Client.Email;

            sqlParameters[2] = new SqlParameter("@Phone", SqlDbType.VarChar);
            sqlParameters[2].Value = dto_Client.Phone;

            sqlParameters[3] = new SqlParameter("@Address", SqlDbType.NVarChar);
            sqlParameters[3].Value = dto_Client.Phone;


            return conn.executeInsertQuery(INSERT_QUERY, sqlParameters);
        }
        public bool updateClientInDB(DTO_Client dto_Client)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar);
            sqlParameters[0].Value = dto_Client.Name;

            sqlParameters[1] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParameters[1].Value = dto_Client.Email;

            sqlParameters[2] = new SqlParameter("@Phone", SqlDbType.VarChar);
            sqlParameters[2].Value = dto_Client.Phone;

            sqlParameters[3] = new SqlParameter("@Address", SqlDbType.NVarChar);
            sqlParameters[3].Value = dto_Client.Phone;

            sqlParameters[4] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[4].Value = dto_Client.ID1;

            return conn.executeUpdateQuery(UPDATE_QUERY, sqlParameters);
        }
        public bool deleteClientInDB(int ID)
        {
            return DAL_Util.delete(TABLE_NAME, ID);
        }

    }

}
