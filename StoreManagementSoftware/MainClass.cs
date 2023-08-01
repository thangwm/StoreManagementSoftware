using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSoftware
{
    internal class MainClass
    {
        public static readonly string con_string = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=StoreManagementSoftware;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(con_string);
        
        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;
            string str = "Select * From Account where username = @username and password = @password";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USERNAME = dt.Rows[0]["username"].ToString();
            }
            return isValid;
        }

        public static string username;

        public static string USERNAME
        {
            get 
            { 
                return username; 
            }
            private set 
            { 
                username = value; 
            }
        }
    }
}
