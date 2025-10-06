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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Shift_settingbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void name_listbtn_Click(object sender, EventArgs e)
        {
            Staff_Listki Staff_Name = new Staff_Listki();
            Staff_Name.Show();
        }

        private void working_statusbtn_Click(object sender, EventArgs e)
        {
            Form_working_status Working = new Form_working_status();
            Working.Show();

        }

        private void notificationbtn_Click(object sender, EventArgs e)
        {
            Form_shift_change_desired_notification Shift_Change = new Form_shift_change_desired_notification();
            Shift_Change.Show();
        }

        private void END_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
