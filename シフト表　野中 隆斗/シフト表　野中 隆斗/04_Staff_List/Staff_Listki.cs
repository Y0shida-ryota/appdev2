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
        private CreateStaff_list  StaffItem;
        private Staff_ListDB StaffDB;
        private DataTable DataTable;
        private InStaff_List  InStaff;
        public Staff_Listki()
        {
           
            InitializeComponent();

            StaffItem = new CreateStaff_list(this.StaffGridView);//Staff_ListKiにあるDataGridViewを渡している
            StaffItem.InitializeGrid();//DataGridViewに列を追加している

            StaffDB = new Staff_ListDB();
            DataTable = StaffDB.Getstaff();//nonakaテーブルからスタッフの情報を取得している

            InStaff = new InStaff_List(this.StaffGridView,DataTable);//DataGridViewとnonakaテーブルの結果を渡している
            InStaff.InStaff();//DataGriDViewの行にnonakaテーブルの結果を代入している。
        }

        private void Staff_List_Load(object sender, EventArgs e)
        {

        }
    }
}
