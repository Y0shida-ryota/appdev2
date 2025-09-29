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
    public partial class Form_shift_change_desired_notification : Form
    {
       
        public Form_shift_change_desired_notification()
        {
            InitializeComponent();
           
        }

        private void Form_shift_change_desired_notification_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "名前");
            dataGridView1.Columns.Add("ChangeDate", "変更希望日");
            dataGridView1.Columns.Add("ChangeTime", "変更希望時間");
            dataGridView1.Columns.Add("WorkOrRest", "働 or 休");

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Confirmed";
            checkColumn.HeaderText = "確認済";
            dataGridView1.Columns.Add(checkColumn);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Rows.Add("0100", "佐藤 太郎", "2025/07/01", "10:00～14:30", "休", true);
            dataGridView1.Rows.Add("0101", "田中 華子", "2025/06/28", "15:00～20:00", "働", false);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                bool isChecked = false;

               
                if (row.Cells["Confirmed"].Value != null)
                {
                    isChecked = Convert.ToBoolean(row.Cells["Confirmed"].Value);
                }

                if (isChecked)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
