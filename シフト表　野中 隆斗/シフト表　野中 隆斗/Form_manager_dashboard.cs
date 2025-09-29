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
    public partial class Form_manager_dashboard : System.Windows.Forms.Form
    {
        public Form_manager_dashboard()
        {
            InitializeComponent();
        }

        private void Shift_settingbtn_Click(object sender, EventArgs e)
        {
            Form form3 = new Form();
            form3.Show();
            this.Hide();
        }

        private void name_listbtn_Click(object sender, EventArgs e)
        {
            Staff_Listki Staff_Name = new Staff_Listki();
            Staff_Name.Show();
            this.Hide();
        }

        private void working_statusbtn_Click(object sender, EventArgs e)
        {
            Form_working_status Working = new Form_working_status();
            Working.Show();
            this.Hide();

        }

        private void notificationbtn_Click(object sender, EventArgs e)
        {
            Form_shift_change_desired_notification Shift_Change = new Form_shift_change_desired_notification();
            Shift_Change.Show();
            this.Hide();
        }

        private void END_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
