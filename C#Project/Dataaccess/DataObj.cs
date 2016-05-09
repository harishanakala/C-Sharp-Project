using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // Required for using Dataset , Datatable and Sql
using System.Data.SqlClient; // Required for Using Sql
using System.Configuration; // for Using Connection From Web.config 
using BusinessObject;  // for acessing business object class

namespace DataAccess
{
    public class DataObj
    {
        SqlConnection con = new
          SqlConnection(ConfigurationManager.ConnectionStrings["Myconstr"].ToString());
        public int AddUserDetails(BusinessObj ObjBO) // passing Business object Here
        {
            try
            {
           
                SqlCommand cmd = new SqlCommand("Studentinfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", ObjBO.Name);
                cmd.Parameters.AddWithValue("@Email", ObjBO.Email);
                cmd.Parameters.AddWithValue("@Phone", ObjBO.Phone);
                cmd.Parameters.AddWithValue("@Department", ObjBO.Department);
                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Result;
            }
            catch
            {
                throw;
            }
        }
    }
}