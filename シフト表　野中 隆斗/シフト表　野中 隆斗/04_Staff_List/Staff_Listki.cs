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
using シフト表_野中_隆斗.Staff_List;

namespace シフト表_野中_隆斗
{
    public partial class Staff_Listki : Form
    {
        private CreateStaff_list StaffItem;
        private Staff_ListDB StaffDB;
        private DataTable DataTable;
        private InStaff_List InStaff;
        public Staff_Listki()
        {

            InitializeComponent();

            StaffItem = new CreateStaff_list(this.StaffGridView);//Staff_ListKiにあるDataGridViewを渡している
            StaffItem.InitializeGrid();//DataGridViewに列を追加している

            StaffDB = new Staff_ListDB();
            DataTable = StaffDB.Getstaff();//nonakaテーブルからスタッフの情報を取得している

            InStaff = new InStaff_List(this.StaffGridView, DataTable);//DataGridViewとnonakaテーブルの結果を渡している
            InStaff.InStaff();//DataGriDViewの行にnonakaテーブルの結果を代入している。

        }

        private void Staff_List_Load(object sender, EventArgs e)
        {

        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            ShiftRequest shiftRequest = new ShiftRequest();
            shiftRequest.Show();
        }

        private void mypage_Btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void setting_Btn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Form_Add form_Add = new Form_Add();
            form_Add.Show();
        }

        private void delete_Btn_Click(object sender, EventArgs e)
        {
            Form_Delete form_Delete = new Form_Delete();
            form_Delete.Show();
        }

        private void edit_Btn_Click(object sender, EventArgs e)
        {
            StaffGridView.Columns[1].ReadOnly = false;
            StaffGridView.Columns[2].ReadOnly = false;
            StaffGridView.Columns[3].ReadOnly = false;
            StaffGridView.Columns[4].ReadOnly = false;
            StaffGridView.Columns[5].ReadOnly = false;
            StaffGridView.Columns[6].ReadOnly = false;
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            

            StaffGridView.Columns[1].ReadOnly = true;
            StaffGridView.Columns[2].ReadOnly = true;
            StaffGridView.Columns[3].ReadOnly = true;
            StaffGridView.Columns[4].ReadOnly = true;
            StaffGridView.Columns[5].ReadOnly = true;
            StaffGridView.Columns[6].ReadOnly = true;

            try
            {
                StaffGridView.EndEdit();

                using (SqlConnection conn = new SqlConnection(DBHelper.connectionstring))
                {
                    conn.Open();

                    foreach (DataGridViewRow row in StaffGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int staffId;
                        if (row.Cells["StaffID"].Value == null ||
                            !int.TryParse(row.Cells["StaffID"].Value.ToString(), out staffId))
                            continue;

                        string sql = @"
                    UPDATE staff
                    SET staff_name = @staff_name,
                        tell = @tell,
                        e_mail = @e_mail,
                        bank_acconunt = @bank_acconunt,
                        address = @address,
                        how = @how
                    WHERE staff_id = @staff_id";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@staff_name", row.Cells["StaffName"].Value ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@tell", row.Cells["Tell"].Value ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@e_mail", row.Cells["e_mail"].Value ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@bank_acconunt", row.Cells["bank_acconunt"].Value ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@address", row.Cells["address"].Value ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@how", row.Cells["how"].Value ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@staff_id", staffId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("変更を保存しました。", "保存完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存エラー: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            StaffDB = new Staff_ListDB();
            DataTable = StaffDB.Getstaff();//nonakaテーブルからスタッフの情報を取得している


            InStaff = new InStaff_List(this.StaffGridView, DataTable);//DataGridViewとnonakaテーブルの結果を渡している
            InStaff.InStaff();//DataGriDViewの行にnonakaテーブルの結果を代入している。

            StaffGridView.Columns[1].ReadOnly = true;
            StaffGridView.Columns[2].ReadOnly = true;
            StaffGridView.Columns[3].ReadOnly = true;
            StaffGridView.Columns[4].ReadOnly = true;
            StaffGridView.Columns[5].ReadOnly = true;
            StaffGridView.Columns[6].ReadOnly = true;
        }
    }
}
