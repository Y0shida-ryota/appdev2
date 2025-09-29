using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace シフト表_野中_隆斗
{
    public class commonNonakaDB

    {
        private string connectionString;
        private ComboBox IDComboBox;
        private Label NameLabel;
        public commonNonakaDB(ComboBox IDComboBox, Label NameLabel)
        {
            this.connectionString = DBHelper.connectionstring;
            this.IDComboBox = IDComboBox;
            this.NameLabel = NameLabel;
            IDName(this.IDComboBox);
            this.IDComboBox.SelectedIndexChanged += (s, e) => Nameevent();
        }
        public void IDName(ComboBox IDComboBox)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //DataTable IDTable = new DataTable();
                String sql = "SELECT staff_id FROM staff ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IDComboBox.Items.Add(reader["staff_id"].ToString());
                }

            }
        }
        public void Nameevent()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // 選択されたIDを取得
                string selectedId = IDComboBox.SelectedItem.ToString();

                string sql = "SELECT staff_name FROM staff WHERE staff_id = @staff_id"; // ← スペルミス修正（WH;ERE → WHERE）
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@staff_id", selectedId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        NameLabel.Text = result.ToString();
                    }
                    else
                    {
                        NameLabel.Text = "該当なし";
                    }
                }

            }
        }
    }
}

