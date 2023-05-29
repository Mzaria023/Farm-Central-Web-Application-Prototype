using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Farm_Central_Web_Application_Prototype.Models
{
    public class Functions
    { 
        private SqlConnection connect;
        private SqlCommand cmd;
        DataTable data;
        private SqlDataAdapter adapter;
        private string ConString;

        public Functions()
        {//database connection string
            ConString = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;
            connect = new SqlConnection(ConString);
            cmd = new SqlCommand();
            cmd.Connection = connect;  
        }
        //getdata method for database 
        public DataTable getData(string Query)
        {
            DataTable data = new DataTable();
            adapter = new SqlDataAdapter(Query,ConString);
            adapter.Fill(data);
            return data;
        }
        //setdata method for database
        public int setData(string Query)
        {
            int cnt = 0;
            //checking if database is closed
            if(connect.State == ConnectionState.Closed )
            {//opens database if close
                connect.Open();    
             }
            cmd.CommandText = Query;    
            cnt = cmd.ExecuteNonQuery();
            //closes database after operation
            connect.Close();
            return cnt;
        }
    }
}