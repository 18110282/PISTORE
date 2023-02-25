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
    class DAL_Employee
    {
        private const String TABLE_NAME = "Employee";
        private const String INSERT_QUERY = "Insert into " + TABLE_NAME + "(Name, Email, Phone, Address, Salary, HireDate)" +
    " values(@Name, @Email, @Phone, @Address, @Salary, @HireDate)";
        private const String UPDATE_QUERY = "Update " + TABLE_NAME + " SET Name = @Name, Email = @Email, Phone = @Phone, Address = @Address, Salary = @Salary, HireDate = @HireDate " +
            " where ID = @ID";

        private DAL_DBConnection conn;

        public DAL_Employee()
        {
            conn = new DAL_DBConnection();
        }

        public DataTable getEmployeeByIDInDB(int ID)
        {
            return DAL_Util.getByID(TABLE_NAME, ID);
        }
        public DataTable getAllEmployee()
        {
            return DAL_Util.listAll(TABLE_NAME);
        }
        public bool insertEmployeeInDB(DTO_Employee dto_Employee)
        {
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar);
            sqlParameters[0].Value = dto_Employee.Name;

            sqlParameters[1] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParameters[1].Value = dto_Employee.Email;

            sqlParameters[2] = new SqlParameter("@Phone", SqlDbType.VarChar);
            sqlParameters[2].Value = dto_Employee.Phone;

            sqlParameters[3] = new SqlParameter("@Address", SqlDbType.NVarChar);
            sqlParameters[3].Value = dto_Employee.Phone;

            sqlParameters[4] = new SqlParameter("@Salary", SqlDbType.Int);
            sqlParameters[4].Value = dto_Employee.Salary;

            sqlParameters[5] = new SqlParameter("@HireDate", SqlDbType.DateTime);
            sqlParameters[5].Value = dto_Employee.HireDate;


            return conn.executeInsertQuery(INSERT_QUERY, sqlParameters);
        }
        public bool updateEmployeeInDB(DTO_Employee dto_Employee)
        {
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@Name", SqlDbType.NVarChar);
            sqlParameters[0].Value = dto_Employee.Name;

            sqlParameters[1] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParameters[1].Value = dto_Employee.Email;

            sqlParameters[2] = new SqlParameter("@Phone", SqlDbType.VarChar);
            sqlParameters[2].Value = dto_Employee.Phone;

            sqlParameters[3] = new SqlParameter("@Address", SqlDbType.NVarChar);
            sqlParameters[3].Value = dto_Employee.Phone;

            sqlParameters[4] = new SqlParameter("@Salary", SqlDbType.Int);
            sqlParameters[4].Value = dto_Employee.Salary;

            sqlParameters[5] = new SqlParameter("@HireDate", SqlDbType.DateTime);
            sqlParameters[5].Value = dto_Employee.HireDate;

            sqlParameters[6] = new SqlParameter("@ID", SqlDbType.Int);
            sqlParameters[6].Value = dto_Employee.ID1;

            return conn.executeUpdateQuery(UPDATE_QUERY, sqlParameters);
        }
        public bool deleteEmployeeInDB(int ID)
        {
            return DAL_Util.delete(TABLE_NAME, ID);
        }


    }
}
