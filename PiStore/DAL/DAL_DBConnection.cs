﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStore.DAL
{
    public class DAL_DBConnection
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection conn;
        private StringBuilder errorMessages;

        public DAL_DBConnection()
        {
            //conn = new SqlConnection(@"Data Source=HIEU\SQLEXPRESS;Initial Catalog=PISTORE; Integrated Security=True");
            conn = new SqlConnection(@"Data Source=192.168.1.10\SQLEXPRESS;Initial Catalog=PISTORE; User ID=sa; Password=sa; Integrated Security=True; Trusted_Connection=false");
        }


        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
        public DataTable executeSelectQuery(String query)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            myAdapter = new SqlDataAdapter();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = query;
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Lỗi từ DB " + "Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public DataTable executeSelectQueryWithParams(String query, SqlParameter[] sqlParameters)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            myAdapter = new SqlDataAdapter();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = query;
                myCommand.Parameters.AddRange(sqlParameters);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Lỗi từ DB " + "Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public bool executeInsertQuery(String query, SqlParameter[] sqlParameters)
        {
            SqlCommand myCommand = new SqlCommand();
            myAdapter = new SqlDataAdapter();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = query;
                myCommand.Parameters.AddRange(sqlParameters);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Lỗi từ DB " + "Index #" + i + "\n"
                        + "Message: " + ex.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool executeUpdateQuery(String query, SqlParameter[] sqlParameters)
        {
            SqlCommand myCommand = new SqlCommand();
            myAdapter = new SqlDataAdapter();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = query;
                myCommand.Parameters.AddRange(sqlParameters);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Lỗi từ DB " + "Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}
