using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace シフト表_野中_隆斗.Staff_List
{
    internal class Staff_ListDB
    {
        private string connectionString;

        public Staff_ListDB()
        {
            connectionString = DBHelper.connectionstring;
        }
        public DataTable Getstaff()
        {
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                DataTable StaffData = new DataTable();
                string getStaff = "SELECT * FROM staff ";
                SqlDataAdapter getStaffCmd = new SqlDataAdapter(getStaff, conn);
                getStaffCmd.Fill(StaffData);
                return StaffData;
            }
        }

    }
}

