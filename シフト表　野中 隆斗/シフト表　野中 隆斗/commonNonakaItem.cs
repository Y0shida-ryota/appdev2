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
        public int Value { get; set; }      // 実際に使う数字
        public string Text { get; set; }    // 表示用
                                            //表示したい内容と中にもう値を分かる場合get setを使わなくてはならない
        public override string ToString() => Text; // ComboBoxに表示される文字
    
   
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
                dayComboBox.Items.Add(new commonNonakaItem { Value = i, Text = i.ToString()});
            }
            dayComboBox.SelectedIndex = DateTime.Now.Day - 1;
        }
        public  void InitMonthComboBox(ComboBox monthComboBox)
        {
            monthComboBox.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(new commonNonakaItem { Value = i, Text = i.ToString() });
            }
            monthComboBox.SelectedIndex = DateTime.Now.Month - 1;
        }
        public  void InitYearComboBox(ComboBox yearComboBox, int startYear, int yearsAhead)
        {
            yearComboBox.Items.Clear();
            commonNonakaItem selectedItem = null;

            for (int y = startYear; y <= DateTime.Now.Year + yearsAhead; y++)
            {
                var item = new commonNonakaItem { Value = y, Text = y.ToString() };
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
            for (int i = 1; i <= 24; i++)
            {
                monthComboBox.Items.Add(new commonNonakaItem { Value = i, Text = i.ToString() });
            }
            monthComboBox.SelectedIndex = DateTime.Now.Month - 1;
        }
        public  void InMinTime(ComboBox monthComboBox)
        {
           
            monthComboBox.Items.Clear();
            for (int i = 0; i < 60; i+=15)
            {
                if (i == 0)
                {
                    monthComboBox.Items.Add(new commonNonakaItem { Value = i, Text = i+"0" });
                }
                else
                {
                    monthComboBox.Items.Add(new commonNonakaItem { Value = i, Text = i.ToString() });
                }
              
            }
            monthComboBox.SelectedIndex = DateTime.Now.Month - 1;
        }
        public  int GetSelectedValue(ComboBox comboBox)
        {
            if (comboBox.SelectedItem is commonNonakaItem item)
                return item.Value;
            return 9; // 取得できなかった場合
        }
    }

}


 
