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

    public partial class ShiftRequest : Form
    {
        public commonNonakaItem Item;
        public ShiftRequest()
        {
            InitializeComponent();
            Item = new commonNonakaItem();
        }

        private void ShiftRequest_Load(object sender, EventArgs e)
        {
            Item.InitYearComboBox(this.yearComboBox, 2020, 2030);
            Item.InitMonthComboBox(this.mbMonth);
            int year = Item.GetSelectedValue(this.yearComboBox);
            int month = ComboBoxHelper.GetSelectedValue(cmbMonth);
            ComboBoxHelper.InitDayComboBox(cmbDay, year, month);
        }
    }
}
