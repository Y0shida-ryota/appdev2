using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace シフト表_野中_隆斗.Staff_List
{
    internal class InStaff_List
    {
        DataTable StaffDate;
        DataGridView Staff_List;
        public InStaff_List(DataGridView Staff_List, DataTable StaffDate)
        {
            this.StaffDate = StaffDate;
            this.Staff_List = Staff_List;
        }
        public void InStaff()
        {
            Staff_List.Rows.Clear(); // 既存行をクリア
            foreach (DataRow row in StaffDate.Rows)
            {
                int rowIndex = Staff_List.Rows.Add();//新しい行を作ってインデックスを追加
                Staff_List.Rows[rowIndex].Cells["StaffID"].Value = row["staff_id"];
                Staff_List.Rows[rowIndex].Cells["StaffName"].Value = row["staff_name"];
                Staff_List.Rows[rowIndex].Cells["Tell"].Value = row["tell"];
                Staff_List.Rows[rowIndex].Cells["e_mail"].Value = row["e_mail"];
                Staff_List.Rows[rowIndex].Cells["bank_acconunt"].Value = row["bank_acconunt"];
                Staff_List.Rows[rowIndex].Cells["address"].Value = row["address"];
                Staff_List.Rows[rowIndex].Cells["how"].Value = row["how"];
            }
        }
    }
}
