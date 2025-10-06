using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace シフト表_野中_隆斗
{
    public partial class Form_working_status : Form
    {
        public Form_working_status()
        {
            InitializeComponent();
            LoadShiftData(DateTime.Today);
        }

        private string GetConnectionString()
        {
            return "Server=PB-B0024029\\SORIMACHI2022;Database=nonaka;User ID=sa;Password=shoo0127;TrustServerCertificate=True;";
        }


        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("現在時刻:" + "HH:mm:ss");
        }

        private void LoadShiftData(DateTime selectedDate)
        {
            string query = @"
                SELECT 
                    s.staff_id AS ID, 
                    s.staff_name AS 名前, 
                    sh.start_time AS 勤務開始時間
                FROM 
                    shift sh
                INNER JOIN 
                    staff s ON sh.staff_id = s.staff_id
                WHERE 
                    sh.shift_date = @date
                ORDER BY 
                    sh.start_time;
            ";


            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@date", selectedDate.Date); // 日付のみ

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;


                if (dataGridView1.Columns.Count >= 3)
                {
                    dataGridView1.Columns[0].Width = 80;
                    dataGridView1.Columns[1].Width = 150;
                    dataGridView1.Columns[2].Width = 150;
                }
            }
        }

        private void Form_working_status_Load(object sender, EventArgs e)
        {
             
        
            label1.Text = DateTime.Now.ToString("現在時刻:" + "HH:mm");
        
        }
    }
}
