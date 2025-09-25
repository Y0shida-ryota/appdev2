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
    public partial class Form_Delete : Form
    {
        public Form_Delete()
        {
            InitializeComponent();
            LoadStaffIds();
            ID_Cb.SelectedIndex = -1;
            namelabel.Text = ""; // ラベルもクリアして、名前が初期表示されないようにします
            this.ID_Cb.SelectedIndexChanged += new System.EventHandler(this.ID_Cb_SelectedIndexChanged);
            
        }

        // キャンセルボタン
        private void cencel_Btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        // 削除ボタン
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (ID_Cb.SelectedItem != null)
            {
                string selectedId = ID_Cb.SelectedItem.ToString();
                DeleteStaff(selectedId);
            }
            else
            {
                MessageBox.Show("削除するスタッフを選択してください。");
            }
        }

        /// <summary>
        /// データベースからスタッフIDを取得し、コンボボックスにロードするメソッド
        /// </summary>
        private void LoadStaffIds()
        {
            ID_Cb.Items.Clear();

            string query = "SELECT staff_id FROM staff";

            using (SqlConnection connection = new SqlConnection(DBHelper.connectionstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ID_Cb.Items.Add(reader["staff_id"].ToString());
                        }

                        if (ID_Cb.Items.Count > 0)
                        {
                            ID_Cb.SelectedIndex = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("データベースのロード中にエラーが発生しました: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// コンボボックスの選択が変更されたときに呼び出されるイベントハンドラ
        /// </summary>
        private void ID_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ID_Cb.SelectedItem != null)
            {
                string selectedId = ID_Cb.SelectedItem.ToString();
                LoadStaffName(selectedId);
            }
        }

        /// <summary>
        /// 選択されたスタッフIDに対応するスタッフ名を取得し、ラベルに表示するメソッド
        /// </summary>
        private void LoadStaffName(string staffId)
        {
            string query = "SELECT staff_name FROM staff WHERE staff_id = @staffId";

            using (SqlConnection connection = new SqlConnection(DBHelper.connectionstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@staffId", staffId);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            namelabel.Text = result.ToString();
                        }
                        else
                        {
                            namelabel.Text = "スタッフ名が見つかりません";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("スタッフ名の取得中にエラーが発生しました: " + ex.Message);
                        namelabel.Text = "エラー";
                    }
                }
            }
        }

        /// <summary>
        /// データベースからスタッフを削除するメソッド
        /// </summary>
        /// <param name="staffId"></param>
        private void DeleteStaff(string staffId)
        {
            // 削除確認のメッセージボックスを表示
            DialogResult dialogResult = MessageBox.Show(
                "ID: " + staffId + namelabel.Text + " を削除しますか？",
                "削除の確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // 「はい」が選択された場合のみ削除処理を実行
            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM staff WHERE staff_id = @staffId";

                using (SqlConnection connection = new SqlConnection(DBHelper.connectionstring))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // SQLインジェクションを防ぐためにパラメータを使用
                        command.Parameters.AddWithValue("@staffId", staffId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery(); // 実行された行数を取得

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show(staffId + namelabel.Text + "を削除しました。");
                                LoadStaffIds(); // 削除後、コンボボックスのリストを更新
                                namelabel.Text = ""; // ラベルをクリア
                            }
                            else
                            {
                                MessageBox.Show("指定されたIDのスタッフは見つかりませんでした。");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("スタッフの削除中にエラーが発生しました: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}