using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace シフト表_野中_隆斗
{
    public partial class Form_Add : System.Windows.Forms.Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void completed_Btn_Click(object sender, EventArgs e)
        {
            // ここに必須入力チェックを追加します。
            // もし入力がなければ警告メッセージを表示し、処理を中断します。
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(TellBox.Text) ||
                string.IsNullOrWhiteSpace(e_mailBox.Text) ||
                string.IsNullOrWhiteSpace(bankBox.Text) ||
                string.IsNullOrWhiteSpace(AddressBox.Text) ||
                string.IsNullOrWhiteSpace(howBox.Text))
            {
                MessageBox.Show("すべての項目を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // ここでメソッドを終了し、これ以降の処理は実行されません。
            }

            // DBHelperクラスから接続文字列を取得します。
            string connectionString = DBHelper.connectionstring;

            // SQLのINSERT文を定義します。SQLインジェクションを防ぐため、パラメーター化クエリを使用します。
            string insertStaff = "INSERT INTO staff (staff_name, tell, e_mail, bank_acconunt, address, how) VALUES(@staff_name, @tell, @e_mail, @bank_acconunt, @address, @how)";

            // SqlConnectionとSqlCommandをusingブロック内で宣言し、リソースが確実に解放されるようにします。
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // データベース接続を開きます。
                    conn.Open();

                    // SqlCommandオブジェクトを作成し、SQL文と接続を関連付けます。
                    using (SqlCommand insertCmd = new SqlCommand(insertStaff, conn))
                    {
                        // パラメーターに各テキストボックスの値を割り当てます。
                        // テキストボックスの名前が一致しているか確認してください。
                        insertCmd.Parameters.AddWithValue("@staff_name", NameBox.Text);
                        insertCmd.Parameters.AddWithValue("@tell", TellBox.Text);
                        insertCmd.Parameters.AddWithValue("@e_mail", e_mailBox.Text);
                        insertCmd.Parameters.AddWithValue("@bank_acconunt", bankBox.Text);
                        insertCmd.Parameters.AddWithValue("@address", AddressBox.Text);
                        insertCmd.Parameters.AddWithValue("@how", howBox.Text);

                        // SQL文を実行します。ExecuteNonQueryは挿入、更新、削除の際に使用します。
                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        // データの保存が成功したことをユーザーに通知します。
                        MessageBox.Show($"データが正常に保存されました。", "完了");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    // SQL関連のエラーが発生した場合、エラーメッセージを表示します。
                    MessageBox.Show($"データベースエラーが発生しました。\nエラーメッセージ: {ex.Message}", "エラー");
                }
                catch (Exception ex)
                {
                    // その他の予期せぬエラーが発生した場合、メッセージを表示します。
                    MessageBox.Show($"予期せぬエラーが発生しました。\nエラーメッセージ: {ex.Message}", "エラー");
                }
            }
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
