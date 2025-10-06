using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace シフト表_野中_隆斗
{
    public class commonNonakaItem//コンボボックスの中身を指定する共通クラス
    {
      
        public class NonakaItem
        {
            public int Value { get; set; }
            public string Text { get; set; }

            public override string ToString() => Text;
        }
        private ComboBox yearComboBox;
        private ComboBox mbMonth;
        private ComboBox cmbDay;
        private ComboBox SHTime;
        private ComboBox SMinTime;
        private ComboBox OHTime;
        private ComboBox OMinTime;
        public commonNonakaItem(ComboBox yearComboBox, ComboBox mbMonth, ComboBox cmbDay, ComboBox SHTime, ComboBox SMinTime, ComboBox OHTime, ComboBox OMinTime)
        {
           this.yearComboBox = yearComboBox;
            this.mbMonth = mbMonth;
            this.cmbDay = cmbDay;
            this.SHTime = SHTime;
            this.SMinTime = SMinTime;
            this.OHTime = OHTime;
            this.OMinTime = OMinTime;
            
        }
        public void InitializeComboBoxes()//年月日にちを指定するコンボボックスの中身を指定する
        {

            InitYearComboBox(this.yearComboBox, 2020, 2030);
            InitMonthComboBox(this.mbMonth);
            int year = GetSelectedValue(this.yearComboBox);
            int month = GetSelectedValue(this.mbMonth);
            InitDayComboBox(cmbDay, year, month);
            InHTime(this.SHTime);
            InMinTime(this.SMinTime);
            InHTime(this.OHTime);
            InMinTime(this.OMinTime);
            this.yearComboBox.SelectedIndexChanged += ComboBox_YearOrMonthChanged;
            mbMonth.SelectedIndexChanged += ComboBox_YearOrMonthChanged;
        }
        private void ComboBox_YearOrMonthChanged(object sender, EventArgs e)
        {
            int? year = commonNonakaItem.GetSelectedValue(yearComboBox);
            int? month = commonNonakaItem.GetSelectedValue(mbMonth);
            InitDayComboBox(cmbDay, year, month);
        }

        public  void InitDayComboBox(ComboBox dayComboBox, int? year, int? month)//?入るかもしれない
        {
            dayComboBox.Items.Clear();

            if (!year.HasValue || !month.HasValue)
            {
                MessageBox.Show("年と月を先に選択してください");
                return; // 年月が選ばれていなければ何もしない
            }
            int Day = DateTime.DaysInMonth(year.Value, month.Value);//Valueがいる外部クラスで判定するときに便利
            for (int i = 1; i <= Day; i++)
            {
                dayComboBox.Items.Add(new NonakaItem { Value = i, Text = i.ToString() + "日" });
            }
            dayComboBox.SelectedIndex = DateTime.Now.Day - 1;
        }
        public  void InitMonthComboBox(ComboBox monthComboBox)
        {
            monthComboBox.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(new NonakaItem { Value = i, Text = i.ToString() + "月" });
            }
            monthComboBox.SelectedIndex = DateTime.Now.Month - 1;
        }
        public  void InitYearComboBox(ComboBox yearComboBox, int startYear, int yearsAhead)
        {
            yearComboBox.Items.Clear();
            NonakaItem selectedItem = null;

            for (int y = startYear; y <= DateTime.Now.Year + yearsAhead; y++)
            {
                var item = new NonakaItem { Value = y, Text = y.ToString() };
                yearComboBox.Items.Add(item);

                // 現在の年と一致するComboItemを保持
                if (y == DateTime.Now.Year)
                    selectedItem = item;
            }

            if (selectedItem != null)
                yearComboBox.SelectedItem = selectedItem; // ComboItem を選択
        }
        public  void InHTime(ComboBox monthComboBox)
        {
            monthComboBox.Items.Clear();
            for (int i = 9; i <= 23; i++)
            {
                monthComboBox.Items.Add(new NonakaItem { Value = i, Text = i.ToString() });
            }
            monthComboBox.SelectedIndex =0;
        }
        public  void InMinTime(ComboBox monthComboBox)
        {
           
            monthComboBox.Items.Clear();
            for (int i = 0; i < 60; i+=15)
            {
                if (i == 0)
                {
                    monthComboBox.Items.Add(new NonakaItem { Value = i, Text = i+"0" });
                }
                else
                {
                    monthComboBox.Items.Add(new NonakaItem { Value = i, Text = i.ToString() });
                }
              
            }
            monthComboBox.SelectedIndex = 0;
        }
        public static int GetSelectedValue(ComboBox comboBox)
        {
            if (comboBox.SelectedItem is NonakaItem item)
                return item.Value;
            return 9; // 取得できなかった場合
        }

        
    }

}


 
