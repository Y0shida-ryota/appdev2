using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;
using static シフト表_野中_隆斗.commonNonakaItem;

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
            IDName(IDComboBox);
            this.IDComboBox.SelectedIndexChanged += (s, e) => Nameevent();
        }
        public void IDName(ComboBox IDComboBox)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                IDComboBox.Items.Clear();
                String sql = "SELECT staff_id FROM staff ";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IDComboBox.Items.Add(new NonakaItem
                    {
                        Value = Convert.ToInt32(reader["staff_id"]),
                        Text = reader["staff_id"].ToString()
                    });
                }
                IDComboBox.SelectedIndex = 0;
            }
        }
        public void Nameevent()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // 選択されたIDを取得
                int selectedId = ((NonakaItem)IDComboBox.SelectedItem).Value;

                string sql = "SELECT staff_name FROM staff WHERE staff_id = @staff_id"; 
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
        public static int GetID(ComboBox IDComboBox)
        {
            if (IDComboBox.SelectedItem is NonakaItem item)
                return item.Value;
            return 2; // 取得できなかった場合
        }
    }
}

