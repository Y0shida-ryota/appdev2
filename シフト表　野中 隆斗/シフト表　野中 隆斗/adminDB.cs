using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace シフト表_野中_隆斗
{

    internal class adminDB
    {
        private string connectionString;
        private int admincount;
        private Label Nolabel;
        private System.Windows.Forms.Form Form1;
        public adminDB(Label Nolabel, System.Windows.Forms.Form Form1)
        {
            this.connectionString = DBHelper.connectionstring;
            this.Nolabel = Nolabel;
            this.Form1 = Form1;   

        }
        public void veriflcation(string ID ,String Password) 
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                String sql = "SELECT staff_id,admin_password FROM admin WHERE staff_id =@staff_id AND admin_password=@admin_password";
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("staff_id", ID);
                    cmd.Parameters.AddWithValue("admin_password", Password);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {

                        this.admincount=0;
                        this.Nolabel.Visible = false;
                        Form_manager_dashboard form2 = new Form_manager_dashboard();
                        form2.Show();
                        this.Form1.Hide();
                    }
                    else
                    {
                        MessageBox.Show("IDまたはパスワードが違います");
                        Judgment();
                    }

                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("IDまたはパスワードが違います");
                    Judgment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("IDまたはパスワードが違います");
                    Judgment();
                }

            }
        }
        public void Judgment()
        {
           
            if(this.admincount >= 3)
            {
                MessageBox.Show("3回間違えたのでアプリを終了します。");
                this.Form1.Close();
            }
        }

    }
}
