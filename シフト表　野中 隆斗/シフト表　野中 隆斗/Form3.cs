using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace シフト表_野中_隆斗
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadStaffToComboBox();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar2.SelectionStart;
            label4.Text = selectedDate.ToString("yyyy/MM/dd/");
        }

        private void LoadStaffToComboBox()
        {
            string connectionString = "Server=PB-B0024029\\SORIMACHI2022;Database=nonaka;User ID=sa;Password=shoo0127;TrustServerCertificate=True;";
            string query = "SELECT staff_id, staff_name FROM staff";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 表示用列を追加（"1：山田太郎" など）
                    dt.Columns.Add("DisplayText", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["DisplayText"] = $"{row["staff_id"]}：{row["staff_name"]}";
                    }

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "DisplayText";  // 表示する文字列
                    comboBox1.ValueMember = "staff_id";       // 内部的に選択されるID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }



        private void Staff_Namebtn_Click(object sender, EventArgs e)
        {
            Staff_Listki Staff_Name = new Staff_Listki();
            Staff_Name.Show();
            this.Hide();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text += comboBox1.Text + " " + comboBox2.Text + ":" + comboBox3.Text + "～" + comboBox4.Text + ":" + comboBox5.Text + Environment.NewLine;
        }

        private void deletion_btn_Click(object sender, EventArgs e)
        {
            int lineIndex = textBox1.GetLineFromCharIndex(textBox1.SelectionStart);
            string[] lines = textBox1.Lines;

            if (lineIndex >= 0 && lineIndex < lines.Length)
            {
                List<string> lineList = lines.ToList();
                lineList.RemoveAt(lineIndex);
                textBox1.Lines = lineList.ToArray();
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
