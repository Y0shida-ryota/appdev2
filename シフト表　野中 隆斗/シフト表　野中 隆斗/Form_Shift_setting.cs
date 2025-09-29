using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace シフト表_野中_隆斗
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            LoadStaffToComboBox();
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;

            LoadShiftForSelectedDate(); // 起動時に当日のシフトを表示
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar2.SelectionStart;
            label4.Text = selectedDate.ToString("yyyy/MM/dd");
        }

        private void LoadStaffToComboBox()
        {
            string connectionString = DBHelper.connectionstring;
            string query = "SELECT staff_id, staff_name FROM staff";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dt.Columns.Add("DisplayText", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["DisplayText"] = $"{row["staff_id"]:D4}：{row["staff_name"]}";
                    }

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "DisplayText";
                    comboBox1.ValueMember = "staff_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex.Message);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar2.SelectionStart.Date;

            string startHour = comboBox2.Text;
            string startMinute = comboBox3.Text;
            string endHour = comboBox4.Text;
            string endMinute = comboBox5.Text;

            string startTimeStr = $"{startHour}:{startMinute}";
            string endTimeStr = $"{endHour}:{endMinute}";

            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("スタッフが正しく選択されていません。");
                return;
            }

            int staffId = Convert.ToInt32(comboBox1.SelectedValue);
            string insertQuery = @"
                INSERT INTO shift (shift_date, start_time, end_time, staff_id) 
                VALUES (@date, @start, @end, @staffId)";

            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.connectionstring))
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@date", selectedDate);
                    cmd.Parameters.AddWithValue("@start", TimeSpan.Parse(startTimeStr));
                    cmd.Parameters.AddWithValue("@end", TimeSpan.Parse(endTimeStr));
                    cmd.Parameters.AddWithValue("@staffId", staffId);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("シフトをデータベースに登録しました！");
                    LoadShiftForSelectedDate(); // 登録後に一覧再表示
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("データベースエラー: " + ex.Message);
            }
        }

        private void deletion_btn_Click(object sender, EventArgs e)
        {
            int lineIndex = textBox1.GetLineFromCharIndex(textBox1.SelectionStart);
            string[] lines = textBox1.Lines;

            if (lineIndex >= 0 && lineIndex < lines.Length)
            {
                string line = lines[lineIndex];

                try
                {
                    string staffPart = line.Split('：')[0];
                    int staffId = int.Parse(staffPart);

                    string timePart = line.Split(' ')[1];
                    string[] times = timePart.Split('～');
                    TimeSpan startTime = TimeSpan.Parse(times[0]);
                    TimeSpan endTime = TimeSpan.Parse(times[1]);

                    DateTime shiftDate = monthCalendar2.SelectionStart.Date;

                    string deleteQuery = @"
                        DELETE FROM shift 
                        WHERE shift_date = @date 
                        AND start_time = @start 
                        AND end_time = @end 
                        AND staff_id = @staffId";

                    using (SqlConnection conn = new SqlConnection(DBHelper.connectionstring))
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", shiftDate);
                        cmd.Parameters.AddWithValue("@start", startTime);
                        cmd.Parameters.AddWithValue("@end", endTime);
                        cmd.Parameters.AddWithValue("@staffId", staffId);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("データベースからも削除しました。");
                            LoadShiftForSelectedDate(); // 再表示
                        }
                        else
                        {
                            MessageBox.Show("データベースに該当するデータが見つかりませんでした。");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("削除処理でエラーが発生しました: " + ex.Message);
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadShiftForSelectedDate();
        }

        private void LoadShiftForSelectedDate()
        {
            DateTime selectedDate = monthCalendar2.SelectionStart.Date;

            string query = @"
                SELECT s.staff_id, s.staff_name, sh.start_time, sh.end_time
                FROM shift sh
                INNER JOIN staff s ON sh.staff_id = s.staff_id
                WHERE sh.shift_date = @date
                ORDER BY sh.start_time";

            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelper.connectionstring))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", selectedDate);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();

                        while (reader.Read())
                        {
                            int staffId = reader.GetInt32(0);
                            string staffName = reader.GetString(1);
                            TimeSpan startTime = reader.GetTimeSpan(2);
                            TimeSpan endTime = reader.GetTimeSpan(3);

                            string line = $"{staffId:D4}：{staffName} {startTime:hh\\:mm}～{endTime:hh\\:mm}";
                            sb.AppendLine(line);
                        }

                        textBox1.Text = sb.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("読み込みエラー: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_manager_dashboard form2 = new Form_manager_dashboard();
            form2.Show();
            this.Hide();
        }

        private void Staff_Namebtn_Click(object sender, EventArgs e)
        {
            Staff_Listki Staff_Name = new Staff_Listki();
            Staff_Name.Show();
            this.Hide();
        }
    }
}
