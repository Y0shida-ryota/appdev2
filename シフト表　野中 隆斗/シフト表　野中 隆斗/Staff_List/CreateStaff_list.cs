using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace シフト表_野中_隆斗.Staff_List
{
    internal class CreateStaff_list
    {
        private DataGridView Staff_List;

        public CreateStaff_list(DataGridView Staff_List)
        {
            this.Staff_List = Staff_List;
        }
        public void InitializeGrid()
        {
            Staff_List.Columns.Clear();//いったん全部消す
            Staff_List.AutoGenerateColumns = false;//DataGridbiewの自動追加をなしにする

            Staff_List.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "StaffID",
                HeaderText = "ID",
                ReadOnly = true,

            });
            Staff_List.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "StaffName",
                HeaderText = "名前",
                ReadOnly = true,
            });
            Staff_List.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Tell",
                HeaderText = "電話番号",
                ReadOnly = true,
            });
            Staff_List.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "e_mail",
                HeaderText = "メールアドレス",
                ReadOnly = true,
            });
            Staff_List.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "bank_acconunt",
                HeaderText = "銀行口座",
                ReadOnly = true,
            });
            Staff_List.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "address",
                HeaderText = "住所",
                ReadOnly = true,
            });
            Staff_List.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "how",
                HeaderText = "通勤手段",
                ReadOnly = true,
            });
        }
    }
}
