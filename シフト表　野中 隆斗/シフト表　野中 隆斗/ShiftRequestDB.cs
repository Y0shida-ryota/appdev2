using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace シフト表_野中_隆斗
{
    public class ShiftRequestDB
    {
        private string connectionString;
        private int staff_id;
        public ShiftRequestDB()
        {
            this.connectionString = DBHelper.connectionstring;
            
        }
        public void ShiftDBIn(ComboBox IDBox,
                       ComboBox yearComboBox, ComboBox mbMonth, ComboBox cmbDay,
                       ComboBox SHTime, ComboBox SMinTime, ComboBox OHTime, ComboBox OMinTime)
        {
            int staff_id = commonNonakaDB.GetID(IDBox);
            int year = commonNonakaItem.GetSelectedValue(yearComboBox);
            int month = commonNonakaItem.GetSelectedValue(mbMonth);
            int day = commonNonakaItem.GetSelectedValue(cmbDay);
            int shtime = commonNonakaItem.GetSelectedValue(SHTime);
            int smintime = commonNonakaItem.GetSelectedValue(SMinTime);
            int ohtime = commonNonakaItem.GetSelectedValue(OHTime);
            int omintime = commonNonakaItem.GetSelectedValue(OMinTime);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO request(staff_id, requset_date, staft_time, end_time) 
                       VALUES (@staff_id, @requset_date, @staft_time, @end_time)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    DateTime RequestTime = new DateTime(year,month,day);
                    TimeSpan StartTime = new TimeSpan(shtime, smintime,0);
                    TimeSpan EndTime = new TimeSpan(ohtime,omintime,0);
                    cmd.Parameters.AddWithValue("@staff_id", staff_id);
                    cmd.Parameters.AddWithValue("@requset_date", RequestTime);
                    cmd.Parameters.AddWithValue("@staft_time", StartTime);
                    cmd.Parameters.AddWithValue("@end_time",EndTime);
                    cmd.ExecuteNonQuery();
                }

    }
        }
    }
    }
